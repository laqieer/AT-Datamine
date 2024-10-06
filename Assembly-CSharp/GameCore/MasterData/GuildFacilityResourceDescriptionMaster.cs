// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.GuildFacilityResourceDescriptionMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000FE1")]
  [Serializable]
  public sealed class GuildFacilityResourceDescriptionMaster : 
    BaseMaster<GuildFacilityResourceDescriptionData>
  {
    [Token(Token = "0x6005CCB")]
    [Address(RVA = "0x278E840", Offset = "0x278E840", VA = "0x278E840")]
    public IReadOnlyDictionary<int, GuildFacilityResourceDescriptionData> GetEntities()
    {
      return (IReadOnlyDictionary<int, GuildFacilityResourceDescriptionData>) null;
    }

    [Token(Token = "0x6005CCC")]
    [Address(RVA = "0x278E848", Offset = "0x278E848", VA = "0x278E848", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005CCD")]
    [Address(RVA = "0x278E8A8", Offset = "0x278E8A8", VA = "0x278E8A8", Slot = "5")]
    protected override GuildFacilityResourceDescriptionData LoadEntity(IMasterDataReader reader)
    {
      return (GuildFacilityResourceDescriptionData) null;
    }

    [Token(Token = "0x6005CCE")]
    [Address(RVA = "0x278E900", Offset = "0x278E900", VA = "0x278E900")]
    public List<GuildFacilityResourceDescriptionData> GetListWithResourceSetId(int resourceSetId)
    {
      return (List<GuildFacilityResourceDescriptionData>) null;
    }

    [Token(Token = "0x6005CCF")]
    [Address(RVA = "0x278EA24", Offset = "0x278EA24", VA = "0x278EA24")]
    public GuildFacilityResourceDescriptionMaster()
    {
    }
  }
}
