﻿using Microsoft.TeamFoundation.WorkItemTracking.WebApi;
using Microsoft.TeamFoundation.WorkItemTracking.WebApi.Models;
using Microsoft.VisualStudio.Services.Client;
using Microsoft.VisualStudio.Services.Common;
using Microsoft.VisualStudio.Services.Graph.Client;
using Microsoft.VisualStudio.Services.WebApi;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GraphQuickStarts.Samples
{
    public class EnumerateUsers
    {
        readonly string _uri;
        readonly string _personalAccessToken;

        /// <summary>
        /// Constructor. Manaully set values to match your account.
        /// </summary>
        public EnumerateUsers()
        {
            _uri = "https://accountname.vssps.visualstudio.com";
            _personalAccessToken = "personal access token";
        }

        public EnumerateUsers(string url, string pat)
        {
            _uri = url;
            _personalAccessToken = pat;
        }

        public List<GraphUser> RunEnumerateUsersUsingClientLib()
        {
            Uri uri = new Uri(_uri);
            VssBasicCredential credentials = new VssBasicCredential("", _personalAccessToken);

            using (GraphHttpClient graphClient = new GraphHttpClient(uri, credentials))
            {
                // Get the first page of Users
                PagedGraphUsers users = graphClient.GetUsersAsync().Result;
                if (users.GraphUsers.Count() > 0)
                {
                    List<GraphUser> graphUsers = new List<GraphUser>(users.GraphUsers);

                    // If there are more than a page's worth of users, continue retrieving users from the server a page at a time
                    string continuationToken = users.ContinuationToken.FirstOrDefault();
                    while (continuationToken != null)
                    {
                        users = graphClient.GetUsersAsync(continuationToken: continuationToken).Result;
                        graphUsers.AddRange(users.GraphUsers);

                        if (users.ContinuationToken != null) { 
                            continuationToken = users.ContinuationToken.FirstOrDefault();
                        }
                        else
                        {
                            break;
                        }
                    }

                    return graphUsers;
                }
            }

            return null;
        }
    }
}
