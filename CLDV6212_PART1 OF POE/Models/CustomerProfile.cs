using Azure.Data.Tables;
using Azure;

namespace CLDV6212_PART1_OF_POE.Models
{
    public class CustomerProfile : ITableEntity
    {
        public string PartitionKey { get; set; }
        public string RowKey { get; set; }
        public DateTimeOffset? Timestamp { get; set; }
        public ETag ETag { get; set; }
       
        //Customizing Field Input Names:
        //Adding the Getters + Setters.
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public CustomerProfile()
        {
            PartitionKey = "CustomerProfile";
            RowKey = Guid.NewGuid().ToString();
        }
    }
}
//<Summary>
//How the Customer Profile Works:
//In this code file it consists of the Customer Profile for getting and setting data from the users POV.
//The Customer Profile class presents a customer profile ENTITY that is storing data in Azure Table Storage.
//The "ITableEntity" interface  requires properties  for table Storage system.
//The PartitionKey is a unique identifier that groups entities into variables or partitions  in the table container.
//The PartitionKey is set to Customer Profile for recording all records and grouping the data together.
//Line 15 to 18:
//FirstName stores the first name of the customer  on the application.
//LastName stores the last name of the customer on the application.
//Email stores the customer's email address.
//Stores the customer Phone Number details into the application.
//User clicks upload contract, and it uploads the users data details to the Azure Storage containers.
//</Summary>
//------------------------------------------- END OF FILE ---------------------------------------------------------------------
