using AbstractFactoryMethodPattern.Processors;
using AbstractFactoryMethodPattern.Graphics;

namespace AbstractFactoryMethodPattern.Notebooks
{
    public abstract class Notebook
    {
        protected IProcessor Processor;
        protected IGraphicCard GraphicCard;

        public string LaptopModel { get; set; }
        public abstract IProcessor GetProcessor { get; }
        public abstract IGraphicCard GetGraphicCard { get; }
    }
}
