// Decompiled with JetBrains decompiler
// Type: Battle.UI.InteractCommandPanel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using GameCore.Input;
using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x20023C0")]
  public class InteractCommandPanel : CommandPanel
  {
    [Token(Token = "0x4009863")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private CommandButton doorSwitchButton;
    [Token(Token = "0x4009864")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private CommandButton warpButton;
    [Token(Token = "0x4009865")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private CommonButton backButton;
    [Token(Token = "0x4009866")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private BackKeyHandlerComponent backKeyHandlerComponent;
    [Token(Token = "0x4009867")]
    [FieldOffset(Offset = "0x58")]
    private CanvasGroup canvasGroup;

    [Token(Token = "0x600DAC6")]
    [Address(RVA = "0x21464D0", Offset = "0x21464D0", VA = "0x21464D0", Slot = "4")]
    protected override void Initialize()
    {
    }

    [Token(Token = "0x600DAC7")]
    [Address(RVA = "0x2146644", Offset = "0x2146644", VA = "0x2146644", Slot = "5")]
    public override void Open(UnitParameterData unit)
    {
    }

    [Token(Token = "0x600DAC8")]
    [Address(RVA = "0x2146850", Offset = "0x2146850", VA = "0x2146850", Slot = "6")]
    protected override IEnumerator OpenTimeLine() => (IEnumerator) null;

    [Token(Token = "0x600DAC9")]
    [Address(RVA = "0x21468E0", Offset = "0x21468E0", VA = "0x21468E0", Slot = "7")]
    public override void Close()
    {
    }

    [Token(Token = "0x600DACA")]
    [Address(RVA = "0x2146AF4", Offset = "0x2146AF4", VA = "0x2146AF4", Slot = "8")]
    protected override IEnumerator CloseTimeLine() => (IEnumerator) null;

    [Token(Token = "0x600DACB")]
    [Address(RVA = "0x21466B0", Offset = "0x21466B0", VA = "0x21466B0")]
    private void ShowInterectCommand()
    {
    }

    [Token(Token = "0x600DACC")]
    [Address(RVA = "0x2146B84", Offset = "0x2146B84", VA = "0x2146B84")]
    public void HideInterectButton()
    {
    }

    [Token(Token = "0x600DACD")]
    [Address(RVA = "0x2146BD4", Offset = "0x2146BD4", VA = "0x2146BD4", Slot = "9")]
    protected override void HidePanelButton()
    {
    }

    [Token(Token = "0x600DACE")]
    [Address(RVA = "0x2146C24", Offset = "0x2146C24", VA = "0x2146C24")]
    public InteractCommandPanel()
    {
    }

    [Token(Token = "0x20023C1")]
    private class InteractUIName
    {
      [Token(Token = "0x4009868")]
      public const string OpenTimeLineName = "Layout_Command_Intreract_In";
      [Token(Token = "0x4009869")]
      public const string CloseTimeLineName = "Layout_Command_Intreract_Return";

      [Token(Token = "0x600DAD6")]
      [Address(RVA = "0x2146CE8", Offset = "0x2146CE8", VA = "0x2146CE8")]
      public InteractUIName()
      {
      }
    }
  }
}
