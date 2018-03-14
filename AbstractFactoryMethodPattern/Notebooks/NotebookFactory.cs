using System;

namespace AbstractFactoryMethodPattern.Notebooks
{
    public abstract class NotebookFactory
    {
        // The factory method pattern to do the initialization decision for us.
        public static Notebook CreateNotebook(NotebookManufacture manufacture)
        {
            switch (manufacture)
            {
                case NotebookManufacture.Dell:
                    return new Dell();

                case NotebookManufacture.Acer:
                    return new Acer();

                case NotebookManufacture.Lenovo:
                    return new Lenovo();

                default:
                    throw new NotImplementedException();
            }
        }
    }
}