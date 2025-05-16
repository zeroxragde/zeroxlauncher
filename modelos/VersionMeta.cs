using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroXLauncher.modelos
{
    public class VersionMeta
    {
        public Downloads downloads { get; set; }
        public Library[] libraries { get; set; }
        public string mainClass { get; set; }
    }
}
