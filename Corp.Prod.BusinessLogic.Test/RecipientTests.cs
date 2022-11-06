using Corp.Prod.BusinessLogic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corp.Prod.BusinessLogic.Test
{
    public class RecipientTests
    {
        Recipient recipient = new()
        {
            City = "Vienna",
            Name = "Steven",
            Street = "Straße",
            Country = "Austria",
            PostalCode = "1234"
        };

        [Fact]
        public void IsInAustria_InputIsAustria_ReturnTrue()
        {
            var recipientlogic = new RecipientLogic(recipient);
            bool result = recipientlogic.IsInAustria();

            Assert.True(result);
        }

        [Fact]
        public void IsInAustria_InputIsGermany_Retrunfalse()
        {
            recipient.Country = "Germany";
            var recipientlogic = new RecipientLogic(this.recipient);
            bool result = recipientlogic.IsInAustria();

            Assert.False(result);
        }

        [Fact]
        public void PostalCode_Valid()
        {
            Assert.Equal("1234", this.recipient.PostalCode);
        }

        [Fact]
        public void PostalCode_Faulty()
        {
            Assert.NotEqual("12345", this.recipient.PostalCode);
        }

        [Fact]
        public void Country_Valid()
        {
            Assert.Equal("Austria", this.recipient.Country);
        }

        [Fact]
        public void Country_Faulty()
        {
            Assert.NotEqual("Germany", this.recipient.Country);
        }

        [Fact]
        public void Street_Valid()
        {
            Assert.Equal("Straße", this.recipient.Street);
        }

        [Fact]
        public void Street_Faulty()
        {
            Assert.NotEqual("Gasse", this.recipient.Street);
        }

        [Fact]
        public void City_Valid()
        {
            var city = this.recipient.City;

            Assert.Equal("Vienna", city);
        }

        [Fact]
        public void City_Faulty()
        {
            var city = this.recipient.City;

            Assert.NotEqual("Innsbruck", city);
        }

        [Fact]
        public void Name_Valid()
        {
            Assert.Equal("Steven", this.recipient.Name);
        }
        [Fact]
        public void Name_Faulty()
        {
            Assert.NotEqual("Bill", this.recipient.Name);
        }
    }
}
