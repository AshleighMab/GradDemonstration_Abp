using AutoMapper;
using GradDemonstration.Authorization.Users;
using GradDemonstration.Domain;
using GradDemonstration.Services.Dto;
using GradDemonstration.Services.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradDemonstration.Services.PersonService.MapProfile
{
    public class PersonMapProfile:Profile
    {
        public PersonMapProfile()
        {
            CreateMap<Person, PersonDto>()
                .ForMember(x => x.userId, m => m.MapFrom(x => x.User != null ? x.User.Id : (long?)null))
                .ForMember(x=>x.GenderName,m=>m.MapFrom(x=>x.Gender != null ? x.Gender.GetEnumDescription():null));

            CreateMap<PersonDto, User>()
                .ForMember(x => x.Name, m => m.MapFrom(x => x.Name))
                .ForMember(x => x.PhoneNumber, m => m.MapFrom(x => x.PhoneNumber))
                .ForMember(x => x.EmailAddress, m => m.MapFrom(x => x.EmailAddress))
                .ForMember(x => x.FullName, m => m.MapFrom(x => x.Name + " " + x.Surname))
                .ForMember(x => x.Password, m => m.MapFrom(x => x.Password))
                .ForMember(x => x.Surname, m => m.MapFrom(x => x.Surname))
                .ForMember(x => x.UserName, m => m.MapFrom(x => x.Name + x.IDNumber.Substring(0, 4)));

            CreateMap<PersonDto,User>()
                .ForMember(e => e.Id, d => d.Ignore());

            CreateMap<PersonDto,Person>()
                .ForMember(e => e.Id, d => d.Ignore());
        }
    }
}
