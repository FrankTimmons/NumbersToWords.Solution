using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using NumbersToWords.Models;

namespace NumbersToWords.Tests
{
  [TestClass]
  public class NumberTests
  {
    [TestMethod]
    public void Number_ConstructANumberInstance_Int() 
    {
      Number newNumber = new Number(0);
      Assert.AreEqual( 0, newNumber.UserNumber);
    }
  }
}