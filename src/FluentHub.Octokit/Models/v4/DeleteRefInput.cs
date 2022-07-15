namespace FluentHub.Octokit.Models.v4
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Autogenerated input type of DeleteRef
    /// </summary>
    public class DeleteRefInput
    {        /// <summary>
        /// The Node ID of the Ref to be deleted.
        /// </summary>
        public ID RefId { get; set; }

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; set; }
    }
}