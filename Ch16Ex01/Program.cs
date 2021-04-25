using System;
using System.IO;
using Azure.Storage.Blobs;

namespace Ch16Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "DefaultEndpointsProtocol=https;AccountName=cloudshell739151656;AccountKey=celf6XA0ZNF/TkUClNnmpwFyXIIYwZ/nupe6JRduICgKIdQsvvxzyfQtw9iCJgu1mnEDGp8HI6F90JOQOVpyhg==;EndpointSuffix=core.windows.net";
            string containerName = "cloudshell739151656";

            BlobContainerClient container = new BlobContainerClient(connectionString, containerName);

            if (container.CreateIfNotExists() != null)
            {
                int numberOfCards = 0;
                DirectoryInfo dir = new DirectoryInfo(@"Cards");

                foreach (FileInfo f in dir.GetFiles("*.*"))
                {
                    string blobName = f.Name;
                    using (var fileStream = File.OpenRead(@"Cards\" + f.Name))
                    {
                        BlobClient blob = container.GetBlobClient(blobName);
                        blob.Upload(fileStream);
                        numberOfCards++;
                        Console.WriteLine($"Uploading: {f.Name} which is {fileStream.Length} bytes.");
                    }
                }
                Console.WriteLine($"Uploaded {numberOfCards} cards");

                container.SetAccessPolicy(Azure.Storage.Blobs.Models.PublicAccessType.Blob);
            }

            foreach (var blob in container.GetBlobs())
            {
                Console.WriteLine(blob.Name + " " + blob.Properties.ContentLength);
            }

        }
    }
}
