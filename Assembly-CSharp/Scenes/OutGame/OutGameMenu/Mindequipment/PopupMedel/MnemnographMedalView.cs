// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.Mindequipment.PopupMedel.MnemnographMedalView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.OutGameMenu.Mindequipment.PopupMedel
{
  [Token(Token = "0x2003C07")]
  public class MnemnographMedalView : MonoBehaviour
  {
    [Token(Token = "0x40109F4")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text _title;
    [Token(Token = "0x40109F5")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Image _mnemnographImage;
    [Token(Token = "0x40109F6")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Image _medalItemImage;
    [Token(Token = "0x40109F7")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Text _conversionCount;
    [Token(Token = "0x40109F8")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private CommonButton _cursorDecMax;
    [Token(Token = "0x40109F9")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private CommonButton _cursorDec;
    [Token(Token = "0x40109FA")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private CommonButton _cursorInc;
    [Token(Token = "0x40109FB")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private CommonButton _cursorIncMax;
    [Token(Token = "0x40109FC")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private Image _presentItemImage;
    [Token(Token = "0x40109FD")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private Text _presentItemName;
    [Token(Token = "0x40109FE")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private Text _presentItemCount;
    [Token(Token = "0x40109FF")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private CommonButton _buttonCancel;
    [Token(Token = "0x4010A00")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private CommonButton _buttonConversion;

    [Token(Token = "0x601798C")]
    [Address(RVA = "0x237E6CC", Offset = "0x237E6CC", VA = "0x237E6CC")]
    public void SetTitle(string text)
    {
    }

    [Token(Token = "0x601798D")]
    [Address(RVA = "0x237E99C", Offset = "0x237E99C", VA = "0x237E99C")]
    public void SetMnemnographImage(Sprite thumb)
    {
    }

    [Token(Token = "0x601798E")]
    [Address(RVA = "0x237EA44", Offset = "0x237EA44", VA = "0x237EA44")]
    public void SetMedalImage(Sprite thumb)
    {
    }

    [Token(Token = "0x601798F")]
    [Address(RVA = "0x237EAF4", Offset = "0x237EAF4", VA = "0x237EAF4")]
    public void SetCoversionCount(int count)
    {
    }

    [Token(Token = "0x6017990")]
    [Address(RVA = "0x237E714", Offset = "0x237E714", VA = "0x237E714")]
    public void SetCursorButtonEvent(
      UnityAction decMax,
      UnityAction dec,
      UnityAction inc,
      UnityAction incMax)
    {
    }

    [Token(Token = "0x6017991")]
    [Address(RVA = "0x237EBB0", Offset = "0x237EBB0", VA = "0x237EBB0")]
    public void SetPresentItemCount(int count)
    {
    }

    [Token(Token = "0x6017992")]
    [Address(RVA = "0x237EB3C", Offset = "0x237EB3C", VA = "0x237EB3C")]
    public void SetCursorButtonEnable(bool dec, bool inc)
    {
    }

    [Token(Token = "0x6017993")]
    [Address(RVA = "0x237ECC8", Offset = "0x237ECC8", VA = "0x237ECC8")]
    public void SetPresentItemName(string name)
    {
    }

    [Token(Token = "0x6017994")]
    [Address(RVA = "0x237E6F0", Offset = "0x237E6F0", VA = "0x237E6F0")]
    public void SetMedalName(string name)
    {
    }

    [Token(Token = "0x6017995")]
    [Address(RVA = "0x237E814", Offset = "0x237E814", VA = "0x237E814")]
    public void SetButtonCancelEvent(UnityAction callback)
    {
    }

    [Token(Token = "0x6017996")]
    [Address(RVA = "0x237E864", Offset = "0x237E864", VA = "0x237E864")]
    public void SetButtonConversionEvent(UnityAction callback)
    {
    }

    [Token(Token = "0x6017997")]
    [Address(RVA = "0x237ECEC", Offset = "0x237ECEC", VA = "0x237ECEC")]
    public MnemnographMedalView()
    {
    }
  }
}
