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

    public sealed class ListLanguagesQuery : IQuery<LanguageDto[]> {

        #region Public Properties

        public string Description { get; set; }

        #endregion Public Properties
    }

    public sealed class ListLanguagesQueryHandler : QueryHandlerBase<LanguageDto[], ListLanguagesQuery> {

        #region Private Read-Only Fields

        private readonly IAuthContext _authContext;

        #endregion Private Read-Only Fields

        #region Public Constructors

        public ListLanguagesQueryHandler(IAuthContext authContext, IMapper mapper, IRepository repository)
            : base(mapper, repository) {
            Prevent.ParameterNull(authContext, nameof(authContext));

            _authContext = authContext;
        }

        #endregion Public Constructors

        #region Public Override Methods

        public override Task<LanguageDto[]> HandleAsync(ListLanguagesQuery query, CancellationToken token = default(CancellationToken)) => Task.Run(() => {
            var authors = Repository.Query<Language>();

            if (!string.IsNullOrWhiteSpace(query.Description)) {
                authors = authors.Where(_ => _.Description.IndexOf(query.Description, StringComparison.CurrentCultureIgnoreCase) >= 0);
            }
            var result = authors
                .Select(Mapper.Map<LanguageDto>)
                .OrderBy(_ => _.Description)
                .ToArray();
            return result;
        }, token);

        #endregion Public Override Methods
    }
}