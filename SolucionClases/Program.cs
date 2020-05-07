using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
namespace SolucionClases
{
    [Serializable()]
    class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("Nombre");
                string Nombre = Console.ReadLine();
                Console.WriteLine("Apellido");
                string Apellido = Console.ReadLine();
                Console.WriteLine("Edad");
                int Edad = Int32.Parse(Console.ReadLine());*/
                Persona H = new Persona("Carlos", "Akel", 20);
                H.SavePersona(); 

             Stream stream = new FileStream("Persona.dat", FileMode.Create);

            BinaryFormatter bi = new BinaryFormatter();
            bi.Serialize(stream, H);
            stream.Close();

            H = null;


            stream = File.Open("Persona.dat", FileMode.Open);

            bi = new BinaryFormatter();

            H = (Persona)bi.Deserialize(stream);
            stream.Close();
            H.Tipe();




        }
    }
}
