using System;
using System.Security.Cryptography.X509Certificates;
using AutoMapper;
using WoWJunkyard.Data.Models;
using WoWJunkyard.Models.Character;
using WoWJunkyard.Models.News;
using WoWJunkyard.Views.Models;
using WoWJunkyard.Views.Models.Enums;
using WoWJunkyard.Views.ViewModels;

namespace WoWJunkyard.Mapping
{
    public class CharacterProfile : Profile
    {
        public CharacterProfile()
        {
            CreateMap<CharacterInputModel, Character>();
            CreateMap<Character, CharacterListViewModel>();
            CreateMap<NewsViewModel, News>();
            CreateMap<News, NewsViewModel>();
            CreateMap<EquippedItemInputModel, EquippedItem>()
                .ForMember(dest => dest.Bonus, m => m.MapFrom(value => string.Join(':', value.BonusList)));
            CreateMap<MediaClass, ItemInfo>()
                .ForMember(dest => dest.ItemIdNumber, m => m.MapFrom(val => val.Id))
                .ForMember(dest => dest.Id,x=>x.Ignore());
            CreateMap<InventoryTypeInputModel, InventoryType>();

            //CreateMap<ItemInfoInputModel, ItemInfo>()
            //    .ForMember(dest => dest.BonusLists, m => m.MapFrom(value => string.Join(':',value.Bonus)));
            //CreateMap<StatInputModel, Stat>();
            //CreateMap<AzeriteEmpoweredItemInputModel, AzeriteEmpoweredItem>();
            //CreateMap<AzeritePowerInputModel, AzeritePower>();
            //CreateMap<AzeriteItemInputModel, AzeriteItem>();
            //CreateMap<WeaponInfoInputModel, WeaponInfo>();
            //CreateMap<DamageInputModel, Damage>();
        }
    }
}