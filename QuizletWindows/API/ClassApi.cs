using QuizletWindows.ViewModels.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace QuizletWindows.API
{
    public class ClassApi
    {
        private HttpClient client;
        private static readonly Lazy<ClassApi> lazyInstance = new Lazy<ClassApi>(() => new ClassApi());
        public static ClassApi Instance { get { return lazyInstance.Value; } }
        public void SetHttpClient(HttpClient httpClient)
        {
            this.client = httpClient;
        }
        public List<ClassViewModel> GetClassesByUser(int UserId)
        {
            return client.GetFromJsonAsync<List<ClassViewModel>>(Api.ClassUrl + $"/{UserId}").Result;
        }
        public async Task<ClassViewModel> GetClass(int classId)
        {
            return await client.GetFromJsonAsync<ClassViewModel>(Api.ClassUrlFind + $"{classId}");
        }
        public async Task<bool> CreateClass(ClassViewModel classViewModel)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync<ClassViewModel>(Api.ClassUrl, classViewModel);
            if (response.StatusCode == HttpStatusCode.BadRequest)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        public async Task<bool> UpdateClass(ClassViewModel classViewModel)
        {
            HttpResponseMessage response = await client.PutAsJsonAsync<ClassViewModel>(Api.ClassUrl, classViewModel);
            if (response.StatusCode == HttpStatusCode.BadRequest)
            {
                return false;
            }
            return true;
        }
        public async Task<bool> DeleteClass(int classId)
        {
            HttpResponseMessage response = await client.DeleteAsync(Api.ClassUrl + $"/{classId}");
            if (response.StatusCode == HttpStatusCode.BadRequest)
            {
                return false;
            }
            return true;
        }

    }
}
