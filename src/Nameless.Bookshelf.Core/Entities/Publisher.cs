using System;
using Nameless.WinFormsApplication.Entities;

namespace Nameless.Bookshelf.Entities {

    public sealed class Publisher : EntityBase<Guid> {

        #region Public Properties

        public string Name { get; set; }

        #endregion Public Properties
    }
}