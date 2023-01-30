using Azure.Core;
using Azure.Identity;
using Azure.Storage.Blobs;

string blobURI = "https://anishstorage786.blob.core.windows.net/anishcontainer/AZ-900.txt";
string filePath = "C:\\ImagesFolder\\anishblob.txt";

TokenCredential tokenCredential = new DefaultAzureCredential();

BlobClient blobClient = new BlobClient(new Uri(blobURI), tokenCredential);

await blobClient.DownloadToAsync(filePath);

Console.WriteLine("The blob is downloaded");


