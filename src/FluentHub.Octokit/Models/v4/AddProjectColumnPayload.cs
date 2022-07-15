namespace FluentHub.Octokit.Models.v4
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;

    /// <summary>
    /// Autogenerated return type of AddProjectColumn
    /// </summary>
    public class AddProjectColumnPayload
    {
        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; set; }

        /// <summary>
        /// The edge from the project's column connection.
        /// </summary>
        public ProjectColumnEdge ColumnEdge { get; set; }

        /// <summary>
        /// The project
        /// </summary>
        public Project Project { get; set; }
    }
}