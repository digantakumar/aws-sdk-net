/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Route53.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteHealthCheck operation.
    /// <para>This action deletes a health check. To delete a health check, send a <c>DELETE</c> request to the <c>2013-04-01/healthcheck/health
    /// check ID </c> resource.</para> <para><b>IMPORTANT:</b> You can delete a health check only if there are no resource record sets associated
    /// with this health check. If resource record sets are associated with this health check, you must disassociate them before you can delete your
    /// health check. If you try to delete a health check that is associated with resource record sets, Route 53 will deny your request with a
    /// HealthCheckInUse error. For information about disassociating the records from your health check, see ChangeResourceRecordSets.</para>
    /// </summary>
    public partial class DeleteHealthCheckRequest : AmazonRoute53Request
    {
        private string healthCheckId;


        /// <summary>
        /// The ID of the health check to delete.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 64</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string HealthCheckId
        {
            get { return this.healthCheckId; }
            set { this.healthCheckId = value; }
        }

        // Check to see if HealthCheckId property is set
        internal bool IsSetHealthCheckId()
        {
            return this.healthCheckId != null;
        }

    }
}
    
