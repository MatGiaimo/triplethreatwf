using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TripleThreat.Framework.Core;
using TripleThreat.Framework.Helpers;

namespace TripleThreatWF.Tests
{
    [TestClass]
    public class DBTests
    {
        [TestMethod]
        public void CreateNewCustomerGroup()
        {
            //using (DatabaseContext dbContext = DatabaseContextFactory.Instance.GetDatabaseContext())
            //{
            //    CustomerGroup newCustGroup = new CustomerGroup();
            //    newCustGroup.Name = "Admin";

            //    dbContext.CustomerGroups.AddObject(newCustGroup);

            //    dbContext.SaveChanges();

            //    dbContext.Refresh(System.Data.Objects.RefreshMode.StoreWins, newCustGroup);

            //    int custGroupId = newCustGroup.Id;

            //    CustomerHelper custHelper = new CustomerHelper(dbContext);

            //    CustomerGroup loadedCustGroup = custHelper.GetCustomerGroupById(custGroupId);

            //    Assert.AreEqual(newCustGroup.Id, loadedCustGroup.Id);
            //    Assert.AreEqual(newCustGroup.Name, loadedCustGroup.Name);
            //}
        }
    }
}
