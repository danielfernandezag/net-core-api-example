using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using GameCollectionAPI.Services;
using GameCollectionAPI.Models;
using GameCollectionAPI.Models.Resources;
using GameCollectionAPI.Extensions;
using AutoMapper;

namespace GameCollectionAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUsersService usersService;
        private readonly IMapper mapper;

        public UsersController(IUsersService usersService, IMapper mapper)
        {
            this.usersService = usersService;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<UserResource>> GetAllAsync()
        {
            var users = await this.usersService.ListAsync();
            var userResource = this.mapper.Map<IEnumerable<UserModel>, IEnumerable<UserResource>>(users);
            return userResource;
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] SaveUserResource resource)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState.GetErrorMessages());
            }

            var user = this.mapper.Map<SaveUserResource, UserModel>(resource);
            var result = await this.usersService.SaveAsync(user);

            if (!result.Success)
            {
                return BadRequest(result.Message);
            }

            var userResource = this.mapper.Map<UserModel, UserResource>(result.User);

            return Ok(userResource);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutAsync(short id,[FromBody] SaveUserResource resource)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState.GetErrorMessages());
            }

            var user = this.mapper.Map<SaveUserResource, UserModel>(resource);
            var result = await this.usersService.UpdateAsync(id, user);

            if (!result.Success)
            {
                return BadRequest(result.Message);
            }


            var userResource = this.mapper.Map<UserModel, UserResource>(result.User);

            return Ok(userResource);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteAsync(short id)
        {

        }
    }
}


