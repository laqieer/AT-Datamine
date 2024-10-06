// Decompiled with JetBrains decompiler
// Type: Scenes.Expedition.Popup.CharacterUnlockConfirmPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.Popup;
using GameCore.Tween;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Expedition.Popup
{
  [Token(Token = "0x2002C59")]
  public class CharacterUnlockConfirmPopup : PopupBase
  {
    [Token(Token = "0x400BCEC")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private Image SlotNumber;
    [Token(Token = "0x400BCED")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private Text textConfirm;
    [Token(Token = "0x400BCEE")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private Text paidCoinCountText;
    [Token(Token = "0x400BCEF")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private UITweenGroup paidCoinTween;
    [Token(Token = "0x400BCF0")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private Text freeCoinCountText;
    [Token(Token = "0x400BCF1")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private UITweenGroup freeCoinTween;
    [Token(Token = "0x400BCF4")]
    [FieldOffset(Offset = "0xC8")]
    private bool isCoinShortage;
    [Token(Token = "0x400BCF5")]
    [FieldOffset(Offset = "0xD0")]
    private AssetCachedSpawner assetCachedSpawner;
    [Token(Token = "0x400BCF6")]
    [FieldOffset(Offset = "0xD8")]
    private Action onClickLawButton;

    [Token(Token = "0x17003BF1")]
    public Action CallbackDecision
    {
      [Token(Token = "0x60115EA"), Address(RVA = "0x4E1A57C", Offset = "0x4E1A57C", VA = "0x4E1A57C")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x60115EB"), Address(RVA = "0x4E1A584", Offset = "0x4E1A584", VA = "0x4E1A584")] set
      {
      }
    }

    [Token(Token = "0x17003BF2")]
    public Action CallbackCancel
    {
      [Token(Token = "0x60115EC"), Address(RVA = "0x4E1A58C", Offset = "0x4E1A58C", VA = "0x4E1A58C")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x60115ED"), Address(RVA = "0x4E1A594", Offset = "0x4E1A594", VA = "0x4E1A594")] set
      {
      }
    }

    [Token(Token = "0x60115EE")]
    [Address(RVA = "0x4E1A59C", Offset = "0x4E1A59C", VA = "0x4E1A59C")]
    public void Initialize(AssetCachedSpawner assetCachedSpawner)
    {
    }

    [Token(Token = "0x60115EF")]
    [Address(RVA = "0x4E1A5A4", Offset = "0x4E1A5A4", VA = "0x4E1A5A4")]
    public void SetData(int slotIndex, int needCount)
    {
    }

    [Token(Token = "0x60115F0")]
    [Address(RVA = "0x4E1A8A8", Offset = "0x4E1A8A8", VA = "0x4E1A8A8")]
    private void UpdateUnitNumber(int slotIndex)
    {
    }

    [Token(Token = "0x60115F1")]
    [Address(RVA = "0x4E1A9FC", Offset = "0x4E1A9FC", VA = "0x4E1A9FC")]
    public void OnClickDecision()
    {
    }

    [Token(Token = "0x60115F2")]
    [Address(RVA = "0x4E1AA34", Offset = "0x4E1AA34", VA = "0x4E1AA34")]
    public void OnClickToClose()
    {
    }

    [Token(Token = "0x60115F3")]
    [Address(RVA = "0x4E1AA50", Offset = "0x4E1AA50", VA = "0x4E1AA50")]
    public void OnClickLowButton()
    {
    }

    [Token(Token = "0x60115F4")]
    [Address(RVA = "0x4E1AA6C", Offset = "0x4E1AA6C", VA = "0x4E1AA6C")]
    public CharacterUnlockConfirmPopup()
    {
    }
  }
}
