using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemaCombo
{
    class Editorial
    {
        public String Id { get; set; }
        public String Nombre { get; set; }
        public override string ToString()
        {
            return Nombre;
        }
    }
}
