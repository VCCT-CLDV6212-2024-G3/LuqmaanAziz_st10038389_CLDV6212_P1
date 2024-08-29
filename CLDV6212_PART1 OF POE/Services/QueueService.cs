using Azure.Storage.Queues;

namespace CLDV6212_PART1_OF_POE.Services
{
    public class QueueService
    {
        private readonly QueueServiceClient _queueServiceClient;

        public QueueService(IConfiguration configuration)
        {
        _queueServiceClient = new QueueServiceClient(configuration["AzureStorage:ConnectionString"]);
        }

        public async Task SendMessageAsync(string queueName, string message)
        {
            var queueClient = _queueServiceClient.GetQueueClient(queueName);

            await queueClient.CreateIfNotExistsAsync();

            await queueClient.SendMessageAsync(message);
        }
    }
}
//<Summary>
//Line 9 to 19:
// Constructor for the QueueService class.
// It initializes the QueueServiceClient using the connection string from the configuration.
// The connection string for the Azure Storage account is retrieved from the application's configuration.
// This connection string is used to create an instance of QueueServiceClient.
// Method to send a message to a specified Azure Queue.
// Parameters:
// - queueName: The name of the queue to which the message will be sent.
// - message: The content of the message to be sent.
// Get a client representing the specified queue in Azure Queue Storage.
// Create the queue if it does not already exist. This ensures the queue is available.
// Send the specified message to the queue.
//</Summary>
//------------------------------- END OF FILE ----------------------------------------------------------------------------------

