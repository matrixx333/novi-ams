using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Api.Interfaces;
using Api.Models;

namespace Api.Services
{
    public class MembersService : IMembersService
    {
        static readonly HttpClient _client = new HttpClient();
        private readonly string _baseUrl = "https://180930b.novitesting.com/";
        private readonly string _apiKey = "";

        public MembersService()
        {
            _client.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Basic", _apiKey);
        }

        public async Task<IEnumerable<MemberDto>> GetMembersAsync()
        {
            // Call asynchronous network methods in a try/catch block to handle exceptions.
            try
            {
                HttpResponseMessage response = await _client.GetAsync(_baseUrl);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                // Above three lines can be replaced with new helper method below
                // string responseBody = await client.GetStringAsync(uri);

                Console.WriteLine(responseBody);
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }

            return new List<MemberDto>();
        }

        public async Task<MemberDto> GetMemberAsync(string userName)
        {
            // Call asynchronous network methods in a try/catch block to handle exceptions.
            try
            {
                HttpResponseMessage response = await _client.GetAsync(_baseUrl);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                // Above three lines can be replaced with new helper method below
                // string responseBody = await client.GetStringAsync(uri);

                Console.WriteLine(responseBody);
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }

            return new MemberDto();
        }
    }
}