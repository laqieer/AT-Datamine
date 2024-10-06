// Decompiled with JetBrains decompiler
// Type: Scenes.Raid.Popup.RewardItemIcon.ISetupDisplayRewardItemIcon
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.MasterData;
using Il2CppDummyDll;
using System;

#nullable disable
namespace Scenes.Raid.Popup.RewardItemIcon
{
  [Token(Token = "0x20029F4")]
  internal interface ISetupDisplayRewardItemIcon
  {
    [Token(Token = "0x6010755")]
    void ItemIconSetDisplay(
      AssetCachedSpawner assetCachedSpawner,
      GuildRaidRewardItemIconBase itemIconBase,
      RewardItemParameter parameter,
      Action<RewardTypeEnum, int> openItemDetailAction);
  }
}
