namespace AbstractFactoryMethodPattern
{
    public class AcerFactory : NotebookFactory
    {
        public AcerFactory(string laptopModel) : base(laptopModel)
        {
            Processor = GetProcessor();
            GraphicCard = GetGraphicCard();
        }

        public override IProcessor GetProcessor()
        {
            return new Amd7ThGen();
        }

        public override IGraphicCard GetGraphicCard()
        {
            return new HdGraphic630();
        }
    }
}