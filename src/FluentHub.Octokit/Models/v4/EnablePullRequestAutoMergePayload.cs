namespace FluentHub.Octokit.Models.v4
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;

    /// <summary>
    /// Autogenerated return type of EnablePullRequestAutoMerge
    /// </summary>
    public class EnablePullRequestAutoMergePayload
    {
        /// <summary>
        /// Identifies the actor who performed the event.
        /// </summary>
        public IActor Actor { get; set; }

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; set; }

        /// <summary>
        /// The pull request auto-merge was enabled on.
        /// </summary>
        public PullRequest PullRequest { get; set; }
    }
}