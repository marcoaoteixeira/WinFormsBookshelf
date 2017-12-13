using MongoDB.Bson.Serialization;
using Nameless.Bookshelf.Entities;
using Nameless.WinFormsApplication.Persistence;

namespace Nameless.Bookshelf.Mappings {

    public sealed class PublisherMappingRegistration : MappingRegistrationBase {

        #region Public Override Methods

        public override BsonClassMap Create() {
            return new BsonClassMap<Publisher>(mapInitializer => {
                mapInitializer.AutoMap();
                
            });
        }

        #endregion Public Override Methods
    }
}