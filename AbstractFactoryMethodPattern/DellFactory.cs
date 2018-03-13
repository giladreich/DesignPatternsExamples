namespace AbstractFactoryMethodPattern
{
    public class DellFactory : NotebookFactory
    {
        public DellFactory(string laptopModel) : base(laptopModel)
        {
            Processor = GetProcessor();
            GraphicCard = GetGraphicCard();
        }

        public override IProcessor GetProcessor()
        {
            // Imagine there is also factory for which CPU.
            // But keeping it simple with 1 cpu type.
            return new Intel7ThGen();
        }

        public override IGraphicCard GetGraphicCard()
        {
            return new RadeonRx550();
        }
    }
}