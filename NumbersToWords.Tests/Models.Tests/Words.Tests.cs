using System.Reflection;
using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumbersToWords.Models;

namespace NumbersToWords.Tests
{
    


    [TestClass]
    public class wordTest{
      [TestMethod]
      public void getNumWord_ReturnWord_string(){
        
        Assert.AreEqual("nineteen",Words.test(123456789123456789));
       //Assert.AreEqual("nineteen",Words.getNumWordRecursive(999999999999));
      }
    }
}
