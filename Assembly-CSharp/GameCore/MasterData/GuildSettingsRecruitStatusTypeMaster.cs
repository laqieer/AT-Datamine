// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.GuildSettingsRecruitStatusTypeMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000FCE")]
  [Serializable]
  public sealed class GuildSettingsRecruitStatusTypeMaster : 
    BaseMaster<GuildSettingsRecruitStatusTypeData>
  {
    [Token(Token = "0x4004F5C")]
    public const string TEXT_AB = "text_masterdata_guild";

    [Token(Token = "0x6005C7F")]
    [Address(RVA = "0x278C2E8", Offset = "0x278C2E8", VA = "0x278C2E8")]
    public IReadOnlyDictionary<int, GuildSettingsRecruitStatusTypeData> GetEntities()
    {
      return (IReadOnlyDictionary<int, GuildSettingsRecruitStatusTypeData>) null;
    }

    [Token(Token = "0x6005C80")]
    [Address(RVA = "0x278C2F0", Offset = "0x278C2F0", VA = "0x278C2F0", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005C81")]
    [Address(RVA = "0x278C350", Offset = "0x278C350", VA = "0x278C350", Slot = "5")]
    protected override GuildSettingsRecruitStatusTypeData LoadEntity(IMasterDataReader reader)
    {
      return (GuildSettingsRecruitStatusTypeData) null;
    }

    [Token(Token = "0x6005C82")]
    [Address(RVA = "0x278C3A8", Offset = "0x278C3A8", VA = "0x278C3A8")]
    public GuildSettingsRecruitStatusTypeMaster()
    {
    }
  }
}
