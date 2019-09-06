using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuckNorrisJOTD
{

    class HttpBinResponse
    {
        public Args args { get; set; }
    }
    public class Args
    {
        public string joke { get; set; }
    }
}

