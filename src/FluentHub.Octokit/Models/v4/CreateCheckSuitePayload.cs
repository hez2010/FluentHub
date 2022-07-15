namespace FluentHub.Octokit.Models.v4
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;

    /// <summary>
    /// Autogenerated return type of CreateCheckSuite
    /// </summary>
    public class CreateCheckSuitePayload
    {
        /// <summary>
        /// The newly created check suite.
        /// </summary>
        public CheckSuite CheckSuite { get; set; }

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; set; }
    }
}