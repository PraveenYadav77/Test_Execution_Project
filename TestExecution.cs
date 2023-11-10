
using SDET_Automation_CAW.Pages;
using Newtonsoft.Json;

namespace TestProject1
{
    [TestFixture]
    public class Tests
    {
        private TestBasePage Start = new TestBasePage();
        [SetUp]
        public void Setup()
        {
            Start.OpneSriver();
        }

        [Test]
        public void TstCase_1()
        {
            Common_Methods.OpenUrl(Constants.CurrentUrl);
           var inputData = Constants.GetTestData();

            Common_Methods.UpdateTableData(inputData);
            var outPutData =Common_Methods.Read_tableData();
            bool assertData=  Common_Methods.CompareTwoListOfDict(inputData,outPutData);
            var result1 = JsonConvert.SerializeObject(inputData);
            var result2 = JsonConvert.SerializeObject(outPutData);

            Assert.IsTrue(assertData,"Tabale  Data not Match Actaul = "+ result2+ "Expected = "+ result1);
           
        }

        [TearDown]
        public void TearDown()
        {
            Start.CloseChorme();
        }

    }
}