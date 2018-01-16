using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Nameless.Bookshelf.Entities;
using Nameless.WinFormsApplication;
using Nameless.WinFormsApplication.CQRS.Queries;
using Nameless.WinFormsApplication.ObjectMapper;
using Nameless.WinFormsApplication.Persistence;

namespace Nameless.Bookshelf.Queries {

    public sealed class ListLanguagesQuery : IQuery<string[]> {

        #region Public Properties

        public string Description { get; set; }

        #endregion Public Properties
    }

    public sealed class ListLanguagesQueryHandler : QueryHandlerBase<string[], ListLanguagesQuery> {

        #region Public Constructors

        public ListLanguagesQueryHandler(IMapper mapper, IRepository repository)
            : base(mapper, repository) { }

        #endregion Public Constructors

        #region Public Override Methods

        public override Task<string[]> HandleAsync(ListLanguagesQuery query, CancellationToken token = default(CancellationToken)) => Task.Run(() => {
            var values = Repository.Query<Book>()
                .SelectMany(_ => _.Languages)
                .Distinct()
                .Where(_ => _ != null && _.ToLowerInvariant().Contains((query.Description ?? string.Empty).ToLowerInvariant()))
                .OrderBy(_ => _)
                .ToArray();

            return values;
        }, token);

        #endregion Public Override Methods
    }
}