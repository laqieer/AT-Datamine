// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ArenaBattleMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000DD8")]
  [Serializable]
  public sealed class ArenaBattleMaster : BaseMaster<ArenaBattleData>
  {
    [Token(Token = "0x6005490")]
    [Address(RVA = "0x3AA5D58", Offset = "0x3AA5D58", VA = "0x3AA5D58")]
    public IReadOnlyDictionary<int, ArenaBattleData> GetEntities()
    {
      return (IReadOnlyDictionary<int, ArenaBattleData>) null;
    }

    [Token(Token = "0x6005491")]
    [Address(RVA = "0x3AA5D60", Offset = "0x3AA5D60", VA = "0x3AA5D60", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005492")]
    [Address(RVA = "0x3AA5DC0", Offset = "0x3AA5DC0", VA = "0x3AA5DC0", Slot = "5")]
    protected override ArenaBattleData LoadEntity(IMasterDataReader reader)
    {
      return (ArenaBattleData) null;
    }

    [Token(Token = "0x6005493")]
    [Address(RVA = "0x3AA5E18", Offset = "0x3AA5E18", VA = "0x3AA5E18")]
    public ArenaBattleMaster()
    {
    }
  }
}
