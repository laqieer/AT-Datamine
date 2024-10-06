// Decompiled with JetBrains decompiler
// Type: CommonScrollRect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

#nullable disable
[Token(Token = "0x2000214")]
public class CommonScrollRect : ScrollRect
{
  [Token(Token = "0x4000C7D")]
  [FieldOffset(Offset = "0x128")]
  [SerializeField]
  private bool m_Interactable;
  [Token(Token = "0x4000C7E")]
  [FieldOffset(Offset = "0x129")]
  private bool m_GroupsAllowInteraction;
  [Token(Token = "0x4000C7F")]
  [FieldOffset(Offset = "0x130")]
  private readonly List<CanvasGroup> m_CanvasGroupCache;

  [Token(Token = "0x17000110")]
  public bool interactable
  {
    [Token(Token = "0x6000D1D"), Address(RVA = "0x4C80CEC", Offset = "0x4C80CEC", VA = "0x4C80CEC")] get
    {
      return new bool();
    }
    [Token(Token = "0x6000D1E"), Address(RVA = "0x4C80CF4", Offset = "0x4C80CF4", VA = "0x4C80CF4")] set
    {
    }
  }

  [Token(Token = "0x6000D1F")]
  [Address(RVA = "0x4C80D00", Offset = "0x4C80D00", VA = "0x4C80D00", Slot = "61")]
  public virtual bool IsInteractable() => new bool();

  [Token(Token = "0x6000D20")]
  [Address(RVA = "0x4C80D20", Offset = "0x4C80D20", VA = "0x4C80D20", Slot = "14")]
  protected override void OnCanvasGroupChanged()
  {
  }

  [Token(Token = "0x6000D21")]
  [Address(RVA = "0x4C80EC4", Offset = "0x4C80EC4", VA = "0x4C80EC4", Slot = "42")]
  public override void OnScroll(PointerEventData data)
  {
  }

  [Token(Token = "0x6000D22")]
  [Address(RVA = "0x4C80F10", Offset = "0x4C80F10", VA = "0x4C80F10", Slot = "44")]
  public override void OnBeginDrag(PointerEventData eventData)
  {
  }

  [Token(Token = "0x6000D23")]
  [Address(RVA = "0x4C80F5C", Offset = "0x4C80F5C", VA = "0x4C80F5C", Slot = "46")]
  public override void OnDrag(PointerEventData eventData)
  {
  }

  [Token(Token = "0x6000D24")]
  [Address(RVA = "0x4C80FA8", Offset = "0x4C80FA8", VA = "0x4C80FA8")]
  public CommonScrollRect()
  {
  }
}
