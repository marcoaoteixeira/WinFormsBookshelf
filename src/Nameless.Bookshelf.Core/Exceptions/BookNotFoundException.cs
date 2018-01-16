using Nameless.Bookshelf.Entities;
using Nameless.WinFormsApplication;

namespace Nameless.Bookshelf {

    public sealed class BookNotFoundException : EntityNotFoundException<Book> {
    }
}