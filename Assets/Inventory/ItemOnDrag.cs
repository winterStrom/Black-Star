using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;//包含UGUI拖拽相关接口的事件库

public class ItemOnDrag : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler//响应拖拽功能的接口
{

	public Transform originalParent;//Item的原始父级
    public Inventory myBag;
    private int currentItemID;

	public void OnBeginDrag(PointerEventData eventData)//开始拖拽
	{
		originalParent = transform.parent;
        currentItemID = originalParent.GetComponent<Slot>().slotID;
		transform.SetParent(transform.parent.parent);//将Item父级设置到Slot的上层
		transform.position = eventData.position;//保持Item位置与鼠标拖拽位置一致
		GetComponent<CanvasGroup>().blocksRaycasts = false;//开始拖拽后取消射线检测以检测下方对象
	}

	public void OnDrag(PointerEventData eventData)//拖拽中
	{
		transform.position = eventData.position;//保持Item位置与鼠标拖拽位置一致
	}

	public void OnEndDrag(PointerEventData eventData)//结束拖拽
	{
        if(eventData.pointerCurrentRaycast.gameObject != null)
        {
		if (eventData.pointerCurrentRaycast.gameObject.name == "Item Image")//如果目标背包栏中有物品
		{
			transform.SetParent(eventData.pointerCurrentRaycast.gameObject.transform.parent.parent);//设置父级到目标背包栏
			transform.position = eventData.pointerCurrentRaycast.gameObject.transform.parent.parent.position;//设置位置到目标位置
            var temp = myBag.Items[currentItemID];
            myBag.Items[currentItemID] = myBag.Items[eventData.pointerCurrentRaycast.gameObject.GetComponentInParent<Slot>().slotID];
            myBag.Items[eventData.pointerCurrentRaycast.gameObject.GetComponentInParent<Slot>().slotID] = temp;
			eventData.pointerCurrentRaycast.gameObject.transform.parent.SetParent(originalParent);//目标背包栏物品交换到原始父级
			eventData.pointerCurrentRaycast.gameObject.transform.parent = originalParent.transform;//目标背包栏物品交换到适宜位置
			GetComponent<CanvasGroup>().blocksRaycasts = true;//重新启用射线检测
			return;
		}
        if(eventData.pointerCurrentRaycast.gameObject.name == "Slot(Clone)")
            {
		    //如果直接检测到Slot
		    transform.SetParent(eventData.pointerCurrentRaycast.gameObject.transform);
		    transform.position = eventData.pointerCurrentRaycast.gameObject.transform.position;
            myBag.Items[eventData.pointerCurrentRaycast.gameObject.GetComponentInParent<Slot>().slotID] = myBag.Items[currentItemID];
            if(eventData.pointerCurrentRaycast.gameObject.GetComponent<Slot>().slotID != currentItemID)
            myBag.Items[currentItemID] = null;
		    GetComponent<CanvasGroup>().blocksRaycasts = true;//重新启用射线检测
            return;
        }
        }
        transform.SetParent(originalParent);
        transform.position = originalParent.position;
        GetComponent<CanvasGroup>().blocksRaycasts = true;
	}
    
}
