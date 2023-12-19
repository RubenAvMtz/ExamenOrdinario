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

        public string Nombre { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

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

        public void AgregarMascota(IMascota mascota)
        {   
            throw new NotImplementedException();
        }

        public IMascota ObtenerMascota(IMascota mascota)
        {
            throw new NotImplementedException();
        }


        public IMascota ObtenerMascotaPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void ObtenerMascotas(List<IMascota> listaMascotas)
        {
            throw new NotImplementedException();
        }


        public Persona(string nombre)
        {
            throw new NotImplementedException();
        }
    }
}
