using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Quobject.SocketIoClientDotNet.Client;

namespace application.simulateur.Classes
{
    public class WebSocketIO
    {

        private static WebSocketIO currentInstance;

        public static String SocketHost = "http://159.89.117.119:8080";

        public static String LinkID;

        #region Declarations

        /// <summary>
        /// Instance of SocketIO
        /// </summary>
        public Socket Socket { get; internal set; }

        /// <summary>
        /// The address of the socket
        /// </summary>
        public String WebSocketAddress { get; internal set; }

        /// <summary>
        /// Event called when the socket is connected
        /// </summary>
        public event EventHandler<EventSocketArgs> OnSocketConnected;

        /// <summary>
        /// Event called when the socket is disconnected
        /// </summary>
        public event EventHandler<EventSocketArgs> OnSocketDisconnected;

        /// <summary>
        /// Event when the socket receive a message
        /// </summary>
        public event EventHandler<EventSocketArgs> OnSocketMessageReceived;

        /// <summary>
        /// Channels
        /// </summary>
        public Dictionary<String, Func<EventSocketArgs, bool>> RegisteredChannels { get; internal set; }

        #endregion Declarations

        #region Constructors
        public WebSocketIO()
        {
            this.RegisteredChannels = new Dictionary<string, Func<EventSocketArgs, bool>>();
        }

        public WebSocketIO(String uri)
        {
            this.WebSocketAddress = uri;
            this.RegisteredChannels = new Dictionary<string, Func<EventSocketArgs, bool>>();
        }

        #endregion Constructors

        #region Public methods

        /// <summary>
        /// Initialize the connection to the WebSocket
        /// </summary>
        public void Connect()
        {
            this.Socket = IO.Socket(this.WebSocketAddress);

            this.Socket.On(Socket.EVENT_CONNECT, () =>
            {
                Console.WriteLine("Socket connected");
                if (this.OnSocketConnected != null)
                    OnSocketConnected(this, new EventSocketArgs(this.Socket));
            });

            this.Socket.On(Socket.EVENT_DISCONNECT, () =>
            {
                Console.WriteLine("Socket disconnected");

                if (this.OnSocketDisconnected != null)
                    OnSocketDisconnected(this, new EventSocketArgs(this.Socket));
            });

            this.Socket.On(Socket.EVENT_MESSAGE, (data) =>
            {
                Console.WriteLine("Message received");
                Console.WriteLine("     " + data);
            });


        }

        /// <summary>
        /// Disconnect the connection of the WebSocket
        /// </summary>
        public void Disconnect()
        {
            this.Socket.Disconnect();
        }

        /// <summary>
        /// Send a message trought the socket in a channel
        /// </summary>
        /// <param name="channel">Specified channel</param>
        /// <param name="message">Message to send</param>
        public void Send(String channel, String message)
        {
            this.Socket.Emit(channel, message);
        }

        public void Send(String channel, JObject obj)
        {
            this.Socket.Emit(channel, obj);
        }

        public void SendBody(String channel, JObject body)
        {
            JObject newJsonObject = new JObject();

            newJsonObject.Add("type", "hardware");
            newJsonObject.Add("link_id", WebSocketIO.LinkID);
            newJsonObject.Add("body", body);

            this.Socket.Emit(channel, newJsonObject);
        }

        public void RegisterChannel(String channel, Func<EventSocketArgs, bool> callback)
        {
            if (this.RegisteredChannels.ContainsKey(channel))
            {
                this.RegisteredChannels[channel] = callback;
            }
            else
            {
                this.RegisteredChannels.Add(channel, callback);

                this.Socket.On(channel, (data) =>
                {
                    if (this.RegisteredChannels[channel] != null)
                        this.RegisteredChannels[channel](new EventSocketArgs(this.Socket, channel, data));
                });
            }
        }

        public void DestroyChannel(String channel)
        {
            this.Socket.Off(channel);
            this.RegisteredChannels.Remove(channel);
        }

        #endregion Public methods

        #region Static methods

        public static WebSocketIO GetInstance()
        {
            if (currentInstance == null)
            {
                currentInstance = new WebSocketIO(SocketHost);
            }

            return currentInstance;
        }

        #endregion Static methods
    }
}
