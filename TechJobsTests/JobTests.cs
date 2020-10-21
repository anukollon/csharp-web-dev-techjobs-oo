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
            Job job1 = new Job("Product tester", new Employer("ACME"), new Location("Dessert"), new PositionType("Quality Control"), new CoreCompetency("Persistence"));
            Assert.AreEqual("Product tester", job1.Name);
            Assert.AreEqual("ACME", job1.EmployerName.Value);
            Assert.AreEqual("Dessert", job1.EmployerLocation.Value);
            Assert.AreEqual("Quality Control", job1.JobType.Value);
            Assert.AreEqual("Persistence", job1.JobCoreCompetency.Value);
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Job job1 = new Job("Tester", new Employer("ACME"), new Location("Kansas City"), new PositionType("QA Tester"), new CoreCompetency("Java"));
            Job job2 = new Job("Tester", new Employer("ACME"), new Location("Kansas City"), new PositionType("QA Tester"), new CoreCompetency("Java"));
            Assert.AreEqual(false, job1.Equals(job2));
        }

        [TestMethod]
        public void TestJobToString()
        {
            //Job job1 = new Job();
            Job job1 = new Job("Tester", new Employer("ACME"), new Location("Kansas City"), new PositionType("QA Tester"), new CoreCompetency("Java"));
            Assert.AreEqual("ID: 2\nName: Tester\nEmployer: ACME\nLocation: Kansas City\nPosition Type: QA Tester\nCore Competency: Java\n", job1.ToString());
        }

        [TestMethod]
        public void TestJobToStringWithEmptyJob()
        {
            Job job1 = new Job();
            //Job job1 = new Job("Tester", new Employer("ACME"), new Location("Kansas City"), new PositionType("QA Tester"), new CoreCompetency("Java"));
            Assert.AreEqual("OOPS! This job does not seem to exist.", job1.ToString());
        }
    }


}
