using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D365Selfie
{
    class ISelfie
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Regarding { get; set; }
        public Guid Leadid { get; set; }
        public Bitmap Bitmap { get; set; }
    }
}
