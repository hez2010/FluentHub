namespace FluentHub.Octokit.Models.v4
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Autogenerated input type of RerequestCheckSuite
    /// </summary>
    public class RerequestCheckSuiteInput
    {
        /// <summary>
        /// The Node ID of the repository.
        /// </summary>
        public ID RepositoryId { get; set; }

        /// <summary>
        /// The Node ID of the check suite.
        /// </summary>
        public ID CheckSuiteId { get; set; }

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; set; }
    }
}