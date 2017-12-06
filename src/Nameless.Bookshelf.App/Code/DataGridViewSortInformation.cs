using System.Windows.Forms;
using Nameless.WinFormsApplication;

namespace Nameless.Bookshelf {

    public sealed class DataGridViewSortInformation {

        #region Public Properties

        public string ColumnName { get; set; }
        public SortOrder Order { get; set; }

        #endregion Public Properties

        #region Public  Constructors

        public DataGridViewSortInformation(string columnName, SortOrder order = SortOrder.Ascending) {
            Prevent.ParameterNullOrWhiteSpace(columnName, nameof(columnName));

            ColumnName = columnName;
            Order = order;
        }

        #endregion Public  Constructors

        #region Public Static Methods

        public static DataGridViewSortInformation Create(string columnName, SortOrder order = SortOrder.Ascending) {
            return new DataGridViewSortInformation(columnName, order);
        }

        #endregion Public Static Methods
    }
}