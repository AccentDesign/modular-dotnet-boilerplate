// --------------------------------------------------------------------------------------------------
// <copyright file="PersistenceSettings.cs" company="AccentDesign">
// </copyright>
// --------------------------------------------------------------------------------------------------

namespace Shared.Core.Settings
{
    public class PersistenceSettings
    {
        public bool UseMsSql { get; set; }

        public bool UsePostgres { get; set; }

        public PersistenceConnectionStrings ConnectionStrings { get; set; }

        public class PersistenceConnectionStrings
        {
            // ReSharper disable once InconsistentNaming
            public string MSSQL { get; set; }

            public string Postgres { get; set; }
        }
    }
}