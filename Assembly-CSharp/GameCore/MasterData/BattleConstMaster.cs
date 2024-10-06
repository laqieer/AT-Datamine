// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.BattleConstMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E2E")]
  [Serializable]
  public sealed class BattleConstMaster : BaseMaster<BattleConstData>
  {
    [Token(Token = "0x40043A9")]
    private const int key = 1;

    [Token(Token = "0x600565E")]
    [Address(RVA = "0x3E355C8", Offset = "0x3E355C8", VA = "0x3E355C8")]
    public IReadOnlyDictionary<int, BattleConstData> GetEntities()
    {
      return (IReadOnlyDictionary<int, BattleConstData>) null;
    }

    [Token(Token = "0x600565F")]
    [Address(RVA = "0x3E355D0", Offset = "0x3E355D0", VA = "0x3E355D0", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005660")]
    [Address(RVA = "0x3E35630", Offset = "0x3E35630", VA = "0x3E35630", Slot = "5")]
    protected override BattleConstData LoadEntity(IMasterDataReader reader)
    {
      return (BattleConstData) null;
    }

    [Token(Token = "0x6005661")]
    [Address(RVA = "0x3E35688", Offset = "0x3E35688", VA = "0x3E35688")]
    public BattleConstData GetData() => (BattleConstData) null;

    [Token(Token = "0x6005662")]
    [Address(RVA = "0x3E356D4", Offset = "0x3E356D4", VA = "0x3E356D4")]
    public BattleConstMaster()
    {
    }
  }
}
