using ExamenOrdinario.Enumeradores;
using ExamenOrdinario.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenOrdinario.Clases
{
    public class Perro : IMascota, IAcariciable
    {
        public string ID => throw new NotImplementedException();

        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int Edad => throw new NotImplementedException();

        public TemperamentoEnum Temperamento { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public EspeciesEnum Especie { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IPersona persona { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void CambiarDueno(IPersona persona)
        {
            throw new NotImplementedException();
        }

        public void HacerRuido()
        {
            throw new NotImplementedException();
        }
    }
}
