using System;
using System.Threading;
using System.Threading.Tasks;
using Nameless.Bookshelf.Entities;
using Nameless.WinFormsApplication;
using Nameless.WinFormsApplication.Auth;
using Nameless.WinFormsApplication.CQRS.Commands;
using Nameless.WinFormsApplication.Persistence;

namespace Nameless.Bookshelf.Commands {

    public sealed class SaveBookCommand : ICommand {

        #region Public Properties

        public Guid ID { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }
        public int Edition { get; set; }
        public int Year { get; set; }
        public string Publisher { get; set; }
        public string[] Authors { get; set; }
        public string[] Languages { get; set; }
        public string Note { get; set; }
        public bool Lent { get; set; }

        #endregion Public Properties
    }

    public sealed class SaveBookCommandHandler : CommandHandlerBase<SaveBookCommand> {

        #region Private Read-Only Fields

        private readonly IAuthContext _authContext;

        #endregion Private Read-Only Fields

        #region Public Constructors

        public SaveBookCommandHandler(IAuthContext authContext, IRepository repository)
            : base(repository) {
            Prevent.ParameterNull(authContext, nameof(authContext));

            _authContext = authContext;
        }

        #endregion Public Constructors

        #region Public Override Methods

        public override Task HandleAsync(SaveBookCommand command, CancellationToken token = default(CancellationToken)) => Task.Run(() => {
            var currentBook = Repository.FindOne<Book>(command.ID) ?? new Book();
            var currentOwner = currentBook.Owner;
            if (currentOwner != null && _authContext.CurrentUser.Username != currentOwner) { throw new BookOwnerException(); }

            currentBook.ID = currentBook.ID != Guid.Empty ? currentBook.ID : Guid.NewGuid();
            currentBook.Title = command.Title;
            currentBook.ISBN = command.ISBN;
            currentBook.Edition = command.Edition;
            currentBook.Year = command.Year;
            currentBook.Publisher = command.Publisher;
            currentBook.Authors = command.Authors;
            currentBook.Languages = command.Languages;
            currentBook.Note = command.Note;
            currentBook.Lent = command.Lent;
            currentBook.Owner = _authContext.CurrentUser.Username;

            Repository.Save(currentBook);
        }, token);

        #endregion Public Override Methods
    }
}