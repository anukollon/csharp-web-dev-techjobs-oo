using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestMethod]
        public void TestSettingJobId()
        {
            Job job1 = new Job();
            Job job2 = new Job();
            Assert.AreNotEqual(job2.Id, job1.Id);
            Assert.AreEqual(1, job2.Id - job1.Id);
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Job job3 = new Job("Product tester", new Employer("ACME"), new Location("Dessert"), new PositionType("Quality Control"), new CoreCompetency("Persistence"));
            Assert.AreEqual("Product tester", job3.Name);
            Assert.AreEqual("ACME", job3.EmployerName.Value);
            Assert.AreEqual("Dessert", job3.EmployerLocation.Value);
            Assert.AreEqual("Quality Control", job3.JobType.Value);
            Assert.AreEqual("Persistence", job3.JobCoreCompetency.Value);
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Job job1 = new Job("Tester", new Employer("ACME"), new Location("Kansas City"), new PositionType("QA Tester"), new CoreCompetency("Java"));
            Job job2 = new Job("Tester", new Employer("ACME"), new Location("Kansas City"), new PositionType("QA Tester"), new CoreCompetency("Java"));
            Assert.AreEqual(false, job1.Equals(job2));
        }
    }


}
