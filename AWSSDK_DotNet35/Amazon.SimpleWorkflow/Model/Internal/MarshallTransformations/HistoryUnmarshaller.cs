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
    using Amazon.SimpleWorkflow.Model;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.SimpleWorkflow.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// HistoryUnmarshaller
      /// </summary>
      internal class HistoryUnmarshaller : IUnmarshaller<History, XmlUnmarshallerContext>, IUnmarshaller<History, JsonUnmarshallerContext>
      {
        History IUnmarshaller<History, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public History Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) return null;
            History history = new History();
        
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
              
              if (context.TestExpression("events", targetDepth))
              {
                
                var unmarshaller = new ListUnmarshaller<HistoryEvent,HistoryEventUnmarshaller>(
                    HistoryEventUnmarshaller.GetInstance());                  
                history.Events = unmarshaller.Unmarshall(context);
                
                continue;
              }
  
              if (context.TestExpression("nextPageToken", targetDepth))
              {
                history.NextPageToken = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
            }
          
            return history;
        }

        private static HistoryUnmarshaller instance;
        public static HistoryUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new HistoryUnmarshaller();
            return instance;
        }
    }
}
  
