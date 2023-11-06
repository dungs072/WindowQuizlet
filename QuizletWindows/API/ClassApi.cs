using QuizletWindows.ViewModels.Classes;
using QuizletWindows.ViewModels.Terminologies;
using System;
using System.Collections.Generic;
using System.IdentityModel.Protocols.WSTrust;
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
        public List<RegisterClass> GetRegisterClass(int userId, string search)
        {
            return client.GetFromJsonAsync<List<RegisterClass>>(Api.ClassRegister + $"/{userId}/{search}").Result;
        }

        public List<UserParticipant> GetDetailParticipantClass(int classId)
        {
            return client.GetFromJsonAsync<List<UserParticipant>>(Api.ClassParticipant + $"/{classId}").Result;
        }
        public List<ClassLearningModuleViewModel> GetDetailLearningModuleClass(int classId)
        {
            return client.GetFromJsonAsync<List<ClassLearningModuleViewModel>>(Api.ClassDetailOwn + $"{classId}").Result;
        }

        public List<LearningModuleViewModel> GetModuleDatas(int classId, int titleId)
        {
            return client.GetFromJsonAsync<List<LearningModuleViewModel>>(Api.ClassModuleDetailOwn + $"{classId}/{titleId}").Result;

        }
        public async Task<bool> AddModuleToClass(LearningModuleDetail detail)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync<LearningModuleDetail>(Api.ClassModuleAdd, detail);
            if (response.StatusCode == HttpStatusCode.BadRequest)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        public async Task<bool> DeleteModuleDetail(int classId, int moduleId)
        {
            HttpResponseMessage response = await client.DeleteAsync(Api.ClassModuleAdd + $"/{classId}/{moduleId}");
            if (response.StatusCode == HttpStatusCode.BadRequest)
            {
                return false;
            }
            return true;
        }
        public List<UserParticipant> GetUserParticipant(int classId, string search, int currentUserId)
        {
            return client.GetFromJsonAsync<List<UserParticipant>>(Api.ClassParticipantSearch + $"/{classId}/{search}/{currentUserId}").Result;
        }
        public async Task<bool> AddParticipantToClass(RegisterDetailClass detail)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync<RegisterDetailClass>(Api.ClassParticipantAdd, detail);
            if (response.StatusCode == HttpStatusCode.BadRequest)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        public async Task<bool> DeleteParticipantFromClass(int classId, int userId)
        {
            HttpResponseMessage response = await client.DeleteAsync(Api.ClassParticipantAdd + $"/{classId}/{userId}");
            if (response.StatusCode == HttpStatusCode.BadRequest)
            {
                return false;
            }
            return true;
        }
        public List<ClassViewModel> GetJoinClass(int userId)
        {
            return client.GetFromJsonAsync<List<ClassViewModel>>(Api.ClassJoin + $"/{userId}").Result;
        }
    }
}
