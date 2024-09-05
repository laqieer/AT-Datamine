// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ArenaBattlePlacementMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000DD6")]
  [Serializable]
  public sealed class ArenaBattlePlacementMaster : BaseMaster<ArenaBattlePlacementData>
  {
    [Token(Token = "0x6005474")]
    [Address(RVA = "0x3AA5850", Offset = "0x3AA5850", VA = "0x3AA5850")]
    public IReadOnlyDictionary<int, ArenaBattlePlacementData> GetEntities()
    {
      return (IReadOnlyDictionary<int, ArenaBattlePlacementData>) null;
    }

    [Token(Token = "0x6005475")]
    [Address(RVA = "0x3AA5858", Offset = "0x3AA5858", VA = "0x3AA5858", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005476")]
    [Address(RVA = "0x3AA58B8", Offset = "0x3AA58B8", VA = "0x3AA58B8", Slot = "5")]
    protected override ArenaBattlePlacementData LoadEntity(IMasterDataReader reader)
    {
      return (ArenaBattlePlacementData) null;
    }

    [Token(Token = "0x6005477")]
    [Address(RVA = "0x3AA5910", Offset = "0x3AA5910", VA = "0x3AA5910")]
    public ArenaBattlePlacementMaster()
    {
    }
  }
}
