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
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.OpsWorks.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.OpsWorks.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateInstance Request Marshaller
    /// </summary>       
    public class CreateInstanceRequestMarshaller : IMarshaller<IRequest, CreateInstanceRequest> 
    {
        public IRequest Marshall(CreateInstanceRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.OpsWorks");
            string target = "OpsWorks_20130218.CreateInstance";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.HttpMethod = "POST";

            string uriResourcePath = "/";
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                if(publicRequest.IsSetAmiId())
                {
                    writer.WritePropertyName("AmiId");
                    writer.Write(publicRequest.AmiId);
                }

                if(publicRequest.IsSetArchitecture())
                {
                    writer.WritePropertyName("Architecture");
                    writer.Write(publicRequest.Architecture);
                }

                if(publicRequest.IsSetAutoScalingType())
                {
                    writer.WritePropertyName("AutoScalingType");
                    writer.Write(publicRequest.AutoScalingType);
                }

                if(publicRequest.IsSetAvailabilityZone())
                {
                    writer.WritePropertyName("AvailabilityZone");
                    writer.Write(publicRequest.AvailabilityZone);
                }

                if(publicRequest.IsSetEbsOptimized())
                {
                    writer.WritePropertyName("EbsOptimized");
                    writer.Write(publicRequest.EbsOptimized);
                }

                if(publicRequest.IsSetHostname())
                {
                    writer.WritePropertyName("Hostname");
                    writer.Write(publicRequest.Hostname);
                }

                if(publicRequest.IsSetInstallUpdatesOnBoot())
                {
                    writer.WritePropertyName("InstallUpdatesOnBoot");
                    writer.Write(publicRequest.InstallUpdatesOnBoot);
                }

                if(publicRequest.IsSetInstanceType())
                {
                    writer.WritePropertyName("InstanceType");
                    writer.Write(publicRequest.InstanceType);
                }

                if(publicRequest.IsSetLayerIds())
                {
                    writer.WritePropertyName("LayerIds");
                    writer.WriteArrayStart();
                    foreach(var publicRequestLayerIdsListValue in publicRequest.LayerIds)
                    {
                        writer.Write(publicRequestLayerIdsListValue);
                    }
                    writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetOs())
                {
                    writer.WritePropertyName("Os");
                    writer.Write(publicRequest.Os);
                }

                if(publicRequest.IsSetRootDeviceType())
                {
                    writer.WritePropertyName("RootDeviceType");
                    writer.Write(publicRequest.RootDeviceType);
                }

                if(publicRequest.IsSetSshKeyName())
                {
                    writer.WritePropertyName("SshKeyName");
                    writer.Write(publicRequest.SshKeyName);
                }

                if(publicRequest.IsSetStackId())
                {
                    writer.WritePropertyName("StackId");
                    writer.Write(publicRequest.StackId);
                }

                if(publicRequest.IsSetSubnetId())
                {
                    writer.WritePropertyName("SubnetId");
                    writer.Write(publicRequest.SubnetId);
                }

                if(publicRequest.IsSetVirtualizationType())
                {
                    writer.WritePropertyName("VirtualizationType");
                    writer.Write(publicRequest.VirtualizationType);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }


    }
}