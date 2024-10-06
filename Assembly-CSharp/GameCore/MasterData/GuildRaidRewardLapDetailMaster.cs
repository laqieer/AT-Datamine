// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.GuildRaidRewardLapDetailMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000FF6")]
  [Serializable]
  public sealed class GuildRaidRewardLapDetailMaster : BaseMaster<GuildRaidRewardLapDetailData>
  {
    [Token(Token = "0x6005D28")]
    [Address(RVA = "0x2791588", Offset = "0x2791588", VA = "0x2791588")]
    public IReadOnlyDictionary<int, GuildRaidRewardLapDetailData> GetEntities()
    {
      return (IReadOnlyDictionary<int, GuildRaidRewardLapDetailData>) null;
    }

    [Token(Token = "0x6005D29")]
    [Address(RVA = "0x2791590", Offset = "0x2791590", VA = "0x2791590", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005D2A")]
    [Address(RVA = "0x27915F0", Offset = "0x27915F0", VA = "0x27915F0", Slot = "5")]
    protected override GuildRaidRewardLapDetailData LoadEntity(IMasterDataReader reader)
    {
      return (GuildRaidRewardLapDetailData) null;
    }

    [Token(Token = "0x6005D2B")]
    [Address(RVA = "0x2791648", Offset = "0x2791648", VA = "0x2791648")]
    public IEnumerable<GuildRaidRewardLapDetailData> GetRewardItemList(int lapRewardId)
    {
      return (IEnumerable<GuildRaidRewardLapDetailData>) null;
    }

    [Token(Token = "0x6005D2C")]
    [Address(RVA = "0x2791750", Offset = "0x2791750", VA = "0x2791750")]
    public GuildRaidRewardLapDetailMaster()
    {
    }
  }
}
