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

    public sealed class ListPublishersQuery : IQuery<string[]> {

        #region Public Properties

        public string Name { get; set; }

        #endregion Public Properties
    }

    public sealed class ListPublishersQueryHandler : QueryHandlerBase<string[], ListPublishersQuery> {

        #region Public Constructors

        public ListPublishersQueryHandler(IMapper mapper, IRepository repository)
            : base(mapper, repository) { }

        #endregion Public Constructors

        #region Public Override Methods

        public override Task<string[]> HandleAsync(ListPublishersQuery query, CancellationToken token = default(CancellationToken)) => Task.Run(() => {
            var values = Repository.Query<Book>()
                .Select(_ => _.Publisher)
                .Distinct()
                .Where(_ => _ != null && _.ToLowerInvariant().Contains((query.Name ?? string.Empty).ToLowerInvariant()))
                .OrderBy(_ => _)
                .ToArray();

            return values;
        }, token);

        #endregion Public Override Methods
    }
}