// Decompiled with JetBrains decompiler
// Type: GameCore.Popup.CommonButtonGroup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

#nullable disable
namespace GameCore.Popup
{
  [Token(Token = "0x2000CD8")]
  public class CommonButtonGroup : MonoBehaviour
  {
    [Token(Token = "0x400398A")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private CommonButtonGroup.ButtonData buttonCancel;
    [Token(Token = "0x400398B")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private CommonButtonGroup.ButtonData buttonOther;
    [Token(Token = "0x400398C")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private CommonButtonGroup.ButtonData buttonDecide;
    [Token(Token = "0x400398D")]
    [FieldOffset(Offset = "0x48")]
    private CommonButtonContent content;

    [Token(Token = "0x60049DE")]
    [Address(RVA = "0x313BCF0", Offset = "0x313BCF0", VA = "0x313BCF0")]
    public void SetButtonContent(CommonButtonContent content)
    {
    }

    [Token(Token = "0x60049DF")]
    [Address(RVA = "0x313BE30", Offset = "0x313BE30", VA = "0x313BE30")]
    public void SetText(string text)
    {
    }

    [Token(Token = "0x60049E0")]
    [Address(RVA = "0x313B07C", Offset = "0x313B07C", VA = "0x313B07C")]
    public void SetInteractableDisabledColor(bool isDisabled)
    {
    }

    [Token(Token = "0x60049E1")]
    [Address(RVA = "0x313BEEC", Offset = "0x313BEEC", VA = "0x313BEEC")]
    public void SetButtonActive(CommonButtonType buttonType)
    {
    }

    [Token(Token = "0x60049E2")]
    [Address(RVA = "0x313C0A8", Offset = "0x313C0A8", VA = "0x313C0A8")]
    public void SetEnableAll()
    {
    }

    [Token(Token = "0x60049E3")]
    [Address(RVA = "0x313C0CC", Offset = "0x313C0CC", VA = "0x313C0CC")]
    public void SetDisableAll()
    {
    }

    [Token(Token = "0x60049E4")]
    [Address(RVA = "0x313BF80", Offset = "0x313BF80", VA = "0x313BF80")]
    public void AddListener(UnityAction call)
    {
    }

    [Token(Token = "0x60049E5")]
    [Address(RVA = "0x313C0F8", Offset = "0x313C0F8", VA = "0x313C0F8")]
    public void RemoveListener(UnityAction call)
    {
    }

    [Token(Token = "0x60049E6")]
    [Address(RVA = "0x313C1BC", Offset = "0x313C1BC", VA = "0x313C1BC")]
    public void RemoveAllListeners()
    {
    }

    [Token(Token = "0x60049E7")]
    [Address(RVA = "0x313C044", Offset = "0x313C044", VA = "0x313C044")]
    private void SetAllButton(Action<CommonButtonGroup.ButtonData> action)
    {
    }

    [Token(Token = "0x60049E8")]
    [Address(RVA = "0x313C2A0", Offset = "0x313C2A0", VA = "0x313C2A0")]
    public CommonButtonGroup()
    {
    }

    [Token(Token = "0x2000CD9")]
    [Serializable]
    private struct ButtonData
    {
      [Token(Token = "0x400398E")]
      [FieldOffset(Offset = "0x0")]
      [SerializeField]
      public CommonButton button;
      [Token(Token = "0x400398F")]
      [FieldOffset(Offset = "0x8")]
      [SerializeField]
      public Text text;
    }
  }
}
