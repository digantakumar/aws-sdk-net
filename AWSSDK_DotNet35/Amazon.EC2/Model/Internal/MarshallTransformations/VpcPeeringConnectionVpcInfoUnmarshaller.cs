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
using System.Collections.Generic;

using Amazon.EC2.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
     /// <summary>
     ///   VpcPeeringConnectionVpcInfo Unmarshaller
     /// </summary>
    internal class VpcPeeringConnectionVpcInfoUnmarshaller : IUnmarshaller<VpcPeeringConnectionVpcInfo, XmlUnmarshallerContext>, IUnmarshaller<VpcPeeringConnectionVpcInfo, JsonUnmarshallerContext> 
    {
        public VpcPeeringConnectionVpcInfo Unmarshall(XmlUnmarshallerContext context) 
        {
            VpcPeeringConnectionVpcInfo vpcPeeringConnectionVpcInfo = new VpcPeeringConnectionVpcInfo();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 1;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("cidrBlock", targetDepth))
                    {
                        vpcPeeringConnectionVpcInfo.CidrBlock = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("ownerId", targetDepth))
                    {
                        vpcPeeringConnectionVpcInfo.OwnerId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("vpcId", targetDepth))
                    {
                        vpcPeeringConnectionVpcInfo.VpcId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return vpcPeeringConnectionVpcInfo;
                }
            }
                        


            return vpcPeeringConnectionVpcInfo;
        }

        public VpcPeeringConnectionVpcInfo Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static VpcPeeringConnectionVpcInfoUnmarshaller instance;

        public static VpcPeeringConnectionVpcInfoUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new VpcPeeringConnectionVpcInfoUnmarshaller();

            return instance;
        }
    }
}
    
