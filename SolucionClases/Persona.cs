using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace SolucionClases
{
    [Serializable()]
    public class Persona : ISerializable
    {
        public string Nombre{ get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }

        public Persona(string Nombre, string Apellido, int Edad)
        {
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Edad = Edad;
        }
        


        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Nombre", Nombre);
            info.AddValue("Apellido", Apellido);
            info.AddValue("Edad", Edad);
        }
        public Persona(SerializationInfo info, StreamingContext context)
        {
            Nombre = (string)info.GetValue("Nombre", typeof(string));
            Apellido = (string)info.GetValue("Apellido", typeof(string));
            Edad = (int)info.GetValue("Edad", typeof(int));

        }
            
        public bool Tipe()
        {
            Console.WriteLine(Nombre);
            Console.WriteLine(Apellido);
            Console.WriteLine(Edad);
            return true;

        }
    }

}
