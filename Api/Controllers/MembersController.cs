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
using Microsoft.EntityFrameworkCore;

namespace Api.Controllers
{
    public class MembersController : BaseApiController
    {
        private readonly IMembersService _membersService;

        public MembersController(IMembersService membersService)
        {
            _membersService = membersService;
        }

        [HttpGet()]
        [AllowAnonymous]
        public async Task<ActionResult<IEnumerable<MemberDto>>> GetMembers()
        {
            var members = await _membersService.GetMembersAsync();
            return Ok(members);
        }

        [HttpGet("{userName}}")]
        [AllowAnonymous]

        public async Task<ActionResult<MemberDto>> GetMember(string userName)
        {
            var member = await _membersService.GetMemberAsync(userName);
            return Ok(member);
        }
    }
}