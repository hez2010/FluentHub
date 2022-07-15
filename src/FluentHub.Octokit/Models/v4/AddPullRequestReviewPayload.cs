namespace FluentHub.Octokit.Models.v4
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;

    /// <summary>
    /// Autogenerated return type of AddPullRequestReview
    /// </summary>
    public class AddPullRequestReviewPayload
    {
        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; set; }

        /// <summary>
        /// The newly created pull request review.
        /// </summary>
        public PullRequestReview PullRequestReview { get; set; }

        /// <summary>
        /// The edge from the pull request's review connection.
        /// </summary>
        public PullRequestReviewEdge ReviewEdge { get; set; }
    }
}