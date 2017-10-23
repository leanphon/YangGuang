using Communal;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MutuDAL;
using MutuModels;
using System.Configuration;
using System.Data;
using System.Diagnostics;

namespace MutuDAL.Tests
{

    [TestClass()]
    public class BenefitDAO_Tests
    {
        BenefitDAO dao = new BenefitDAO();

        [TestMethod()]
        public void AddBenefit_Test()
        {
            BenefitBean b = new BenefitBean();
            b.Level = "Cc";
            b.BaseSalary = 200;
            Assert.IsTrue(dao.AddBenefit(b) == ReturnStatus.OK);
            DataSet set = dao.GetAllBenefit();
            Assert.IsTrue(set.Tables.Count > 0);

            DataRow[] matches = set.Tables[0].Select("");
            Assert.IsTrue(matches.Length == 1);
        }

        //[TestMethod()]
        //public void UpdateBenefit_Test()
        //{
        //    Assert.Fail();
        //}

        //[TestMethod()]
        //public void DeleteBenefit_Test()
        //{
        //    Assert.Fail();
        //}

    }
}
