using System;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.IdGenerators;
using Nameless.WinFormsApplication.Entities;
using Nameless.WinFormsApplication.Persistence;

namespace Nameless.Bookshelf.Mappings {

    public sealed class EntityBaseMappingRegistration : MappingRegistrationBase {

        #region Public Override Methods

        public override BsonClassMap Create() {
            return new BsonClassMap<EntityBase<Guid>>(mapInitializer => {
                mapInitializer.AutoMap();
                mapInitializer.MapIdMember(_ => _.ID).SetIdGenerator(GuidGenerator.Instance);
            });
        }

        #endregion Public Override Methods
    }
}