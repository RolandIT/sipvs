using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIPVS_projekt1
{
    class Logic
    {
        private Document doc;


        public Logic()
        {
            this.doc = new Document();
        }

        internal Document Doc { get => doc; set => doc = value; }
    }
}
