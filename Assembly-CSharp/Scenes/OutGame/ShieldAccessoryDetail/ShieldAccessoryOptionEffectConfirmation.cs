// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.ShieldAccessoryDetail.ShieldAccessoryOptionEffectConfirmation
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.Popup;
using Il2CppDummyDll;
using Network.Param;
using Scenes.OutGame.EquipmentDetail;
using StaqData;
using System;
using System.Collections;
using System.Collections.Generic;
using UI.Direction;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.ShieldAccessoryDetail
{
  [Token(Token = "0x20033A9")]
  public class ShieldAccessoryOptionEffectConfirmation : PopupBase
  {
    [Token(Token = "0x400E071")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private UITimelineController timeLineController;
    [Token(Token = "0x400E072")]
    [FieldOffset(Offset = "0x90")]
    private bool isTimelineDirection;
    [Token(Token = "0x400E073")]
    private const string inoutTimeLineAssetbundleName = "ui_page_equipdetail_timeline";
    [Token(Token = "0x400E074")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private WeaponOptionEffectContainer[] weaponOptionEffectContainerBefore;
    [Token(Token = "0x400E075")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private WeaponOptionEffectContainer[] weaponOptionEffectContainerAfter;
    [Token(Token = "0x400E076")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private ContentLotteryResultItem contentLotteryResultItem;
    [Token(Token = "0x400E077")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private CommonButton closeButton;
    [Token(Token = "0x400E078")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    private CommonButton changeButton;
    [Token(Token = "0x400E079")]
    [FieldOffset(Offset = "0xC0")]
    private Accessory dispWeapon;
    [Token(Token = "0x400E07A")]
    [FieldOffset(Offset = "0xC8")]
    private int selectNum;
    [Token(Token = "0x400E07B")]
    [FieldOffset(Offset = "0xD0")]
    private List<PlayerGearOptionCandidateType> playerGearOptionCandidateType;
    [Token(Token = "0x400E07C")]
    [FieldOffset(Offset = "0xD8")]
    private List<ContentLotteryResultItem> contentLotteryResultItems;
    [Token(Token = "0x400E07E")]
    [FieldOffset(Offset = "0xE8")]
    private AssetCachedSpawner assetCachedSpawner;

    [Token(Token = "0x170043B5")]
    public Action OnCloseEvent
    {
      [Token(Token = "0x6014505"), Address(RVA = "0x206BAD8", Offset = "0x206BAD8", VA = "0x206BAD8")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x6014506"), Address(RVA = "0x206BAE0", Offset = "0x206BAE0", VA = "0x206BAE0")] set
      {
      }
    }

    [Token(Token = "0x6014507")]
    [Address(RVA = "0x206A990", Offset = "0x206A990", VA = "0x206A990")]
    public void Initialize(
      AssetCachedSpawner assetCachedSpawner,
      List<PlayerGearOptionCandidateType> effectData,
      Accessory weapon)
    {
    }

    [Token(Token = "0x6014508")]
    [Address(RVA = "0x206AD54", Offset = "0x206AD54", VA = "0x206AD54")]
    public void SetEffectBefore(AccessoryOptionEffect[] weaponOptionEffects)
    {
    }

    [Token(Token = "0x6014509")]
    [Address(RVA = "0x206BB9C", Offset = "0x206BB9C", VA = "0x206BB9C")]
    public void SetEffectAfter()
    {
    }

    [Token(Token = "0x601450A")]
    [Address(RVA = "0x206BAF0", Offset = "0x206BAF0", VA = "0x206BAF0")]
    public void SetSelectContent()
    {
    }

    [Token(Token = "0x601450B")]
    [Address(RVA = "0x206BCC0", Offset = "0x206BCC0", VA = "0x206BCC0", Slot = "8")]
    public override void Open()
    {
    }

    [Token(Token = "0x601450C")]
    [Address(RVA = "0x206BD64", Offset = "0x206BD64", VA = "0x206BD64", Slot = "9")]
    public override void Close()
    {
    }

    [Token(Token = "0x601450D")]
    [Address(RVA = "0x206BDF4", Offset = "0x206BDF4", VA = "0x206BDF4", Slot = "6")]
    public override void OnBackClosed()
    {
    }

    [Token(Token = "0x601450E")]
    [Address(RVA = "0x206BE18", Offset = "0x206BE18", VA = "0x206BE18")]
    private IEnumerator CancelApi(Action callback = null) => (IEnumerator) null;

    [Token(Token = "0x601450F")]
    [Address(RVA = "0x206BEB4", Offset = "0x206BEB4", VA = "0x206BEB4")]
    private IEnumerator ChangeApi(Action callback = null) => (IEnumerator) null;

    [Token(Token = "0x6014510")]
    [Address(RVA = "0x206BF50", Offset = "0x206BF50", VA = "0x206BF50")]
    private IEnumerator playTimeline(
      string timeLineSettingNameList,
      UITimelineController.DirectionType inout,
      Action finishAction)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6014511")]
    [Address(RVA = "0x206C004", Offset = "0x206C004", VA = "0x206C004")]
    public ShieldAccessoryOptionEffectConfirmation()
    {
    }
  }
}
