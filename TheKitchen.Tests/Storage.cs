using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StaticVoid.Core.Repository;
using TheKitchen.Model.Models;
using TheKitchen.Storage;

namespace TheKitchen.Tests
{
    [TestClass]
    public class Storage
    {
        class TestItem : IEntity
        {
            public int ID { get; set; }
            public string Name { get; set; }
        }

        [TestMethod]
        public void TestMethod1()
        {
            IRepository<TestItem> repo = new InMemoryRepository<TestItem>();
            repo.Create(new TestItem() { ID = 1, Name = "Frank" });

            var item = repo.GetBy(p => p.ID == 1);
            item.Name = "Fred";
            int i = 0;
        }
    }
}
