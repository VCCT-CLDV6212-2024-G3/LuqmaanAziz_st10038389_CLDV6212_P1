using Azure.Data.Tables;
using CLDV6212_PART1_OF_POE.Models;

namespace CLDV6212_PART1_OF_POE.Services
{
    public class TableService
    {
        private readonly TableClient _tableClient;

        public TableService(IConfiguration configuration)
        {
        var connectionString = configuration["AzureStorage:ConnectionString"];

        var serviceClient = new TableServiceClient(connectionString);

        _tableClient = serviceClient.GetTableClient("CustomerProfiles");
        _tableClient.CreateIfNotExists();
        }

        public async Task AddEntityAsync(CustomerProfile profile)
        {
        await _tableClient.AddEntityAsync(profile);
        }
    }
}
//<Summary>
//Line 10 to 21:
// Constructor for the TableService class.
// It initializes the TableClient using the connection string from the configuration.
// Retrieve the connection string for the Azure Storage account from the application's configuration.
// Create a TableServiceClient using the connection string.
// Get a TableClient representing the specified table in Azure Table Storage ("CustomerProfiles").
// Ensure the table exists by creating it if it does not already exist.

// Method to add a new entity (customer profile) to the table.
// Parameters:
// - profile: The customer profile entity to be added to the table.
//</Summary>
//------------------------------------------- END OF FILE --------------------------------------------------------------------
