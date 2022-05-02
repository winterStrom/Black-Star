using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
	static InventoryManager instance;//单例模式
	//以便于在其他脚本中调用InventoryManager

	public Inventory myBag;			//角色背包数据库引用
	public GameObject slotGrid;		//背包栏引用
	//public Slot slotPrefab;			//?背包栏填充预制体脚本引用
    public GameObject emptySlot;
	public Text itemInfomation;		//物品描述文本引用
    public List<GameObject> slots = new List<GameObject>();//存放Slot


	private void Awake()
	{
		if (instance != null)//?如果有InventoryManager在场上，新上场的InventoryManager会销毁(保持只有一个Manager)
			Destroy(this);
		instance = this;
	}
    private void OnEnable()//?
	{
		RefreshItem();
		instance.itemInfomation.text = "";
	}

    /*public static void CreateNewItem(Item item)
	{
		Slot newItem = Instantiate(instance.slotPrefab,instance.slotGrid.transform.position,Quaternion.identity);
		//创建一个新的Slot，用以存储从对应Item中获得的数据
		newItem.gameObject.transform.SetParent(instance.slotGrid.transform);
		//将创建好的物品附着在Grid(背包栏)上

		//完成Slot中变量的赋值(获取需要的数据)
		newItem.slotItem = item;
		newItem.slotImage.sprite = item.itemImage;
		newItem.slotNum.text = item.itemHeld.ToString();
	}*/
public static async void RefreshItem()
	{
		//为了避免代码的复杂混乱，这里考虑将Grid中全部内容清空，并重新从数据库中获取更新后的信息
		for (int i = 0; i < instance.slotGrid.transform.childCount; i++)
		{
			if (instance.slotGrid.transform.childCount == 0)
			break;
			Destroy(instance.slotGrid.transform.GetChild(i).gameObject);
            instance.slots.Clear();
		}

		for (int i = 0; i < instance.myBag.Items.Count; i++)
		{
			//CreateNewItem(instance.myBag.ItemList[i]);//将数据库中所有的物品信息全部重新添加(舍弃)
            instance.slots.Add(Instantiate(instance.emptySlot));//生成Slot并添加到列表中
            instance.slots[i].transform.SetParent(instance.slotGrid.transform);//将生成的Slot添加到Grid中
            instance.slots[i].GetComponent<Slot>().slotID = i;
            instance.slots[i].GetComponent<Slot>().SetUpSlot(instance.myBag.Items[i]);

		}
	}

    public static void UpdataItemInfo(string ItemDescription)
	{
		instance.itemInfomation.text = ItemDescription;
	}



}
