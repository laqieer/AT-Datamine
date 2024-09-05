// Decompiled with JetBrains decompiler
// Type: Scenes.Raid.Popup.RewardItemIcon.SetupDisplayStyleThumb
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
  [Token(Token = "0x20029F9")]
  internal class SetupDisplayStyleThumb : ISetupDisplayRewardItemIcon
  {
    [Token(Token = "0x601075E")]
    [Address(RVA = "0x4891A2C", Offset = "0x4891A2C", VA = "0x4891A2C", Slot = "4")]
    public void ItemIconSetDisplay(
      AssetCachedSpawner assetCachedSpawner,
      GuildRaidRewardItemIconBase itemIconBase,
      RewardItemParameter parameter,
      Action<RewardTypeEnum, int> openItemDetailAction)
    {
    }

    [Token(Token = "0x601075F")]
    [Address(RVA = "0x48914D8", Offset = "0x48914D8", VA = "0x48914D8")]
    public SetupDisplayStyleThumb()
    {
    }
  }
}
