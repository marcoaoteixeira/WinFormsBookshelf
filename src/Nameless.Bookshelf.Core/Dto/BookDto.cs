using System;

namespace Nameless.Bookshelf.Dto {

    public sealed class BookDto {

        #region Public Properties

        public Guid ID { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }
        public int Edition { get; set; }
        public int Year { get; set; }
        public string Publisher { get; set; }
        public string[] Authors { get; set; }
        public string[] Languages { get; set; }
        public string Note { get; set; }
        public bool Lent { get; set; }
        public OwnerDto Owner { get; set; }

        // Computed
        public string AuthorsFlatten => string.Join("; ", Authors ?? new string[0]);
        public string LanguagesFlatten => string.Join("; ", Languages ?? new string[0]);
        public string OwnerName => Owner?.Name;

        #endregion Public Properties
    }
}