// Decompiled with JetBrains decompiler
// Type: Scenes.Raid.Popup.GuildRaidBossReward.GuildRaidDamageRateRewardContent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.MasterData;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Scenes.Raid.Popup.GuildRaidBossReward
{
  [Token(Token = "0x2002A03")]
  internal class GuildRaidDamageRateRewardContent : MonoBehaviour
  {
    [Token(Token = "0x400B2E7")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GuildRaidRewardItemIconBase raidRewardItemIconBase;
    [Token(Token = "0x400B2E8")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private List<GuildRaidDamagePercentageText> percentageTexts;
    [Token(Token = "0x400B2E9")]
    [FieldOffset(Offset = "0x28")]
    [Header("虫眼鏡アイコン")]
    [SerializeField]
    private CommonButton searchButton;
    [Token(Token = "0x400B2EA")]
    [FieldOffset(Offset = "0x30")]
    private RewardContentBase contentBase;

    [Token(Token = "0x6010780")]
    [Address(RVA = "0x48932B0", Offset = "0x48932B0", VA = "0x48932B0")]
    public void Setup(
      AssetCachedSpawner assetCachedSpawner,
      List<GuildRaidRewardSuppressDetailData> data,
      Action<RewardTypeEnum, int> openItemDetailAction)
    {
    }

    [Token(Token = "0x6010781")]
    [Address(RVA = "0x489386C", Offset = "0x489386C", VA = "0x489386C")]
    private void OpenSystemPopup()
    {
    }

    [Token(Token = "0x6010782")]
    [Address(RVA = "0x4893B58", Offset = "0x4893B58", VA = "0x4893B58")]
    public GuildRaidDamageRateRewardContent()
    {
    }
  }
}
