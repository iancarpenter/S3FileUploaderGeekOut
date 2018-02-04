using Amazon.S3;
using Amazon.S3.Model;

namespace S3FileUploaderGeekOut
{

    /// <summary>
    /// Based upon https://stackoverflow.com/a/41382560/55640
    /// </summary>
    public class S3Uploader
    {
        private string bucketName = "YourBucketNameHere";
        private string keyName = "YourFileNameHere";
        private string filePath = @"EnterThePathToTheFileAndFileNameHere";

        public void UploadFile()
        {
            var client = new AmazonS3Client(Amazon.RegionEndpoint.EUWest2);
         
            PutObjectRequest putRequest = new PutObjectRequest
            {
                BucketName = bucketName,
                Key = keyName,
                FilePath = filePath,
                ContentType = "text/plain"
            };

            PutObjectResponse response = client.PutObject(putRequest);
            
        }
    }

}
