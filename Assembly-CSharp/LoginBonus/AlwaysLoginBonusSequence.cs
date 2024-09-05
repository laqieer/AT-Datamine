// Decompiled with JetBrains decompiler
// Type: LoginBonus.AlwaysLoginBonusSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.MasterData;
using GameCore.Popup;
using Home;
using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using UI.ItemDetail;
using UI.MultipleItemDetail;

#nullable disable
namespace LoginBonus
{
  [Token(Token = "0x2000AB2")]
  public class AlwaysLoginBonusSequence : ILoginBonusSequence
  {
    [Token(Token = "0x400312C")]
    [FieldOffset(Offset = "0x18")]
    private LoginBonusRewardHolder loginBonusRewardHolder;
    [Token(Token = "0x400312D")]
    [FieldOffset(Offset = "0x20")]
    private LoginBonusLoader loginBonusLoader;
    [Token(Token = "0x400312E")]
    [FieldOffset(Offset = "0x28")]
    private int totalLoginCount;
    [Token(Token = "0x400312F")]
    [FieldOffset(Offset = "0x2C")]
    private int loginBonusId;
    [Token(Token = "0x4003130")]
    [FieldOffset(Offset = "0x30")]
    private AlwaysLoginBonusView loginBonusPrefabAsset;
    [Token(Token = "0x4003131")]
    [FieldOffset(Offset = "0x38")]
    private AlwaysLoginBonusView alwaysLoginBonusView;
    [Token(Token = "0x4003132")]
    [FieldOffset(Offset = "0x40")]
    private ILoginBonus3DEffectPlayer loginBonus3DEffectPlayer;
    [Token(Token = "0x4003133")]
    [FieldOffset(Offset = "0x48")]
    private ItemDetailPopupProvider itemDetailPopupGenerator;
    [Token(Token = "0x4003134")]
    [FieldOffset(Offset = "0x50")]
    private MultipleItemDetailPopupGenerator multipleItemDetailPopupGenerator;
    [Token(Token = "0x4003135")]
    [FieldOffset(Offset = "0x58")]
    private PopupBase openedPopup;
    [Token(Token = "0x4003136")]
    [FieldOffset(Offset = "0x60")]
    private AssetCachedSpawner assetCachedSpawner;

    [Token(Token = "0x170008BD")]
    public bool IsReady
    {
      [Token(Token = "0x6003CD4"), Address(RVA = "0x2C06954", Offset = "0x2C06954", VA = "0x2C06954", Slot = "9")] get
      {
        return new bool();
      }
      [Token(Token = "0x6003CD5"), Address(RVA = "0x2C0695C", Offset = "0x2C0695C", VA = "0x2C0695C")] private set
      {
      }
    }

    [Token(Token = "0x170008BE")]
    public bool IsFinished
    {
      [Token(Token = "0x6003CD6"), Address(RVA = "0x2C06968", Offset = "0x2C06968", VA = "0x2C06968", Slot = "8")] get
      {
        return new bool();
      }
      [Token(Token = "0x6003CD7"), Address(RVA = "0x2C06970", Offset = "0x2C06970", VA = "0x2C06970")] private set
      {
      }
    }

    [Token(Token = "0x170008BF")]
    public bool IsPrepareStartCalled
    {
      [Token(Token = "0x6003CD8"), Address(RVA = "0x2C0697C", Offset = "0x2C0697C", VA = "0x2C0697C", Slot = "7")] get
      {
        return new bool();
      }
      [Token(Token = "0x6003CD9"), Address(RVA = "0x2C06984", Offset = "0x2C06984", VA = "0x2C06984")] private set
      {
      }
    }

    [Token(Token = "0x170008C0")]
    public LoginBonusTypeEnum LoginBonusType
    {
      [Token(Token = "0x6003CDA"), Address(RVA = "0x2C06990", Offset = "0x2C06990", VA = "0x2C06990", Slot = "10")] get
      {
        return new LoginBonusTypeEnum();
      }
      [Token(Token = "0x6003CDB"), Address(RVA = "0x2C06998", Offset = "0x2C06998", VA = "0x2C06998")] private set
      {
      }
    }

    [Token(Token = "0x6003CDC")]
    [Address(RVA = "0x2C069A0", Offset = "0x2C069A0", VA = "0x2C069A0")]
    public AlwaysLoginBonusSequence(AssetCachedSpawner assetCachedSpawner = null)
    {
    }

    [Token(Token = "0x6003CDD")]
    [Address(RVA = "0x2C069C8", Offset = "0x2C069C8", VA = "0x2C069C8")]
    public void Setup(
      int loginBonusId,
      int currentRewardNumber,
      int totalLoginCount,
      ILoginBonus3DEffectPlayer loginBonus3DEffectPlayer,
      LoginBonusTypeEnum typeEnum)
    {
    }

    [Token(Token = "0x6003CDE")]
    [Address(RVA = "0x2C06F40", Offset = "0x2C06F40", VA = "0x2C06F40", Slot = "4")]
    public void PrepareStart()
    {
    }

    [Token(Token = "0x6003CDF")]
    [Address(RVA = "0x2C070FC", Offset = "0x2C070FC", VA = "0x2C070FC")]
    private IEnumerator PrepareStartAsync() => (IEnumerator) null;

    [Token(Token = "0x6003CE0")]
    [Address(RVA = "0x2C0718C", Offset = "0x2C0718C", VA = "0x2C0718C")]
    private IEnumerator WaitForReadyAsync(Action onReady) => (IEnumerator) null;

    [Token(Token = "0x6003CE1")]
    [Address(RVA = "0x2C07228", Offset = "0x2C07228", VA = "0x2C07228", Slot = "5")]
    public void Start()
    {
    }

    [Token(Token = "0x6003CE2")]
    [Address(RVA = "0x2C07328", Offset = "0x2C07328", VA = "0x2C07328")]
    private void StartImple()
    {
    }

    [Token(Token = "0x6003CE3")]
    [Address(RVA = "0x2C07504", Offset = "0x2C07504", VA = "0x2C07504")]
    private IEnumerator EffectRoutine() => (IEnumerator) null;

    [Token(Token = "0x6003CE4")]
    [Address(RVA = "0x2C07594", Offset = "0x2C07594", VA = "0x2C07594", Slot = "6")]
    public void Release()
    {
    }

    [Token(Token = "0x6003CE5")]
    [Address(RVA = "0x2C0785C", Offset = "0x2C0785C", VA = "0x2C0785C")]
    private void OnClickRewardItem(ILoginBonusRewardUIParam param)
    {
    }

    [Token(Token = "0x6003CE6")]
    [Address(RVA = "0x2C08000", Offset = "0x2C08000", VA = "0x2C08000")]
    private void OpenSingleItemDetailPopup(ILoginBonusRewardUIParam param)
    {
    }

    [Token(Token = "0x6003CE7")]
    [Address(RVA = "0x2C07C74", Offset = "0x2C07C74", VA = "0x2C07C74")]
    private void OpenMultipleItemDetailPopup(
      IEnumerable<MultipleItemDetailParamater> multipleItemDetailParamaters)
    {
    }

    [Token(Token = "0x6003CE8")]
    [Address(RVA = "0x2C07E90", Offset = "0x2C07E90", VA = "0x2C07E90")]
    private void OpenOtherDetailPopup(ILoginBonusRewardUIParam param)
    {
    }
  }
}
