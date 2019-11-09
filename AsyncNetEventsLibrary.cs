using System;

namespace AsyncNetEvents
{

    public abstract class UpdateEventArgs : EventArgs
    {
        
        public UpdateEventArgs()
        {

        }
    }

    public class ServerUpdateEventArgs : UpdateEventArgs
    {
        //For changes in server behavior -- SOURCE is server
        public ServerUpdateEventArgs()
        {

        }
    }

    public class ClientUpdateEventArgs : UpdateEventArgs
    {
        //For changes in client behavior -- SOURCE is client
        public ClientUpdateEventArgs()
        {

        }
    }

}
