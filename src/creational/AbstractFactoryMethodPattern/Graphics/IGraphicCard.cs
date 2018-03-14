namespace AbstractFactoryMethodPattern.Graphics
{
    public interface IGraphicCard
    {
        ProcessorManufacture ProcessorManufacture { get; }
        double Price { get; set; }
    }

    public class RadeonRx550 : IGraphicCard
    {
        public ProcessorManufacture ProcessorManufacture => ProcessorManufacture.Amd;
        public double Price { get; set; } = 117.90;
    }

    public class HdGraphic630 : IGraphicCard
    {
        public ProcessorManufacture ProcessorManufacture => ProcessorManufacture.Intel;
        public double Price { get; set; } = 123.90;
    }
}
