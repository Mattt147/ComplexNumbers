using ComplexNumbers;
namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestAdd()
        {
            ComplexNumber firstnumb = new ComplexNumber(5, 7);
            ComplexNumber secondnumb = new ComplexNumber(5.5, -2);
            ComplexNumber thirdnumb = new ComplexNumber(12, -1);
            ComplexNumber fourthnumb = new ComplexNumber(0, -2);
            ComplexNumber fifthnumb = new ComplexNumber(2, 3);
            ComplexNumber sixthnumb = new ComplexNumber(5, -7);
            ComplexNumber seventhnumb = new ComplexNumber(75, -50);
            ComplexNumber eighthnumb = new ComplexNumber(3, 4);


            Assert.That(firstnumb.Add(secondnumb), Is.EqualTo(new ComplexNumber(10.5, 5)));
            Assert.That(thirdnumb.Add(fourthnumb), Is.EqualTo(new ComplexNumber(12, -3)));
            Assert.That(fifthnumb.Add(sixthnumb), Is.EqualTo(new ComplexNumber(7, -4)));
            Assert.That(seventhnumb.Add(eighthnumb), Is.EqualTo(new ComplexNumber(78, -46)));
        }
        [Test]
        public void TestDif()
        {
            ComplexNumber firstnumb = new ComplexNumber(5, 7);
            ComplexNumber secondnumb = new ComplexNumber(5.5, -2);
            ComplexNumber thirdnumb = new ComplexNumber(12, -1);
            ComplexNumber fourthnumb = new ComplexNumber(0, -2);
            ComplexNumber fifthnumb = new ComplexNumber(2, 3);
            ComplexNumber sixthnumb = new ComplexNumber(5, -7);
            ComplexNumber seventhnumb = new ComplexNumber(75, -50);
            ComplexNumber eighthnumb = new ComplexNumber(3, 4);


            Assert.That(firstnumb.Dif(secondnumb), Is.EqualTo(new ComplexNumber(-0.5, 9)));
            Assert.That(thirdnumb.Dif(fourthnumb), Is.EqualTo(new ComplexNumber(12, 1)));
            Assert.That(fifthnumb.Dif(sixthnumb), Is.EqualTo(new ComplexNumber(-3, 10)));
            Assert.That(seventhnumb.Dif(eighthnumb), Is.EqualTo(new ComplexNumber(72, -54)));
        }
        [Test]
        public void TestMul()
        {
            ComplexNumber firstnumb = new ComplexNumber(5, 7);
            ComplexNumber secondnumb = new ComplexNumber(5.5, -2);
            ComplexNumber thirdnumb = new ComplexNumber(12, -1);
            ComplexNumber fourthnumb = new ComplexNumber(0, -2);
            ComplexNumber fifthnumb = new ComplexNumber(2, 3);
            ComplexNumber sixthnumb = new ComplexNumber(5, -7);
            ComplexNumber seventhnumb = new ComplexNumber(75, -50);
            ComplexNumber eighthnumb = new ComplexNumber(3, 4);


            Assert.That(firstnumb.Mul(secondnumb), Is.EqualTo(new ComplexNumber(41.5, 28.5)));
            Assert.That(thirdnumb.Mul(fourthnumb), Is.EqualTo(new ComplexNumber(-2, -24)));
            Assert.That(fifthnumb.Mul(sixthnumb), Is.EqualTo(new ComplexNumber(31, 1)));
            Assert.That(seventhnumb.Mul(eighthnumb), Is.EqualTo(new ComplexNumber(425, 150)));
        }
        [Test]
        public void TestDiv()
        {
            ComplexNumber firstnumb = new ComplexNumber(5, 7);
            ComplexNumber secondnumb = new ComplexNumber(5.5, -2);
            ComplexNumber thirdnumb = new ComplexNumber(12, -1);
            ComplexNumber fourthnumb = new ComplexNumber(0, -2);
            ComplexNumber fifthnumb = new ComplexNumber(2, 3);
            ComplexNumber sixthnumb = new ComplexNumber(5, -7);
            ComplexNumber seventhnumb = new ComplexNumber(75, -50);
            ComplexNumber eighthnumb = new ComplexNumber(3, 4);


            Assert.That(firstnumb.Div(secondnumb), Is.EqualTo(new ComplexNumber(0.394, 1.416)));
            Assert.That(thirdnumb.Div(fourthnumb), Is.EqualTo(new ComplexNumber(0.5, 6)));
            Assert.That(fifthnumb.Div(sixthnumb), Is.EqualTo(new ComplexNumber(-0.149, 0.392)));
            Assert.That(seventhnumb.Div(eighthnumb), Is.EqualTo(new ComplexNumber(1, -18)));
        }
    }
}