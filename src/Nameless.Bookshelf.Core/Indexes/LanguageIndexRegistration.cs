using System.Collections.Generic;
using MongoDB.Driver;
using Nameless.Bookshelf.Entities;
using Nameless.WinFormsApplication.Persistence;

namespace Nameless.Bookshelf.Indexes {

    public sealed class LanguageIndexRegistration : IndexRegistrationBase<Language> {

        #region Public Override Methods

        public override IEnumerable<IndexDefinition<Language>> Create() {
            var indexKeys = Builders<Language>.IndexKeys;
            var uniqueOption = new CreateIndexOptions<Language> { Unique = true };
            return new[] {
                new IndexDefinition<Language>(
                    key: indexKeys.Combine(
                        keys: new[] {
                            Builders<Language>.IndexKeys.Ascending(_ => _.Description)
                        }
                    ),
                    options: uniqueOption
                )
            };
        }

        #endregion Public Override Methods
    }
}