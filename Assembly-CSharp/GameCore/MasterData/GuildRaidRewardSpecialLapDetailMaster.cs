// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.GuildRaidRewardSpecialLapDetailMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000FFB")]
  [Serializable]
  public sealed class GuildRaidRewardSpecialLapDetailMaster : 
    BaseMaster<GuildRaidRewardSpecialLapDetailData>
  {
    [Token(Token = "0x6005D3B")]
    [Address(RVA = "0x2791D58", Offset = "0x2791D58", VA = "0x2791D58")]
    public IReadOnlyDictionary<int, GuildRaidRewardSpecialLapDetailData> GetEntities()
    {
      return (IReadOnlyDictionary<int, GuildRaidRewardSpecialLapDetailData>) null;
    }

    [Token(Token = "0x6005D3C")]
    [Address(RVA = "0x2791D60", Offset = "0x2791D60", VA = "0x2791D60", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005D3D")]
    [Address(RVA = "0x2791DC0", Offset = "0x2791DC0", VA = "0x2791DC0", Slot = "5")]
    protected override GuildRaidRewardSpecialLapDetailData LoadEntity(IMasterDataReader reader)
    {
      return (GuildRaidRewardSpecialLapDetailData) null;
    }

    [Token(Token = "0x6005D3E")]
    [Address(RVA = "0x2791E18", Offset = "0x2791E18", VA = "0x2791E18")]
    public HashSet<int> GetLapList(int specialLapRewardId) => (HashSet<int>) null;

    [Token(Token = "0x6005D3F")]
    [Address(RVA = "0x27922F4", Offset = "0x27922F4", VA = "0x27922F4")]
    public List<GuildRaidRewardSpecialLapDetailData> GetRewardSpecialLapDataBySpecialLapRewardId(
      int specialLapId)
    {
      return (List<GuildRaidRewardSpecialLapDetailData>) null;
    }

    [Token(Token = "0x6005D40")]
    [Address(RVA = "0x2792418", Offset = "0x2792418", VA = "0x2792418")]
    public GuildRaidRewardSpecialLapDetailMaster()
    {
    }
  }
}
