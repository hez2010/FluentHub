namespace FluentHub.Octokit.Models.v4
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Autogenerated input type of MoveProjectColumn
    /// </summary>
    public class MoveProjectColumnInput
    {        /// <summary>
        /// The id of the column to move.
        /// </summary>
        public ID ColumnId { get; set; }

        /// <summary>
        /// Place the new column after the column with this id. Pass null to place it at the front.
        /// </summary>
        public ID? AfterColumnId { get; set; }

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; set; }
    }
}