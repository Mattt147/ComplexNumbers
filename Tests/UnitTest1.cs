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
        public void Test1()
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
            Assert.That(firstnumb.Add(secondnumb), Is.EqualTo(new ComplexNumber(10.5, 5)));
            Assert.That(firstnumb.Add(secondnumb), Is.EqualTo(new ComplexNumber(10.5, 5)));
            Assert.That(firstnumb.Add(secondnumb), Is.EqualTo(new ComplexNumber(10.5, 5)));
        }
    }
}