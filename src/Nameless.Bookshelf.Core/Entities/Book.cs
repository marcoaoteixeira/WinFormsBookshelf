using System;
using Nameless.WinFormsApplication.Entities;

namespace Nameless.Bookshelf.Entities {

    public sealed class Book : EntityBase<Guid> {

        #region Public Properties

        public string Title { get; set; }
        public string ISBN { get; set; }
        public int Edition { get; set; }
        public string Year { get; set; }
        public string Publisher { get; set; }
        public string[] Authors { get; set; }
        public string[] Languages { get; set; }
        public string Note { get; set; }
        public bool Lent { get; set; }
        public string Owner { get; set; }

        #endregion Public Properties
    }
}