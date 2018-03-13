namespace AbstractFactoryMethodPattern
{
    public class LenovoFactory : NotebookFactory
    {
        public LenovoFactory(string laptopModel) : base(laptopModel)
        {
            Processor = GetProcessor();
            GraphicCard = GetGraphicCard();
        }

        public override IProcessor GetProcessor()
        {
            return new Intel7ThGen();
        }

        public override IGraphicCard GetGraphicCard()
        {
            return new HdGraphic630();
        }
    }
}