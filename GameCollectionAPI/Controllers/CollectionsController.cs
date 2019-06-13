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
    public class CollectionsController : ControllerBase
    {
        private readonly ICollectionsService collectionsService;
        private readonly IMapper mapper;

        public CollectionsController(ICollectionsService collectionsService, IMapper mapper)
        {
            this.collectionsService = collectionsService;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<CollectionResource>> GetAllAsync()
        {
            var collections = await this.collectionsService.ListAsync();
            var collectionsResource = this.mapper.Map<IEnumerable<CollectionModel>, IEnumerable<CollectionResource>>(collections);
            return collectionsResource;
        }   
    }
}