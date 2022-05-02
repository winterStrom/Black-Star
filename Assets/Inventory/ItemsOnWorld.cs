using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemsOnWorld : MonoBehaviour
{
	public Item thisItem;					//素材所属的Item(物品配置文件)
	public Inventory thisInventory;			//素材所属的Inventory(背包配置文件)
    private void OnTriggerEnter2D(Collider2D collision)//物品被人物碰到时
	{
		if (collision.gameObject.CompareTag("Player"))//若碰到物品的碰撞体为玩家
		{
			AddNewItem();//将物品添加到指定物品栏
			Destroy(gameObject);//在场景中摧毁物品
		}
	}

	public void AddNewItem()//将物品添加到指定物品栏
	{
		if (!thisInventory.Items.Contains(thisItem))//若指定物品栏中尚未存放该物品
		{
			//thisInventory.Items.Add(thisItem);//在物品栏中添加物品
			//InventoryManager.CreateNewItem(thisItem);
			for (int i = 0; i < thisInventory.Items.Count; i++)
			{
				if (thisInventory.Items[i]==null)
				{
					thisInventory.Items[i] = thisItem;
					break;
				}
			}

		}
		else
		{
			thisItem.itemHeld+=1;//物品持有数量增加
		}
		InventoryManager.RefreshItem();
	}

}

