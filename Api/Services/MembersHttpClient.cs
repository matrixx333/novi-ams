using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Api.Interfaces;
using Api.Models;
using Newtonsoft.Json;

namespace Api.Services
{
    public class MembersHttpClient : IMembersHttpClient
    {
        static readonly HttpClient _client = new HttpClient();
        private readonly IConfiguration _config;

        public MembersHttpClient(IConfiguration config)
        {
            _config = config;
            _client.BaseAddress = new Uri(_config["BaseUrl"]);
            _client.DefaultRequestHeaders
                    .Accept
                    .Add(new MediaTypeWithQualityHeaderValue("application/json"));
            _client.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Basic", _config["ApiKey"]);
        }

        public async Task<IEnumerable<Member>> GetMembersAsync()
        {
            var membersResponse = new MembersResponse();
            try
            {
                var response = await _client.GetAsync("/api/members");
                membersResponse = response.Content.ReadFromJsonAsync<MembersResponse>().Result;
            }
            catch (HttpRequestException e)
            {                
                Console.WriteLine("MembersHttpClient.GetMembersAsync :{0} ", e.Message);
            }

            return membersResponse.Results;
        }

        public async Task<Member> GetMemberAsync(string uniqueId)
        {
            var member = new Member();
            try
            {
                var response = await _client.GetAsync($"/api/members/{uniqueId}");
                member = response.Content.ReadFromJsonAsync<Member>().Result;
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("MembersHttpClient.GetMemberAsync :{0} ", e.Message);
            }

            return member;
        }
    }
}