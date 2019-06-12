using AutoMapper;
using GameCollectionAPI.Models.Resources;

namespace GameCollectionAPI.Models.Mapping
{
    public class ModelToResourceProfile : Profile
    {
        public ModelToResourceProfile()
        {
            CreateMap<UserModel, UserResource>();
            CreateMap<CollectionModel, CollectionResource>();
            CreateMap<GameModel, GameResource>();
        }
    }
}
