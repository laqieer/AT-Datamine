// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.BattleMissionMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E57")]
  [Serializable]
  public sealed class BattleMissionMaster : BaseMaster<BattleMissionData>
  {
    [Token(Token = "0x400451B")]
    public const string TEXT_AB = "text_masterdata_battle";
    [Token(Token = "0x400451C")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, List<BattleMissionData>> missionSetTable;

    [Token(Token = "0x6005755")]
    [Address(RVA = "0x3E3D318", Offset = "0x3E3D318", VA = "0x3E3D318")]
    public IReadOnlyDictionary<int, BattleMissionData> GetEntities()
    {
      return (IReadOnlyDictionary<int, BattleMissionData>) null;
    }

    [Token(Token = "0x6005756")]
    [Address(RVA = "0x3E3D320", Offset = "0x3E3D320", VA = "0x3E3D320", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005757")]
    [Address(RVA = "0x3E3D380", Offset = "0x3E3D380", VA = "0x3E3D380", Slot = "5")]
    protected override BattleMissionData LoadEntity(IMasterDataReader reader)
    {
      return (BattleMissionData) null;
    }

    [Token(Token = "0x6005758")]
    [Address(RVA = "0x3E3D3F0", Offset = "0x3E3D3F0", VA = "0x3E3D3F0")]
    private void OnLoadEntity(BattleMissionData entity)
    {
    }

    [Token(Token = "0x6005759")]
    [Address(RVA = "0x3E3D3F4", Offset = "0x3E3D3F4", VA = "0x3E3D3F4")]
    private void GroupingByMissionSet(BattleMissionData entity)
    {
    }

    [Token(Token = "0x600575A")]
    [Address(RVA = "0x3E3D548", Offset = "0x3E3D548", VA = "0x3E3D548")]
    public IReadOnlyList<BattleMissionData> GetDataByMissionSetId(int missionSetId)
    {
      return (IReadOnlyList<BattleMissionData>) null;
    }

    [Token(Token = "0x600575B")]
    [Address(RVA = "0x3E3D654", Offset = "0x3E3D654", VA = "0x3E3D654")]
    public IReadOnlyList<BattleMissionData> GetListByMissionSetId(int missionSetId)
    {
      return (IReadOnlyList<BattleMissionData>) null;
    }

    [Token(Token = "0x600575C")]
    [Address(RVA = "0x3E3D734", Offset = "0x3E3D734", VA = "0x3E3D734")]
    public int GetMissionNum(int missionSetId) => new int();

    [Token(Token = "0x600575D")]
    [Address(RVA = "0x3E3D7E4", Offset = "0x3E3D7E4", VA = "0x3E3D7E4")]
    public BattleMissionMaster()
    {
    }
  }
}
