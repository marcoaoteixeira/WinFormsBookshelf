using System.Collections.Generic;
using MongoDB.Driver;
using Nameless.Bookshelf.Entities;
using Nameless.WinFormsApplication.Persistence;

namespace Nameless.Bookshelf.Indexes {

    public sealed class AuthorIndexRegistration : IndexRegistrationBase<Author> {

        #region Public Override Methods

        public override IEnumerable<IndexDefinition<Author>> Create() {
            var indexKeys = Builders<Author>.IndexKeys;
            var uniqueOption = new CreateIndexOptions<Author> { Unique = true };
            return new[] {
                new IndexDefinition<Author>(
                    key: indexKeys.Combine(
                        keys: new[] {
                            Builders<Author>.IndexKeys.Ascending(_ => _.Name)
                        }
                    ),
                    options: uniqueOption
                )
            };
        }

        #endregion Public Override Methods
    }
}