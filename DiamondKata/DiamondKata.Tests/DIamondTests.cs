using Microsoft.VisualStudio.TestTools.UnitTesting;
using DiamondKata;
using DiamondKata.Shapes;
using Moq;

namespace DiamondKata.Tests
{
    [TestClass]
    public class DiamondTests
    {
        [TestInitialize]
        public void SetUp()
        {     
        }

        [TestMethod]
        [DataRow('$', "")]
        [DataRow('6', "")]
        [DataRow(' ', "")]
        public void Nothing_Is_Printed_When_Input_Is_Not_An_Alphabet(char input, string expectedShape)
        {
            BaseShapeBuilder diamondShapeBuilder = new Dimaond(input);
            string resultShape = diamondShapeBuilder.Build();
            Assert.AreEqual(expectedShape, resultShape);
        }

        [TestMethod]
        [DataRow('A',"A")]
        [DataRow('a', "A")]
        [DataRow('B'," A \n\nB B\n\n A ")]
        [DataRow('C', "  A  \n\n B B \n\nC   C\n\n B B \n\n  A  ")]
        public void Can_Print_Diamond_With_One_Alphabet(char input, string expectedShape)
        {
            BaseShapeBuilder diamondShapeBuilder = new Dimaond(input);
            string resultShape =diamondShapeBuilder.Build();
            Assert.AreEqual(expectedShape, resultShape);
        }

    }
}

