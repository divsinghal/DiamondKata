using System;
using DiamondKata.Shapes;

namespace DiamondKata
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseShapeBuilder diamondShape = new Dimaond('D');
            string shapeArray = diamondShape.Build();
            Console.WriteLine(shapeArray);
        }
    }
}

