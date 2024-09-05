// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.GuildFacilityMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000FEA")]
  [Serializable]
  public sealed class GuildFacilityMaster : BaseMaster<GuildFacilityData>
  {
    [Token(Token = "0x4004F93")]
    public const string TEXT_AB = "text_masterdata_guild";

    [Token(Token = "0x6005CEC")]
    [Address(RVA = "0x278F790", Offset = "0x278F790", VA = "0x278F790")]
    public IReadOnlyDictionary<int, GuildFacilityData> GetEntities()
    {
      return (IReadOnlyDictionary<int, GuildFacilityData>) null;
    }

    [Token(Token = "0x6005CED")]
    [Address(RVA = "0x278F798", Offset = "0x278F798", VA = "0x278F798", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005CEE")]
    [Address(RVA = "0x278F7F8", Offset = "0x278F7F8", VA = "0x278F7F8", Slot = "5")]
    protected override GuildFacilityData LoadEntity(IMasterDataReader reader)
    {
      return (GuildFacilityData) null;
    }

    [Token(Token = "0x6005CEF")]
    [Address(RVA = "0x278F850", Offset = "0x278F850", VA = "0x278F850")]
    public List<GuildFacilityData> GetFacilityDataList() => (List<GuildFacilityData>) null;

    [Token(Token = "0x6005CF0")]
    [Address(RVA = "0x278F8BC", Offset = "0x278F8BC", VA = "0x278F8BC")]
    public GuildFacilityMaster()
    {
    }
  }
}
