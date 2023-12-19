﻿using System;
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
        public string Temperamento
        {
            get; set;
        }
        public string Especie
        {
            get; set;
        }
        public IPersona persona
        {
            get; set;
        }



    }
}