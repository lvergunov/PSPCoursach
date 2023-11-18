using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Player.Multyplayer
{
    public class ClientComponent : MonoBehaviour
    {
        
        private TcpClient _client;
        private StreamWriter _writer;
        private StreamReader _reader;

        public void InitClient()
        {
            var stream = _client.GetStream();
            _reader = new StreamReader(stream);
            _writer = new StreamWriter(stream);
        }
        private void FixedUpdate()
        {
            string message = _reader.ReadLine();
            if (message != null)
                FetchJSON(message);
        }

        private void FetchJSON(string instruction) {
            JsonPackage jsonObject = (JsonPackage)JsonUtility.FromJson(instruction, typeof(JsonPackage));
            if (jsonObject.multiplayerObjectType == MultiplayerObject.User) {
                transform.position = new Vector3(jsonObject.newPosition.X, jsonObject.newPosition.Y, 0.0f);
            }
        }
    }
}
