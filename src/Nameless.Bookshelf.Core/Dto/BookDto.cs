using System;

namespace Nameless.Bookshelf.Dto {

    public sealed class BookDto {

        #region Public Properties

        public Guid ID { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }
        public int Edition { get; set; }
        public string Year { get; set; }
        public PublisherDto Publisher { get; set; }
        public AuthorDto[] Authors { get; set; }
        public LanguageDto[] Languages { get; set; }
        public string Note { get; set; }
        public bool Lent { get; set; }
        public OwnerDto Owner { get; set; }

        #endregion Public Properties
    }
}