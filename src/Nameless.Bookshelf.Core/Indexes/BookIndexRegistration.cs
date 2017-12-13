using System.Collections.Generic;
using MongoDB.Driver;
using Nameless.Bookshelf.Entities;
using Nameless.WinFormsApplication.Persistence;

namespace Nameless.Bookshelf.Indexes {

    public sealed class BookIndexRegistration : IndexRegistrationBase<Book> {

        #region Public Override Methods

        public override IEnumerable<IndexDefinition<Book>> Create() {
            var indexKeys = Builders<Book>.IndexKeys;
            return new[] {
                new IndexDefinition<Book>(
                    key: indexKeys.Combine(
                        keys: new[] {
                            Builders<Book>.IndexKeys.Ascending(_ => _.Title),
                            Builders<Book>.IndexKeys.Ascending(_ => _.ISBN),
                            Builders<Book>.IndexKeys.Ascending(_ => _.Publisher)
                        }
                    ),
                    options: null
                )
            };
        }

        #endregion Public Override Methods
    }
}