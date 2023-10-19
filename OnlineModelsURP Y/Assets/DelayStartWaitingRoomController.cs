using Photon.Pun;
using Photon.Realtime;
using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;

public class DelayStartWaitingRoomController : MonoBehaviourPunCallbacks
{
    private PhotonView myView;
    [SerializeField] int multiPlayerSceneIndex;
    [SerializeField] int menuSceneIndex;

    private int playerCount;
    private int roomSize;

    [SerializeField] int minPlayersToStart;
    [SerializeField] TextMeshProUGUI timerToStart;
    [SerializeField] private GameObject waitScreeen;
    [SerializeField] private GameObject yScreen;
    [SerializeField] private GameObject bScreen;

    private bool readyToStartCountDown;
    private bool readyToStart;
    private bool startingGame;

    private float timerToStartGame;
    private float notFullGameTimer;
    private float fullGameTimer;

    [SerializeField] float maxWaitTime;
    [SerializeField] float maxFullGameWaitTime;

    
    void Start()
    {
        myView = GetComponent<PhotonView>();
        fullGameTimer = maxFullGameWaitTime;
        notFullGameTimer = maxWaitTime;
        timerToStartGame = maxWaitTime;

        PlayerCounterUpdate();
    }

    private void PlayerCounterUpdate()
    {
        playerCount = PhotonNetwork.PlayerList.Length;
        roomSize = PhotonNetwork.CurrentRoom.MaxPlayers;
        if (playerCount == roomSize)
        {
            readyToStart = true;
        }else if (playerCount >= minPlayersToStart)
        {
            readyToStartCountDown = true;
        }
        else
        {
            readyToStartCountDown = false;
            readyToStart = false;
        }
    }

    public override void OnPlayerEnteredRoom(Player newPlayer)
    {
        PlayerCounterUpdate();
        if (PhotonNetwork.IsMasterClient)
        {
            myView.RPC("RPC_SendTimer", RpcTarget.Others, timerToStartGame);
        }
    }

    [PunRPC]
    private void RPC_SendTimer(float timeIn)
    {
        timerToStartGame = timeIn;
        notFullGameTimer = timeIn;
        if (timeIn < fullGameTimer)
        {
            fullGameTimer = timeIn;
        }
    }

    public override void OnPlayerLeftRoom(Player otherPlayer)
    {
        PlayerCounterUpdate();
    }

    // Update is called once per frame
    void Update()
    {
        WaitingForMorePlayers();
    }

    private void WaitingForMorePlayers()
    {
        if (playerCount <= 1)
        {
            ResetTimer();
        }
        if (readyToStart)
        {
            waitScreeen.SetActive(false);
            bScreen.SetActive(true);
            fullGameTimer += Time.deltaTime;
            timerToStartGame += Time.deltaTime;
        }else if (readyToStartCountDown)
        {
            waitScreeen.SetActive(false);
            bScreen.SetActive(true);
            notFullGameTimer -= Time.deltaTime;
            timerToStartGame = notFullGameTimer;
        }

        string tempTimer = string.Format("{0:00}", timerToStartGame);
        timerToStart.text = tempTimer;

        if (timerToStartGame <= 0f)
        {
            if (startingGame)
            {
                return;
            }
            StartGame();
        }
    }

    private void StartGame()
    {
        startingGame = true;
        if (!PhotonNetwork.IsMasterClient)
        {
            return;
        }
        PhotonNetwork.CurrentRoom.IsOpen = false;
        PhotonNetwork.LoadLevel(multiPlayerSceneIndex);
    }

    private void ResetTimer()
    {
        timerToStartGame = maxWaitTime;
        notFullGameTimer = maxWaitTime;
        fullGameTimer = maxFullGameWaitTime;
    }

    public void DelayCancel()
    {
        PhotonNetwork.LeaveRoom();
        SceneManager.LoadScene(menuSceneIndex);
    }
}
