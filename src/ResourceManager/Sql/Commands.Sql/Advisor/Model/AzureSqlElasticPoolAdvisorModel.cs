// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

namespace Microsoft.Azure.Commands.Sql.Advisor.Model
{
    /// <summary>
    /// Represents an Azure Sql Elastic Pool Advisor
    /// </summary>
    public class AzureSqlElasticPoolAdvisorModel : AzureSqlServerAdvisorModel
    {
        /// <summary>
        /// Gets or sets the name of the elastic pool
        /// </summary>
        public string ElasticPoolName { get; set; }

        /// <summary>
        /// Default Constructor
        /// </summary>
        public AzureSqlElasticPoolAdvisorModel()
        {
        }

        /// <summary>
        /// Construct AzureSqlElasticPoolAdvisorModel from Management.Sql.LegacySdk.Models.Advisor object
        /// </summary>
        /// <param name="resourceGroupName">Resource group</param>
        /// <param name="serverName">Server name</param>
        /// <param name="elasticPoolName">Elastic Pool name</param>
        /// <param name="advisor">Advisor object</param>
        public AzureSqlElasticPoolAdvisorModel(string resourceGroupName, string serverName, string elasticPoolName, Management.Sql.LegacySdk.Models.Advisor advisor)
        : base(resourceGroupName, serverName, advisor)
        {
            ElasticPoolName = elasticPoolName;
        }
    }
}
