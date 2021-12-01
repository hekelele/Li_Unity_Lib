using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Photon.Pun
{
    public class Player
    {

    }

    public class PhotonNetwork
    {
        public static void ConnectUsingSettings()
        {

        }

        public static bool AutomaticallySyncScene;
    }

    
}

namespace Photon.Realtime
{

}

public abstract class MonoBehaviourPunCallbacks : MonoBehaviour
{
    public abstract void OnConnectedToMaster();

    public abstract void OnJoinedLobby();

    public abstract void OnJoinedRoom();

    public abstract void OnPlayerEnteredRoom(Photon.Pun.Player newPlayer);

    public abstract void OnCreateRoomFailed(short returnCode, string message);
};
