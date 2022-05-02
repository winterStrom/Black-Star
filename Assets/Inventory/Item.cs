using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="New Item",menuName ="Inventory/New Item")]
public class Item : ScriptableObject
{
	public string itemName;			//物品名称
	public Sprite itemImage;		//物品所使用的填充图片
	public int itemHeld;			//物品持有数量
	[TextArea]						//文本域标签(使string在Inspector窗口的编辑区从一行变为一个文本框)
	public string itemInfo;			//物品信息(可能多行)
    public bool equip;
}
