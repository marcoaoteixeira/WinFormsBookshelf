using System;
using System.Threading;
using System.Threading.Tasks;
using Nameless.Bookshelf.Entities;
using Nameless.WinFormsApplication.CQRS.Commands;
using Nameless.WinFormsApplication.Persistence;

namespace Nameless.Bookshelf.Commands {

    public sealed class SaveLanguageCommand : ICommand {

        #region Public Properties

        public Guid ID { get; set; }
        public string Description { get; set; }

        #endregion Public Properties
    }

    public sealed class SaveLanguageCommandHandler : CommandHandlerBase<SaveLanguageCommand> {

        #region Public Constructors

        public SaveLanguageCommandHandler(IRepository repository)
            : base(repository) { }

        #endregion Public Constructors

        #region Public Override Methods

        public override Task HandleAsync(SaveLanguageCommand command, CancellationToken token = default(CancellationToken)) => Task.Run(() => {
            var language = Repository.FindOne<Language>(command.ID) ?? new Language();

            language.ID = language.ID != Guid.Empty ? language.ID : Guid.NewGuid();
            language.Description = command.Description;

            Repository.Save(language);
        }, token);

        #endregion Public Override Methods
    }
}