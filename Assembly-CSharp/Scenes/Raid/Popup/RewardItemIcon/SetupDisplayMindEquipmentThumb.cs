// Decompiled with JetBrains decompiler
// Type: Scenes.Raid.Popup.RewardItemIcon.SetupDisplayMindEquipmentThumb
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
  [Token(Token = "0x20029F7")]
  internal class SetupDisplayMindEquipmentThumb : ISetupDisplayRewardItemIcon
  {
    [Token(Token = "0x601075A")]
    [Address(RVA = "0x4891880", Offset = "0x4891880", VA = "0x4891880", Slot = "4")]
    public void ItemIconSetDisplay(
      AssetCachedSpawner assetCachedSpawner,
      GuildRaidRewardItemIconBase itemIconBase,
      RewardItemParameter parameter,
      Action<RewardTypeEnum, int> openItemDetailAction)
    {
    }

    [Token(Token = "0x601075B")]
    [Address(RVA = "0x48914E0", Offset = "0x48914E0", VA = "0x48914E0")]
    public SetupDisplayMindEquipmentThumb()
    {
    }
  }
}
