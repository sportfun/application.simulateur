using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Quobject.SocketIoClientDotNet.Client;

namespace application.simulateur.Classes
{

    public class EventSocketArgs : EventArgs
    {

        #region Declarations

        /// <summary>
        /// Socket
        /// </summary>
        public Socket Socket { get; internal set; }

        /// <summary>
        /// Data
        /// </summary>
        public Object Data { get; internal set; }

        /// <summary>
        /// Channel
        /// </summary>
        public String Channel { get; internal set; }

        #endregion Declarations

        #region Constructor
        public EventSocketArgs(Socket socket)
        {
            this.Socket = socket;
        }

        public EventSocketArgs(Socket socket, String channel)
        {
            this.Socket = socket;
            this.Channel = channel;
        }


        public EventSocketArgs(Socket socket, String channel, Object data)
        {
            this.Socket = socket;
            this.Channel = channel;
            this.Data = data;
        }

        #endregion Constructor
    }
}
