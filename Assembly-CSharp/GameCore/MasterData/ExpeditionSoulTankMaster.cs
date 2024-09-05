// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ExpeditionSoulTankMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000FAB")]
  [Serializable]
  public sealed class ExpeditionSoulTankMaster : BaseMaster<ExpeditionSoulTankData>
  {
    [Token(Token = "0x6005BF5")]
    [Address(RVA = "0x2787A54", Offset = "0x2787A54", VA = "0x2787A54")]
    public IReadOnlyDictionary<int, ExpeditionSoulTankData> GetEntities()
    {
      return (IReadOnlyDictionary<int, ExpeditionSoulTankData>) null;
    }

    [Token(Token = "0x6005BF6")]
    [Address(RVA = "0x2787A5C", Offset = "0x2787A5C", VA = "0x2787A5C", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005BF7")]
    [Address(RVA = "0x2787ABC", Offset = "0x2787ABC", VA = "0x2787ABC", Slot = "5")]
    protected override ExpeditionSoulTankData LoadEntity(IMasterDataReader reader)
    {
      return (ExpeditionSoulTankData) null;
    }

    [Token(Token = "0x6005BF8")]
    [Address(RVA = "0x2787B14", Offset = "0x2787B14", VA = "0x2787B14")]
    public ExpeditionSoulTankMaster()
    {
    }
  }
}
