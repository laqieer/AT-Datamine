// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.GuildFacilityEffectMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000FD3")]
  [Serializable]
  public sealed class GuildFacilityEffectMaster : BaseMaster<GuildFacilityEffectData>
  {
    [Token(Token = "0x6005C91")]
    [Address(RVA = "0x278C97C", Offset = "0x278C97C", VA = "0x278C97C")]
    public IReadOnlyDictionary<int, GuildFacilityEffectData> GetEntities()
    {
      return (IReadOnlyDictionary<int, GuildFacilityEffectData>) null;
    }

    [Token(Token = "0x6005C92")]
    [Address(RVA = "0x278C984", Offset = "0x278C984", VA = "0x278C984", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005C93")]
    [Address(RVA = "0x278C9E4", Offset = "0x278C9E4", VA = "0x278C9E4", Slot = "5")]
    protected override GuildFacilityEffectData LoadEntity(IMasterDataReader reader)
    {
      return (GuildFacilityEffectData) null;
    }

    [Token(Token = "0x6005C94")]
    [Address(RVA = "0x278CA3C", Offset = "0x278CA3C", VA = "0x278CA3C")]
    public List<GuildFacilityEffectData> GetFacilityEffectDataList()
    {
      return (List<GuildFacilityEffectData>) null;
    }

    [Token(Token = "0x6005C95")]
    [Address(RVA = "0x278CAA8", Offset = "0x278CAA8", VA = "0x278CAA8")]
    public GuildFacilityEffectData GetData(int facilityId, int level)
    {
      return (GuildFacilityEffectData) null;
    }

    [Token(Token = "0x6005C96")]
    [Address(RVA = "0x278CBB4", Offset = "0x278CBB4", VA = "0x278CBB4")]
    public GuildFacilityEffectMaster()
    {
    }
  }
}
