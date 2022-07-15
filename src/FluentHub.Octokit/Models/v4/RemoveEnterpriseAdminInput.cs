namespace FluentHub.Octokit.Models.v4
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Autogenerated input type of RemoveEnterpriseAdmin
    /// </summary>
    public class RemoveEnterpriseAdminInput
    {        /// <summary>
        /// The Enterprise ID from which to remove the administrator.
        /// </summary>
        public ID EnterpriseId { get; set; }

        /// <summary>
        /// The login of the user to remove as an administrator.
        /// </summary>
        public string Login { get; set; }

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; set; }
    }
}