using ExamenOrdinario.Enumeradores;
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
        public TemperamentoEnum Temperamento
        {
            get; set;
        }
        public EspeciesEnum Especie
        {
            get; set;
        }
        public IPersona persona
        {
            get; set;
        }

        public void HacerRuido();

        public void CambiarDueno(IPersona persona);



    }
}
