using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

/*  Author: hekelele / Github
 *  
 *  LUL Photon Launcher
 *  - inherit it and add it to hierachy
 *  
 *  
 *  version: 0.1.0
 *  Last Updated Date: 2021/12/01
 */

namespace LUL.Thirdparty.Photon
{
    public abstract class LPhotonLauncher : MonoBehaviourPunCallbacks
    {
        //Delegate On Connected To Master Server
        public delegate void DeConnectedToMS();
        public event DeConnectedToMS EvConnectedToMS = () => { };

        //Delegate On Joined Lobby
        public delegate void DeJoinedLobby();
        public event DeJoinedLobby EvJoinedLobby = () => { };

        //Delegate On Joined Room
        public delegate void DeJoinedRoom();
        public event DeJoinedRoom EvJoinedRoom = () => { };

        // Delegate On Other (Player) Entered Room
        public delegate void DeOEnteredRoom(Player newPlayer);
        /// <summary>
        /// Event On Other (Player) Entered Room
        /// </summary>
        public event DeOEnteredRoom EvOEnteredRoom = (Player newPlayer) => { };

        protected abstract void LogErrorMessage(string errorTitle, short returnCode, string message);

        public void ConnectToMasterServer()
        {
            PhotonNetwork.AutomaticallySyncScene = true;
            PhotonNetwork.ConnectUsingSettings();
        }

        public override void OnConnectedToMaster()
        {
            EvConnectedToMS();
        }

        public override void OnJoinedLobby()
        {
            EvJoinedLobby();
        }

        public override void OnJoinedRoom()
        {
            EvJoinedRoom();
        }

        public override void OnPlayerEnteredRoom(Player newPlayer)
        {
            EvOEnteredRoom(newPlayer);
        }

        public override void OnCreateRoomFailed(short returnCode, string message)
        {
            LogErrorMessage("Room Creation Failed", returnCode, message);
        }
    }
}


