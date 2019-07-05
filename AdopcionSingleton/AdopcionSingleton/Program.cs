using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdopcionSingleton
{
    class Program: Adopcion
    {
        static void Main(string[] args)
        {
            Datos datos1 = Datos.GetInstancia();
            datos1.ListaPerros.Add(new Perro() { Id = 1, Nombre = "Hachiko", Edad = 4 });
            datos1.ListaPerros.Add(new Perro() { Id = 2, Nombre = "Coraje", Edad = 4 });
            datos1.ListaPerros.Add(new Perro() { Id = 3, Nombre = "Betoben", Edad = 4 });
            datos1.ListaPerros.Add(new Perro() { Id = 4, Nombre = "Jose", Edad = 4 });
            datos1.ListaPerros.Add(new Perro() { Id = 5, Nombre = "SANCHEZ", Edad = 4 });

            foreach (Perro perro in datos1.ListaPerros)
            {
                Console.WriteLine("Id = " + perro.Id + " Nombre: " + perro.Nombre);
            }
            Console.ReadLine();
        }
    }
}
