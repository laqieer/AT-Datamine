// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ExpendablesMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001057")]
  [Serializable]
  public sealed class ExpendablesMaster : BaseMaster<ExpendablesData>
  {
    [Token(Token = "0x40050EE")]
    public const string TEXT_AB = "text_masterdata_item";

    [Token(Token = "0x6005EDE")]
    [Address(RVA = "0x28C8554", Offset = "0x28C8554", VA = "0x28C8554")]
    public IReadOnlyDictionary<int, ExpendablesData> GetEntities()
    {
      return (IReadOnlyDictionary<int, ExpendablesData>) null;
    }

    [Token(Token = "0x6005EDF")]
    [Address(RVA = "0x28C855C", Offset = "0x28C855C", VA = "0x28C855C", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005EE0")]
    [Address(RVA = "0x28C85BC", Offset = "0x28C85BC", VA = "0x28C85BC", Slot = "5")]
    protected override ExpendablesData LoadEntity(IMasterDataReader reader)
    {
      return (ExpendablesData) null;
    }

    [Token(Token = "0x6005EE1")]
    [Address(RVA = "0x28C8614", Offset = "0x28C8614", VA = "0x28C8614")]
    public IReadOnlyCollection<ExpendablesData> GetList()
    {
      return (IReadOnlyCollection<ExpendablesData>) null;
    }

    [Token(Token = "0x6005EE2")]
    [Address(RVA = "0x28C8664", Offset = "0x28C8664", VA = "0x28C8664")]
    public ExpendablesMaster()
    {
    }
  }
}
