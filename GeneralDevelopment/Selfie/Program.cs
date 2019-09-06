using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using Microsoft.Xrm.Tooling.Connector;
using Microsoft.Xrm.Sdk.Client;
using System.ServiceModel.Description;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Crm.Sdk.Messages;
using Emgu.CV;
using Emgu.Util;
using System.Net;
using System.IO;
using System.Drawing;

namespace D365Selfie
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        private static OrganizationServiceProxy _serviceProxy;
        private static OrganizationServiceContext _orgContext;
        private static IOrganizationService _service;
        
        /// </summary>
        [STAThread]
        static void Main()
        {   
            IAppConfig ac = GetAppConfig();
            ISelfie selfie = new ISelfie();
            Program._service = GetService(ac);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Capture());
        }
        static public IAppConfig GetAppConfig()
        {
            IAppConfig ac = new IAppConfig
            {
                AuthType = ConfigurationManager.AppSettings.Get("AuthType"),
                ServerUrl = ConfigurationManager.AppSettings.Get("ServerUrl"),
                Domain = ConfigurationManager.AppSettings.Get("Domain"),
                UserName = ConfigurationManager.AppSettings.Get("UserName"),
                Password = ConfigurationManager.AppSettings.Get("Password"),
                Uri = ConfigurationManager.AppSettings.Get("Uri")
            };
            return ac;
        }
        static public CrmServiceClient GetService(IAppConfig ac)
        {
            return new CrmServiceClient(String.Format(ConfigurationManager.ConnectionStrings["crmConnectionString"].ConnectionString, ac.AuthType, ac.ServerUrl, ac.UserName, ac.Password));

        }
        static public OrganizationServiceProxy GetServiceProxy(IAppConfig ac)
        {

            Uri oUri = new Uri(ac.Uri);
            ClientCredentials clientCredentials = new ClientCredentials();
            clientCredentials.UserName.UserName = ac.UserName;
            clientCredentials.UserName.Password = ac.Password;
            _serviceProxy = new OrganizationServiceProxy(oUri, null, clientCredentials, null);
            return _serviceProxy;
        }
        static public void AttachImage(OrganizationServiceProxy serviceProxy, ISelfie selfie)
        {
            
            string entitytype = "lead";
            Annotation a = new Annotation
            {
                Subject = "Event Encounter: " + selfie.Email,
                FileName = "SELFIE_" + selfie.Email + "_.jpeg",
                MimeType = "image/jpeg",
                ObjectId = new EntityReference(entitytype, selfie.Leadid),
                NoteText = "Event Encounter: " + selfie.Email
            };

            using (var ms = new MemoryStream())
            {
                using (var bitmap = new Bitmap(selfie.Bitmap))
                {
                    bitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    var bitmap64 = Convert.ToBase64String(ms.GetBuffer());
                    a.DocumentBody = bitmap64;
                }
            }
            serviceProxy.Create(a);
        }
        static public Guid SubmitSelfie(ISelfie capturedselfie)
        {
            IAppConfig ac = GetAppConfig();
            Lead theLead = new Lead
            {
                Subject = "Event Encounter with " + capturedselfie.Firstname + " " + capturedselfie.Lastname,
                FirstName = capturedselfie.Firstname,
                LastName = capturedselfie.Lastname,
                EMailAddress1 = capturedselfie.Email,
                Telephone1 = capturedselfie.Phone,
                Description = capturedselfie.Regarding
            };
            _serviceProxy = GetServiceProxy(ac);
            try
            {
                using (_serviceProxy)
                {
                    _serviceProxy.EnableProxyTypes();
                    _service = GetService(ac);
                    _service = (IOrganizationService)_serviceProxy;
                    _orgContext = new OrganizationServiceContext(_service);
                    theLead.Id = _service.Create(theLead);
                    capturedselfie.Leadid= theLead.Id;
                    AttachImage(_serviceProxy,capturedselfie);
                }
            }
            catch(Exception)
            {

                throw;
            }
            return theLead.Id;
        }
       
    }
}
