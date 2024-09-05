// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.GuildSettingsConditionsTypeMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000FC8")]
  [Serializable]
  public sealed class GuildSettingsConditionsTypeMaster : BaseMaster<GuildSettingsConditionsTypeData>
  {
    [Token(Token = "0x4004F4E")]
    public const string TEXT_AB = "text_masterdata_guild";

    [Token(Token = "0x6005C6D")]
    [Address(RVA = "0x278BC58", Offset = "0x278BC58", VA = "0x278BC58")]
    public IReadOnlyDictionary<int, GuildSettingsConditionsTypeData> GetEntities()
    {
      return (IReadOnlyDictionary<int, GuildSettingsConditionsTypeData>) null;
    }

    [Token(Token = "0x6005C6E")]
    [Address(RVA = "0x278BC60", Offset = "0x278BC60", VA = "0x278BC60", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005C6F")]
    [Address(RVA = "0x278BCC0", Offset = "0x278BCC0", VA = "0x278BCC0", Slot = "5")]
    protected override GuildSettingsConditionsTypeData LoadEntity(IMasterDataReader reader)
    {
      return (GuildSettingsConditionsTypeData) null;
    }

    [Token(Token = "0x6005C70")]
    [Address(RVA = "0x278BD18", Offset = "0x278BD18", VA = "0x278BD18")]
    public GuildSettingsConditionsTypeMaster()
    {
    }
  }
}
