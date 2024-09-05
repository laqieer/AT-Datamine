// Decompiled with JetBrains decompiler
// Type: Scenes.Raid.Popup.GuildRaidLapReward.GuildRaidLapRewardContent
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
namespace Scenes.Raid.Popup.GuildRaidLapReward
{
  [Token(Token = "0x20029FB")]
  internal class GuildRaidLapRewardContent : MonoBehaviour
  {
    [Token(Token = "0x400B2D3")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GuildRaidRewardItemIconBase raidRewardItemIconBase;
    [Token(Token = "0x400B2D4")]
    [FieldOffset(Offset = "0x20")]
    private RewardContentBase contentBase;

    [Token(Token = "0x6010762")]
    [Address(RVA = "0x4891BE0", Offset = "0x4891BE0", VA = "0x4891BE0")]
    public void Setup(
      AssetCachedSpawner assetCachedSpawner,
      IEnumerable<GuildRaidRewardLapDetailData> data,
      Action<RewardTypeEnum, int> openItemDetailAction)
    {
    }

    [Token(Token = "0x6010763")]
    [Address(RVA = "0x4891F2C", Offset = "0x4891F2C", VA = "0x4891F2C")]
    public GuildRaidLapRewardContent()
    {
    }
  }
}
