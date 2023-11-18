using DevExpress.Utils.MVVM.Services;
using QuizletWindows.ViewModels.User;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using QuizletWindows.Forms;
using Notification = QuizletWindows.Forms.Notification;
using System.Net;

namespace QuizletWindows.API
{
    public class UserApi
    {
        private HttpClient client;
        private static readonly Lazy<UserApi> lazyInstance = new Lazy<UserApi>(() => new UserApi());
        public static UserApi Instance {  get { return lazyInstance.Value; } } 
        public void SetHttpClient (HttpClient httpClient)
        {
            this.client = httpClient;
        }
        public async Task<List<UserViewModel>> GetUsers()
        {
            var users = await client.GetFromJsonAsync<List<UserViewModel>>(Api.UserUrl);
            return users;
        }
        public UserViewModel FindAccount(string username, string password)
        {
            var user = client.GetFromJsonAsync<UserViewModel>(Api.UserUrl + $"/{username}/{password}");
            return user.Result;
        }
        public async Task<UserViewModel> GetProfile(int userId)
        {
            var user = await client.GetFromJsonAsync<UserViewModel>(Api.UserUrl + $"/{userId}");
            return user;
        }
        public async Task<bool> UpdateProfile(UserViewModel user)
        {
            HttpResponseMessage response = await client.PutAsJsonAsync<UserViewModel>(Api.UserUrl, user);
            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            return false;
        }
        public async Task<bool> ChangePassword(ChangePasswordViewModel model)
        {
            HttpResponseMessage response = await client.PutAsJsonAsync<ChangePasswordViewModel>(Api.UserChangePassword, model);
            if (response.StatusCode == HttpStatusCode.NoContent)
            {
                return false;
            }
            return true;

        }
        public async Task<bool> HandleForgetPassword(ForgetPasswordViewModel model)
        {
            HttpResponseMessage response = await client.PutAsJsonAsync<ForgetPasswordViewModel>(Api.UserForgetPassword, model);
            if (response.StatusCode == HttpStatusCode.NoContent)
            {
                return false;
            }
            return true;
        }
    }
}
