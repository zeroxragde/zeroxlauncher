using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroXLauncher.modelos
{
    public class VersionManifest
    {
        public Latest latest { get; set; }
        public VersionInfo[] versions { get; set; }
    }
}
