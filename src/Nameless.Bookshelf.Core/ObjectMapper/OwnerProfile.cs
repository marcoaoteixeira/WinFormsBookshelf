using AutoMapper;
using Nameless.Bookshelf.Dto;
using Nameless.WinFormsApplication.Auth.Entities;

namespace Nameless.Bookshelf.ObjectMapper {

    public sealed class OwnerProfile : Profile {

        #region Public Constructors

        public OwnerProfile() {
            CreateMap<User, OwnerDto>()
                .ForMember(dest => dest.Identifier, opts => opts.MapFrom(src => src.Username.ToString()))
                .ForMember(dest => dest.Name, opts => opts.MapFrom(src => src.DisplayName));
        }

        #endregion Public Constructors
    }
}