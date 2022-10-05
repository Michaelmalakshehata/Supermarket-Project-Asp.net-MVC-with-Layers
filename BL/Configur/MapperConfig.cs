using AutoMapper;
using BL.ViewModel;
using DAL;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Configur
{
    public static class MapperConfig
    {
        public static IMapper Mapper { get; set; }
        static MapperConfig()
        {
            var config = new MapperConfiguration(
                cfg =>
                {
                    cfg.CreateMap<Order, OrderViewModel>().ReverseMap();
                    cfg.CreateMap<ApplicationUserIdentity, LoginViewModel>().ReverseMap();
                    cfg.CreateMap<ApplicationUserIdentity, RegisterViewodel>().ReverseMap();
                    //cfg.CreateMap<IdentityResult, ResultStatue>().ReverseMap();

                });
            Mapper = config.CreateMapper();
        }
    }
}
