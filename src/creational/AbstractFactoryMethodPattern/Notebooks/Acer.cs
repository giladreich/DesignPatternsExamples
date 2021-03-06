﻿using AbstractFactoryMethodPattern.Processors;
using AbstractFactoryMethodPattern.Graphics;

namespace AbstractFactoryMethodPattern.Notebooks
{
    public class Acer : Notebook
    {
        public override IProcessor GetProcessor
        {
            get
            {
                if (Processor == null)
                    Processor = new Amd7ThGen();

                return Processor;
            }
        }

        public override IGraphicCard GetGraphicCard
        {
            get
            {
                if (GraphicCard == null)
                    GraphicCard = new HdGraphic630();

                return GraphicCard;
            }
        }
    }
}