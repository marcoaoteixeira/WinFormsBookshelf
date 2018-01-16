using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Nameless.Bookshelf.Dto;
using Nameless.Bookshelf.Entities;
using Nameless.WinFormsApplication;
using Nameless.WinFormsApplication.Auth;
using Nameless.WinFormsApplication.Auth.Entities;
using Nameless.WinFormsApplication.CQRS.Queries;
using Nameless.WinFormsApplication.ObjectMapper;
using Nameless.WinFormsApplication.Persistence;

namespace Nameless.Bookshelf.Queries {

    public sealed class ListBooksQuery : IQuery<BookDto[]> {

        #region Public Properties

        public string Title { get; set; }
        public string ISBN { get; set; }
        public string Publisher { get; set; }
        public string Author { get; set; }
        public string Language { get; set; }

        #endregion Public Properties
    }

    public sealed class ListBooksQueryHandler : QueryHandlerBase<BookDto[], ListBooksQuery> {

        #region Private Read-Only Fields

        private readonly IAuthContext _authContext;

        #endregion Private Read-Only Fields

        #region Public Constructors

        public ListBooksQueryHandler(IAuthContext authContext, IMapper mapper, IRepository repository)
            : base(mapper, repository) {
            Prevent.ParameterNull(authContext, nameof(authContext));

            _authContext = authContext;
        }

        #endregion Public Constructors

        #region Public Override Methods

        public override Task<BookDto[]> HandleAsync(ListBooksQuery query, CancellationToken token = default(CancellationToken)) => Task.Run(() => {
            var books = Repository
                .Query<Book>()
                .Where(_ =>
                    (_.Title != null && _.Title.ToLowerInvariant().Contains((query.Title ?? string.Empty).ToLowerInvariant())) &&
                    (_.ISBN != null && _.ISBN.ToLowerInvariant().Contains((query.ISBN ?? string.Empty).ToLowerInvariant())) &&
                    (_.Publisher != null && _.Publisher.ToLowerInvariant().Contains((query.Publisher ?? string.Empty).ToLowerInvariant())) &&
                    (_.Authors != null && _.Authors.Any(author => author.ToLowerInvariant().Contains((query.Author ?? string.Empty).ToLowerInvariant()))) &&
                    (_.Languages != null && _.Languages.Any(language => language.ToLowerInvariant().Contains((query.Language ?? string.Empty).ToLowerInvariant())))
                )
                .OrderBy(_ => _.Title);

            var users = Repository
                .Query<User>()
                .ToDictionary(_ => _.Username, _ => _.DisplayName);

            var result = books.Select(Mapper.Map<BookDto>).ToArray();

            result.Each(_ => _.Owner.Name = users[_.Owner.Identifier]);

            return result;
        }, token);

        #endregion Public Override Methods
    }
}