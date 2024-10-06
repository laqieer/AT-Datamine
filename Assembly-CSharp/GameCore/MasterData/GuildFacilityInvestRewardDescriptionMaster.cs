// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.GuildFacilityInvestRewardDescriptionMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000FD8")]
  [Serializable]
  public sealed class GuildFacilityInvestRewardDescriptionMaster : 
    BaseMaster<GuildFacilityInvestRewardDescriptionData>
  {
    [Token(Token = "0x6005CAC")]
    [Address(RVA = "0x278D9BC", Offset = "0x278D9BC", VA = "0x278D9BC")]
    public IReadOnlyDictionary<int, GuildFacilityInvestRewardDescriptionData> GetEntities()
    {
      return (IReadOnlyDictionary<int, GuildFacilityInvestRewardDescriptionData>) null;
    }

    [Token(Token = "0x6005CAD")]
    [Address(RVA = "0x278D9C4", Offset = "0x278D9C4", VA = "0x278D9C4", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005CAE")]
    [Address(RVA = "0x278DA24", Offset = "0x278DA24", VA = "0x278DA24", Slot = "5")]
    protected override GuildFacilityInvestRewardDescriptionData LoadEntity(IMasterDataReader reader)
    {
      return (GuildFacilityInvestRewardDescriptionData) null;
    }

    [Token(Token = "0x6005CAF")]
    [Address(RVA = "0x278DA7C", Offset = "0x278DA7C", VA = "0x278DA7C")]
    public List<GuildFacilityInvestRewardDescriptionData> GetListWithRewardSetId(int rewardSetId)
    {
      return (List<GuildFacilityInvestRewardDescriptionData>) null;
    }

    [Token(Token = "0x6005CB0")]
    [Address(RVA = "0x278DBA0", Offset = "0x278DBA0", VA = "0x278DBA0")]
    public GuildFacilityInvestRewardDescriptionMaster()
    {
    }
  }
}
