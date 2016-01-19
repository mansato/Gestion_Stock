using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class TVA
    {
        public int id_tva { get; set; }
        public decimal montant { get; set; }

        public TVA()
        { }

        public TVA(int id, decimal m)
        {
            this.id_tva = id;
            this.montant = m;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
