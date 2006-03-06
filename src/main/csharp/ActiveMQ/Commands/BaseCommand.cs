//
// Marshalling code for Open Wire Format for BaseCommand
//
//
// NOTE!: This file is autogenerated - do not modify!
//        if you need to make a change, please see the Groovy scripts in the
//        activemq-openwire module
//

using ActiveMQ.Commands;
using System;



namespace ActiveMQ.Commands
{
	public abstract class BaseCommand : AbstractCommand
    {
        
        public override int GetHashCode()
        {
            return (CommandId * 37) + GetDataStructureType();
        }
        
        public override bool Equals(Object that)
        {
            if (that is BaseCommand)
            {
                BaseCommand thatCommand = (BaseCommand) that;
                return this.GetDataStructureType() == thatCommand.GetDataStructureType()
                    && this.CommandId == thatCommand.CommandId;
            }
            return false;
        }
        
        public override String ToString()
        {
            string answer = GetDataStructureTypeAsString(GetDataStructureType());
            if (answer.Length == 0)
            {
                answer = base.ToString();
            }
            return answer + ": id = " + CommandId;
        }
        
        
    }
}

