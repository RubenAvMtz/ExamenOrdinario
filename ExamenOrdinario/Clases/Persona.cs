﻿using ExamenOrdinario.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenOrdinario.Clases
{
    public class Persona : IPersona
    {
        public int ID => throw new NotImplementedException();

        public string Nombre { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void AcariciarMascota()
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
    }
}