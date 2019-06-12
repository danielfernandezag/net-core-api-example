using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using GameCollectionAPI.Services;
using GameCollectionAPI.Models;
using GameCollectionAPI.Models.Resources;
using AutoMapper;

namespace GameCollectionAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GamesController : ControllerBase
    {
        private readonly IGamesService gamesService;
        private readonly IMapper mapper;

        public GamesController(IGamesService gamesService, IMapper mapper)
        {
            this.gamesService = gamesService;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<GameResource>> Get()
        {
            var games = await this.gamesService.ListAsync();
            var gamesResource = this.mapper.Map<IEnumerable<GameModel>, IEnumerable<GameResource>>(games); 
            return gamesResource;
        }
    }
}