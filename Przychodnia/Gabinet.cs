using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przychodnia
{
    [Serializable]
    public class Gabinet
    {
        int nr;
        public static List<Gabinet> listaGabinetow = new List<Gabinet>();

        public int Nr
        {
            get => nr;
            set => nr = value;
        }
        public override string ToString()
        {
            return nr.ToString();
        }

    }
}
