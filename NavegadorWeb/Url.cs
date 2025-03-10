using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavegadorWeb
{
    internal class Url
    {
        public string link {  get; set; }
        public int veces {  get; set; }
        public DateTime fechaBusqueda {  get; set; }

        public Url()
        {
        }

        public Url(string link, int veces, DateTime fechaBusqueda)
        {
            this.link = link;
            this.veces = veces;
            this.fechaBusqueda = fechaBusqueda;
        }
    }
}
