using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MoveBag : MonoBehaviour, IDragHandler
{

	RectTransform currentRect;//当前的组件坐标

	private void Awake()
	{
		currentRect = GetComponent<RectTransform>();
	}

	public void OnDrag(PointerEventData eventData)
	{
		currentRect.anchoredPosition += eventData.delta;
		//anchoredPosition为矩形中心点(Pivot)与与锚点中心点(Anchors)之间的相对坐标
		//? 在拖拽过程中，使anchoredPosition值变化鼠标拖拽的位移(Vector2)，使得整个对象的位置随之相应变化
		//? 若使用eventData.position会使得面板拖拽移动尺度太大且偏移中心点
	}
}
