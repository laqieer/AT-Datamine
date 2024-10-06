// Decompiled with JetBrains decompiler
// Type: Scenes.Raid.Popup.GuildRaidLapReward.GuildRaidLapRewardPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.MasterData;
using Il2CppDummyDll;
using Scenes.Raid.Popup.GuildRaidAnimation;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Scenes.Raid.Popup.GuildRaidLapReward
{
  [Token(Token = "0x20029FC")]
  internal class GuildRaidLapRewardPopup : GuildRaidRewardPopupBase
  {
    [Token(Token = "0x400B2D5")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    [Header("毎ラップ報酬")]
    private GuildRaidLapRewardContent guildRaidEveryLapRewardContent;
    [Token(Token = "0x400B2D6")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    [Header("特定ラップ報酬")]
    private GuildRaidSpecialLapRewardContainer guildRaidSpecialLapRewardContainer;
    [Token(Token = "0x400B2D7")]
    [FieldOffset(Offset = "0xB8")]
    private IGuildRaidAnimation popupAnimation;
    [Token(Token = "0x400B2D8")]
    [FieldOffset(Offset = "0xC0")]
    private AssetCachedSpawner assetCachedSpawner;

    [Token(Token = "0x6010764")]
    [Address(RVA = "0x488CFEC", Offset = "0x488CFEC", VA = "0x488CFEC")]
    public static void Create(
      AssetCachedSpawner assetCachedSpawner,
      Action<GuildRaidLapRewardPopup> onFinish)
    {
    }

    [Token(Token = "0x6010765")]
    [Address(RVA = "0x488DD48", Offset = "0x488DD48", VA = "0x488DD48")]
    public void Open(int raidId, int clearLap, Action<RewardTypeEnum, int> openItemDetailAction)
    {
    }

    [Token(Token = "0x6010766")]
    [Address(RVA = "0x4892340", Offset = "0x4892340", VA = "0x4892340")]
    private void Init(AssetCachedSpawner assetCachedSpawner)
    {
    }

    [Token(Token = "0x6010767")]
    [Address(RVA = "0x4891F3C", Offset = "0x4891F3C", VA = "0x4891F3C")]
    private void Setup(int raidId, int clearLap, Action<RewardTypeEnum, int> openItemDetailAction)
    {
    }

    [Token(Token = "0x6010768")]
    [Address(RVA = "0x4892424", Offset = "0x4892424", VA = "0x4892424")]
    private IEnumerable<GuildRaidRewardLapDetailData> GetRewardLapDetailData(int lapRewardId)
    {
      return (IEnumerable<GuildRaidRewardLapDetailData>) null;
    }

    [Token(Token = "0x6010769")]
    [Address(RVA = "0x48924AC", Offset = "0x48924AC", VA = "0x48924AC")]
    private List<GuildRaidRewardSpecialLapDetailData> GetRewardSpecialLapDataBySpecialLapRewardId(
      int specialLapRewardId)
    {
      return (List<GuildRaidRewardSpecialLapDetailData>) null;
    }

    [Token(Token = "0x601076A")]
    [Address(RVA = "0x4892534", Offset = "0x4892534", VA = "0x4892534")]
    private IEnumerable<int> GetRewardLaps(int specialLapRewardId) => (IEnumerable<int>) null;

    [Token(Token = "0x601076B")]
    [Address(RVA = "0x4892B58", Offset = "0x4892B58", VA = "0x4892B58")]
    public GuildRaidLapRewardPopup()
    {
    }
  }
}
