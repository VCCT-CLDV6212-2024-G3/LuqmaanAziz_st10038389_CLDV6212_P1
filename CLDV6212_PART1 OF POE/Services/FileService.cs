using Azure.Storage.Files.Shares;

namespace CLDV6212_PART1_OF_POE.Services
{
    public class FileService
    {
        private readonly ShareServiceClient _shareServiceClient;

        public FileService(IConfiguration configuration)
        {
        _shareServiceClient = new ShareServiceClient(configuration["AzureStorage:ConnectionString"]);
        }

        public async Task UploadFileAsync(string shareName, string fileName, Stream content)
        {
            var shareClient = _shareServiceClient.GetShareClient(shareName);

            await shareClient.CreateIfNotExistsAsync();

            var directoryClient = shareClient.GetRootDirectoryClient();

            var fileClient = directoryClient.GetFileClient(fileName);

            await fileClient.CreateAsync(content.Length);

            await fileClient.UploadAsync(content);
        }
    }
}
//<Summary>
//Line 16 to 20:
//Line 16:Client presenting the specific file share in Azure File Storage.
//Line 17:Makes sures the file is READY!
//Line 18:Client presenting the ROOT Directory of the file share in AZURE!
//Line 19:Client presenting the specific file within the Root Directory!
//Line 20:Create the File Share in Azure!
//</Summary>
//------------------------------------------ END OF FILE -------------------------------------------------------------------
