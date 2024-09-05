// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AlignmentStratagemSettingsMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20011A2")]
  [Serializable]
  public sealed class AlignmentStratagemSettingsMaster : BaseMaster<AlignmentStratagemSettingsData>
  {
    [Token(Token = "0x6006514")]
    [Address(RVA = "0x4AF525C", Offset = "0x4AF525C", VA = "0x4AF525C")]
    public IReadOnlyDictionary<int, AlignmentStratagemSettingsData> GetEntities()
    {
      return (IReadOnlyDictionary<int, AlignmentStratagemSettingsData>) null;
    }

    [Token(Token = "0x6006515")]
    [Address(RVA = "0x4AF5264", Offset = "0x4AF5264", VA = "0x4AF5264", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006516")]
    [Address(RVA = "0x4AF52C4", Offset = "0x4AF52C4", VA = "0x4AF52C4", Slot = "5")]
    protected override AlignmentStratagemSettingsData LoadEntity(IMasterDataReader reader)
    {
      return (AlignmentStratagemSettingsData) null;
    }

    [Token(Token = "0x6006517")]
    [Address(RVA = "0x4AF531C", Offset = "0x4AF531C", VA = "0x4AF531C")]
    public static AlignmentStratagemSettingsData Get(
      BoardData boardData,
      UnitParameterData activator,
      UnitParameterData mainActionTargetUnit)
    {
      return (AlignmentStratagemSettingsData) null;
    }

    [Token(Token = "0x6006518")]
    [Address(RVA = "0x4AF5568", Offset = "0x4AF5568", VA = "0x4AF5568")]
    public static IReadOnlyList<UnitParameterData> GetParticipants(
      BoardData boardData,
      UnitParameterData activator,
      UnitParameterData mainActionTargetUnit)
    {
      return (IReadOnlyList<UnitParameterData>) null;
    }

    [Token(Token = "0x6006519")]
    [Address(RVA = "0x4AF5808", Offset = "0x4AF5808", VA = "0x4AF5808")]
    private static bool Available(
      BoardData boardData,
      UnitParameterData alignmentUnitParam,
      UnitParameterData mainActionTargetUnit)
    {
      return new bool();
    }

    [Token(Token = "0x600651A")]
    [Address(RVA = "0x4AF5CEC", Offset = "0x4AF5CEC", VA = "0x4AF5CEC")]
    public AlignmentStratagemSettingsMaster()
    {
    }
  }
}
