using AutoMapper;
using Nameless.Bookshelf.Dto;
using Nameless.Bookshelf.Entities;

namespace Nameless.Bookshelf.ObjectMapper {

    public sealed class BookProfile : Profile {

        #region Public Constructors

        public BookProfile() {
            CreateMap<Book, BookDto>()
                .ForMember(dest => dest.Owner, opts => opts.MapFrom(src => new OwnerDto { Identifier = src.Owner }));
            CreateMap<BookDto, Book>()
                .ForMember(dest => dest.Owner, opts => opts.MapFrom(src => src.Owner != null ? src.Owner.Identifier : null));
        }

        #endregion Public Constructors
    }
}