using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using EducationLibrary.Entities;
using EducationLibrary.Api.Models;

namespace EducationLibrary.Api.Mapper
{
    public class MapperConfig
    {
        public static IMapper GetMapper()
        {
            var config = new MapperConfiguration(conf =>
            {

                conf.CreateMap<Preview, PreviewModel>();
                conf.CreateMap<Preview, PreviewModel>().ReverseMap();
            });
            return config.CreateMapper();
        }

    }
}
