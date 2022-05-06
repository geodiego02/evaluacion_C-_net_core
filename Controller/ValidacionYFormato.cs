using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENA_Rodrigo_Vera_3600.Controller
{
    class ValidacionYFormato
    {
        public string formato(int m)
        {
            string f;
            if (m == 0)
            {
                f = "$0";
            }
            else
            {
                f = "$" + m.ToString("###,###,###,###");
            }
            return f;
        }
        public bool vTexto(string t)
        {
            t.Trim();

            if (t == "" || t == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool vNumero(string t)
        {
            int num;
            if (Int32.TryParse(t, out num) == false)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
