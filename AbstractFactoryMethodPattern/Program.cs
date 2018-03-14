using System;
using System.Collections.Generic;
using AbstractFactoryMethodPattern.Notebooks;

namespace AbstractFactoryMethodPattern
{
    class Program
    {
        /// <summary>
        /// Definition:
        /// The abstract factory pattern provides an interface for creating families of related or 
        /// dependent objects without specifying their concrete classes.
        /// 
        /// 
        /// When to use?:
        /// 1. Abstract factory pattern in useful when the client needs to create objects which are 
        /// somehow related. If we need to create the family of related or dependent objects, then \
        /// we can use Abstract Factory Pattern.
        /// 
        /// 2. When your system has to create multiple families of products or you want to provide a 
        /// library of products without exposing the implementation details.
        /// </summary>
        static void Main(string[] args)
        {
            List<Notebook> laptops = ProduceSomeLaptops();

            foreach (Notebook laptop in laptops)
            {

                Console.WriteLine($"{laptop.LaptopModel}:");

                Console.WriteLine(" CPU: " +
                                  $"\n  {laptop.GetProcessor.Manufacture} Manufacture " +
                                  $"\n  {laptop.GetProcessor.Cores} cores" +
                                  $"\n  {laptop.GetProcessor.Price}$");

                Console.WriteLine("\n Graphics:" +
                                  $"\n  {laptop.GetGraphicCard.ProcessorManufacture} Manufacture" +
                                  $"\n  {laptop.GetGraphicCard.Price}$\n\n");
            }


            Console.ReadKey();
        }

        private static List<Notebook> ProduceSomeLaptops()
        {
            Notebook dell = NotebookFactory.CreateNotebook(NotebookManufacture.Dell);
            dell.LaptopModel = "Dell Inspiron 7000 Gaming"; // give it a name like a real manufacture :)

            Notebook alienware = NotebookFactory.CreateNotebook(NotebookManufacture.Dell);
            alienware.LaptopModel = "Dell Alienware m17x";

            Notebook acerLaptop = NotebookFactory.CreateNotebook(NotebookManufacture.Acer);
            acerLaptop.LaptopModel = "Acer Q51AC Gaming";

            Notebook lenovoLaptop = NotebookFactory.CreateNotebook(NotebookManufacture.Lenovo);
            lenovoLaptop.LaptopModel = "Lenovo P50V";

            return new List<Notebook> { dell, alienware, acerLaptop, lenovoLaptop };
        }
    }

}
