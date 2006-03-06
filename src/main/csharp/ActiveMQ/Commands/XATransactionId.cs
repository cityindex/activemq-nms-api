/*
* Copyright 2006 The Apache Software Foundation or its licensors, as
* applicable.
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
*     http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*/

using System;
using System.Collections;

using ActiveMQ.OpenWire;
using ActiveMQ.Commands;

namespace ActiveMQ.Commands
{
    //
    //  Marshalling code for Open Wire Format for XATransactionId
    //
    //
    //  NOTE!: This file is autogenerated - do not modify!
    //         if you need to make a change, please see the Groovy scripts in the
    //         activemq-core module
    //
    public class XATransactionId : TransactionId
    {
        public const byte ID_XATransactionId = 112;
    			
        int formatId;
        byte[] globalTransactionId;
        byte[] branchQualifier;

		public override int GetHashCode() {
            int answer = 0;
            answer = (answer * 37) + HashCode(FormatId);
            answer = (answer * 37) + HashCode(GlobalTransactionId);
            answer = (answer * 37) + HashCode(BranchQualifier);
            return answer;

		}
	

		public override bool Equals(object that) {
	    	if (that is XATransactionId) {
	    	    return Equals((XATransactionId) that);
			}
			return false;
    	}
    
		public virtual bool Equals(XATransactionId that) {
            if (! Equals(this.FormatId, that.FormatId)) return false;
            if (! Equals(this.GlobalTransactionId, that.GlobalTransactionId)) return false;
            if (! Equals(this.BranchQualifier, that.BranchQualifier)) return false;
            return true;

		}
	

		public override string ToString() {
            return GetType().Name + "["
                + " FormatId=" + FormatId
                + " GlobalTransactionId=" + GlobalTransactionId
                + " BranchQualifier=" + BranchQualifier
                + " ]";

		}
	


        public override byte GetDataStructureType() {
            return ID_XATransactionId;
        }


        // Properties

        public int FormatId
        {
            get { return formatId; }
            set { this.formatId = value; }            
        }

        public byte[] GlobalTransactionId
        {
            get { return globalTransactionId; }
            set { this.globalTransactionId = value; }            
        }

        public byte[] BranchQualifier
        {
            get { return branchQualifier; }
            set { this.branchQualifier = value; }            
        }

    }
}
