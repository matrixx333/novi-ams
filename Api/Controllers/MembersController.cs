using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Api.Interfaces;
using Api.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    public class MembersController : BaseApiController
    {
        private readonly IMembersHttpClient _membersHttpClient;
        private readonly IConfiguration _config;

        public MembersController(IMembersHttpClient membersHttpClient, IConfiguration config) 
        {
            _membersHttpClient = membersHttpClient;
            _config = config;
        }

        [HttpGet()]
        public async Task<ActionResult<IEnumerable<Member>>> GetMembers()
        {
            var members = await _membersHttpClient.GetMembersAsync();
            return Ok(members.OrderBy(m => m.Name));
        }

        [HttpGet("{uniqueId}")]

        public async Task<ActionResult<Member>> GetMember(string uniqueId)
        {
            var member = await _membersHttpClient.GetMemberAsync(uniqueId);
            return Ok(member);
        }
    }
}