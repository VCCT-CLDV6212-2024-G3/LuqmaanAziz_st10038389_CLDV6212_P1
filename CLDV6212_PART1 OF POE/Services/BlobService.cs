using Azure.Storage.Blobs;

namespace CLDV6212_PART1_OF_POE.Services
{
    public class BlobService
    {
        private readonly BlobServiceClient _blobServiceClient;

        public BlobService(IConfiguration configuration)
        {
            _blobServiceClient = new BlobServiceClient(configuration["AzureStorage:ConnectionString"]);
        }
        //Method to upload a blob (file) to a specfiied container in Azure Blob Storage.
        //Parameters:
        //Line 18 to 21:
        //Container Name: The name of the container in which the Blob data will be stored.
        //BlobName: The name given to upload blob data.
        //Content: A stream containing the content of the blob service data.
        public async Task UploadBlobAsync(string containerName, string blobName, Stream content)
        {
            var containerClient = _blobServiceClient.GetBlobContainerClient(containerName);
            await containerClient.CreateIfNotExistsAsync();
            var blobClient = containerClient.GetBlobClient(blobName);
            await blobClient.UploadAsync(content, true);
        }
    }
}
//<Summary>
//Line 21 to 24:
//Line 21: Client presenting the specified container in blob storage.
//Line 22: Useful code line for ensuring the container is available.
//Line 23: Client representing the blob container.
//Line 24: Upload the information to a blob  storage.
//</Summary>
//------------------------------------ END OF FILE ---------------------------------------------------------------------------