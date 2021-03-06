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
    using System.IO;
    using ThirdParty.Json.LitJson;
    using Amazon.AWSSupport.Model;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.AWSSupport.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// TrustedAdvisorCheckRefreshStatusUnmarshaller
      /// </summary>
      internal class TrustedAdvisorCheckRefreshStatusUnmarshaller : IUnmarshaller<TrustedAdvisorCheckRefreshStatus, XmlUnmarshallerContext>, IUnmarshaller<TrustedAdvisorCheckRefreshStatus, JsonUnmarshallerContext>
      {
        TrustedAdvisorCheckRefreshStatus IUnmarshaller<TrustedAdvisorCheckRefreshStatus, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public TrustedAdvisorCheckRefreshStatus Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) return null;
            TrustedAdvisorCheckRefreshStatus trustedAdvisorCheckRefreshStatus = new TrustedAdvisorCheckRefreshStatus();
        
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
              
              if (context.TestExpression("checkId", targetDepth))
              {
                trustedAdvisorCheckRefreshStatus.CheckId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("status", targetDepth))
              {
                trustedAdvisorCheckRefreshStatus.Status = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("millisUntilNextRefreshable", targetDepth))
              {
                trustedAdvisorCheckRefreshStatus.MillisUntilNextRefreshable = LongUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
            }
          
            return trustedAdvisorCheckRefreshStatus;
        }

        private static TrustedAdvisorCheckRefreshStatusUnmarshaller instance;
        public static TrustedAdvisorCheckRefreshStatusUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new TrustedAdvisorCheckRefreshStatusUnmarshaller();
            return instance;
        }
    }
}
  
