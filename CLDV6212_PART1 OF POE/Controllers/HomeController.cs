//ST10038389
//Luqmaan Aziz
//CLDV6212 - POE PART 1:
//Nuget Packages Installed for this code file.
using CLDV6212_PART1_OF_POE.Models;
using CLDV6212_PART1_OF_POE.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CLDV6212_PART1_OF_POE.Controllers
{
    public class HomeController : Controller
    {
        private readonly BlobService _blobService;
        private readonly TableService _tableService;
        private readonly QueueService _queueService;
        private readonly FileService _fileService;

        //Line 19 to 25: Constructor  is where the services is injected to allow the controller to use the tool.
        public HomeController(BlobService blobService, TableService tableService, QueueService queueService, FileService fileService)
        {
            _blobService = blobService;
            _tableService = tableService;
            _queueService = queueService;
            _fileService = fileService;
        }
        //Line 27 to 30: This action method renders the main view of the web application.
        public IActionResult Index()
        {
            return View();
        }
        //Line 33 to 41: This action method adds a customer profile  to Azure Table Storage.
        //The Upload File field on the web application  is saved in a Blob Container named "Product-image".
        [HttpPost]
        public async Task<IActionResult> UploadImage(IFormFile file)
        {
            if (file != null)
            {
                using var stream = file.OpenReadStream();
                await _blobService.UploadBlobAsync("product-images", file.FileName, stream);
            }
            return RedirectToAction("Index");
            //The Return string redirects the data to the Index action after uploading the file.
        }
        //The Action Method adds a Customer Profile to Azure Table Storage.
        //Storing Customer Information as an ENTITY in a TABLE!
        //Line 48 to 56:Discussing the Adding Customer Profile.
        //Storing Customer Information as an ENTITY in a TABLE!
        [HttpPost]
        public async Task<IActionResult> AddCustomerProfile(CustomerProfile profile)
        {
            if (ModelState.IsValid)
            {
                await _tableService.AddEntityAsync(profile);
            }
            return RedirectToAction("Index");
            //Redirects to the Index action after adding the profile.
        }
        //Action method processes the order by sending a message to an Azure Queue.
        //The Message  is now being processed as per the users order.
        //Line  61 to 67: Discussing the ProcessOrder System!
        [HttpPost]
        public async Task<IActionResult> ProcessOrder(string orderId)
        {
            await _queueService.SendMessageAsync("order-processing", $"Processing order {orderId}");
            return RedirectToAction("Index");
        }
        //Sends the message to the "Order-processing" queue in Azure Queue Storage.
        //Action method handles the upload of a contract that the user has now entered into the web application.
        //The upload file is now storing in a directory  labelled "contracts-logs".
        //Line 72 to 81: Discussing how the Uploading of the contracts by the users details work!
        [HttpPost]
        public async Task<IActionResult> UploadContract(IFormFile file)
        {
            if (file != null)
            {
                using var stream = file.OpenReadStream();
                await _fileService.UploadFileAsync("contracts-logs", file.FileName, stream);
            }
            return RedirectToAction("Index");
            //The user now uploads the file and upload it to Azure File Storage.
        }
    }
}
//<summary>
//Summary Of Code File:
//Line 12 to 17:
//The HomeController is responsible for handling Web Requests and interacting with various Azure Services.
//Services:
//BlobService handles the file uploads to Azure Blob storage.
//TableService handles the operations with Azure Table Storage.
//QueueService handles the message queue operations with Azure Queue Storage.
//FileService handles the file operations on file storage.
//</summary>
//------------------------------------------ END OF FILE ----------------------------------------------------------------------



