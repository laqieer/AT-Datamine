// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.GuildRoleTypeMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000FBF")]
  [Serializable]
  public sealed class GuildRoleTypeMaster : BaseMaster<GuildRoleTypeData>
  {
    [Token(Token = "0x4004F3A")]
    public const string TEXT_AB = "text_masterdata_guild";

    [Token(Token = "0x6005C52")]
    [Address(RVA = "0x278B2B8", Offset = "0x278B2B8", VA = "0x278B2B8")]
    public IReadOnlyDictionary<int, GuildRoleTypeData> GetEntities()
    {
      return (IReadOnlyDictionary<int, GuildRoleTypeData>) null;
    }

    [Token(Token = "0x6005C53")]
    [Address(RVA = "0x278B2C0", Offset = "0x278B2C0", VA = "0x278B2C0", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005C54")]
    [Address(RVA = "0x278B320", Offset = "0x278B320", VA = "0x278B320", Slot = "5")]
    protected override GuildRoleTypeData LoadEntity(IMasterDataReader reader)
    {
      return (GuildRoleTypeData) null;
    }

    [Token(Token = "0x6005C55")]
    [Address(RVA = "0x278B378", Offset = "0x278B378", VA = "0x278B378")]
    public GuildRoleTypeMaster()
    {
    }
  }
}
