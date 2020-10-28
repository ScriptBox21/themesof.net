﻿using System.Collections.Generic;

namespace DotNetEpicsWeb.Data
{
    public static class DotNetEpicsConstants
    {
        public static string ApplicationName => "dotnet-epics";

        public const string GitHubAvatarUrl = "avatar_url";
        public const string TokenClaim = "acess_token";
        public const string ProductTeamOrg = "dotnet";
        public const string ProductTeamSlug = "npt";
        public const string ProductTeamRole = "product-team";

        public const string LabelTheme = "Theme";
        public const string LabelEpic = "Epic";
        public const string LabelUserStory = "User Story";
        public const string LabelIssue = "Issue";

        public static IReadOnlyList<string> Labels => new[]
        {
            LabelTheme,
            LabelEpic,
            LabelUserStory
        };
    }
}
