using System;
using System.Linq;
using FluentAssertions;
using FluentAssertions.Execution;
using GraduateRecruitment.ConsoleApp.Data;
using NUnit.Framework;

namespace GraduateRecruitment.UnitTests.Data
{
    [TestFixture]
    internal class OpenBarRepositoryTests
    {
        [Test]
        public void AllInventory()
        {
            var repo = new OpenBarRepository();

            var result = repo.AllInventory.ToList();

            using (new AssertionScope())
            {
                result.Count.Should().Be(10);
                result[0].Id.Should().Be(1);
                result[0].Name.Should().Be("Savanna Dry");
                result[0].Price.Should().Be(17.99M);
            }
        }

        [Test]
        public void AllFridgeStockTakes()
        {
            var repo = new OpenBarRepository();

            var result = repo.AllFridgeStocks.ToList();

            using (new AssertionScope())
            {
                result.Count.Should().Be(4750);
                result[0].Id.Should().Be(1);
                result[0].Quantity.Taken.Should().Be(0);
                result[0].Quantity.Added.Should().Be(50);
                result[0].Inventory.Id.Should().Be(1);
                result[0].Inventory.Name.Should().Be("Savanna Dry");
                result[0].Inventory.Price.Should().Be(17.99M);
            }
        }

        [Test]
        public void AllOpenBarRecords()
        {
            var repo = new OpenBarRepository();

            var result = repo.AllOpenBarRecords.ToList();

            using (new AssertionScope())
            {
                result.Count.Should().Be(475);
                result[0].Id.Should().Be(1);
                result[0].Date.Should().Be(new DateTime(2021, 01, 01));
                result[0].DayOfWeek.Should().Be(DayOfWeek.Friday);
                result[0].NumberOfPeopleInBar.Should().Be(37);
                result[0].FridgeStockTakeList[0].Id.Should().Be(1);
                result[0].FridgeStockTakeList[0].Quantity.Taken.Should().Be(0);
                result[0].FridgeStockTakeList[0].Quantity.Added.Should().Be(50);
                result[0].FridgeStockTakeList[0].Inventory.Id.Should().Be(1);
                result[0].FridgeStockTakeList[0].Inventory.Name.Should().Be("Savanna Dry");
                result[0].FridgeStockTakeList[0].Inventory.Price.Should().Be(17.99M);
            }
        }
    }
}