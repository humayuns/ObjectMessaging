using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectMessaging
{
    class ObjectFactory
    {
        public static ISenderReceiver GetHelloBuiler()
        {
            return new HelloBuilder();
        }

        public static ISenderReceiver GetHiBuilder()
        {
            return new HiBuilder();
        }
    }
}
