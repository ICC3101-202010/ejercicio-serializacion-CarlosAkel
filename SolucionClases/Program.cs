using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace SolucionClases
{
    [Serializable()]
    class Program
    {
        static void Main(string[] args)
        {
            List<Persona> persona = new List<Persona>();
            string Nombre = " ";
            string Apellido = " ";
            int Edad = 0;
            int caso = 0;
            string answ = "yes";
            while(answ == "yes") {
                Console.WriteLine("Crear persona[1], guardar[2],cargar[3],Leer[4]");
            caso = Int32.Parse(Console.ReadLine());
            Persona H = new Persona(" ", " ", 0);
                Console.WriteLine(persona.Count());

                switch (caso)
                {
                    case 1:

                        Console.WriteLine("Nombre");
                        Nombre = Console.ReadLine();
                        Console.WriteLine("Apellido");
                        Apellido = Console.ReadLine();
                        Console.WriteLine("Edad");
                        Edad = Int32.Parse(Console.ReadLine());
                        Persona H2 = new Persona(Nombre, Apellido, Edad);
                        persona.Add(H2);
                        Console.WriteLine(persona.Count());
                        break;

                    case 2:
                        IFormatter formatter = new BinaryFormatter();

                        Stream stream = new FileStream("MyFile.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                        formatter.Serialize(stream, persona.Count());
                        Console.WriteLine(persona.Count());
                        for (int i = 0; i < persona.Count(); i++)
                        {
                            Console.WriteLine("si");
                            formatter.Serialize(stream,persona[i]);
                        }
                        stream.Close();
                        break;

                    case 3:
                        IFormatter formatter2 = new BinaryFormatter();
                        Stream stream2 = new FileStream("MyFile.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
                        int p = (int)formatter2.Deserialize(stream2);
                        for (int i = 0; i < p; i++)
                        {
                            Persona obj = (Persona)formatter2.Deserialize(stream2);

                            persona.Add(obj);
                        }
                        stream2.Close();
                        break;
                    case 4:

                        for (int i = 0; i < persona.Count()-1; i++)
                        {
                            Console.WriteLine(persona[i].Nombre);
                            Console.WriteLine(persona[i].Apellido);
                            Console.WriteLine(persona[i].Edad);
                        }
                        answ = "NO";
                        break;;

                }



            }

  







        }
    }
}
