using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject playerData; // 数据
    public GameObject playerHands; // 手牌
    public List<Card> playerDeckList = new List<Card>(); // 卡组
    public List<Card> playerUseList = new List<Card>(); // 卡组
    public GameObject cardPrefab;
    public GameObject[] useCard;
    protected CardData CardDate;
    private PlayerInputActions controls;
    public BattleCard battle;
    public GameObject[] card;
    public Transform playerTran;
    public int[] id;
    public int i = 0;

    void Awake() 
    {
        controls = new PlayerInputActions();
        controls.GamePlayer.UseCardQ.started += ctx =>UseCardQ(); 
        controls.GamePlayer.UseCardE.started += ctx =>DrawCard(); 
    }
    void OnEnable() 
    {
        controls.GamePlayer.Enable();
    }
    void OnDisable() 
    {
        controls.GamePlayer.Disable();
    }
    void Start()
    {
        GameStart();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void GameStart()
    {
        CardDate = playerData.GetComponent<CardData>();
        ReadDeck();
    }
    public void DrawCard()
    {
        if(playerDeckList[0] != null)
        {
            GameObject newCard = GameObject.Instantiate(cardPrefab, playerHands.transform);
            newCard.GetComponent<CardDisplay>().card = playerDeckList[0];
            id[i] = playerDeckList[0].id;
            playerDeckList.RemoveAt(0);
            useCard[i] = newCard;
            i++;
        }
        //newCard.GetComponent<CardDisplay>().ShowCard();
    }
    public void ReadDeck() // 从数据中读取卡组
    {
        PlayerDataManager pdm = playerData.GetComponent<PlayerDataManager>();
        for (int i = 0; i < pdm.playerDeck.Length; i++)
        {
            if (pdm.playerDeck[i] != 0)
            {
                int counter = pdm.playerDeck[i];
                for (int j = 0; j < counter; j++)
                {
                    playerDeckList.Add(CardDate.CopyCard(i));
                }
            }
            
        }
        CopyCard();
        ShuffletDeck();
    }
    public void CopyCard()
    {
        for(int i = 0; i<playerDeckList.Count;i++)
        {
            playerUseList.Add(playerDeckList[i]);
        }
    }

    public void UseCardQ()
    {
        if(playerUseList[0] != null&&useCard != null && i>0)
        {
            i--;
            Destroy(useCard[0]);
            battle.CreateIMagic(card[id[i]],playerTran);
            for(int j=0;j<i;j++)
            {
                GameObject temp = useCard[j+1];

                useCard[j] = temp;
                useCard[j+1] = null;
            }
            playerUseList.RemoveAt(0);
        } 
    }
    // public void UseCardE()
    // {
    //     if(playerUseList[0] != null)
    //     {
    //     battle.CreateMonster(card[cardID1],playerTran);
    //     Destroy(useCard[1]);
    //     cardID1 = playerUseList[0].id;
    //     cardName = playerUseList[0].cardName.ToString(); 
    //     playerUseList.RemoveAt(0);
    //     }
    //     if(playerDeckList[0] != null)
    //     {
    //     GameObject newCard = GameObject.Instantiate(cardPrefab,playerHands[1].transform);
    //     newCard.GetComponent<CardDisplay>().card = playerDeckList[0];
    //     playerDeckList.RemoveAt(0);
    //     useCard[1] = newCard;
    //     }  
    // }
 public void ShuffletDeck()
 {
     for (int i = 0; i < playerDeckList.Count; i++)
                {
                    int rad = Random.Range(0, playerDeckList.Count);
                    Card temp = playerDeckList[i];
                    playerDeckList[i] = playerDeckList[rad];
                    playerDeckList[rad] = temp;
                }
 }
}
