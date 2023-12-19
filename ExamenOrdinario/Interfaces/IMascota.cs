using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenOrdinario.Interfaces
{
    public interface IMascota
    {
        public string ID
        {
            get;
        }
        public string Name
        {
            get; set;
        }
        public int Edad
        {
            get;
        }



    }
}
