using System;
using Nameless.WinFormsApplication.Entities;

namespace Nameless.Bookshelf.Entities {

    public sealed class Language : EntityBase<Guid> {

        #region Public Properties

        public string Description { get; set; }

        #endregion Public Properties
    }
}