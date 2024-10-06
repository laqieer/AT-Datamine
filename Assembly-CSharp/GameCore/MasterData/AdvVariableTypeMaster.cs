// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AdvVariableTypeMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000DC4")]
  [Serializable]
  public sealed class AdvVariableTypeMaster : BaseMaster<AdvVariableTypeData>
  {
    [Token(Token = "0x6005425")]
    [Address(RVA = "0x3AA2120", Offset = "0x3AA2120", VA = "0x3AA2120")]
    public IReadOnlyDictionary<int, AdvVariableTypeData> GetEntities()
    {
      return (IReadOnlyDictionary<int, AdvVariableTypeData>) null;
    }

    [Token(Token = "0x6005426")]
    [Address(RVA = "0x3AA2128", Offset = "0x3AA2128", VA = "0x3AA2128", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005427")]
    [Address(RVA = "0x3AA2188", Offset = "0x3AA2188", VA = "0x3AA2188", Slot = "5")]
    protected override AdvVariableTypeData LoadEntity(IMasterDataReader reader)
    {
      return (AdvVariableTypeData) null;
    }

    [Token(Token = "0x6005428")]
    [Address(RVA = "0x3AA21E0", Offset = "0x3AA21E0", VA = "0x3AA21E0")]
    public AdvVariableTypeData GetByName(string name) => (AdvVariableTypeData) null;

    [Token(Token = "0x6005429")]
    [Address(RVA = "0x3AA2380", Offset = "0x3AA2380", VA = "0x3AA2380")]
    public AdvVariableTypeMaster()
    {
    }
  }
}
