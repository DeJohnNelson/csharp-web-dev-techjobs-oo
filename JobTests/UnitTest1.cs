using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;
namespace JobTests
{
    [TestClass]
    public class JobTests
    {
        Job test_job;
        Job test_job1;
        
        
       

        [TestMethod]
        public void TestSettingJobId()
        {
            test_job = new Job();
            test_job1 = new Job();
            Assert.AreEqual(1, test_job1.Id - test_job.Id);
        }
        [TestMethod]
        public void TestJobConstructorsSetsAllFields()
        {
            test_job= new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            
          
           
             Assert.AreEqual("Product tester", test_job.Name);
             Assert.AreEqual("ACME", test_job.EmployerName);
            Assert.AreEqual("Desert", test_job.EmployerLocation);
            Assert.AreEqual("Quality control", test_job.JobType);
            Assert.AreEqual("Persistence", test_job.JobCoreCompetency);

        }
        [TestMethod]
        public void TestJobsForEquality()
        {
            test_job = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            test_job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.IsFalse(test_job.Equals(test_job1));
        }
        [TestMethod]
        public void TestStartsAndEndsWithNewLine()
        {
            test_job = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            string testString = test_job.ToString();
            char firstChar = testString[0];
            char lastChar = testString[testString.Length-1];
            Assert.IsTrue(firstChar == lastChar);
        }
        [TestMethod]
        public void DataTestString()
        {
            test_job = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            string testString = $"\n ID: { test_job.Id}\nName: { test_job.Name}\n Employer: { test_job.EmployerName}\n Location: { test_job.EmployerLocation}\n Position Type: { test_job.JobType}\n Core Competency: { test_job.JobCoreCompetency} \n";
            Assert.AreEqual(testString, test_job.ToString());
        }
        [TestMethod]
        public void EmptyValidation()
        {
            test_job = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"),new CoreCompetency( ""));
            string testString = test_job.ToString();
            Assert.IsTrue(testString.Contains("Data not available"));
        }
        
    }
}
