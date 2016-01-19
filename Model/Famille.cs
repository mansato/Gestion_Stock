using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Famille
    {
        public int id_famille { get; set; }
        public string famille { get; set; }

        public Famille()
        { }

        public Famille(int id, string f)
        {
            this.id_famille = id;
            this.famille = f;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
