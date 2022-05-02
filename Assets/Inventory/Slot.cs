using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    public int slotID;
	public Item slotItem;	//物品所对应的物品信息存储
	public Image slotImage;	//Slot对应的图片组件，引用以在之后对其进行修改
	public Text slotNum;	//Slot对应的标识物品数量的Text组件引用
    public GameObject itemInSlot;//Slot下的Item子物体引用
    public string slotInfo;//Slot文本信息

    public void ItemOnClick()//点击背包栏填充物品图像
	{
		InventoryManager.UpdataItemInfo(slotInfo);
	}
    public void SetUpSlot(Item item)
	{
		if (item == null)//若从数据库中传来的Item为空，则仅显示背景Slot
		{
			itemInSlot.SetActive(false);
			return;
		}
		//若从数据库取得的Item非空，则对应完成数据传递
		slotImage.sprite = item.itemImage;
		slotNum.text = item.itemHeld.ToString();
        slotInfo = item.itemInfo;
	}

}
