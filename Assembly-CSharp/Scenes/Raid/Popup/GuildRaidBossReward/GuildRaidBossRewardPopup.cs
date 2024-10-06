// Decompiled with JetBrains decompiler
// Type: Scenes.Raid.Popup.GuildRaidBossReward.GuildRaidBossRewardPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.MasterData;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Raid.Popup.GuildRaidBossReward
{
  [Token(Token = "0x2002A00")]
  internal class GuildRaidBossRewardPopup : GuildRaidRewardPopupBase
  {
    [Token(Token = "0x400B2E0")]
    [FieldOffset(Offset = "0xA8")]
    [Header("ボスのimage")]
    [SerializeField]
    private Image bossStyleImage;
    [Token(Token = "0x400B2E1")]
    [FieldOffset(Offset = "0xB0")]
    [Header("撃破報酬")]
    [SerializeField]
    private GuildRaidDefeatBossRewardContent defeatBossRewardContent;
    [Token(Token = "0x400B2E2")]
    [FieldOffset(Offset = "0xB8")]
    [FormerlySerializedAs("damagePercentageRewardContent")]
    [Header("HP割合報酬")]
    [SerializeField]
    private GuildRaidDamageRateRewardContent damageRateRewardContent;
    [Token(Token = "0x400B2E3")]
    [FieldOffset(Offset = "0xC0")]
    private AssetCachedSpawner assetCachedSpawner;

    [Token(Token = "0x6010774")]
    [Address(RVA = "0x4887248", Offset = "0x4887248", VA = "0x4887248")]
    public static void Create(
      AssetCachedSpawner assetCachedSpawner,
      Action<GuildRaidBossRewardPopup> onFinish)
    {
    }

    [Token(Token = "0x6010775")]
    [Address(RVA = "0x4888C94", Offset = "0x4888C94", VA = "0x4888C94")]
    public void Open(
      int raidQuestSuppressId,
      int bossStyleId,
      Action<RewardTypeEnum, int> openItemDetailAction)
    {
    }

    [Token(Token = "0x6010776")]
    [Address(RVA = "0x4892F34", Offset = "0x4892F34", VA = "0x4892F34")]
    private void Init(AssetCachedSpawner assetCachedSpawner)
    {
    }

    [Token(Token = "0x6010777")]
    [Address(RVA = "0x4892D90", Offset = "0x4892D90", VA = "0x4892D90")]
    private void Setup(
      int raidQuestSuppressId,
      int bossStyleId,
      Action<RewardTypeEnum, int> openItemDetailAction)
    {
    }

    [Token(Token = "0x6010778")]
    [Address(RVA = "0x4893698", Offset = "0x4893698", VA = "0x4893698")]
    private void SetupSprite(Sprite sprite)
    {
    }

    [Token(Token = "0x6010779")]
    [Address(RVA = "0x4893040", Offset = "0x4893040", VA = "0x4893040")]
    private bool TryGetRewardSuppressDetailData(
      int raidQuestSuppressId,
      out List<GuildRaidRewardSuppressDetailData> defeatBossRewardItemData,
      out List<GuildRaidRewardSuppressDetailData> damageRateRewardItemData)
    {
      return new bool();
    }

    [Token(Token = "0x601077A")]
    [Address(RVA = "0x48936C0", Offset = "0x48936C0", VA = "0x48936C0")]
    public GuildRaidBossRewardPopup()
    {
    }
  }
}
