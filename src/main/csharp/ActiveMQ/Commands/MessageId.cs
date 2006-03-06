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
    //  Marshalling code for Open Wire Format for MessageId
    //
    //
    //  NOTE!: This file is autogenerated - do not modify!
    //         if you need to make a change, please see the Groovy scripts in the
    //         activemq-core module
    //
    public class MessageId : AbstractCommand
    {
        public const byte ID_MessageId = 110;
    			
        ProducerId producerId;
        long producerSequenceId;
        long brokerSequenceId;

		public override int GetHashCode() {
            int answer = 0;
            answer = (answer * 37) + HashCode(ProducerId);
            answer = (answer * 37) + HashCode(ProducerSequenceId);
            answer = (answer * 37) + HashCode(BrokerSequenceId);
            return answer;

		}
	

		public override bool Equals(object that) {
	    	if (that is MessageId) {
	    	    return Equals((MessageId) that);
			}
			return false;
    	}
    
		public virtual bool Equals(MessageId that) {
            if (! Equals(this.ProducerId, that.ProducerId)) return false;
            if (! Equals(this.ProducerSequenceId, that.ProducerSequenceId)) return false;
            if (! Equals(this.BrokerSequenceId, that.BrokerSequenceId)) return false;
            return true;

		}
	

		public override string ToString() {
            return GetType().Name + "["
                + " ProducerId=" + ProducerId
                + " ProducerSequenceId=" + ProducerSequenceId
                + " BrokerSequenceId=" + BrokerSequenceId
                + " ]";

		}
	


        public override byte GetDataStructureType() {
            return ID_MessageId;
        }


        // Properties

        public ProducerId ProducerId
        {
            get { return producerId; }
            set { this.producerId = value; }            
        }

        public long ProducerSequenceId
        {
            get { return producerSequenceId; }
            set { this.producerSequenceId = value; }            
        }

        public long BrokerSequenceId
        {
            get { return brokerSequenceId; }
            set { this.brokerSequenceId = value; }            
        }

    }
}
