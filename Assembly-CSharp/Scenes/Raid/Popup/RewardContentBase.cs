// Decompiled with JetBrains decompiler
// Type: Scenes.Raid.Popup.RewardContentBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.MasterData;
using Il2CppDummyDll;
using Scenes.Raid.Popup.RewardItemIcon;
using System;
using System.Collections.Generic;

#nullable disable
namespace Scenes.Raid.Popup
{
  [Token(Token = "0x20029F3")]
  internal class RewardContentBase
  {
    [Token(Token = "0x400B2CA")]
    [FieldOffset(Offset = "0x10")]
    private readonly GuildRaidRewardItemIconBase itemIconBase;
    [Token(Token = "0x400B2CB")]
    [FieldOffset(Offset = "0x18")]
    private readonly AssetCachedSpawner assetCachedSpawner;
    [Token(Token = "0x400B2CC")]
    [FieldOffset(Offset = "0x20")]
    private readonly Dictionary<string, ISetupDisplayRewardItemIcon> itemIconSetupDisplays;

    [Token(Token = "0x6010752")]
    [Address(RVA = "0x4891310", Offset = "0x4891310", VA = "0x4891310")]
    public RewardContentBase(
      GuildRaidRewardItemIconBase itemIconBase,
      AssetCachedSpawner assetCachedSpawner)
    {
    }

    [Token(Token = "0x6010753")]
    [Address(RVA = "0x48914F0", Offset = "0x48914F0", VA = "0x48914F0")]
    public void RewardItemIconSetupDisplay(
      RewardItemParameter parameter,
      Action<RewardTypeEnum, int> openItemDetailAction)
    {
    }

    [Token(Token = "0x6010754")]
    [Address(RVA = "0x489160C", Offset = "0x489160C", VA = "0x489160C")]
    private string GetRewardItemIconKey(RewardTypeEnum rewardType) => (string) null;
  }
}
