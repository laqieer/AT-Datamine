// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.GuildFacilityResourceTableDescriptionMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000FE4")]
  [Serializable]
  public sealed class GuildFacilityResourceTableDescriptionMaster : 
    BaseMaster<GuildFacilityResourceTableDescriptionData>
  {
    [Token(Token = "0x6005CD6")]
    [Address(RVA = "0x278ED80", Offset = "0x278ED80", VA = "0x278ED80")]
    public IReadOnlyDictionary<int, GuildFacilityResourceTableDescriptionData> GetEntities()
    {
      return (IReadOnlyDictionary<int, GuildFacilityResourceTableDescriptionData>) null;
    }

    [Token(Token = "0x6005CD7")]
    [Address(RVA = "0x278ED88", Offset = "0x278ED88", VA = "0x278ED88", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005CD8")]
    [Address(RVA = "0x278EDE8", Offset = "0x278EDE8", VA = "0x278EDE8", Slot = "5")]
    protected override GuildFacilityResourceTableDescriptionData LoadEntity(IMasterDataReader reader)
    {
      return (GuildFacilityResourceTableDescriptionData) null;
    }

    [Token(Token = "0x6005CD9")]
    [Address(RVA = "0x278EE40", Offset = "0x278EE40", VA = "0x278EE40")]
    public List<GuildFacilityResourceTableDescriptionData> GetListWithTableId(int tableId)
    {
      return (List<GuildFacilityResourceTableDescriptionData>) null;
    }

    [Token(Token = "0x6005CDA")]
    [Address(RVA = "0x278EF64", Offset = "0x278EF64", VA = "0x278EF64")]
    public GuildFacilityResourceTableDescriptionMaster()
    {
    }
  }
}
