// Decompiled with JetBrains decompiler
// Type: Battle.Grid.GridInputHandler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

#nullable disable
namespace Battle.Grid
{
  [Token(Token = "0x200252E")]
  public class GridInputHandler : 
    MonoBehaviour,
    IPointerDownHandler,
    IEventSystemHandler,
    IPointerUpHandler,
    IPointerExitHandler
  {
    [Token(Token = "0x1700314F")]
    public IGridEventDispatcher Dispatcher
    {
      [Token(Token = "0x600E597"), Address(RVA = "0x4869670", Offset = "0x4869670", VA = "0x4869670")] get
      {
        return (IGridEventDispatcher) null;
      }
      [Token(Token = "0x600E598"), Address(RVA = "0x4869678", Offset = "0x4869678", VA = "0x4869678")] set
      {
      }
    }

    [Token(Token = "0x600E599")]
    [Address(RVA = "0x4869680", Offset = "0x4869680", VA = "0x4869680")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600E59A")]
    [Address(RVA = "0x4869688", Offset = "0x4869688", VA = "0x4869688", Slot = "4")]
    public void OnPointerDown(PointerEventData eventData)
    {
    }

    [Token(Token = "0x600E59B")]
    [Address(RVA = "0x4869738", Offset = "0x4869738", VA = "0x4869738", Slot = "5")]
    public void OnPointerUp(PointerEventData eventData)
    {
    }

    [Token(Token = "0x600E59C")]
    [Address(RVA = "0x48697EC", Offset = "0x48697EC", VA = "0x48697EC", Slot = "6")]
    public void OnPointerExit(PointerEventData eventData)
    {
    }

    [Token(Token = "0x600E59D")]
    [Address(RVA = "0x48698A0", Offset = "0x48698A0", VA = "0x48698A0")]
    public GridInputHandler()
    {
    }
  }
}
