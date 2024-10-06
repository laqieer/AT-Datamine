// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.GuildFacilityRewardDescriptionMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000FE7")]
  [Serializable]
  public sealed class GuildFacilityRewardDescriptionMaster : 
    BaseMaster<GuildFacilityRewardDescriptionData>
  {
    [Token(Token = "0x6005CE1")]
    [Address(RVA = "0x278F2C0", Offset = "0x278F2C0", VA = "0x278F2C0")]
    public IReadOnlyDictionary<int, GuildFacilityRewardDescriptionData> GetEntities()
    {
      return (IReadOnlyDictionary<int, GuildFacilityRewardDescriptionData>) null;
    }

    [Token(Token = "0x6005CE2")]
    [Address(RVA = "0x278F2C8", Offset = "0x278F2C8", VA = "0x278F2C8", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005CE3")]
    [Address(RVA = "0x278F328", Offset = "0x278F328", VA = "0x278F328", Slot = "5")]
    protected override GuildFacilityRewardDescriptionData LoadEntity(IMasterDataReader reader)
    {
      return (GuildFacilityRewardDescriptionData) null;
    }

    [Token(Token = "0x6005CE4")]
    [Address(RVA = "0x278F380", Offset = "0x278F380", VA = "0x278F380")]
    public List<GuildFacilityRewardDescriptionData> GetListWithSetId(int rewardSetId)
    {
      return (List<GuildFacilityRewardDescriptionData>) null;
    }

    [Token(Token = "0x6005CE5")]
    [Address(RVA = "0x278F4A4", Offset = "0x278F4A4", VA = "0x278F4A4")]
    public GuildFacilityRewardDescriptionMaster()
    {
    }
  }
}
