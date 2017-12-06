using System;
using System.Runtime.Serialization;

namespace Nameless.Bookshelf {

    [Serializable]
    public class BookOwnerException : Exception {

        #region Public Constructors

        public BookOwnerException()
            : this("Você não é dono deste livro, portanto não pode editar suas características.") { }

        public BookOwnerException(string message)
            : base(message) { }

        public BookOwnerException(string message, Exception inner)
            : base(message, inner) { }

        #endregion Public Constructors

        #region Protected Constructors

        protected BookOwnerException(SerializationInfo info, StreamingContext context)
            : base(info, context) { }

        #endregion Protected Constructors
    }
}