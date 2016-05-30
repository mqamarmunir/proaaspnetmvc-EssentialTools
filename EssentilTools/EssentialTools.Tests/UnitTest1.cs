﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EssentilTools.Models;

namespace EssentialTools.Tests
{
    [TestClass]
    public class UnitTest1
    {
        private IDiscountHelper getTestObject()
        {
            return new MinimumDiscountHelper();
        }
        [TestMethod]
        public void Discount_Above_100()
        {
            IDiscountHelper target = getTestObject();

            decimal total = 200M;
            var discountedTotal = target.ApplyDiscount(total);

            Assert.AreEqual(total * 0.9M, discountedTotal);
        }
    }
}