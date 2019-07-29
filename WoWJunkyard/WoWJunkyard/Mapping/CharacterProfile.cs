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
            CreateMap<ItemsInputModel, Items>()
                .ForMember(dest =>dest.ItemInfos,m => m.MapFrom(s => s.ItemInfo));
            CreateMap<ItemInfoInputModel, ItemInfo>()
                .ForMember(dest => dest.BonusLists, m => m.MapFrom(value => string.Join(':',value.Bonus)));
            CreateMap<StatInputModel, Stat>();
            CreateMap<AzeriteEmpoweredItemInputModel, AzeriteEmpoweredItem>();
            CreateMap<AzeritePowerInputModel, AzeritePower>();
            CreateMap<AzeriteItemInputModel, AzeriteItem>();
            CreateMap<WeaponInfoInputModel, WeaponInfo>();
            CreateMap<DamageInputModel, Damage>();
        }
    }
}