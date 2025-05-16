using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroXLauncher.modelos
{
    public class Artifact
    {
        public string url { get; set; }
        public string sha1 { get; set; }
        public long size { get; set; }
        public string path { get; set; }
    }
}
