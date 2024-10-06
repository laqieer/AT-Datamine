// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryFreeActionRewardObjectRewardsMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001279")]
  [Serializable]
  public sealed class StoryFreeActionRewardObjectRewardsMaster : 
    BaseMaster<StoryFreeActionRewardObjectRewardsData>
  {
    [Token(Token = "0x6006909")]
    [Address(RVA = "0x48CBD5C", Offset = "0x48CBD5C", VA = "0x48CBD5C")]
    public IReadOnlyDictionary<int, StoryFreeActionRewardObjectRewardsData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryFreeActionRewardObjectRewardsData>) null;
    }

    [Token(Token = "0x600690A")]
    [Address(RVA = "0x48CBD64", Offset = "0x48CBD64", VA = "0x48CBD64", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x600690B")]
    [Address(RVA = "0x48CBDC4", Offset = "0x48CBDC4", VA = "0x48CBDC4", Slot = "5")]
    protected override StoryFreeActionRewardObjectRewardsData LoadEntity(IMasterDataReader reader)
    {
      return (StoryFreeActionRewardObjectRewardsData) null;
    }

    [Token(Token = "0x600690C")]
    [Address(RVA = "0x48CBE1C", Offset = "0x48CBE1C", VA = "0x48CBE1C")]
    public StoryFreeActionRewardObjectRewardsMaster()
    {
    }
  }
}
