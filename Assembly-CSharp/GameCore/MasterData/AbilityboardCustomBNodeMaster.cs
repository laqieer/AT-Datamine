// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AbilityboardCustomBNodeMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001342")]
  [Serializable]
  public sealed class AbilityboardCustomBNodeMaster : BaseMaster<AbilityboardCustomBNodeData>
  {
    [Token(Token = "0x4005AB9")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, List<AbilityboardCustomBNodeData>> descriptionTable;

    [Token(Token = "0x6006C9C")]
    [Address(RVA = "0x46F5570", Offset = "0x46F5570", VA = "0x46F5570")]
    public IReadOnlyDictionary<int, AbilityboardCustomBNodeData> GetEntities()
    {
      return (IReadOnlyDictionary<int, AbilityboardCustomBNodeData>) null;
    }

    [Token(Token = "0x6006C9D")]
    [Address(RVA = "0x46F5578", Offset = "0x46F5578", VA = "0x46F5578", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006C9E")]
    [Address(RVA = "0x46F583C", Offset = "0x46F583C", VA = "0x46F583C", Slot = "5")]
    protected override AbilityboardCustomBNodeData LoadEntity(IMasterDataReader reader)
    {
      return (AbilityboardCustomBNodeData) null;
    }

    [Token(Token = "0x6006C9F")]
    [Address(RVA = "0x46F58AC", Offset = "0x46F58AC", VA = "0x46F58AC")]
    private void OnLoadEntity(AbilityboardCustomBNodeData entity)
    {
    }

    [Token(Token = "0x6006CA0")]
    [Address(RVA = "0x46F55E0", Offset = "0x46F55E0", VA = "0x46F55E0")]
    private void OnCompletedLoading()
    {
    }

    [Token(Token = "0x6006CA1")]
    [Address(RVA = "0x46F58B0", Offset = "0x46F58B0", VA = "0x46F58B0")]
    private void GroupingByGroupId(AbilityboardCustomBNodeData entity)
    {
    }

    [Token(Token = "0x6006CA2")]
    [Address(RVA = "0x46F5A6C", Offset = "0x46F5A6C", VA = "0x46F5A6C")]
    public IReadOnlyList<AbilityboardCustomBNodeData> GetListByCustomBID(int customBID)
    {
      return (IReadOnlyList<AbilityboardCustomBNodeData>) null;
    }

    [Token(Token = "0x6006CA3")]
    [Address(RVA = "0x46F5B28", Offset = "0x46F5B28", VA = "0x46F5B28")]
    public AbilityboardCustomBNodeMaster()
    {
    }
  }
}
