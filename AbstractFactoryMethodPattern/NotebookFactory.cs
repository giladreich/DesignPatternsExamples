using System;

namespace AbstractFactoryMethodPattern
{
    public abstract class NotebookFactory
    {
        public string LaptopModel { get; set; }
        public IProcessor Processor { get; set; }  
        public IGraphicCard GraphicCard { get; set; }

        protected NotebookFactory(string laptopModel)
        {
            LaptopModel = laptopModel;
        }

        public abstract IProcessor GetProcessor();
        public abstract IGraphicCard GetGraphicCard();

        public static NotebookFactory ProduceNotebook(ComputerManufacture manufacture, string laptopModel)
        {
            switch (manufacture)
            {
                case ComputerManufacture.Dell:
                    return new DellFactory(laptopModel);

                case ComputerManufacture.Acer:
                    return new AcerFactory(laptopModel);

                case ComputerManufacture.Lenovo:
                    return new LenovoFactory(laptopModel);

                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
