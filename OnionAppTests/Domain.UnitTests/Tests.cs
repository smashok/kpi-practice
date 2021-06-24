using FluentAssertions;

using OnionApp.Infrastructure.Business;
using OnionApp.Infrastructure.Data;
using OnionApp.Services.Interfaces;

using System;
using System.Linq;

using Xunit;

namespace Domain.UnitTests
{
    public class PhoneRepositoryTests
    {
        private readonly PhoneRepository _repos = new PhoneRepository();

        [Fact]
        public void GetPhoneList_should_return_collection()
        {
            //act 
            var actual = _repos.GetPhoneList();

            //ass
            actual.Should().NotBeNullOrEmpty();
        }

        [Fact]
        public void GetPhone_should_return_value()
        {
            //act 
            var actual = _repos.GetPhone(1);

            //ass
            actual.Should().NotBeNull();
        }


        [Fact]
        public void Delete_should_delete_value()
        {
            //arr
            var baseRepos = _repos.GetPhoneList();
            var id = baseRepos.First().Id;

            //act
            _repos.Delete(id);
            _repos.Save();

            //ass
            _repos.GetPhoneList().Should().NotContain(e => e.Id == id);
        }

        [Fact]
        public void CreatePhone_when_pass_null_should_not_throw_exception()
        {
            //act 
            Action act = () => _repos.Create(null);

            //ass 
            act.Should().NotThrow();
        }

        [Fact]
        public void Update_when_pass_null_should_not_throw_exception()
        {
            //act 
            Action act = () => _repos.Update(null);

            //ass 
            act.Should().NotThrow();
        }

        [Fact]
        public void IOrder_when_pass_null_should_not_throw_exception()
        {
            //arr
            IOrder x = new OnlineOrder();

            //act 
            Action act = () => x.MakeOrder(null);

            //ass 
            act.Should().NotThrow();
        }
    }
}
