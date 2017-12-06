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
        public string Year { get; set; }
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
            var book = Repository.FindOne<Book>(command.ID) ?? new Book();
            var currentOwner = book.Owner;
            if (_authContext.CurrentUser.Username != currentOwner) {
                throw new BookOwnerException();
            }

            book.ID = book.ID != Guid.Empty ? book.ID : Guid.NewGuid();
            book.Title = command.Title;
            book.ISBN = command.ISBN;
            book.Edition = command.Edition;
            book.Year = command.Year;
            book.Publisher = command.Publisher;
            book.Authors = command.Authors;
            book.Languages = command.Languages;
            book.Note = command.Note;
            book.Lent = command.Lent;
            book.Owner = _authContext.CurrentUser.Username;

            Repository.Save(book);
        }, token);

        #endregion Public Override Methods
    }
}