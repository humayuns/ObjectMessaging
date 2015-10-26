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
        public enum BuilderType
        {
            Hello,
            Hi
            
        }
        public static ISenderReceiver GetBuilder(BuilderType type)
        {
            ISenderReceiver people = null;
            switch (type)
            {
                case BuilderType.Hello:
                    people = new HelloBuilder();
                    break;
                case BuilderType.Hi:
                    people = new HiBuilder();
                    break;
            }
            return people;
        }
    }
}
