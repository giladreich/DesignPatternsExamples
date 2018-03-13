namespace AbstractFactoryMethodPattern
{
    public interface IProcessor
    {
        Manufacture Manufacture { get; }

        int Cores { get; }

        double Price { get; }
    }

    public class Intel7ThGen : IProcessor
    {
        public Manufacture Manufacture => Manufacture.Intel;
        public int Cores => 4;
        public double Price => 225.99;
    }

    public class Amd7ThGen : IProcessor
    {
        public Manufacture Manufacture => Manufacture.Amd;
        public int Cores => 2;
        public double Price => 150;
    }

}
