using AutoMapper;
using WoWJunkyard.Data.Models;
using WoWJunkyard.Views.Models;

namespace WoWJunkyard.Mapping
{
    public class CharacterProfile : Profile
    {
        public CharacterProfile()
        {
            CreateMap<CharacterInputModel, Character>();
            CreateMap<ItemsInputModel, Items>();
            CreateMap<ItemInfoInputModel, ItemInfo>();
            CreateMap<StatInputModel, Stat>();
            CreateMap<BonusListInputModel, BonusList>();
        }
    }
}