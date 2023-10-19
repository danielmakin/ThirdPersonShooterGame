using Photon.Pun;
using System.IO;
using UnityEngine;

public class GameSetupController : MonoBehaviour
{
    [SerializeField] private bool isLobby;
    void Start()
    {
        CreatePlayer();
    }

    void CreatePlayer()
    {
        if (isLobby)
        {
            Transform newTrans = transform.Find("/position_" + PhotonNetwork.CurrentRoom.PlayerCount);
            PhotonNetwork.Instantiate(Path.Combine("PolygonHeist", "Prefab", "Characters", "LobbyCharacter"), newTrans.position, Quaternion.identity);
        }
    }
}
