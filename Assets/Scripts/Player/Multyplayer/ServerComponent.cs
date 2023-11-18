using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using System.Net;

namespace Assets.Scripts.Player.Multyplayer
{
    public class ServerComponent : MonoBehaviour
    {
        public void Initialize()
        {
            _listener = new TcpListener(IPAddress.Any,_portNumber);     
        }
        private TcpListener _listener;
        private int _portNumber = 53222;
        
    }
}
