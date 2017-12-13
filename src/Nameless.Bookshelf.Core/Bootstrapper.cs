using System.IO;
using Nameless.WinFormsApplication;

namespace Nameless.Bookshelf {

    /// <summary>
    /// Singleton Pattern implementation for Bootstrap. (see: https://en.wikipedia.org/wiki/Singleton_pattern)
    /// </summary>
    public sealed class Bootstrapper {

        #region Private Static Read-Only Fields

        private static readonly Bootstrapper _instance = new Bootstrapper();

        #endregion Private Static Read-Only Fields

        #region Public Static Properties

        /// <summary>
        /// Gets the unique instance of BootStrap.
        /// </summary>
        public static Bootstrapper Instance => _instance;

        #endregion Public Static Properties

        #region Static Constructors

        // Explicit static constructor to tell the C# compiler
        // not to mark type as beforefieldinit
        static Bootstrapper() {
        }

        #endregion Static Constructors

        #region Private Constructors

        private Bootstrapper() {
        }

        #endregion Private Constructors

        #region Public Methods

        public void Run() {
            if (string.IsNullOrWhiteSpace(Common.DataDirectoryPath)) {
                Common.DataDirectoryPath = Path.Combine(typeof(Bootstrapper).Assembly.GetDirectoryPath(), "App_Data");
                if (!Directory.Exists(Common.DataDirectoryPath)) {
                    Directory.CreateDirectory(Common.DataDirectoryPath);
                }
            }
        }

        #endregion Public Methods
    }
}