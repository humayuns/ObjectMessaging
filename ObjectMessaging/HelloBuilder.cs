namespace ObjectMessaging
{
    class HelloBuilder : ISenderReceiver
    {

        private string _msg = "";
        public void Receive(string text)
        {
            _msg = text;
        }

        public string Send()
        {
            return "Hello " + _msg;
        }
    }
}
