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
        private string _id;
        public string ID
        {
            get { return _id; }
            private set { _id = value; }
        }

        private string _name;
        public string Name 
        {
            get { return _name; }
            set { _name = value; }
        }

        private int _edad;
        public int Edad
        {
            get { return _edad; }
            set 
            {
                if( value > 14)
                {
                    throw new Exception("La edad del perro debe ser menor a 14");
                }
                _edad = value; 
            }
        }

        private TemperamentoEnum _temperamento;
        public TemperamentoEnum Temperamento
        {
            get { return _temperamento; }
            set { _temperamento = value; }
        }

        private EspeciesEnum _especie;
        public EspeciesEnum Especie
        {
            get { return _especie; }
            set { _especie = value; }
        }

        private IPersona _persona;
        public IPersona Persona
        {
            get { return _persona; }
            set { _persona = value; }
        }

        public void CambiarDueno(IPersona persona)
        {
            this.Persona = persona;
            Console.WriteLine($"{this.Name} ha cambiado de dueño a {persona.Nombre}");
        }

        public void HacerRuido()
        {
            Console.WriteLine($"{this.Name} hace guau guau");
        }

        public void ResponderCaricia()
        {
            throw new NotImplementedException();
        }

        public void MoverLaCola()
        {
            Console.WriteLine($"{this.Name} está moviendo la cola");
        }

        public void Grunir()
        {
            Console.WriteLine($"{this.Name} está gruñendo");
        }
    }
}
