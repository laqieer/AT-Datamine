// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryBattleMissionMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E6C")]
  [Serializable]
  public sealed class StoryBattleMissionMaster : BaseMaster<StoryBattleMissionData>
  {
    [Token(Token = "0x40045B6")]
    public const string TEXT_AB = "text_masterdata_battle";
    [Token(Token = "0x40045B7")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, List<StoryBattleMissionData>> missionSetTable;

    [Token(Token = "0x60057DE")]
    [Address(RVA = "0x3E44404", Offset = "0x3E44404", VA = "0x3E44404")]
    public IReadOnlyDictionary<int, StoryBattleMissionData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryBattleMissionData>) null;
    }

    [Token(Token = "0x60057DF")]
    [Address(RVA = "0x3E4440C", Offset = "0x3E4440C", VA = "0x3E4440C", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60057E0")]
    [Address(RVA = "0x3E4446C", Offset = "0x3E4446C", VA = "0x3E4446C", Slot = "5")]
    protected override StoryBattleMissionData LoadEntity(IMasterDataReader reader)
    {
      return (StoryBattleMissionData) null;
    }

    [Token(Token = "0x60057E1")]
    [Address(RVA = "0x3E444DC", Offset = "0x3E444DC", VA = "0x3E444DC")]
    private void OnLoadEntity(StoryBattleMissionData entity)
    {
    }

    [Token(Token = "0x60057E2")]
    [Address(RVA = "0x3E444E0", Offset = "0x3E444E0", VA = "0x3E444E0")]
    private void GroupingByMissionSet(StoryBattleMissionData entity)
    {
    }

    [Token(Token = "0x60057E3")]
    [Address(RVA = "0x3E44634", Offset = "0x3E44634", VA = "0x3E44634")]
    public IEnumerable<StoryBattleMissionData> GetDataByMissionSetId(int missionSetId)
    {
      return (IEnumerable<StoryBattleMissionData>) null;
    }

    [Token(Token = "0x60057E4")]
    [Address(RVA = "0x3E446F0", Offset = "0x3E446F0", VA = "0x3E446F0")]
    public StoryBattleMissionMaster()
    {
    }
  }
}
