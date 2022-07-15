namespace FluentHub.Octokit.Models.v4
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;

    /// <summary>
    /// The connection type for CreatedPullRequestReviewContribution.
    /// </summary>
    public class CreatedPullRequestReviewContributionConnection
    {
        /// <summary>
        /// A list of edges.
        /// </summary>
        public List<CreatedPullRequestReviewContributionEdge> Edges { get; set; }

        /// <summary>
        /// A list of nodes.
        /// </summary>
        public List<CreatedPullRequestReviewContribution> Nodes { get; set; }

        /// <summary>
        /// Information to aid in pagination.
        /// </summary>
        public PageInfo PageInfo { get; set; }

        /// <summary>
        /// Identifies the total count of items in the connection.
        /// </summary>
        public int TotalCount { get; set; }
    }
}