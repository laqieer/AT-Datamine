// Decompiled with JetBrains decompiler
// Type: UnitEquipmentView.UI.ItemEasyUIEventTrigger
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

#nullable disable
namespace UnitEquipmentView.UI
{
  [Token(Token = "0x2000453")]
  public class ItemEasyUIEventTrigger : 
    MonoBehaviour,
    ItemEasyUIEventTrigger.IPointerEventHandler,
    IPointerDownHandler,
    IEventSystemHandler,
    IPointerUpHandler,
    IPointerExitHandler
  {
    [Token(Token = "0x40017E4")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private ItemEasyDataUI target;

    [Token(Token = "0x6001892")]
    [Address(RVA = "0x2491388", Offset = "0x2491388", VA = "0x2491388", Slot = "4")]
    private void UnityEngine\u002EEventSystems\u002EIPointerDownHandler\u002EOnPointerDown(
      PointerEventData eventData)
    {
    }

    [Token(Token = "0x6001893")]
    [Address(RVA = "0x24913AC", Offset = "0x24913AC", VA = "0x24913AC", Slot = "6")]
    private void UnityEngine\u002EEventSystems\u002EIPointerExitHandler\u002EOnPointerExit(
      PointerEventData eventData)
    {
    }

    [Token(Token = "0x6001894")]
    [Address(RVA = "0x24913D0", Offset = "0x24913D0", VA = "0x24913D0", Slot = "5")]
    private void UnityEngine\u002EEventSystems\u002EIPointerUpHandler\u002EOnPointerUp(
      PointerEventData eventData)
    {
    }

    [Token(Token = "0x6001895")]
    [Address(RVA = "0x24913E8", Offset = "0x24913E8", VA = "0x24913E8")]
    public ItemEasyUIEventTrigger()
    {
    }

    [Token(Token = "0x2000454")]
    public interface IPointerEventHandler : 
      IPointerDownHandler,
      IEventSystemHandler,
      IPointerUpHandler,
      IPointerExitHandler
    {
    }
  }
}
