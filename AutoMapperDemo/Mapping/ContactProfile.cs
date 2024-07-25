using AutoMapper;
using AutoMapperDemo.Data.Models;
using AutoMapperDemo.Models;

namespace AutoMapperDemo.Mapping
{
    public class ContactProfile : Profile
    {
        public ContactProfile()
        {
            CreateMap<ContactViewModel, Contact>();
        }
    }
}