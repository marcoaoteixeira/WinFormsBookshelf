using System;
using System.Reflection;

namespace Nameless.Bookshelf {

    internal static class Internal {

        #region Private Static Read-Only Fields

        private static readonly Version CurrentAssemblyVersion = Assembly.GetExecutingAssembly().GetName().Version;

        #endregion Private Static Read-Only Fields

        #region Internal Static Read-Only Fields

        internal static readonly string SoftwareVersion = $"v{CurrentAssemblyVersion.Major}.{CurrentAssemblyVersion.Minor}.{CurrentAssemblyVersion.Revision}";

        #endregion Internal Static Read-Only Fields
    }
}