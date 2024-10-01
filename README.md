ST1003839
Luqmaan Aziz
CLDV6212 - PART2 OF POE:
-------------------------
PART 2 OF POE - Function App Project  WITH MVC Project!!!
----------------------------------------------------------

URL Link Running through Web Application:
-----------------------------------------
https://st10038389-cfc7cjgyhucde4b7.northeurope-01.azurewebsites.net/

GitHub Link:
------------
https://github.com/VCCT-CLDV6212-2024-G3
--------------------------------------------

URL Link of Web Application Running Locally:
--------------------------------------------
https://localhost:7015/
-----------------------

URL Link of Function App Running on Web:
----------------------------------------
https://st10038389function.azurewebsites.net/

GitHub Link of Function App:
----------------------------
i.e. Having problems with GitHub! 

Screenshots of Setting up the Function Application in Azure Services:
1.Screenshot of Function App in Azure:
--------------------------------------
![image](https://github.com/user-attachments/assets/b9f3a96c-f617-4200-bf8c-fbef1469a5e6)

2.Screenshot of Azure Function App Link:
----------------------------------------
![image](https://github.com/user-attachments/assets/f007f133-cc6b-4d09-bc60-535908b9a8eb)

3.Screenshot of Azure Function App Deployment Process:
------------------------------------------------------
![image](https://github.com/user-attachments/assets/8299f3f2-5ff5-4450-870d-0307004f3b05)

4.Screenshot of Function App HTTP TRIGGERS:
--------------------------------------------
![image](https://github.com/user-attachments/assets/1cec78c7-49db-496b-a5de-f5a93cf19cd4)

5.Screenshot of Function App Project Running:
---------------------------------------------
![image](https://github.com/user-attachments/assets/423c5b39-56bb-4879-b11b-47ca5dced738)

6.Screenshot of Function App Running on Web:
--------------------------------------------
![image](https://github.com/user-attachments/assets/6c3c0a2d-cdf5-46bf-914b-9c8b929ec67e)

7.Screenshot of How to Publish:
------------------------------
Step 1:
-------
![image](https://github.com/user-attachments/assets/4a09ac99-29e0-49c2-b123-40ba0995b6a8)

Step 2:Select Azure Windows:
----------------------------
![image](https://github.com/user-attachments/assets/46492f9f-1f2a-4aab-85ed-60920bf55592)

Step 3:Select Instance and click finish:
----------------------------------------
![image](https://github.com/user-attachments/assets/19827646-3cca-4365-b7b1-74640222e54e)

Step 4: Publishing to Azure:
----------------------------
![image](https://github.com/user-attachments/assets/30eff0e2-795e-4930-9c30-92d1ba9ffb41)

Step 5: Function App Project Published Successfully:
----------------------------------------------------
![image](https://github.com/user-attachments/assets/155b979c-6144-43a9-b9b1-ff75212a9653)

Screenshots of Function Application Outcome:
--------------------------------------------
Screenshot of Function1 | AzureFunctionRoot.cs:
-----------------------------------------------
![image](https://github.com/user-attachments/assets/db5fcce1-b0c0-454d-8f6e-664b8da66dd2)

Screenshot of ProcessQueueMessage.cs:
-------------------------------------
![image](https://github.com/user-attachments/assets/3e63d1ee-d73d-467a-9367-748671a19977)

Screenshot of StoreTableInfo.cs:
--------------------------------
![image](https://github.com/user-attachments/assets/de011b98-75c7-4f8b-bdda-a354a5dbffe4)

Screenshot of UploadBlob.cs:
----------------------------
![image](https://github.com/user-attachments/assets/8225941b-5b0d-4012-8d67-46af2e3f29d9)

Written Answers for Discussion Questions:
B. Using Services for improving the Customer Experience:
Discuss how the following services could add value to the customer experience in your app:
•	Azure Event Hubs
•	Azure Event Bus
Answer: Azure Event Hubs
Description of the Service: 
•	Millions of events may be processed per second by Azure Event Hubs, a fully managed real-time data input solution. Due to its capacity to manage massive amounts of data from several sources, applications can receive, process, and analyse the data instantly.
Mechanism:
•	Partitioning
Regarding scalability and high availability, it dynamically divides inbound events. Events can be processed simultaneously since each split can be handled independently.
•	Customer Divisions 
Through consumer groups, many consumer applications can independently read the same event stream, allowing different applications to respond differently to the same events. 
•	Holding On 
Applications can reprocess past data as needed by allowing events to be kept for a configurable amount of time. 



Value to End Users:
1.	Real-time Insights
•	Users can obtain real-time insights into their application's performance, user behaviour, and other crucial data by ingesting and processing events.
2.	Scalability
•	Capable of managing enormous volumes of data, applications can expand without experiencing a decrease in speed, improving user experience even under heavy loads.
3.	Data Integration: 
•	Event Hubs enables data integration with other Azure services (such as Azure Functions or Azure Stream Analytics) to deliver machine learning and analytics-driven enriched user experiences.
4. Higher Interaction
The instantaneous application responses to user activities, including purchasing, logging in, or other interactions, make for a more engaging user experience. 
Answer: Azure Event Bus
Description of the Service
•	Azure Service Bus is an enterprise message gateway that is completely managed and enables message-based communication between applications.
Mechanism:
Topics and Queues
•	Service Bus routes messages effectively by using topics with subscriptions for publish/subscribe scenarios and queues for point-to-point communication.

•	Delivery of Messages
The system guarantees reliable message delivery by providing transactional messaging and at-least-once options for delivery, which prevent communications from being lost.
Message Routing
•	To provide subscribers with precise control over which messages are sent to which ones, Service Bus offers complex message routing functionalities like filtering and algorithms.
Integration
•	Its smooth integration allows for increased cross-platform communication and usefulness with a variety of Azure services and on-premises systems.
Value to End Users:
1.	Reliable Communication
•	Reliability in message delivery implies fewer glitches and service disruptions for users, which increases their satisfaction and confidence in the program.
2.	Asynchronous Processing
•	Asynchronous processing yields faster response times and more seamless user interactions by allowing actions to be queued and processed without requiring users to wait.
3.	Enhanced Features
•	Complex workflows and notifications that can be implemented can result in richer user experiences, like alerts, order confirmations, and system changes that keep users informed and involved.
4. separated Buildings
This allows services to be separately designed, deployed, and scaled, rendering systems more flexible and able to shift as user needs do.




Screenshot of UploadFile.cs:
----------------------------
![image](https://github.com/user-attachments/assets/bbd6ea40-d680-4ee0-9d29-33d797527181)


