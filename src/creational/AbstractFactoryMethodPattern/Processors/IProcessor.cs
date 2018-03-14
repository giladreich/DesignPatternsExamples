namespace AbstractFactoryMethodPattern.Processors
{
    public interface IProcessor
    {
        ProcessorManufacture Manufacture { get; }
        int Cores { get; }
        double Price { get; set; }
    }

    public class Intel7ThGen : IProcessor
    {
        public ProcessorManufacture Manufacture => ProcessorManufacture.Intel;
        public int Cores => 4;
        public double Price { get; set; } = 225.99;
    }

    public class Amd7ThGen : IProcessor
    {
        public ProcessorManufacture Manufacture => ProcessorManufacture.Amd;
        public int Cores => 2;
        public double Price { get; set; } = 150.90;
    }
}
