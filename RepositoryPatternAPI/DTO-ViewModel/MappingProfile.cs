using AutoMapper;
using Entities.Models;
using Entities.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryPatternAPI.DTO_ViewModel
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Owner, OwnerViewModel>();
            CreateMap<OwnerForCreationViewModel, Owner>();
            CreateMap<OwnerForUpdateViewModel, Owner>();
        }
    }
}
