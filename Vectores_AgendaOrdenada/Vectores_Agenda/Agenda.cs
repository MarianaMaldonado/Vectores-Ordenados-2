using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectores_Agenda
{
    class Agenda 
    {
        public Contacto [] book = new Contacto [15]; //Creación del vector y asignación de 16 posiciones
        public int _position;

        public Agenda()
        {
            _position = 0;
        }
        
        
        /// <summary>
        /// Método agregar, donde el usuario hará uso de este para poder anexar un nuevo contacto a la agenda
        /// </summary>
        /// <param name="Persona"></param>
        public void Agregar(Contacto Persona)
        {
            //while (_position < 15) //validar que son 15 contactos
            
                //book[_position] = Persona;
                // _position++;

                if (_position != 0)
                {
                    for(int i = 0; i < _position; i++)
                    {
                    if (Persona.Codigo < book[i].Codigo)
                    {
                        Insertar(Persona, i);
                        break;
                    }
                    else if (i == _position - 1)
                        book[_position] = Persona;
                    }
                }
                else
                    book[_position] = Persona;

                _position++;
                //if (_position  < 15) 
                //{
                //    for (int i = 1; i < 15; i++)
                //    {
                //        if (codigo = _position)
                //        {
                //            _position++;
                //        }
                //    }
                //}
                
            
            
        }

        /// <summary>
        /// Método eliminar, donde el usuario podrá eliminar un contacto
        /// </summary>
        public void Eliminar(int posicion)
        {

            if (posicion == _position)
            {
                //buscar y si existe eliminarlo
                for (int i = 0; i == _position; i++)
                    book[i - 1] = null;
                _position--;
            }
        }

        /// <summary>
        /// Método de listar, donde el usuario podrá visualizar la agenda con la información correspondiente
        /// </summary>
        /// <returns></returns>
        public string Listar()
        {
            string contacto = "";

            for (int i = 0; i < _position; i++)
                
                contacto +=  book[i].ToString() + Environment.NewLine;
                

            return contacto;
        }
        
        /// <summary>
        /// Método buscar, donde el usuario podrá buscar a un contacto haciendo referencia desde su número telefónico  
        /// </summary>
        /// <param name="telefono"></param>
        /// <returns></returns>
        public Contacto Buscar(int telefono)
        {
            
            for (int i = 0; i < _position; i++)
            {
                if (book[i].Telefono == telefono)
                {
                    return book[i];
                }
                    
            }
            return null;
        }


        /// <summary>
        /// Método insertar, donde el usuario podrá insertar un nuevo contacto dependiendo de la posición que se le indique 
        /// </summary>
        /// <param name="contacto"></param>
        /// <param name="newPosition"></param>
        private void Insertar(Contacto contacto, int newPosition)
        {

            for (int i = _position ; i > newPosition ; i--)
                {
                    book[i] = book[i - 1];
                    
                }
                book[newPosition] = contacto;
                
        }
    }
}
