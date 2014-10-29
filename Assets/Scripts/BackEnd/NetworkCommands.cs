//Created A class that houses all of the networking Commands
//Wyatt

using UnityEngine;
using System;
using System.Collections.Generic;

#if UNITY_EDITOR
using UnityEditor;
#endif

public static class NetworkCommands
{
    public bool JoinLobby()
    {
        PhotonNetwork.JoinLobby();
    }

    public static bool Create(string ToBeCreated, Vector3 PositionCreated)
    {
        if (NetworkInstantiate(ToBeCreated, PositionCreated, Quaternion.Identity(), 0))
        {
            return true;
        }
        return false;
    }

    private static bool NetworkInstantiate(string ToBeCreated, Vector3 PositionCreated, Quaternion Rotation, int group)
    {
        if (ToBeCreated == null)
        {
            return false;
        }
        if (Rotation.Equals(null))
        {
            Rotation = Quaternion.identity;
        }
        if (group < 0)
        {
            group = 0;
        }
        if (PhotonNetwork.Instantiate(ToBeCreated, PositionCreated, Rotation, group))
        {
            return true;
        }
        return false;
    }

    public static bool isMasterClient()
    {
        return PhotonNetwork.isMasterClient;
    }
}