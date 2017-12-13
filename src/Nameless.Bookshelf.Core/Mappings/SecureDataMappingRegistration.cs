using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.IdGenerators;
using Nameless.WinFormsApplication.Auth.Entities;
using Nameless.WinFormsApplication.Persistence;

namespace Nameless.Bookshelf.Mappings {

    public sealed class SecureDataMappingRegistration : MappingRegistrationBase {

        #region Public Override Methods

        public override BsonClassMap Create() {
            return new BsonClassMap<SecureData>(mapInitializer => {
                mapInitializer.AutoMap();
                mapInitializer.MapIdMember(_ => _.Username).SetIdGenerator(StringObjectIdGenerator.Instance);
            });
        }

        #endregion Public Override Methods
    }
}