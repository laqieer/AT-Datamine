// Decompiled with JetBrains decompiler
// Type: Scenes.Raid.Popup.GuildRaidBossReward.GuildRaidDefeatBossRewardContent
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
  [Token(Token = "0x2002A05")]
  internal class GuildRaidDefeatBossRewardContent : MonoBehaviour
  {
    [Token(Token = "0x400B2EE")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GuildRaidRewardItemIconBase raidRewardItemIconBase;
    [Token(Token = "0x400B2EF")]
    [FieldOffset(Offset = "0x20")]
    private RewardContentBase contentBase;

    [Token(Token = "0x6010787")]
    [Address(RVA = "0x48930FC", Offset = "0x48930FC", VA = "0x48930FC")]
    public void Setup(
      AssetCachedSpawner assetCachedSpawner,
      List<GuildRaidRewardSuppressDetailData> data,
      Action<RewardTypeEnum, int> openItemDetailAction)
    {
    }

    [Token(Token = "0x6010788")]
    [Address(RVA = "0x4893CEC", Offset = "0x4893CEC", VA = "0x4893CEC")]
    public GuildRaidDefeatBossRewardContent()
    {
    }
  }
}
