// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.GuildFacilityLevelRewardMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000FDB")]
  [Serializable]
  public sealed class GuildFacilityLevelRewardMaster : BaseMaster<GuildFacilityLevelRewardData>
  {
    [Token(Token = "0x6005CB7")]
    [Address(RVA = "0x278DEFC", Offset = "0x278DEFC", VA = "0x278DEFC")]
    public IReadOnlyDictionary<int, GuildFacilityLevelRewardData> GetEntities()
    {
      return (IReadOnlyDictionary<int, GuildFacilityLevelRewardData>) null;
    }

    [Token(Token = "0x6005CB8")]
    [Address(RVA = "0x278DF04", Offset = "0x278DF04", VA = "0x278DF04", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005CB9")]
    [Address(RVA = "0x278DF64", Offset = "0x278DF64", VA = "0x278DF64", Slot = "5")]
    protected override GuildFacilityLevelRewardData LoadEntity(IMasterDataReader reader)
    {
      return (GuildFacilityLevelRewardData) null;
    }

    [Token(Token = "0x6005CBA")]
    [Address(RVA = "0x278DFBC", Offset = "0x278DFBC", VA = "0x278DFBC")]
    public List<GuildFacilityLevelRewardData> GetListWithFacilityId(int facilityId)
    {
      return (List<GuildFacilityLevelRewardData>) null;
    }

    [Token(Token = "0x6005CBB")]
    [Address(RVA = "0x278E0E0", Offset = "0x278E0E0", VA = "0x278E0E0")]
    public List<GuildFacilityLevelRewardData> GetListWithFacilityExp(int facilityId, int experience)
    {
      return (List<GuildFacilityLevelRewardData>) null;
    }

    [Token(Token = "0x6005CBC")]
    [Address(RVA = "0x278E26C", Offset = "0x278E26C", VA = "0x278E26C")]
    public List<GuildFacilityLevelRewardData> GetListWithFacilityLevel(int facilityId, int level)
    {
      return (List<GuildFacilityLevelRewardData>) null;
    }

    [Token(Token = "0x6005CBD")]
    [Address(RVA = "0x278E394", Offset = "0x278E394", VA = "0x278E394")]
    public GuildFacilityLevelRewardData GetDataWithFacilityLevel(int facilityId, int facilityLevel)
    {
      return (GuildFacilityLevelRewardData) null;
    }

    [Token(Token = "0x6005CBE")]
    [Address(RVA = "0x278E4A0", Offset = "0x278E4A0", VA = "0x278E4A0")]
    public GuildFacilityLevelRewardMaster()
    {
    }
  }
}
