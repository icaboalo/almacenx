using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almacen
{
    class Usuario
    {
        public Int16 id { get; set; }

        public String login { get; set; }

        public String pwd { get; set; }

        public String nombre { get; set; }

        public Boolean activo { get; set; }

        public Boolean esAdmin { get; set; }

        public Boolean reportes { get; set; }

        public Usuario( Int16 i, String log, String pw, String nom, Boolean act, Boolean adm, Boolean rep)
        {
            id = i;
            login = log;
            pwd = pw;
            nombre = nom;
            activo = act;
            esAdmin = adm;
            reportes = rep;
        }
        public Usuario(Int16 i, String pw)
        {
            id = i;
            pwd = pw;
        }
    }
}
