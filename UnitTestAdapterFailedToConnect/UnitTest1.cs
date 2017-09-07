namespace UnitTestAdapterFailedToConnect
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class UnitTest1
    {
        public TestContext TestContext { get; set; }

        [TestMethod, DataSource( //TODO: Reimplement when able to run a data driven test
             "Microsoft.VisualStudio.TestTools.DataSource.TestCase",
             "http://TFSServerName:8080/tfs/CollectionName;TeamProject", //TODO: Update this to your tfs
             "TestCaseId", //TODO: Update to your test case id
             DataAccessMethod.Sequential)]
        public void TestMethod1()
        {
            var userRole = TestContext.DataRow["userRole"].ToString();
            Assert.IsNotNull(userRole);
        }
    }
}