using RestSharp;

namespace WebAPI
{
    class API_logic
    {
        public RestClient Get_Upload_client()
        {
            RestClient client = new RestClient("https://content.dropboxapi.com/2/files/upload");
            return client;
        }

        public RestClient Get_GerMetadata_client()
        {
            RestClient client = new RestClient("https://api.dropboxapi.com/2/files/get_metadata");
            return client;
        }

        public RestClient Get_Delete_client()
        {
            RestClient client = new RestClient("https://api.dropboxapi.com/2/files/delete");
            return client;
        }

        public RestClient Get_List_Folder_client()
        {
            RestClient client = new RestClient("https://api.dropboxapi.com/2/files/list_folder");
            return client;
        }

        public RestRequest CreateRequest()
        {
            RestRequest request = new RestRequest(Method.POST);
            return request;
        }

        public void Timeout(RestClient cl)
        {
            cl.Timeout = -1;
        }
        public void Upload_Request(RestRequest request)
        {
            request.AddHeader("Dropbox-API-Arg", "{\"path\": \"/text.txt\",\"mode\": \"add\",\"autorename\": true,\"mute\": false,\"strict_conflict\": false}");
            request.AddHeader("Content-Type", "application/octet-stream");
            request.AddHeader("Authorization", "Bearer 13Gu24K64B0AAAAAAAAAAcOFPX6fztjgss9ISCRPBTnp1ezqOPRBbVe_6wtiRzqd");
        }

        public void GetMetadata_Request(RestRequest request2)
        {
            request2.AddHeader("Authorization", "Bearer 13Gu24K64B0AAAAAAAAAAcOFPX6fztjgss9ISCRPBTnp1ezqOPRBbVe_6wtiRzqd"); 
            request2.AddHeader("Content-Type", "application/json");
            var body = @"{" + "\n" + @"    ""path"": ""/text(1).txt"" " + "\n" + @"}";
            request2.AddParameter("application/json", body, ParameterType.RequestBody);
        }

        public void Delete_Request(RestRequest request3)
        {
            request3.AddHeader("Authorization", "Bearer 13Gu24K64B0AAAAAAAAAAcOFPX6fztjgss9ISCRPBTnp1ezqOPRBbVe_6wtiRzqd"); 
            request3.AddHeader("Content-Type", "application/json");
            var body = @"{" + "\n" + @"    ""path"": ""/text.txt"" " + "\n" + @"}";
            request3.AddParameter("application/json", body, ParameterType.RequestBody);
        }

        
        public IRestResponse Responce(RestClient client, RestRequest request)
        {
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
            return response;
        }

    }
}

