namespace AbstractFactoryMethodPattern
{
    public interface IGraphicCard
    {
        Manufacture Manufacture { get; }
        double Price { get; }
    }

    public class RadeonRx550 : IGraphicCard
    {
        public Manufacture Manufacture => Manufacture.Amd;
        public double Price => 117.90;
    }

    public class HdGraphic630 : IGraphicCard
    {
        public Manufacture Manufacture => Manufacture.Intel;
        public double Price => 123.90;
    }
}
