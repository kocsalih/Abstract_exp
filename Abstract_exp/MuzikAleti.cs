using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_exp
{
    public abstract class MuzikAleti
    {
        public string muzikAleti { get; set; }
        public string markasi { get; set; }

        public abstract void cal();

        public MuzikAleti()
        {

        }
    }
}
