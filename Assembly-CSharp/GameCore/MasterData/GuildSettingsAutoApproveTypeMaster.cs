// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.GuildSettingsAutoApproveTypeMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000FC2")]
  [Serializable]
  public sealed class GuildSettingsAutoApproveTypeMaster : 
    BaseMaster<GuildSettingsAutoApproveTypeData>
  {
    [Token(Token = "0x4004F40")]
    public const string TEXT_AB = "text_masterdata_guild";

    [Token(Token = "0x6005C5B")]
    [Address(RVA = "0x278B640", Offset = "0x278B640", VA = "0x278B640")]
    public IReadOnlyDictionary<int, GuildSettingsAutoApproveTypeData> GetEntities()
    {
      return (IReadOnlyDictionary<int, GuildSettingsAutoApproveTypeData>) null;
    }

    [Token(Token = "0x6005C5C")]
    [Address(RVA = "0x278B648", Offset = "0x278B648", VA = "0x278B648", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005C5D")]
    [Address(RVA = "0x278B6A8", Offset = "0x278B6A8", VA = "0x278B6A8", Slot = "5")]
    protected override GuildSettingsAutoApproveTypeData LoadEntity(IMasterDataReader reader)
    {
      return (GuildSettingsAutoApproveTypeData) null;
    }

    [Token(Token = "0x6005C5E")]
    [Address(RVA = "0x278B700", Offset = "0x278B700", VA = "0x278B700")]
    public GuildSettingsAutoApproveTypeMaster()
    {
    }
  }
}
