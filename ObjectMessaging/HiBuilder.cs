using System;

namespace ObjectMessaging
{
    class HiBuilder : ISenderReceiver
    {
        private string _msg = "";
        public void Receive(string text)
        {
            _msg = text;
        }

        public string Send()
        {
            return "Hi " + _msg;
        }
    }
}
