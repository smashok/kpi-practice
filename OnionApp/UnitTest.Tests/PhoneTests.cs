using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnionApp.Controllers;
using Xunit;
using OnionApp.Domain.Core;


namespace UnitTest.Tests
{
    public class PhoneTests
    {
        [Fact]
        public void If_has_Id_and_Name_Return_Price()
        {
            var sut = new Phone { Id = "1a", Name = "IPhone" };
            string actual = sut.Price;

            Assert.Equal("1a  IPhone6S", actual);
        }
        [Fact]
        public void If_has_Id_Return_Price()
        {
            var sut = new Phone { Id = "1a" };
            string actual = sut.Price;

            Assert.Equal("1a" , actual);
        }
    }
}
