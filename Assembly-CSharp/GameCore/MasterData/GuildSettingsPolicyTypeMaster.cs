// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.GuildSettingsPolicyTypeMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000FCB")]
  [Serializable]
  public sealed class GuildSettingsPolicyTypeMaster : BaseMaster<GuildSettingsPolicyTypeData>
  {
    [Token(Token = "0x4004F57")]
    public const string TEXT_AB = "text_masterdata_guild";

    [Token(Token = "0x6005C76")]
    [Address(RVA = "0x278BFDC", Offset = "0x278BFDC", VA = "0x278BFDC")]
    public IReadOnlyDictionary<int, GuildSettingsPolicyTypeData> GetEntities()
    {
      return (IReadOnlyDictionary<int, GuildSettingsPolicyTypeData>) null;
    }

    [Token(Token = "0x6005C77")]
    [Address(RVA = "0x278BFE4", Offset = "0x278BFE4", VA = "0x278BFE4", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005C78")]
    [Address(RVA = "0x278C044", Offset = "0x278C044", VA = "0x278C044", Slot = "5")]
    protected override GuildSettingsPolicyTypeData LoadEntity(IMasterDataReader reader)
    {
      return (GuildSettingsPolicyTypeData) null;
    }

    [Token(Token = "0x6005C79")]
    [Address(RVA = "0x278C09C", Offset = "0x278C09C", VA = "0x278C09C")]
    public GuildSettingsPolicyTypeMaster()
    {
    }
  }
}
