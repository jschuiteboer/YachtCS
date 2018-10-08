using System;
using System.Diagnostics;

namespace Yacht01.exercises
{
    class EventHandlerExercise
    {

        public static void Run(string[] args)
        {
            MyList list = new MyList();

            list.OnMessageAdded += (sender, e) => Debug.WriteLine("message added: {0}", (object) e.Message);

            list.AddMessage("testMessage 1");
            list.AddMessage("testMessage 2");
        }
    }

    class MyList
    {
        public event EventHandler<MessageAddedEvent> OnMessageAdded = delegate { };

        public void AddMessage(string message)
        {
            OnMessageAdded(this, new MessageAddedEvent(message));
        }
    }

    class MessageAddedEvent : EventArgs
    {
        public string Message { get; set; }

        public MessageAddedEvent(string message)
        {
            this.Message = message;
        }
    }
}
