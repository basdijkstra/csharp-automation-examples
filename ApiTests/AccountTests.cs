using NUnit.Framework;
using RestSharp;

namespace ApiTests
{
    [TestFixture]
    public class AccountTests
    {

        [Test]
        public void RetrieveDataForAccount12345_CheckStatusCode_ShouldBeHttp200()
        {
            // arrange
            RestClient client = new RestClient("http://parabank.parasoft.com/parabank/services/bank");
            RestRequest request = new RestRequest("/accounts/12345", Method.GET);

            // act
            IRestResponse response = client.Execute(request);

            // assert
            Assert.AreEqual(System.Net.HttpStatusCode.OK, response.StatusCode);
        }

        [Test]
        public void RetrieveDataForAccount99999_CheckStatusCode_ShouldBeHttp404()
        {
            // arrange
            RestClient client = new RestClient("http://parabank.parasoft.com/parabank/services/bank");
            RestRequest request = new RestRequest("/accounts/10101", Method.GET);

            // act
            IRestResponse response = client.Execute(request);

            // assert
            Assert.AreEqual(System.Net.HttpStatusCode.NotFound, response.StatusCode);
        }
    }
}
