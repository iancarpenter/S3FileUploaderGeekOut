namespace S3FileUploaderGeekOut
{
    class Program
    {
        static void Main(string[] args)
        {
            S3Uploader s3 = new S3Uploader();

            s3.UploadFile();
        }
    }
}
