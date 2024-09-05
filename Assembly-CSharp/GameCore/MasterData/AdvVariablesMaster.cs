// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AdvVariablesMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000DC1")]
  [Serializable]
  public sealed class AdvVariablesMaster : BaseMaster<AdvVariablesData>
  {
    [Token(Token = "0x600541B")]
    [Address(RVA = "0x3AA1910", Offset = "0x3AA1910", VA = "0x3AA1910")]
    public IReadOnlyDictionary<int, AdvVariablesData> GetEntities()
    {
      return (IReadOnlyDictionary<int, AdvVariablesData>) null;
    }

    [Token(Token = "0x600541C")]
    [Address(RVA = "0x3AA1918", Offset = "0x3AA1918", VA = "0x3AA1918", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x600541D")]
    [Address(RVA = "0x3AA1978", Offset = "0x3AA1978", VA = "0x3AA1978", Slot = "5")]
    protected override AdvVariablesData LoadEntity(IMasterDataReader reader)
    {
      return (AdvVariablesData) null;
    }

    [Token(Token = "0x600541E")]
    [Address(RVA = "0x3AA19D0", Offset = "0x3AA19D0", VA = "0x3AA19D0")]
    public AdvVariablesData GetByName(string name) => (AdvVariablesData) null;

    [Token(Token = "0x600541F")]
    [Address(RVA = "0x3AA1B70", Offset = "0x3AA1B70", VA = "0x3AA1B70")]
    public List<string> CreateList() => (List<string>) null;

    [Token(Token = "0x6005420")]
    [Address(RVA = "0x3AA1D84", Offset = "0x3AA1D84", VA = "0x3AA1D84")]
    public AdvVariablesMaster()
    {
    }
  }
}
