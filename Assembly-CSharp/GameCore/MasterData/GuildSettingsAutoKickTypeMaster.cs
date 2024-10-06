// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.GuildSettingsAutoKickTypeMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000FC5")]
  [Serializable]
  public sealed class GuildSettingsAutoKickTypeMaster : BaseMaster<GuildSettingsAutoKickTypeData>
  {
    [Token(Token = "0x4004F45")]
    public const string TEXT_AB = "text_masterdata_guild";

    [Token(Token = "0x6005C64")]
    [Address(RVA = "0x278B94C", Offset = "0x278B94C", VA = "0x278B94C")]
    public IReadOnlyDictionary<int, GuildSettingsAutoKickTypeData> GetEntities()
    {
      return (IReadOnlyDictionary<int, GuildSettingsAutoKickTypeData>) null;
    }

    [Token(Token = "0x6005C65")]
    [Address(RVA = "0x278B954", Offset = "0x278B954", VA = "0x278B954", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005C66")]
    [Address(RVA = "0x278B9B4", Offset = "0x278B9B4", VA = "0x278B9B4", Slot = "5")]
    protected override GuildSettingsAutoKickTypeData LoadEntity(IMasterDataReader reader)
    {
      return (GuildSettingsAutoKickTypeData) null;
    }

    [Token(Token = "0x6005C67")]
    [Address(RVA = "0x278BA0C", Offset = "0x278BA0C", VA = "0x278BA0C")]
    public GuildSettingsAutoKickTypeMaster()
    {
    }
  }
}
