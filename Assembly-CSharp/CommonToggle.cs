// Decompiled with JetBrains decompiler
// Type: CommonToggle
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

#nullable disable
[Token(Token = "0x2000215")]
[AddComponentMenu("UI/Common Toggle", 31)]
public class CommonToggle : Toggle
{
  [Token(Token = "0x4000C80")]
  private const float DEFALT_REPEATED_HIT_PREVENTION_TIME = 0.3f;
  [Token(Token = "0x4000C81")]
  [FieldOffset(Offset = "0x120")]
  [SerializeField]
  private List<Graphic> m_additionalTargetGraphics;
  [Token(Token = "0x4000C82")]
  [FieldOffset(Offset = "0x128")]
  [SerializeField]
  private ButtonClickSETypeEnum m_buttonClickSEType;
  [Token(Token = "0x4000C83")]
  [FieldOffset(Offset = "0x130")]
  [SerializeField]
  private string m_buttonClickSEName;
  [Token(Token = "0x4000C84")]
  [FieldOffset(Offset = "0x138")]
  [SerializeField]
  private bool isDisabledRepeatedHitPrevention;

  [Token(Token = "0x17000111")]
  public List<Graphic> additionalTargetGraphics
  {
    [Token(Token = "0x6000D25"), Address(RVA = "0x1C843C4", Offset = "0x1C843C4", VA = "0x1C843C4")] get
    {
      return (List<Graphic>) null;
    }
  }

  [Token(Token = "0x17000112")]
  public ButtonClickSETypeEnum buttonClickSEType
  {
    [Token(Token = "0x6000D26"), Address(RVA = "0x1C843CC", Offset = "0x1C843CC", VA = "0x1C843CC")] get
    {
      return new ButtonClickSETypeEnum();
    }
  }

  [Token(Token = "0x17000113")]
  public string buttonClickSEName
  {
    [Token(Token = "0x6000D27"), Address(RVA = "0x1C843D4", Offset = "0x1C843D4", VA = "0x1C843D4")] get
    {
      return (string) null;
    }
  }

  [Token(Token = "0x6000D28")]
  [Address(RVA = "0x1C843DC", Offset = "0x1C843DC", VA = "0x1C843DC", Slot = "49")]
  public override void OnPointerClick(PointerEventData eventData)
  {
  }

  [Token(Token = "0x6000D29")]
  [Address(RVA = "0x1C845C0", Offset = "0x1C845C0", VA = "0x1C845C0")]
  private void PreventRepeatedHits()
  {
  }

  [Token(Token = "0x6000D2A")]
  [Address(RVA = "0x1C844A8", Offset = "0x1C844A8", VA = "0x1C844A8")]
  public bool ShouldInvokeOnClick(PointerEventData eventData) => new bool();

  [Token(Token = "0x6000D2B")]
  [Address(RVA = "0x1C84720", Offset = "0x1C84720", VA = "0x1C84720", Slot = "26")]
  protected override void DoStateTransition(Selectable.SelectionState state, bool instant)
  {
  }

  [Token(Token = "0x6000D2C")]
  [Address(RVA = "0x1C84880", Offset = "0x1C84880", VA = "0x1C84880")]
  private void StartAdditionalColorTween(Color targetColor, bool instant)
  {
  }

  [Token(Token = "0x6000D2D")]
  [Address(RVA = "0x1C849E0", Offset = "0x1C849E0", VA = "0x1C849E0")]
  public CommonToggle()
  {
  }
}
