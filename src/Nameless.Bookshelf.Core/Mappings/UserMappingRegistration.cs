using MongoDB.Bson.Serialization;
using Nameless.WinFormsApplication.Auth.Entities;
using Nameless.WinFormsApplication.Persistence;

namespace Nameless.Bookshelf.Mappings {

    public sealed class UserMappingRegistration : MappingRegistrationBase {

        #region Public Override Methods

        public override BsonClassMap Create() {
            return new BsonClassMap<User>(mapInitializer => {
                mapInitializer.AutoMap();
            });
        }

        #endregion Public Override Methods
    }
}