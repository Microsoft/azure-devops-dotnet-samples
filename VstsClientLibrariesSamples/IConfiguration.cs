﻿using System;
using Microsoft.VisualStudio.Services.Common;

namespace VstsClientLibrariesSamples
{
    public interface IConfiguration
    {        
        string PersonalAccessToken { get; set; }
        string Project { get; set; }
        string UriString { get; set; }        
        string Query { get; set; }
        string Identity { get; set; }
        string WorkItemIds { get; set; }
        Int32 WorkItemId { get; set; }
        string FilePath { get; set; }
        string GitRepositoryId { get; set; }
        string GitTargetVersionBranch { get; set; }
        string GitBaseVersionBranch { get; set; }
    }
}