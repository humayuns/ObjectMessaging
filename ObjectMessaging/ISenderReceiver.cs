namespace ObjectMessaging
{
    interface ISenderReceiver
    {
        void Receive(string text);
        string Send();
    }
}
