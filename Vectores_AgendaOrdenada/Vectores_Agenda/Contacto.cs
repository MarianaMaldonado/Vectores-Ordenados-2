using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectores_Agenda
{
    class Contacto
    {
        /// <summary>
        /// Agenda 
        /// </summary>
        private string _nombre;
        private string _apPaterno;
        private string _apMaterno;
        private int _edad;
        private string _email;
        private int _telefono;
        private int _codigo;


        /// <summary>
        /// Propiedad de nombre del contacto
        /// </summary>
        public string Nombre
        {
            get
            {
                return _nombre;
            }

            set
            {
                _nombre = value;
            }
        }

        /// <summary>
        /// Propiedad de apellido paterno del contacto
        /// </summary>
        public string ApellidoPaterno
        {
            get
            {
                return _apPaterno;
            }

            set
            {
                _apPaterno = value;
            }
        }

        /// <summary>
        /// Propiedad de apellido materno del contacto
        /// </summary>
        public string ApellidoMaterno
        {
            get
            {
                return _apMaterno;
            }

            set
            {
                _apMaterno = value;
            }
        }

        /// <summary>
        /// Propiedad de la edad del contacto
        /// </summary>
        public int Edad
        {
            get
            {
                return _edad;
            }

            set
            {
                _edad = value;
            }
        }

        /// <summary>
        /// Propiedad del correo del contacto
        /// </summary>
        public string Email
        {
            get
            {
                return _email;
            }

            set
            {
                _email = value;
            }
        }


        /// <summary>
        /// Propiedad de teléfono del contacto 
        /// </summary>
        public int Telefono
        {
            get
            {
                return _telefono;
            }

            set
            {
                _telefono = value;
            }
        }

        public int Codigo
        {
           
            get
            {
                return _codigo;
            }

            set
            {
                _codigo = value;
            }
        }

        public Contacto(string Nombre, string ApellidoPaterno, string ApellidoMaterno, int Edad, string Email, int Telefono, int Codigo)
        {
            _nombre = Nombre;
            _apPaterno = ApellidoPaterno;
            _apMaterno = ApellidoMaterno;
            _edad = Edad;
            _email = Email;
            _telefono = Telefono;
            _codigo = Codigo;
        }

        public override string ToString()
        {
            string Contacto = "Nombre: " + Nombre.ToString() + Environment.NewLine + "Apellido paterno: " + ApellidoPaterno.ToString() + Environment.NewLine + "Apellido materno: " + ApellidoMaterno.ToString() + Environment.NewLine +
                              "Edad: " + Edad.ToString() + Environment.NewLine + "Email: " + Email.ToString() + Environment.NewLine + "Teléfono: " + Telefono.ToString() + Environment.NewLine + "Código " + Codigo.ToString() + Environment.NewLine;

                               

            return Contacto;
        }
            

    }
}
