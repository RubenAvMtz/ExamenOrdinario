using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenOrdinario.Interfaces
{
    public interface IPersona
    {
        public int ID
        {
            get; 
        }
        public string Nombre
        {
            get; set;
        }

        public IMascota ObtenerMascota(IMascota mascota);

        public IMascota ObtenerMascotaPorId(int id);

        public void AgregarMascota(IMascota mascota);

        public void AcariciarMascota();

        public void AcariciarMascotas();


    }
}
