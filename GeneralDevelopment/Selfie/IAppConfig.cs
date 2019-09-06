using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D365Selfie
{
    class IAppConfig
    {
        public string AuthType { get; set; }
        public string ServerUrl { get; set; }
        public string Domain { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Uri { get; set; }
        
    }

}