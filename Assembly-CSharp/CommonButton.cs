// Decompiled with JetBrains decompiler
// Type: CommonButton
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
[Token(Token = "0x2000210")]
[AddComponentMenu("UI/Common Button", 31)]
public class CommonButton : Button
{
  [Token(Token = "0x4000C48")]
  private const float DEFALT_REPEATED_HIT_PREVENTION_TIME = 0.3f;
  [Token(Token = "0x4000C49")]
  [FieldOffset(Offset = "0x100")]
  [SerializeField]
  private List<Graphic> m_additionalTargetGraphics;
  [Token(Token = "0x4000C4A")]
  [FieldOffset(Offset = "0x108")]
  [SerializeField]
  private string m_buttonClickSEName;
  [Token(Token = "0x4000C4B")]
  [FieldOffset(Offset = "0x110")]
  [SerializeField]
  private ButtonClickSETypeEnum m_buttonClickSEType;
  [Token(Token = "0x4000C4C")]
  [FieldOffset(Offset = "0x114")]
  [SerializeField]
  private bool isDisabledRepeatedHitPrevention;
  [Token(Token = "0x4000C4D")]
  [FieldOffset(Offset = "0x115")]
  [SerializeField]
  private bool isEnabledOnSubmit;
  [Token(Token = "0x4000C4E")]
  [FieldOffset(Offset = "0x118")]
  private ColorBlock m_initColors;
  [Token(Token = "0x4000C4F")]
  [FieldOffset(Offset = "0x170")]
  private bool m_isInitializedInitColor;
  [Token(Token = "0x4000C51")]
  [FieldOffset(Offset = "0x178")]
  private bool clickedFlag;

  [Token(Token = "0x1700010A")]
  public List<Graphic> additionalTargetGraphics
  {
    [Token(Token = "0x6000CFB"), Address(RVA = "0x4C7F5EC", Offset = "0x4C7F5EC", VA = "0x4C7F5EC")] get
    {
      return (List<Graphic>) null;
    }
  }

  [Token(Token = "0x1700010B")]
  public string ButtonClickSEName
  {
    [Token(Token = "0x6000CFC"), Address(RVA = "0x4C7F5F4", Offset = "0x4C7F5F4", VA = "0x4C7F5F4")] get
    {
      return (string) null;
    }
  }

  [Token(Token = "0x1700010C")]
  public ButtonClickSETypeEnum buttonClickSEType
  {
    [Token(Token = "0x6000CFD"), Address(RVA = "0x4C7F5FC", Offset = "0x4C7F5FC", VA = "0x4C7F5FC")] get
    {
      return new ButtonClickSETypeEnum();
    }
  }

  [Token(Token = "0x1700010D")]
  public int ClickCounter
  {
    [Token(Token = "0x6000CFE"), Address(RVA = "0x4C7F604", Offset = "0x4C7F604", VA = "0x4C7F604")] get
    {
      return new int();
    }
    [Token(Token = "0x6000CFF"), Address(RVA = "0x4C7F60C", Offset = "0x4C7F60C", VA = "0x4C7F60C")] private set
    {
    }
  }

  [Token(Token = "0x1700010E")]
  public bool IsClicked
  {
    [Token(Token = "0x6000D00"), Address(RVA = "0x4C7F614", Offset = "0x4C7F614", VA = "0x4C7F614")] get
    {
      return new bool();
    }
  }

  [Token(Token = "0x6000D01")]
  [Address(RVA = "0x4C7F4D4", Offset = "0x4C7F4D4", VA = "0x4C7F4D4")]
  public CommonButton()
  {
  }

  [Token(Token = "0x6000D02")]
  [Address(RVA = "0x4C7F624", Offset = "0x4C7F624", VA = "0x4C7F624")]
  public void ResetClickCounter()
  {
  }

  [Token(Token = "0x6000D03")]
  [Address(RVA = "0x4C7F630", Offset = "0x4C7F630", VA = "0x4C7F630")]
  private void UpdateClickCounter()
  {
  }

  [Token(Token = "0x6000D04")]
  [Address(RVA = "0x4C7F64C", Offset = "0x4C7F64C", VA = "0x4C7F64C", Slot = "43")]
  protected virtual void Update()
  {
  }

  [Token(Token = "0x6000D05")]
  [Address(RVA = "0x4C7F668", Offset = "0x4C7F668", VA = "0x4C7F668", Slot = "41")]
  public override void OnPointerClick(PointerEventData eventData)
  {
  }

  [Token(Token = "0x6000D06")]
  [Address(RVA = "0x4C7F78C", Offset = "0x4C7F78C", VA = "0x4C7F78C")]
  private void PreventRepeatedHits()
  {
  }

  [Token(Token = "0x6000D07")]
  [Address(RVA = "0x4C7F3F4", Offset = "0x4C7F3F4", VA = "0x4C7F3F4")]
  public bool ShouldInvokeOnClick(PointerEventData eventData) => new bool();

  [Token(Token = "0x6000D08")]
  [Address(RVA = "0x4C7F8EC", Offset = "0x4C7F8EC", VA = "0x4C7F8EC", Slot = "26")]
  protected override void DoStateTransition(Selectable.SelectionState state, bool instant)
  {
  }

  [Token(Token = "0x6000D09")]
  [Address(RVA = "0x4C7FA4C", Offset = "0x4C7FA4C", VA = "0x4C7FA4C")]
  private void StartAdditionalColorTween(Color targetColor, bool instant)
  {
  }

  [Token(Token = "0x6000D0A")]
  [Address(RVA = "0x4C7FBAC", Offset = "0x4C7FBAC", VA = "0x4C7FBAC")]
  public void SetInteractableDisabledColor(bool isDisabled)
  {
  }

  [Token(Token = "0x6000D0B")]
  [Address(RVA = "0x4C7FCBC", Offset = "0x4C7FCBC", VA = "0x4C7FCBC", Slot = "42")]
  public override void OnSubmit(BaseEventData eventData)
  {
  }
}
