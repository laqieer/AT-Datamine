// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.Mindequipment.ConversionCompleted.ConversionCompletedView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.OutGameMenu.Mindequipment.ConversionCompleted
{
  [Token(Token = "0x2003C0F")]
  public class ConversionCompletedView : MonoBehaviour
  {
    [Token(Token = "0x4010A14")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Image _medalItemImage;
    [Token(Token = "0x4010A15")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text _medalItemName;
    [Token(Token = "0x4010A16")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Text _textGetMedalNum;
    [Token(Token = "0x4010A17")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Text _textBeforeMedalNum;
    [Token(Token = "0x4010A18")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Text _textAfterMedalNum;
    [Token(Token = "0x4010A19")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private CommonButton _buttonClose;

    [Token(Token = "0x60179B7")]
    [Address(RVA = "0x237F800", Offset = "0x237F800", VA = "0x237F800")]
    public void SetMedalItemImage(Sprite thumb)
    {
    }

    [Token(Token = "0x60179B8")]
    [Address(RVA = "0x237F624", Offset = "0x237F624", VA = "0x237F624")]
    public void SetMedalName(string name)
    {
    }

    [Token(Token = "0x60179B9")]
    [Address(RVA = "0x237F648", Offset = "0x237F648", VA = "0x237F648")]
    public void SetMedalNum(int get, int before, int after)
    {
    }

    [Token(Token = "0x60179BA")]
    [Address(RVA = "0x237F6F4", Offset = "0x237F6F4", VA = "0x237F6F4")]
    public void SetButtonCloseEvent(UnityAction callback)
    {
    }

    [Token(Token = "0x60179BB")]
    [Address(RVA = "0x237F81C", Offset = "0x237F81C", VA = "0x237F81C")]
    public ConversionCompletedView()
    {
    }
  }
}
