using CabInvoiceGeneratorDay30;
using NUnit.Framework;

namespace CabInvoiceGeneratorTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GivenDistanceAndTime_WhenCalculate_ShouldReturnTotalFare()
        {
            InvoiceGenerator invoice = new InvoiceGenerator();
            double result = invoice.CalculateCabFare(5.0, 2);
            double expected = 52;
            Assert.AreEqual(result, expected);
        }
    }
}
