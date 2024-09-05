// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.GuildRaidStageMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200111A")]
  [Serializable]
  public sealed class GuildRaidStageMaster : BaseMaster<GuildRaidStageData>, IQuestStageMaster
  {
    [Token(Token = "0x600626F")]
    [Address(RVA = "0x4ADF3BC", Offset = "0x4ADF3BC", VA = "0x4ADF3BC")]
    public IReadOnlyDictionary<int, GuildRaidStageData> GetEntities()
    {
      return (IReadOnlyDictionary<int, GuildRaidStageData>) null;
    }

    [Token(Token = "0x6006270")]
    [Address(RVA = "0x4ADF3C4", Offset = "0x4ADF3C4", VA = "0x4ADF3C4", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006271")]
    [Address(RVA = "0x4ADF424", Offset = "0x4ADF424", VA = "0x4ADF424", Slot = "5")]
    protected override GuildRaidStageData LoadEntity(IMasterDataReader reader)
    {
      return (GuildRaidStageData) null;
    }

    [Token(Token = "0x6006272")]
    [Address(RVA = "0x4ADF47C", Offset = "0x4ADF47C", VA = "0x4ADF47C", Slot = "6")]
    public IQuestStage GetStage(int id) => (IQuestStage) null;

    [Token(Token = "0x6006273")]
    [Address(RVA = "0x4ADF4D4", Offset = "0x4ADF4D4", VA = "0x4ADF4D4")]
    public GuildRaidStageMaster()
    {
    }
  }
}
