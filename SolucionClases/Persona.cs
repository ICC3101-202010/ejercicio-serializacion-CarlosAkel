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
        private string Nombre{ get; set; }
        private string Apellido { get; set; }
        private int Edad { get; set; }


        List<string> Names = new List<string>() ;
        List<string> LastName = new List<string>();
        List<int> Age = new List<int>();
        public Persona(string Nombre, string Apellido, int Edad)
        {
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Edad = Edad;
        }
        
        public void SavePersona()
        {
            Names.Add(Nombre);
            LastName.Add(Apellido);
            Age.Add(Edad);
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
