// Decompiled with JetBrains decompiler
// Type: GameCore.UIControls.UIPointerHoldTrigger
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

#nullable disable
namespace GameCore.UIControls
{
  [Token(Token = "0x2000C19")]
  public class UIPointerHoldTrigger : 
    MonoBehaviour,
    IPointerDownHandler,
    IEventSystemHandler,
    IPointerUpHandler,
    IPointerExitHandler
  {
    [Token(Token = "0x40036E7")]
    [FieldOffset(Offset = "0x0")]
    public static float TimeForHold;
    [Token(Token = "0x40036E8")]
    [FieldOffset(Offset = "0x18")]
    public UnityEvent OnHold;
    [Token(Token = "0x40036E9")]
    [FieldOffset(Offset = "0x20")]
    private Coroutine checkHoldCoroutine;

    [Token(Token = "0x600453F")]
    [Address(RVA = "0x350E5D0", Offset = "0x350E5D0", VA = "0x350E5D0", Slot = "4")]
    public void OnPointerDown(PointerEventData eventData)
    {
    }

    [Token(Token = "0x6004540")]
    [Address(RVA = "0x350E614", Offset = "0x350E614", VA = "0x350E614", Slot = "5")]
    public void OnPointerUp(PointerEventData eventData)
    {
    }

    [Token(Token = "0x6004541")]
    [Address(RVA = "0x350E664", Offset = "0x350E664", VA = "0x350E664", Slot = "6")]
    public void OnPointerExit(PointerEventData eventData)
    {
    }

    [Token(Token = "0x6004542")]
    [Address(RVA = "0x350E5D4", Offset = "0x350E5D4", VA = "0x350E5D4")]
    private void StartCheckHold()
    {
    }

    [Token(Token = "0x6004543")]
    [Address(RVA = "0x350E63C", Offset = "0x350E63C", VA = "0x350E63C")]
    private void EndCheckHold()
    {
    }

    [Token(Token = "0x6004544")]
    [Address(RVA = "0x350E68C", Offset = "0x350E68C", VA = "0x350E68C")]
    private IEnumerator CheckHold() => (IEnumerator) null;

    [Token(Token = "0x6004545")]
    [Address(RVA = "0x350E71C", Offset = "0x350E71C", VA = "0x350E71C")]
    public UIPointerHoldTrigger()
    {
    }

    [Token(Token = "0x6004546")]
    [Address(RVA = "0x350E784", Offset = "0x350E784", VA = "0x350E784")]
    static UIPointerHoldTrigger()
    {
    }
  }
}
