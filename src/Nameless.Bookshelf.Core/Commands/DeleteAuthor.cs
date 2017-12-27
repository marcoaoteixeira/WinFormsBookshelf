using System;
using System.Threading;
using System.Threading.Tasks;
using Nameless.Bookshelf.Entities;
using Nameless.WinFormsApplication.CQRS.Commands;
using Nameless.WinFormsApplication.Persistence;

namespace Nameless.Bookshelf.Commands {

    public sealed class DeleteAuthorCommand : ICommand {

        #region Public Properties

        public Guid ID { get; set; }

        #endregion Public Properties
    }

    public sealed class DeleteAuthorCommandHandler : CommandHandlerBase<DeleteAuthorCommand> {

        #region Public Constructors

        public DeleteAuthorCommandHandler(IRepository repository)
            : base(repository) { }

        #endregion Public Constructors

        #region Public Override Methods

        public override Task HandleAsync(DeleteAuthorCommand command, CancellationToken token = default(CancellationToken)) => Task.Run(() => {
            Repository.Delete(new Author { ID = command.ID });
        }, token);

        #endregion Public Override Methods
    }
}