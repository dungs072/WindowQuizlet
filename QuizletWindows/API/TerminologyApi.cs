using QuizletWindows.ViewModels.Terminologies;
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
    public class TerminologyApi
    {
        private HttpClient client;
        private static readonly Lazy<TerminologyApi> lazyInstance = new Lazy<TerminologyApi>(() => new TerminologyApi());
        public static TerminologyApi Instance { get { return lazyInstance.Value; } }
        public void SetHttpClient(HttpClient httpClient)
        {
            this.client = httpClient;
        }
        #region Title

        public List<TitleViewModel> GetTitles()
        {
            return client.GetFromJsonAsync<List<TitleViewModel>>(Api.TitleUrl).Result;
        }
        public List<TitleViewModel> GetTitlesBaseOnUserId(int UserId)
        {
            return client.GetFromJsonAsync<List<TitleViewModel>>(Api.TitleUrlUser + $"{UserId}").Result;
        }
        public async Task<bool> CreateTitle(TitleViewModel titleViewModel)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync<TitleViewModel>(Api.TitleUrl, titleViewModel);
            if (response.StatusCode == HttpStatusCode.BadRequest)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public async Task<bool> UpdateTitle(TitleViewModel titleViewModel)
        {
            HttpResponseMessage response = await client.PutAsJsonAsync<TitleViewModel>(Api.TitleUrl, titleViewModel);
            if (response.StatusCode == HttpStatusCode.BadRequest)
            {
                return false;
            }
            else
            {
                return true;
            }
            
        }
        public async Task DeleteTitle(int TitleId)
        {
            await client.DeleteAsync(Api.TitleUrl + $"/{TitleId}");
        }
        #endregion

        #region Module
        public List<LearningModuleViewModel2> GetLearningModuleByTitleId(int TitleId)
        {
            return  client.GetFromJsonAsync<List<LearningModuleViewModel2>>(Api.LearningModuleUrl + $"/{TitleId}").Result;
        }
        public async Task<bool> CreateLearningModule(LearningModuleViewModel2 learningModuleViewModel)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync<LearningModuleViewModel2>(Api.LearningModuleUrl, learningModuleViewModel);
            if (response.StatusCode == HttpStatusCode.BadRequest)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        public async Task<bool> DeleteLearningModule(int LearningModuleId)
        {
            HttpResponseMessage response = await client.DeleteAsync(Api.LearningModuleUrl + $"/{LearningModuleId}");
            if (response.StatusCode == HttpStatusCode.BadRequest)
            {
                return false;
            }
            return true;
        }

        public async Task<bool> UpdateLearningModule(LearningModuleViewModel2 learningModuleViewModel)
        {
            HttpResponseMessage response = await client.PutAsJsonAsync<LearningModuleViewModel2>(Api.LearningModuleUrl, learningModuleViewModel);
            if (response.StatusCode == HttpStatusCode.BadRequest)
            {
                return false;
            }
            return true;
        }
        #endregion
    }
}
