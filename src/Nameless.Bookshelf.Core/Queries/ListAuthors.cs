using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Nameless.Bookshelf.Dto;
using Nameless.Bookshelf.Entities;
using Nameless.WinFormsApplication;
using Nameless.WinFormsApplication.Auth;
using Nameless.WinFormsApplication.CQRS.Queries;
using Nameless.WinFormsApplication.ObjectMapper;
using Nameless.WinFormsApplication.Persistence;

namespace Nameless.Bookshelf.Queries {

    public sealed class ListAuthorsQuery : IQuery<AuthorDto[]> {

        #region Public Properties

        public string Name { get; set; }

        #endregion Public Properties
    }

    public sealed class ListAuthorsQueryHandler : QueryHandlerBase<AuthorDto[], ListAuthorsQuery> {

        #region Private Read-Only Fields

        private readonly IAuthContext _authContext;

        #endregion Private Read-Only Fields

        #region Public Constructors

        public ListAuthorsQueryHandler(IAuthContext authContext, IMapper mapper, IRepository repository)
            : base(mapper, repository) {
            Prevent.ParameterNull(authContext, nameof(authContext));

            _authContext = authContext;
        }

        #endregion Public Constructors

        #region Public Override Methods

        public override Task<AuthorDto[]> HandleAsync(ListAuthorsQuery query, CancellationToken token = default(CancellationToken)) => Task.Run(() => {
            var authors = Repository.Query<Author>();

            if (!string.IsNullOrWhiteSpace(query.Name)) {
                authors = authors.Where(_ => _.Name.IndexOf(query.Name, StringComparison.CurrentCultureIgnoreCase) >= 0);
            }
            var result = authors
                .Select(Mapper.Map<AuthorDto>)
                .OrderBy(_ => _.Name)
                .ToArray();
            return result;
        }, token);

        #endregion Public Override Methods
    }
}