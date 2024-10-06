// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AbilityboardCustomANodeMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200133D")]
  [Serializable]
  public sealed class AbilityboardCustomANodeMaster : BaseMaster<AbilityboardCustomANodeData>
  {
    [Token(Token = "0x4005AAA")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, List<AbilityboardCustomANodeData>> descriptionTable;

    [Token(Token = "0x6006C85")]
    [Address(RVA = "0x46F45E4", Offset = "0x46F45E4", VA = "0x46F45E4")]
    public IReadOnlyDictionary<int, AbilityboardCustomANodeData> GetEntities()
    {
      return (IReadOnlyDictionary<int, AbilityboardCustomANodeData>) null;
    }

    [Token(Token = "0x6006C86")]
    [Address(RVA = "0x46F45EC", Offset = "0x46F45EC", VA = "0x46F45EC", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006C87")]
    [Address(RVA = "0x46F48B0", Offset = "0x46F48B0", VA = "0x46F48B0", Slot = "5")]
    protected override AbilityboardCustomANodeData LoadEntity(IMasterDataReader reader)
    {
      return (AbilityboardCustomANodeData) null;
    }

    [Token(Token = "0x6006C88")]
    [Address(RVA = "0x46F4920", Offset = "0x46F4920", VA = "0x46F4920")]
    private void OnLoadEntity(AbilityboardCustomANodeData entity)
    {
    }

    [Token(Token = "0x6006C89")]
    [Address(RVA = "0x46F4654", Offset = "0x46F4654", VA = "0x46F4654")]
    private void OnCompletedLoading()
    {
    }

    [Token(Token = "0x6006C8A")]
    [Address(RVA = "0x46F4924", Offset = "0x46F4924", VA = "0x46F4924")]
    private void GroupingByGroupId(AbilityboardCustomANodeData entity)
    {
    }

    [Token(Token = "0x6006C8B")]
    [Address(RVA = "0x46F4AE0", Offset = "0x46F4AE0", VA = "0x46F4AE0")]
    public AbilityboardCustomANodeData GetListByCustomIdAndMoldType(
      int customAId,
      MoldTypeEnum moldType)
    {
      return (AbilityboardCustomANodeData) null;
    }

    [Token(Token = "0x6006C8C")]
    [Address(RVA = "0x46F4C84", Offset = "0x46F4C84", VA = "0x46F4C84")]
    public AbilityboardCustomANodeMaster()
    {
    }
  }
}
