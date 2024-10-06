// Decompiled with JetBrains decompiler
// Type: Battle.UI.DoubleCommandPanel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using GameCore.Input;
using Il2CppDummyDll;
using System;
using System.Collections;
using UnityEngine;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x20023BC")]
  public class DoubleCommandPanel : CommandPanel
  {
    [Token(Token = "0x4009853")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public CommandButton doubleButton;
    [Token(Token = "0x4009854")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    public CommandButton releaseButton;
    [Token(Token = "0x4009855")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    public CommandButton switchButton;
    [Token(Token = "0x4009856")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private BackKeyHandlerComponent backKeyHandlerComponent;
    [Token(Token = "0x4009857")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private CommonButton backButton;
    [Token(Token = "0x4009858")]
    [FieldOffset(Offset = "0x60")]
    private Action<bool> OnDoubleConfirm;
    [Token(Token = "0x4009859")]
    [FieldOffset(Offset = "0x68")]
    private UnitParameterData unit;

    [Token(Token = "0x17002F26")]
    public CommonButton BackButton
    {
      [Token(Token = "0x600DAA6"), Address(RVA = "0x2145610", Offset = "0x2145610", VA = "0x2145610")] get
      {
        return (CommonButton) null;
      }
    }

    [Token(Token = "0x600DAA7")]
    [Address(RVA = "0x2145618", Offset = "0x2145618", VA = "0x2145618", Slot = "4")]
    protected override void Initialize()
    {
    }

    [Token(Token = "0x600DAA8")]
    [Address(RVA = "0x2145728", Offset = "0x2145728", VA = "0x2145728")]
    public void SetOnDoubleConfirm(Action<bool> ac)
    {
    }

    [Token(Token = "0x600DAA9")]
    [Address(RVA = "0x2145730", Offset = "0x2145730", VA = "0x2145730", Slot = "5")]
    public override void Open(UnitParameterData actionUnit)
    {
    }

    [Token(Token = "0x600DAAA")]
    [Address(RVA = "0x21457D0", Offset = "0x21457D0", VA = "0x21457D0", Slot = "6")]
    protected override IEnumerator OpenTimeLine() => (IEnumerator) null;

    [Token(Token = "0x600DAAB")]
    [Address(RVA = "0x2145860", Offset = "0x2145860", VA = "0x2145860", Slot = "7")]
    public override void Close()
    {
    }

    [Token(Token = "0x600DAAC")]
    [Address(RVA = "0x21458D0", Offset = "0x21458D0", VA = "0x21458D0")]
    public void CloseByOtherCommand()
    {
    }

    [Token(Token = "0x600DAAD")]
    [Address(RVA = "0x2145940", Offset = "0x2145940", VA = "0x2145940", Slot = "8")]
    protected override IEnumerator CloseTimeLine() => (IEnumerator) null;

    [Token(Token = "0x600DAAE")]
    [Address(RVA = "0x21459D0", Offset = "0x21459D0", VA = "0x21459D0")]
    private void UpdateDoubleCommandButton(UnitParameterData unit)
    {
    }

    [Token(Token = "0x600DAAF")]
    [Address(RVA = "0x2145E1C", Offset = "0x2145E1C", VA = "0x2145E1C", Slot = "9")]
    protected override void HidePanelButton()
    {
    }

    [Token(Token = "0x600DAB0")]
    [Address(RVA = "0x2145E8C", Offset = "0x2145E8C", VA = "0x2145E8C")]
    private void OnSelectRelease()
    {
    }

    [Token(Token = "0x600DAB1")]
    [Address(RVA = "0x2145FC0", Offset = "0x2145FC0", VA = "0x2145FC0")]
    private void OnSelectSwitch()
    {
    }

    [Token(Token = "0x600DAB2")]
    [Address(RVA = "0x2145FE0", Offset = "0x2145FE0", VA = "0x2145FE0")]
    public DoubleCommandPanel()
    {
    }

    [Token(Token = "0x20023BD")]
    private class DoubleUIName
    {
      [Token(Token = "0x400985A")]
      public const string OpenTimeLineName = "Layout_Command_Double_In";
      [Token(Token = "0x400985B")]
      public const string CloseTimeLineName = "Layout_Command_Double_Return";
      [Token(Token = "0x400985C")]
      public const string ShowDoubleButtonTween = "Double_Excution_In";

      [Token(Token = "0x600DAB9")]
      [Address(RVA = "0x2146084", Offset = "0x2146084", VA = "0x2146084")]
      public DoubleUIName()
      {
      }
    }
  }
}
