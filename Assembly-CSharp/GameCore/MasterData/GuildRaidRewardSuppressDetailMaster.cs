// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.GuildRaidRewardSuppressDetailMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001002")]
  [Serializable]
  public sealed class GuildRaidRewardSuppressDetailMaster : 
    BaseMaster<GuildRaidRewardSuppressDetailData>
  {
    [Token(Token = "0x6005D54")]
    [Address(RVA = "0x2792B38", Offset = "0x2792B38", VA = "0x2792B38")]
    public IReadOnlyDictionary<int, GuildRaidRewardSuppressDetailData> GetEntities()
    {
      return (IReadOnlyDictionary<int, GuildRaidRewardSuppressDetailData>) null;
    }

    [Token(Token = "0x6005D55")]
    [Address(RVA = "0x2792B40", Offset = "0x2792B40", VA = "0x2792B40", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005D56")]
    [Address(RVA = "0x2792BA0", Offset = "0x2792BA0", VA = "0x2792BA0", Slot = "5")]
    protected override GuildRaidRewardSuppressDetailData LoadEntity(IMasterDataReader reader)
    {
      return (GuildRaidRewardSuppressDetailData) null;
    }

    [Token(Token = "0x6005D57")]
    [Address(RVA = "0x2792BF8", Offset = "0x2792BF8", VA = "0x2792BF8")]
    public (List<GuildRaidRewardSuppressDetailData>, List<GuildRaidRewardSuppressDetailData>) GetRewardSuppressDetailDataBySuppressId(
      int suppressId)
    {
      return ();
    }

    [Token(Token = "0x6005D58")]
    [Address(RVA = "0x2792F70", Offset = "0x2792F70", VA = "0x2792F70")]
    public List<GuildRaidRewardSuppressDetailData> GetSubjugationReward(int suppressId)
    {
      return (List<GuildRaidRewardSuppressDetailData>) null;
    }

    [Token(Token = "0x6005D59")]
    [Address(RVA = "0x279314C", Offset = "0x279314C", VA = "0x279314C")]
    public List<GuildRaidRewardSuppressDetailData> GetDamageReward(int suppressId)
    {
      return (List<GuildRaidRewardSuppressDetailData>) null;
    }

    [Token(Token = "0x6005D5A")]
    [Address(RVA = "0x27933E4", Offset = "0x27933E4", VA = "0x27933E4")]
    public GuildRaidRewardSuppressDetailMaster()
    {
    }
  }
}
