using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Player.Multyplayer
{
    public class JsonPackage
    {
        public int objectId;
        public MultiplayerObject multiplayerObjectType;
        public MyltiplayerOperation operationType;
        public Vector2 newPosition;
        public float newHealthrate;
    }
}

public enum MultiplayerObject { 
    User, StaticObject, Bullet, Enemy
}

public enum MyltiplayerOperation { 
    ChangePosition, ChangeHealthrate, Destroy
}
