// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.BattleInitialPlacementMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E53")]
  [Serializable]
  public sealed class BattleInitialPlacementMaster : BaseMaster<BattleInitialPlacementData>
  {
    [Token(Token = "0x6005744")]
    [Address(RVA = "0x3E3CD28", Offset = "0x3E3CD28", VA = "0x3E3CD28")]
    public IReadOnlyDictionary<int, BattleInitialPlacementData> GetEntities()
    {
      return (IReadOnlyDictionary<int, BattleInitialPlacementData>) null;
    }

    [Token(Token = "0x6005745")]
    [Address(RVA = "0x3E3CD30", Offset = "0x3E3CD30", VA = "0x3E3CD30", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005746")]
    [Address(RVA = "0x3E3CD90", Offset = "0x3E3CD90", VA = "0x3E3CD90", Slot = "5")]
    protected override BattleInitialPlacementData LoadEntity(IMasterDataReader reader)
    {
      return (BattleInitialPlacementData) null;
    }

    [Token(Token = "0x6005747")]
    [Address(RVA = "0x3E3CDE8", Offset = "0x3E3CDE8", VA = "0x3E3CDE8")]
    public BattleInitialPlacementMaster()
    {
    }
  }
}
