using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;

public class ProceduralFillingLevel : MonoBehaviour
{

    public void InitializeRooms(List<BoundsInt> rooms) {
        _rooms = rooms;
        PlaceCharacter();
    }

    private void PlaceCharacter()
    {
        var mostCentralledRoomDist = _rooms.Min(a=>Vector3.Distance(a.center, Vector3.zero));
        var mostCentralRoom = _rooms.First(a=>Vector3.Distance(a.center, Vector3.zero).Equals(mostCentralledRoomDist));
        //var character = multiplayerController.hostCharacter.PlayableCharacter;
        Vector2 placeForCharacter = new Vector2(mostCentralRoom.center.x - mostCentralRoom.size.x / 2,
            mostCentralRoom.center.y - mostCentralRoom.size.y / 2);
        //character.transform.position = placeForCharacter;
    }
    private List<BoundsInt> _rooms;
}

