// Decompiled with JetBrains decompiler
// Type: Scenes.Expedition.Popup.ExpeditionBossInsufficientCountPopup
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
  [Token(Token = "0x2002C6A")]
  public class ExpeditionBossInsufficientCountPopup : PopupBase
  {
    [Token(Token = "0x400BD36")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private CommonButton closeButton;
    [Token(Token = "0x400BD37")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private CommonButton lawButton;
    [Token(Token = "0x400BD38")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private Text ticketsCountText;
    [Token(Token = "0x400BD39")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private UITweenGroup ticketCountTween;
    [Token(Token = "0x400BD3A")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private CommonButton ticketUseButton;
    [Token(Token = "0x400BD3B")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private Text ticketsRemainingCountText;
    [Token(Token = "0x400BD3C")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    private Text stoneNeedCountText;
    [Token(Token = "0x400BD3D")]
    [FieldOffset(Offset = "0xC0")]
    [SerializeField]
    private Text paidCoinCountText;
    [Token(Token = "0x400BD3E")]
    [FieldOffset(Offset = "0xC8")]
    [SerializeField]
    private Text freeCoinStoneCountText;
    [Token(Token = "0x400BD3F")]
    [FieldOffset(Offset = "0xD0")]
    [SerializeField]
    private UITweenGroup paidCoinCountTween;
    [Token(Token = "0x400BD40")]
    [FieldOffset(Offset = "0xD8")]
    [SerializeField]
    private UITweenGroup freeCoinCountTween;
    [Token(Token = "0x400BD41")]
    [FieldOffset(Offset = "0xE0")]
    [SerializeField]
    private CommonButton stoneUseButton;
    [Token(Token = "0x400BD42")]
    [FieldOffset(Offset = "0xE8")]
    [SerializeField]
    private Text stoneRemainingCountText;
    [Token(Token = "0x400BD43")]
    [FieldOffset(Offset = "0xF0")]
    private Action closeAction;
    [Token(Token = "0x400BD44")]
    [FieldOffset(Offset = "0xF8")]
    private Action ticketUseAction;
    [Token(Token = "0x400BD45")]
    [FieldOffset(Offset = "0x100")]
    private Action stoneUseAction;
    [Token(Token = "0x400BD46")]
    [FieldOffset(Offset = "0x108")]
    private bool isCoinShortage;
    [Token(Token = "0x400BD47")]
    [FieldOffset(Offset = "0x109")]
    private bool isCoinCounterEmpty;
    [Token(Token = "0x400BD48")]
    [FieldOffset(Offset = "0x110")]
    private AssetCachedSpawner assetCachedSpawner;

    [Token(Token = "0x601163E")]
    [Address(RVA = "0x4E1D960", Offset = "0x4E1D960", VA = "0x4E1D960")]
    private static int GetTicketId() => new int();

    [Token(Token = "0x601163F")]
    [Address(RVA = "0x4E1DA08", Offset = "0x4E1DA08", VA = "0x4E1DA08")]
    public void Initialized(
      AssetCachedSpawner assetCachedSpawner,
      Action closeAction,
      Action ticketUseAction,
      Action stoneUseAction)
    {
    }

    [Token(Token = "0x6011640")]
    [Address(RVA = "0x4E1E0E8", Offset = "0x4E1E0E8", VA = "0x4E1E0E8")]
    public ExpeditionBossInsufficientCountPopup()
    {
    }
  }
}
