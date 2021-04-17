﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fw.BE;
using fw.Interfaces;

namespace Imp.BE
{
    public class PacienteBE : IBaseEntity
    {
        public PacienteBE()
        {
            this.ID = Convert.ToString(Guid.NewGuid());
        }


        private string _ID;
        public string ID { get => _ID; set => _ID = value; }

        private string _FechaCreacion;
        public string FechaCreacion { get => _FechaCreacion; set => _FechaCreacion = value; }

        private string _FechaEliminacion;
        public string FechaEliminacion { get => _FechaEliminacion; set => _FechaEliminacion = value; }


        private string _nombre;
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        private string _apellido;        
        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }


        private string _dni;
        public string DNI
        {
            get { return _dni; }
            set { _dni = value; }
        }

        private string _dvh;
        public string dvh { get => _dvh; set => _dvh = value; }
    }
}
