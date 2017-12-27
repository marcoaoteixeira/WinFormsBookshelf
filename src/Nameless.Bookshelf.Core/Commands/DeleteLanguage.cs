using System;
using System.Threading;
using System.Threading.Tasks;
using Nameless.Bookshelf.Entities;
using Nameless.WinFormsApplication.CQRS.Commands;
using Nameless.WinFormsApplication.Persistence;

namespace Nameless.Bookshelf.Commands {

    public sealed class DeleteLanguageCommand : ICommand {

        #region Public Properties

        public Guid ID { get; set; }

        #endregion Public Properties
    }

    public sealed class DeleteLanguageCommandHandler : CommandHandlerBase<DeleteLanguageCommand> {

        #region Public Constructors

        public DeleteLanguageCommandHandler(IRepository repository)
            : base(repository) { }

        #endregion Public Constructors

        #region Public Override Methods

        public override Task HandleAsync(DeleteLanguageCommand command, CancellationToken token = default(CancellationToken)) => Task.Run(() => {
            Repository.Delete(new Language { ID = command.ID });
        }, token);

        #endregion Public Override Methods
    }
}