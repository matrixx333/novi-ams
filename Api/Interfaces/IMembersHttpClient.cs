using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Models;

namespace Api.Interfaces
{
    public interface IMembersHttpClient
    {
        Task<IEnumerable<Member>> GetMembersAsync();
        Task<Member> GetMemberAsync(string userName);
    }
}