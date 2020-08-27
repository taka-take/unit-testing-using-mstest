using Microsoft.VisualStudio.TestTools.UnitTesting;
using Prime.Services;

namespace PrimeService.Tests
{
  [TestClass]
  public class PrimeService_IsPrimeShould
  {
    private readonly PrimeService _primeService;

    public PrimeService_IsPrimeShould()
    {
      _primeService = new PrimeService();
    }

    [TestMethod]
    public void IsPrime_InputIs1_ReturnsFalse()
    {
      var result = _primeService.IsPrime(1);

      Assert.IsFalse(result, "1 should not be prime");
    }
  }
}
