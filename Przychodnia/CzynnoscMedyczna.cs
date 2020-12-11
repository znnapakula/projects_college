using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przychodnia
{
    [Serializable]
    public class CzynnoscMedyczna
    {
        string nazwa;

        public string Nazwa
        {
            get => nazwa;
            set => nazwa = value;
        }

        public static List<CzynnoscMedyczna> listaCzynnosci = new List<CzynnoscMedyczna>();

        public override string ToString()
        {
            return this.nazwa;
        }
    }
}
