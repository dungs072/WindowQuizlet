using DevExpress.XtraReports.Parameters.ViewModels;
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
        public async Task<bool> DeleteTitle(int TitleId)
        {
            HttpResponseMessage response = await client.DeleteAsync(Api.TitleUrl + $"/{TitleId}");
            if (response.StatusCode == HttpStatusCode.NoContent)
            {
                return false;
            }
            else
            {
                return true;
            }
            
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

            var canDelete = await client.GetStringAsync(Api.ClassCanDeleteLearningModule + $"/{LearningModuleId}/{Program.UserId}");
            //if(response.StatusCode== HttpStatusCode.BadRequest) 
            //{
            //    return "2";
            //}
            if (canDelete != "yes")
            {
                return false;
            }
            else
            {
                HttpResponseMessage response = await client.DeleteAsync(Api.LearningModuleUrl + $"/{LearningModuleId}");
                if (response.StatusCode == HttpStatusCode.BadRequest)
                {
                    return false;
                }
                return true;
            }
            //HttpResponseMessage response = await client.DeleteAsync(Api.LearningModuleUrl + $"/{LearningModuleId}");
            //if (response.StatusCode == HttpStatusCode.BadRequest)
            //{
            //    return false;
            //}
            //return true;
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

        #region Terminology
        public List<TermViewModel> GetTermByLearningModuleId(int learningModuleId)
        {
            return client.GetFromJsonAsync<List<TermViewModel>>(Api.TermUrl + $"/{learningModuleId}").Result;
        }
        public async Task<bool> CreateTerm(TermViewModel termViewModel)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync<TermViewModel>(Api.TermUrl, termViewModel);
            if (response.StatusCode == HttpStatusCode.BadRequest)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        public async Task<bool> DeleteTerm(int termId)
        {
            HttpResponseMessage response = await client.DeleteAsync(Api.TermUrl + $"/{termId}");
            if (response.StatusCode == HttpStatusCode.BadRequest)
            {
                return false;
            }
            return true;
        }

        public async Task<bool> UpdateTerm(TermViewModel termViewModel)
        {
            HttpResponseMessage response = await client.PutAsJsonAsync<TermViewModel>(Api.TermUrl, termViewModel);
            if (response.StatusCode == HttpStatusCode.BadRequest)
            {
                return false;
            }
            return true;
        }
        #endregion

        #region Practice_Test
        public List<ObjectivePack> GetObjectivePacks(int learningModuleId)
        {
            return client.GetFromJsonAsync<List<ObjectivePack>>(Api.TermUrlObjective + $"{learningModuleId}").Result;
        }

        public async Task<bool> UpdateTermTest(ResultQuestion resultQuestion)
        {
            HttpResponseMessage response = await client.PutAsJsonAsync<ResultQuestion>(Api.TermTest, resultQuestion);
            if (response.StatusCode == HttpStatusCode.BadRequest)
            {
                return false;
            }
            return true;
        }
        #endregion
    }
}
