﻿using System.Configuration;

namespace VstsRestApiSamples.Tests
{
    public static class InitHelper
    {
        public static IConfiguration GetConfiguration(IConfiguration configuration)
        {
            configuration.PersonalAccessToken = ConfigurationSettings.AppSettings["appsetting.pat"].ToString();
            configuration.Project = ConfigurationSettings.AppSettings["appsetting.project"].ToString();
            configuration.MoveToProject = ConfigurationSettings.AppSettings["appsetting.movetoproject"].ToString();
            configuration.Query = ConfigurationSettings.AppSettings["appsetting.query"].ToString();
            configuration.Identity = ConfigurationSettings.AppSettings["appsetting.identity"].ToString();
            configuration.UriString = ConfigurationSettings.AppSettings["appsetting.uri"].ToString();   
            configuration.WorkItemIds = ConfigurationSettings.AppSettings["appsetting.workitemids"].ToString();
            configuration.WorkItemId = ConfigurationSettings.AppSettings["appsetting.workitemid"].ToString();
            configuration.ProcessId = ConfigurationSettings.AppSettings["appsetting.processid"].ToString();
            configuration.PickListId = ConfigurationSettings.AppSettings["appsetting.picklistid"].ToString();
            configuration.QueryId = ConfigurationSettings.AppSettings["appsetting.queryid"].ToString();
            configuration.FilePath = ConfigurationSettings.AppSettings["appsetting.filepath"].ToString();
            configuration.GitRepositoryId = ConfigurationSettings.AppSettings["appsetting.git.repositoryid"].ToString();
            configuration.GitTargetVersionBranch = ConfigurationSettings.AppSettings["appsetting.git.targetVersionBranch"].ToString();
            configuration.GitBaseVersionBranch = ConfigurationSettings.AppSettings["appsetting.git.baseVersionBranch"].ToString();

            return configuration;
        }
    }
}
