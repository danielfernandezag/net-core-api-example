using AutoMapper;
using GameCollectionAPI.Models;
using GameCollectionAPI.Models.Resources;

namespace GameCollectionAPI.Models.Mapping
{
    public class ResourceToModelProfile : Profile
    {
        public ResourceToModelProfile()
        {
            CreateMap<SaveUserResource, UserModel>();
            CreateMap<SaveCollectionResource, CollectionModel>();
            CreateMap<SaveGameResource, GameModel>();
        }
    }
}
