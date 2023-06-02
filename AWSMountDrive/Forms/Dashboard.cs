using Amazon;
using Amazon.S3;
using Amazon.S3.Model;

namespace AWSMountDrive.Forms
{
    public partial class Dashboard : Form
    {

        string bucketName = string.Empty;
        string awsAccessKey = string.Empty;
        string awsSecretKey = string.Empty;
        IAmazonS3 client = null;



        public async Task ConnectToS3()
        {
            // Set your AWS access key ID and secret access key
            ///  string accessKey = "YOUR_ACCESS_KEY";
            //  string secretKey = "YOUR_SECRET_KEY";

            // Set the AWS region where your S3 bucket is located
            RegionEndpoint region = RegionEndpoint.USWest2; // Change to your desired region

            // Create an instance of the Amazon S3 client
            using (var client = new AmazonS3Client(awsAccessKey, awsSecretKey, region))
            {
                // You can now use the client object to interact with Amazon S3
                // For example, you can list buckets:
                ListBucketsResponse response = await client.ListBucketsAsync();
                foreach (S3Bucket bucket in response.Buckets)
                {
                    bucketName = bucket.BucketName;
                    lblStatus.Text = "Connected";
                    btnCreate.Enabled = true;   

                    Console.WriteLine(bucket.BucketName);
                }
            }
        }


        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
           
        }

        private async void btnInitialize_Click(object sender, EventArgs e)
        {


            if (txtBucket.Text == "" || txtAccess.Text == "" || txtSecretKey.Text == "")
            {
                MessageBox.Show("All Fields are compulsory");
                return;
            }


            bucketName = txtBucket.Text;
            awsAccessKey = txtAccess.Text;
            awsSecretKey = txtSecretKey.Text;

            await ConnectToS3();

        }

        public async Task CreateFolder(string bucketName, string folderName)
        {
            RegionEndpoint region = RegionEndpoint.USEast1; // Change to your desired region

    //        string endpointUrl = $"s3-ap-south-2.amazonaws.com";

            string endpointUrl = "https://s3.us-east-1.amazonaws.com";

            // Create an instance of the Amazon S3 client
            using (var client = new AmazonS3Client(awsAccessKey, awsSecretKey, new AmazonS3Config { ServiceURL = endpointUrl }))
            {
                // Create a request to put an empty object with the desired folder name as the key
                var request = new PutObjectRequest
                {
                    BucketName = bucketName,
                    Key = folderName + "/"
                };

                // Send the request to create the "folder"
                PutObjectResponse response = await client.PutObjectAsync(request);

                if (response.HttpStatusCode.ToString() == "OK")
                {
                    lblStatus.Text = "Folder Successfully created";
                }
            }
        }



        private async void btnCreate_Click(object sender, EventArgs e)
        {
            string folderPath = txtpath.Text + "/";

            await CreateFolder(bucketName, folderPath);
        }
    }
}
