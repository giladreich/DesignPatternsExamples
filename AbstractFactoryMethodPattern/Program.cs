using System;
using System.Collections.Generic;


namespace AbstractFactoryMethodPattern
{
    class Program
    {
        /// <summary>
        /// Definition:
        /// The abstract factory pattern provides an interface for creating families of related or 
        /// dependent objects without specifying their concrete classes.
        /// 
        /// Defintion2:
        /// Abstract factory pattern in useful when the client needs to create objects which are 
        /// somehow related. If we need to create the family of related or dependent objects, then \
        /// we can use Abstract Factory Pattern.
        /// 
        /// When to use?:
        /// When your system has to create multiple families of products or you want to provide a 
        /// library of products without exposing the implementation details.
        /// </summary>
        static void Main(string[] args)
        {
            NotebookFactory dellLaptop   = NotebookFactory.ProduceNotebook(ComputerManufacture.Dell, "Dell Inspiron 7000 Gaming");
            NotebookFactory acerLaptop   = NotebookFactory.ProduceNotebook(ComputerManufacture.Acer, "Acer Q51AC Gaming");
            NotebookFactory lenovoLaptop = NotebookFactory.ProduceNotebook(ComputerManufacture.Lenovo, "Lenovo P50V");

            List<NotebookFactory> laptops = new List<NotebookFactory>
            {
                dellLaptop, acerLaptop, lenovoLaptop
            };

            foreach (NotebookFactory laptop in laptops)
            {

                Console.WriteLine($"{laptop.LaptopModel}:");

                Console.WriteLine($" CPU: " +
                                  $"\n  {laptop.Processor.Manufacture} Manufacture " +
                                  $"\n  {laptop.Processor.Cores} cores" +
                                  $"\n  {laptop.Processor.Price}$");

                Console.WriteLine($"\n Graphics:" +
                                  $"\n  {laptop.GraphicCard.Manufacture} Manufacture" +
                                  $"\n  {laptop.GraphicCard.Price}$\n\n");
            }


            Console.ReadKey();
        }
    }

}
