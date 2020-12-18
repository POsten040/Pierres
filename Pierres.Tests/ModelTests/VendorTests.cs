using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pierres.Models;
using System.Collections.Generic;
using System;

namespace ToDoList.Tests
{
  [TestClass]
  public class CategoryTest : IDisposable
  {

    public void Dispose()
    {
      Category.ClearAll();
    }

    [TestMethod]

  }
}