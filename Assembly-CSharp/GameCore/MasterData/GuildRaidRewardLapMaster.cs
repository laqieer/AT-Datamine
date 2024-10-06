// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.GuildRaidRewardLapMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000FF9")]
  [Serializable]
  public sealed class GuildRaidRewardLapMaster : BaseMaster<GuildRaidRewardLapData>
  {
    [Token(Token = "0x6005D33")]
    [Address(RVA = "0x2791AAC", Offset = "0x2791AAC", VA = "0x2791AAC")]
    public IReadOnlyDictionary<int, GuildRaidRewardLapData> GetEntities()
    {
      return (IReadOnlyDictionary<int, GuildRaidRewardLapData>) null;
    }

    [Token(Token = "0x6005D34")]
    [Address(RVA = "0x2791AB4", Offset = "0x2791AB4", VA = "0x2791AB4", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005D35")]
    [Address(RVA = "0x2791B14", Offset = "0x2791B14", VA = "0x2791B14", Slot = "5")]
    protected override GuildRaidRewardLapData LoadEntity(IMasterDataReader reader)
    {
      return (GuildRaidRewardLapData) null;
    }

    [Token(Token = "0x6005D36")]
    [Address(RVA = "0x2791B6C", Offset = "0x2791B6C", VA = "0x2791B6C")]
    public GuildRaidRewardLapMaster()
    {
    }
  }
}
