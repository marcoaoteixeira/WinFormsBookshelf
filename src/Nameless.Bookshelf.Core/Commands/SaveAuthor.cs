using System;
using System.Threading;
using System.Threading.Tasks;
using Nameless.Bookshelf.Entities;
using Nameless.WinFormsApplication.CQRS.Commands;
using Nameless.WinFormsApplication.Persistence;

namespace Nameless.Bookshelf.Commands {

    public sealed class SaveAuthorCommand : ICommand {

        #region Public Properties

        public Guid ID { get; set; }
        public string Name { get; set; }

        #endregion Public Properties
    }

    public sealed class SaveAuthorCommandHandler : CommandHandlerBase<SaveAuthorCommand> {

        #region Public Constructors

        public SaveAuthorCommandHandler(IRepository repository)
            : base(repository) { }

        #endregion Public Constructors

        #region Public Override Methods

        public override Task HandleAsync(SaveAuthorCommand command, CancellationToken token = default(CancellationToken)) => Task.Run(() => {
            var author = Repository.FindOne<Author>(command.ID) ?? new Author();

            author.ID = author.ID != Guid.Empty ? author.ID : Guid.NewGuid();
            author.Name = command.Name;

            Repository.Save(author);
        }, token);

        #endregion Public Override Methods
    }
}