using QuizletWindows.ViewModels;
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
    public class AchivementApi
    {
        private HttpClient client;
        private static readonly Lazy<AchivementApi> lazyInstance = new Lazy<AchivementApi>(() => new AchivementApi());
        public static AchivementApi Instance { get { return lazyInstance.Value; } }
        public void SetHttpClient(HttpClient httpClient)
        {
            this.client = httpClient;
        }
        public List<LevelTerms> GetLevelTerm(int UserId)
        {
            return client.GetFromJsonAsync<List<LevelTerms>>(Api.AchivementUser + $"/{UserId}").Result;
        }
        public AchieveStatistics GetAchieveStatistics(int UserId)
        {
            return client.GetFromJsonAsync<AchieveStatistics>(Api.AchieveStatistics + $"/{UserId}").Result;
        }

        public List<string> GetSequenceDates(int userId)
        {
            return  client.GetFromJsonAsync<List<string>>(Api.SequenceCalender + $"/{userId}").Result;
        }
        public bool MarkAttendance(MarkAttendance mark)
        {
            HttpResponseMessage response = client.PostAsJsonAsync<MarkAttendance>(Api.MarkAttendance, mark).Result;
            if (response.StatusCode == HttpStatusCode.NoContent)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        public List<Badge> GetBadges(int UserId)
        {
            return client.GetFromJsonAsync<List<Badge>>(Api.Badges + $"/{UserId}").Result;
        }
    }
}
