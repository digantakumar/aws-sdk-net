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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the CreateNetworkAclEntry operation.
    /// <para>Creates an entry (a rule) in a network ACL with the specified rule number. Each network ACL has a set of numbered ingress rules and a
    /// separate set of numbered egress rules. When determining whether a packet should be allowed in or out of a subnet associated with the ACL, we
    /// process the entries in the ACL according to the rule numbers, in ascending order. Each network ACL has a set of ingress rules and a separate
    /// set of egress rules.</para> <para>We recommend that you leave room between the rule numbers (for example, 100, 110, 120, ...), and not
    /// number them one right after the other (for example, 101, 102, 103, ...). This makes it easier to add a rule between existing ones without
    /// having to renumber the rules.</para> <para>After you add an entry, you can't modify it; you must either replace it, or create an entry and
    /// delete the old one.</para> <para>For more information about network ACLs, see <a
    /// href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_ACLs.html" >Network ACLs</a> in the <i>Amazon Virtual Private Cloud User
    /// Guide</i> .</para>
    /// </summary>
    public partial class CreateNetworkAclEntryRequest : AmazonEC2Request
    {
        private string networkAclId;
        private int? ruleNumber;
        private string protocol;
        private RuleAction ruleAction;
        private bool? egress;
        private string cidrBlock;
        private IcmpTypeCode icmpTypeCode;
        private PortRange portRange;


        /// <summary>
        /// The ID of the ACL.
        ///  
        /// </summary>
        public string NetworkAclId
        {
            get { return this.networkAclId; }
            set { this.networkAclId = value; }
        }

        // Check to see if NetworkAclId property is set
        internal bool IsSetNetworkAclId()
        {
            return this.networkAclId != null;
        }

        /// <summary>
        /// The rule number for the entry (for example, 100). ACL entries are processed in ascending order by rule number. Constraints: Positive integer
        /// from 1 to 32766
        ///  
        /// </summary>
        public int RuleNumber
        {
            get { return this.ruleNumber ?? default(int); }
            set { this.ruleNumber = value; }
        }

        // Check to see if RuleNumber property is set
        internal bool IsSetRuleNumber()
        {
            return this.ruleNumber.HasValue;
        }

        /// <summary>
        /// The protocol. A value of -1 means all protocols.
        ///  
        /// </summary>
        public string Protocol
        {
            get { return this.protocol; }
            set { this.protocol = value; }
        }

        // Check to see if Protocol property is set
        internal bool IsSetProtocol()
        {
            return this.protocol != null;
        }

        /// <summary>
        /// Indicates whether to allow or deny the traffic that matches the rule.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>allow, deny</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public RuleAction RuleAction
        {
            get { return this.ruleAction; }
            set { this.ruleAction = value; }
        }

        // Check to see if RuleAction property is set
        internal bool IsSetRuleAction()
        {
            return this.ruleAction != null;
        }

        /// <summary>
        /// Indicates whether this is an egress rule (rule is applied to traffic leaving the subnet).
        ///  
        /// </summary>
        public bool Egress
        {
            get { return this.egress ?? default(bool); }
            set { this.egress = value; }
        }

        // Check to see if Egress property is set
        internal bool IsSetEgress()
        {
            return this.egress.HasValue;
        }

        /// <summary>
        /// The network range to allow or deny, in CIDR notation.
        ///  
        /// </summary>
        public string CidrBlock
        {
            get { return this.cidrBlock; }
            set { this.cidrBlock = value; }
        }

        // Check to see if CidrBlock property is set
        internal bool IsSetCidrBlock()
        {
            return this.cidrBlock != null;
        }

        /// <summary>
        /// ICMP protocol: The ICMP type and code.
        ///  
        /// </summary>
        public IcmpTypeCode IcmpTypeCode
        {
            get { return this.icmpTypeCode; }
            set { this.icmpTypeCode = value; }
        }

        // Check to see if IcmpTypeCode property is set
        internal bool IsSetIcmpTypeCode()
        {
            return this.icmpTypeCode != null;
        }

        /// <summary>
        /// TCP or UDP protocols: The range of ports the rule applies to.
        ///  
        /// </summary>
        public PortRange PortRange
        {
            get { return this.portRange; }
            set { this.portRange = value; }
        }

        // Check to see if PortRange property is set
        internal bool IsSetPortRange()
        {
            return this.portRange != null;
        }

    }
}
    
