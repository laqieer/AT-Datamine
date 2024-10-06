// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.GlobalShop.ReloadStonePopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using GameCore.Popup;
using GameCore.Tween;
using Il2CppDummyDll;
using Network.Param;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.OutGameMenu.GlobalShop
{
  [Token(Token = "0x2003BC4")]
  public class ReloadStonePopup : PopupBase
  {
    [Token(Token = "0x4010874")]
    private const string TWEEN_NORMAL_TEXT_COLOR = "NormalValueColor";
    [Token(Token = "0x4010875")]
    private const string TWEEN_ALERT_TEXT_COLOR = "MinusValueColor";
    [Token(Token = "0x4010876")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private Text updateTime;
    [Token(Token = "0x4010877")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private Text necessaryCost;
    [Token(Token = "0x4010878")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private Text paidAfterCoin;
    [Token(Token = "0x4010879")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private Text freeAfterCoin;
    [Token(Token = "0x401087A")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private Button confrimButton;
    [Token(Token = "0x401087B")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private Text specialCommercialLawButtonTxt;
    [Token(Token = "0x401087C")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x401087D")]
    [FieldOffset(Offset = "0xC0")]
    private bool isComfirm;
    [Token(Token = "0x4010880")]
    [FieldOffset(Offset = "0xD8")]
    private DateTime? limitTime;
    [Token(Token = "0x4010881")]
    [FieldOffset(Offset = "0xE8")]
    private TimeSpan? subTime;
    [Token(Token = "0x4010882")]
    [FieldOffset(Offset = "0xF8")]
    private PaymentTypeEnum paymentType;
    [Token(Token = "0x4010883")]
    [FieldOffset(Offset = "0xFC")]
    private bool isEndLimit;
    [Token(Token = "0x4010884")]
    [FieldOffset(Offset = "0x100")]
    private int cost;

    [Token(Token = "0x17004C55")]
    public Action<bool> OnClickConfrim
    {
      [Token(Token = "0x60177F3"), Address(RVA = "0x265A3BC", Offset = "0x265A3BC", VA = "0x265A3BC")] get
      {
        return (Action<bool>) null;
      }
      [Token(Token = "0x60177F4"), Address(RVA = "0x265A3C4", Offset = "0x265A3C4", VA = "0x265A3C4")] set
      {
      }
    }

    [Token(Token = "0x17004C56")]
    public Action OnClickCancel
    {
      [Token(Token = "0x60177F5"), Address(RVA = "0x265A3CC", Offset = "0x265A3CC", VA = "0x265A3CC")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x60177F6"), Address(RVA = "0x265A3D4", Offset = "0x265A3D4", VA = "0x265A3D4")] set
      {
      }
    }

    [Token(Token = "0x60177F7")]
    [Address(RVA = "0x264EFAC", Offset = "0x264EFAC", VA = "0x264EFAC")]
    public void SetData(PlayerShopResetButtonType resetButtonType)
    {
    }

    [Token(Token = "0x60177F8")]
    [Address(RVA = "0x265A480", Offset = "0x265A480", VA = "0x265A480")]
    private void Update()
    {
    }

    [Token(Token = "0x60177F9")]
    [Address(RVA = "0x265A710", Offset = "0x265A710", VA = "0x265A710")]
    public void OnClickToConfirm()
    {
    }

    [Token(Token = "0x60177FA")]
    [Address(RVA = "0x265A730", Offset = "0x265A730", VA = "0x265A730")]
    public void OnClickToCancel()
    {
    }

    [Token(Token = "0x60177FB")]
    [Address(RVA = "0x265A74C", Offset = "0x265A74C", VA = "0x265A74C")]
    public void OnClickToSpecifiedCommercialTransactionsAct()
    {
    }

    [Token(Token = "0x60177FC")]
    [Address(RVA = "0x265A3DC", Offset = "0x265A3DC", VA = "0x265A3DC")]
    private void SetButtonText()
    {
    }

    [Token(Token = "0x60177FD")]
    [Address(RVA = "0x265A754", Offset = "0x265A754", VA = "0x265A754")]
    public ReloadStonePopup()
    {
    }
  }
}
