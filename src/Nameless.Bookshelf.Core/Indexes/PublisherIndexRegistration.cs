using System.Collections.Generic;
using MongoDB.Driver;
using Nameless.Bookshelf.Entities;
using Nameless.WinFormsApplication.Persistence;

namespace Nameless.Bookshelf.Indexes {

    public sealed class PublisherIndexRegistration : IndexRegistrationBase<Publisher> {

        #region Public Override Methods

        public override IEnumerable<IndexDefinition<Publisher>> Create() {
            var indexKeys = Builders<Publisher>.IndexKeys;
            var uniqueOption = new CreateIndexOptions<Publisher> { Unique = true };
            return new[] {
                new IndexDefinition<Publisher>(
                    key: indexKeys.Combine(
                        keys: new[] {
                            Builders<Publisher>.IndexKeys.Ascending(_ => _.Name)
                        }
                    ),
                    options: uniqueOption
                )
            };
        }

        #endregion Public Override Methods
    }
}