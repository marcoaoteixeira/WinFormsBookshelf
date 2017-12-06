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

    public sealed class ListBooksQuery : IQuery<BookDto[]> {

        #region Public Properties

        public string Title { get; set; }
        public string ISBN { get; set; }
        public string Publisher { get; set; }
        public string Authors { get; set; }
        public string Languages { get; set; }

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
            var books = Repository.Query<Book>();

            if (!string.IsNullOrWhiteSpace(query.Title)) {
                books = books.Where(_ => _.Title.IndexOf(query.Title, StringComparison.CurrentCultureIgnoreCase) >= 0);
            }
            if (!string.IsNullOrWhiteSpace(query.ISBN)) {
                books = books.Where(_ => _.ISBN.IndexOf(query.ISBN, StringComparison.CurrentCultureIgnoreCase) >= 0);
            }
            if (!string.IsNullOrWhiteSpace(query.Publisher)) {
                books = books.Where(_ => _.Publisher.IndexOf(query.ISBN, StringComparison.CurrentCultureIgnoreCase) >= 0);
            }
            if (!string.IsNullOrWhiteSpace(query.Authors)) {
                books = books.Where(_ => _.Authors != null && _.Authors.Any(author => author.IndexOf(query.Authors, StringComparison.CurrentCultureIgnoreCase) >= 0));
            }
            if (!string.IsNullOrWhiteSpace(query.Languages)) {
                books = books.Where(_ => _.Languages != null && _.Languages.Any(language => language.IndexOf(query.Languages, StringComparison.CurrentCultureIgnoreCase) >= 0));
            }

            var result = books.Select(Mapper.Map<BookDto>).ToArray();
            return result;
        }, token);

        #endregion Public Override Methods
    }
}