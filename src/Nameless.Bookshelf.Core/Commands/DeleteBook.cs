using System;
using System.Threading;
using System.Threading.Tasks;
using Nameless.Bookshelf.Entities;
using Nameless.WinFormsApplication;
using Nameless.WinFormsApplication.Auth;
using Nameless.WinFormsApplication.CQRS.Commands;
using Nameless.WinFormsApplication.Persistence;

namespace Nameless.Bookshelf.Commands {

    public sealed class DeleteBookCommand : ICommand {

        #region Public Properties

        public Guid ID { get; set; }

        #endregion Public Properties
    }

    public sealed class DeleteBookCommandHandler : CommandHandlerBase<DeleteBookCommand> {

        #region Private Read-Only Fields

        private readonly IAuthContext _authContext;

        #endregion Private Read-Only Fields

        #region Public Constructors

        public DeleteBookCommandHandler(IAuthContext authContext, IRepository repository)
            : base(repository) {
            Prevent.ParameterNull(authContext, nameof(authContext));

            _authContext = authContext;
        }

        #endregion Public Constructors

        #region Public Override Methods

        public override Task HandleAsync(DeleteBookCommand command, CancellationToken token = default(CancellationToken)) => Task.Run(() => {
            var currentBook = Repository.FindOne<Book>(command.ID);
            if (currentBook == null) { throw new BookNotFoundException(); }
            var currentOwner = currentBook.Owner;
            if (_authContext.CurrentUser.Username != currentOwner) { throw new BookOwnerException(); }
            Repository.Delete(currentBook);
        }, token);

        #endregion Public Override Methods
    }
}