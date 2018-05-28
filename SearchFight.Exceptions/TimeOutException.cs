using System;

namespace SearchFight.Exceptions
{
    public class TimeOutException:Exception
    {
        public override string Message
        {
            get
            {
                return "A time out has ocurred while performing a search. Please try again later.";
            }
        }
    }
}
