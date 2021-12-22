using NUnit.Framework;
using RestSharp;
 

namespace WebAPI.StepDefinitions
{
    [Binding]
    public class WebAPIStepDefinitions
    {   private static API_logic c1 = new API_logic();
        private RestClient client_upload = c1.Get_Upload_client();
        private RestClient client_get_metadata = c1.Get_GerMetadata_client();
        private RestClient client_delete = c1.Get_Delete_client();
        private RestRequest request1 = c1.CreateRequest();
        private RestRequest request2 = c1.CreateRequest();
        private RestRequest request3 = c1.CreateRequest();



        [Given(@"I have file to upload")]
        public void GivenIHaveFileToUpload()
        {
            c1.Timeout(client_upload);
        }

        [When(@"I send request to upload")]
        public void WhenISendRequestToUpload()
        {
            c1.Upload_Request(request1);
        }

        [Then(@"I get uploaded file")]
        public void ThenIGetUploadedFile()
        {
            IRestResponse responce = c1.Responce(client_upload, request1);
            Assert.AreEqual((int)responce.StatusCode, 200);

        }

        [Given(@"I have file to get metadata")]
        public void GivenIHaveFileToGetMetadata()
        {
            c1.Timeout(client_get_metadata);
        }

        [When(@"I send request to get metadata")]
        public void WhenISendRequestToGetMetadata()
        {
            c1.GetMetadata_Request(request2);
        }

        [Then(@"I get metadata")]
        public void ThenIGetMetadata()
        {
            IRestResponse responce = c1.Responce(client_get_metadata, request2);
            Assert.AreEqual((int)responce.StatusCode, 200);
        }

        [Given(@"I have file to delete")]
        public void GivenIHaveFileToDelete()
        {
            c1.Timeout(client_delete);
        }

        [When(@"I send request to delete")]
        public void WhenISendRequestToDelete()
        {
            c1.Delete_Request(request3);
        }

        [Then(@"I responce that file delited")]
        public void ThenIResponceThatFileDelited()
        {
            IRestResponse responce = c1.Responce(client_delete, request3);
            Assert.AreEqual((int)responce.StatusCode, 200);
        }
    }
}
