using ExamenOrdinario.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenOrdinario.Clases
{
    public class Persona : IPersona
    {

        private List<IMascota> listaMascotas;

        public int ID => throw new NotImplementedException();

        private string _nombre;
        public string Nombre
        {
            get { return _nombre; }
            set
            {
                if (string.IsNullOrWhiteSpace(_nombre){
                    throw new Exception("El nombre introducido no es valido");
                    _nombre = value;
                }
            }
        }

        public void AcariciarMascota()
        {
            throw new NotImplementedException();
        }

        public void AcariciarMascotas()
        {
            throw new NotImplementedException();
        }

        public void AgregarMascota(IMascota mascota)
        {
            throw new NotImplementedException();
        }

        public IMascota ObtenerMascota(IMascota mascota)
        {
            return listaMascotas.Find(m => m.Equals(mascota));
        }


        public IMascota ObtenerMascotaPorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<IMascota> ObtenerMascotas()
        {
            List<IMascota> listaDeMascotas = this.listaMascotas;
            return listaDeMascotas; 
        }


        public Persona(string nombre)
        {
            throw new NotImplementedException();
        }
    }
}
