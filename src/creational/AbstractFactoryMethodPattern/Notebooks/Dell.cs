using AbstractFactoryMethodPattern.Processors;
using AbstractFactoryMethodPattern.Graphics;

namespace AbstractFactoryMethodPattern.Notebooks
{
    public class Dell : Notebook
    {
        // Imagine we call here another factory method for which CPU to create.
        // But keeping it simple with 1 cpu type.
        public override IProcessor GetProcessor
        {
            get
            {
                if (Processor == null)
                    Processor = new Intel7ThGen();

                return Processor;
            }
        }

        public override IGraphicCard GetGraphicCard
        {
            get
            {
                if (GraphicCard == null)
                    GraphicCard = new RadeonRx550();

                return GraphicCard;
            }
        }
    }
}