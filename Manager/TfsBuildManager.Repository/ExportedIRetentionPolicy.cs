﻿//-----------------------------------------------------------------------
// <copyright file="ExportedIRetentionPolicy.cs">(c) https://github.com/tfsbuildextensions/BuildManager. This source is subject to the Microsoft Permissive License. See http://www.microsoft.com/resources/sharedsource/licensingbasics/sharedsourcelicenses.mspx. All other rights reserved.</copyright>
//-----------------------------------------------------------------------
namespace TfsBuildManager.Repository
{
    using Microsoft.TeamFoundation.Build.Client;

    public class ExportedIRetentionPolicy : IRetentionPolicy
    {
        public IBuildDefinition BuildDefinition { get; set; }

        public BuildReason BuildReason { get; set; }

        public BuildStatus BuildStatus { get; set; }

        public int NumberToKeep { get; set; }

        public DeleteOptions DeleteOptions { get; set; }
    }
}
