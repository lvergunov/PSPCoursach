using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Player.Multyplayer
{
    public abstract class NetworkHandler
    {
        public abstract void HandlePlayerMovement(int id, Vector2 newPosition);
    }
}
