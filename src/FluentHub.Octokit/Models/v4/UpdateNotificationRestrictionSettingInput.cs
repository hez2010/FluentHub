namespace FluentHub.Octokit.Models.v4
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Autogenerated input type of UpdateNotificationRestrictionSetting
    /// </summary>
    public class UpdateNotificationRestrictionSettingInput
    {        /// <summary>
        /// The ID of the owner on which to set the restrict notifications setting.
        /// </summary>
        public ID OwnerId { get; set; }

        /// <summary>
        /// The value for the restrict notifications setting.
        /// </summary>
        public NotificationRestrictionSettingValue SettingValue { get; set; }

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; set; }
    }
}