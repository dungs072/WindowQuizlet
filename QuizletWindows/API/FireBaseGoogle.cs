using DevExpress.Drawing;
using Firebase.Auth;
using Firebase.Storage;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace QuizletWindows.API
{
    public class FireBaseGoogle
    {
        private readonly string apiKey = "AIzaSyDdwQpFpqzK-c4emQlK5Sy6pTDMVnh5qiY";
        private readonly string bucket = "quizlet-c9cab.appspot.com";
        private readonly string gmail = "sa123@gmail.com";
        private readonly string password = "123456";
        public FirebaseStorage FirebaseStorage { get; private set; }

        public FireBaseGoogle() 
        {
            Initial();
        }
        private async Task Initial()
        {
            var cancellation = new CancellationTokenSource();
            // Initialize Firebase Storage
            var auth = new FirebaseAuthProvider(new FirebaseConfig(apiKey));
            var authLink = await auth.SignInWithEmailAndPasswordAsync(gmail, password);

            FirebaseStorage = new FirebaseStorage(bucket, new FirebaseStorageOptions
            {
                AuthTokenAsyncFactory = () => Task.FromResult(authLink.FirebaseToken)
            });
        }
        public byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png); // You can choose a different format if needed
                return ms.ToArray();
            }
        }
        public async Task<string> StoreImage(string path, Image image)
        {
            if (FirebaseStorage == null)
            {
                await Initial();
            }
            byte[] imageBytes = ImageToByteArray(image);
            var task = FirebaseStorage
                .Child(path)
                .Child($"image_{DateTime.Now.Ticks}.png")
                .PutAsync(new MemoryStream(imageBytes));

           return await task;
        }

        public async void DeleteTheOldImage(string image)
        {
            if(FirebaseStorage==null)
            {
                await Initial();
            }
            string fileNameDelete = ExtractFileNameFromUrl(image);
            string deletePath = $"images/{fileNameDelete}";
            await FirebaseStorage.Child(deletePath).DeleteAsync();
        }

        private string ExtractFileNameFromUrl(string url)
        {
            // Use Uri to parse the URL
            Uri uri = new Uri(url);

            // Get the filename from the URL using Path.GetFileName
            string fileName = Path.GetFileName(uri.LocalPath);

            return fileName;
        }

    }
}
