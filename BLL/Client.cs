using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;

namespace BLL
{
    
    [Serializable]

    public class Client
    {
        public enum clienttype
        {
            Driver = 0,
            Passenger
        }
        private readonly User clientUserDetails;
        private readonly string locationIndex;
        private readonly double lat;
        private readonly double lon;
        private readonly clienttype clientType;
        public static Socket Clientsocket;

        public static void ConnectSocket()
        {
            Clientsocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            Clientsocket.Connect(new IPEndPoint(IPAddress.Loopback, 3128));
        }

        public User ClientUserDetails
        {
            get
            {
                return clientUserDetails;
            }
        }

        public string LocationIndex
        {
            get
            {
                return locationIndex;
            }
        }

        public double Lat
        {
            get
            {
                return lat;
            }
        }

        public double Lon
        {
            get
            {
                return lon;
            }
        }

        public Client()
        {
                
        }
        public Client(User userpara, string locapara, double dLat, double dLong, clienttype type = clienttype.Passenger)
        {
            this.clientUserDetails = userpara;
            this.locationIndex = locapara;
            this.lat = dLat;
            this.lon = dLong;
            this.clientType = type;
        }
        public Client(User userpara, string locapara, double dLat, double dLong)
        {
            this.clientUserDetails = userpara;
            this.locationIndex = locapara;
            this.lat = dLat;
            this.lon = dLong;
          
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
