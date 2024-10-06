// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.EquipmentDetail.WeaponOptionEffectConfirmation
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.Popup;
using Il2CppDummyDll;
using Network.Param;
using StaqData;
using System;
using System.Collections;
using System.Collections.Generic;
using UI.Direction;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.EquipmentDetail
{
  [Token(Token = "0x20036BC")]
  public class WeaponOptionEffectConfirmation : PopupBase
  {
    [Token(Token = "0x400EE81")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private UITimelineController timeLineController;
    [Token(Token = "0x400EE82")]
    [FieldOffset(Offset = "0x90")]
    private bool isTimelineDirection;
    [Token(Token = "0x400EE83")]
    private const string inoutTimeLineAssetbundleName = "ui_page_equipdetail_timeline";
    [Token(Token = "0x400EE84")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private WeaponOptionEffectContainer[] weaponOptionEffectContainerBefore;
    [Token(Token = "0x400EE85")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private WeaponOptionEffectContainer[] weaponOptionEffectContainerAfter;
    [Token(Token = "0x400EE86")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private ContentLotteryResultItem contentLotteryResultItem;
    [Token(Token = "0x400EE87")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private CommonButton closeButton;
    [Token(Token = "0x400EE88")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    private CommonButton changeButton;
    [Token(Token = "0x400EE89")]
    [FieldOffset(Offset = "0xC0")]
    private Weapon dispWeapon;
    [Token(Token = "0x400EE8A")]
    [FieldOffset(Offset = "0xC8")]
    private int selectNum;
    [Token(Token = "0x400EE8B")]
    [FieldOffset(Offset = "0xD0")]
    private List<PlayerGearOptionCandidateType> playerGearOptionCandidateType;
    [Token(Token = "0x400EE8C")]
    [FieldOffset(Offset = "0xD8")]
    private List<ContentLotteryResultItem> contentLotteryResultItems;
    [Token(Token = "0x400EE8E")]
    [FieldOffset(Offset = "0xE8")]
    private AssetCachedSpawner assetCachedSpawner;

    [Token(Token = "0x1700475E")]
    public Action OnCloseEvent
    {
      [Token(Token = "0x60158BF"), Address(RVA = "0x1A61878", Offset = "0x1A61878", VA = "0x1A61878")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x60158C0"), Address(RVA = "0x1A61880", Offset = "0x1A61880", VA = "0x1A61880")] set
      {
      }
    }

    [Token(Token = "0x60158C1")]
    [Address(RVA = "0x1A60784", Offset = "0x1A60784", VA = "0x1A60784")]
    public void Initialize(
      AssetCachedSpawner assetCachedSpawner,
      List<PlayerGearOptionCandidateType> effectData,
      Weapon weapon)
    {
    }

    [Token(Token = "0x60158C2")]
    [Address(RVA = "0x1A60B48", Offset = "0x1A60B48", VA = "0x1A60B48")]
    public void SetEffectBefore(StaqData.WeaponOptionEffect[] weaponOptionEffects)
    {
    }

    [Token(Token = "0x60158C3")]
    [Address(RVA = "0x1A6193C", Offset = "0x1A6193C", VA = "0x1A6193C")]
    public void SetEffectAfter()
    {
    }

    [Token(Token = "0x60158C4")]
    [Address(RVA = "0x1A61890", Offset = "0x1A61890", VA = "0x1A61890")]
    public void SetSelectContent()
    {
    }

    [Token(Token = "0x60158C5")]
    [Address(RVA = "0x1A61A5C", Offset = "0x1A61A5C", VA = "0x1A61A5C", Slot = "8")]
    public override void Open()
    {
    }

    [Token(Token = "0x60158C6")]
    [Address(RVA = "0x1A61B00", Offset = "0x1A61B00", VA = "0x1A61B00", Slot = "9")]
    public override void Close()
    {
    }

    [Token(Token = "0x60158C7")]
    [Address(RVA = "0x1A61B90", Offset = "0x1A61B90", VA = "0x1A61B90", Slot = "6")]
    public override void OnBackClosed()
    {
    }

    [Token(Token = "0x60158C8")]
    [Address(RVA = "0x1A61BB4", Offset = "0x1A61BB4", VA = "0x1A61BB4")]
    private IEnumerator CancelApi(Action callback = null) => (IEnumerator) null;

    [Token(Token = "0x60158C9")]
    [Address(RVA = "0x1A61C50", Offset = "0x1A61C50", VA = "0x1A61C50")]
    private IEnumerator ChangeApi(Action callback = null) => (IEnumerator) null;

    [Token(Token = "0x60158CA")]
    [Address(RVA = "0x1A61CEC", Offset = "0x1A61CEC", VA = "0x1A61CEC")]
    private IEnumerator playTimeline(
      string timeLineSettingNameList,
      UITimelineController.DirectionType inout,
      Action finishAction)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60158CB")]
    [Address(RVA = "0x1A61DA0", Offset = "0x1A61DA0", VA = "0x1A61DA0")]
    public WeaponOptionEffectConfirmation()
    {
    }
  }
}
