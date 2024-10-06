// Decompiled with JetBrains decompiler
// Type: QuestStageSelectSlide
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

#nullable disable
[Token(Token = "0x20002A0")]
public class QuestStageSelectSlide : 
  MonoBehaviour,
  IDragHandler,
  IEventSystemHandler,
  IBeginDragHandler,
  IEndDragHandler
{
  [Token(Token = "0x4000F6E")]
  [FieldOffset(Offset = "0x18")]
  [SerializeField]
  private float checkDragLength;
  [Token(Token = "0x4000F6F")]
  [FieldOffset(Offset = "0x20")]
  [SerializeField]
  private UnityEvent<float> OnDragInfo;
  [Token(Token = "0x4000F70")]
  [FieldOffset(Offset = "0x28")]
  private Vector2 dragStartPos;
  [Token(Token = "0x4000F71")]
  [FieldOffset(Offset = "0x30")]
  private float dragWidth;

  [Token(Token = "0x600104B")]
  [Address(RVA = "0x1BE6484", Offset = "0x1BE6484", VA = "0x1BE6484")]
  private void Start()
  {
  }

  [Token(Token = "0x600104C")]
  [Address(RVA = "0x1BE64F4", Offset = "0x1BE64F4", VA = "0x1BE64F4", Slot = "4")]
  public void OnDrag(PointerEventData eventData)
  {
  }

  [Token(Token = "0x600104D")]
  [Address(RVA = "0x1BE64F8", Offset = "0x1BE64F8", VA = "0x1BE64F8", Slot = "5")]
  public void OnBeginDrag(PointerEventData eventData)
  {
  }

  [Token(Token = "0x600104E")]
  [Address(RVA = "0x1BE6514", Offset = "0x1BE6514", VA = "0x1BE6514", Slot = "6")]
  public void OnEndDrag(PointerEventData eventData)
  {
  }

  [Token(Token = "0x600104F")]
  [Address(RVA = "0x1BE6594", Offset = "0x1BE6594", VA = "0x1BE6594")]
  public QuestStageSelectSlide()
  {
  }
}
