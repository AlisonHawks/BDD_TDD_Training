using NUnit.Framework;

namespace Using_NUnit
{
    [TestFixture]
    public class Calculate_Test
    {
        [Test]
        public void Somar_2_valores()
        {
            var calc = new Calculate();

            var result = calc.Somar(2, 2);

            Assert.AreEqual(4, result);
        }

        [Test]
        public void Multiplicar_2_valores()
        {
            var calc = new Calculate();

            var result = calc.Multiplicar(2, 2);

            Assert.AreEqual(4, result);
        }

        [Test]
        public void Potencia_2_valores()
        {
            var calc = new Calculate();

            var result = calc.Potecia(2, 2);

            Assert.AreEqual(4, result);
        }
    }
}