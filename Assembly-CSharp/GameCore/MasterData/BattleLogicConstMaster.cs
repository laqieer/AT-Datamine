// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.BattleLogicConstMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E30")]
  [Serializable]
  public sealed class BattleLogicConstMaster : BaseMaster<BattleLogicConstData>
  {
    [Token(Token = "0x40043B2")]
    private const int key = 1;

    [Token(Token = "0x6005667")]
    [Address(RVA = "0x3E35B5C", Offset = "0x3E35B5C", VA = "0x3E35B5C")]
    public IReadOnlyDictionary<int, BattleLogicConstData> GetEntities()
    {
      return (IReadOnlyDictionary<int, BattleLogicConstData>) null;
    }

    [Token(Token = "0x6005668")]
    [Address(RVA = "0x3E35B64", Offset = "0x3E35B64", VA = "0x3E35B64", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005669")]
    [Address(RVA = "0x3E35BC4", Offset = "0x3E35BC4", VA = "0x3E35BC4", Slot = "5")]
    protected override BattleLogicConstData LoadEntity(IMasterDataReader reader)
    {
      return (BattleLogicConstData) null;
    }

    [Token(Token = "0x600566A")]
    [Address(RVA = "0x3E35C34", Offset = "0x3E35C34", VA = "0x3E35C34")]
    private void OnLoadEntity(BattleLogicConstData entity)
    {
    }

    [Token(Token = "0x600566B")]
    [Address(RVA = "0x3E35D38", Offset = "0x3E35D38", VA = "0x3E35D38")]
    public BattleLogicConstData GetData() => (BattleLogicConstData) null;

    [Token(Token = "0x600566C")]
    [Address(RVA = "0x3E35D84", Offset = "0x3E35D84", VA = "0x3E35D84")]
    public BattleLogicConstMaster()
    {
    }
  }
}
