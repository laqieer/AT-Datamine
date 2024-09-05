// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.BattleFacilityPlacementMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E5E")]
  [Serializable]
  public sealed class BattleFacilityPlacementMaster : BaseMaster<BattleFacilityPlacementData>
  {
    [Token(Token = "0x600579E")]
    [Address(RVA = "0x3E41F00", Offset = "0x3E41F00", VA = "0x3E41F00")]
    public IReadOnlyDictionary<int, BattleFacilityPlacementData> GetEntities()
    {
      return (IReadOnlyDictionary<int, BattleFacilityPlacementData>) null;
    }

    [Token(Token = "0x600579F")]
    [Address(RVA = "0x3E41F08", Offset = "0x3E41F08", VA = "0x3E41F08", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60057A0")]
    [Address(RVA = "0x3E41F68", Offset = "0x3E41F68", VA = "0x3E41F68", Slot = "5")]
    protected override BattleFacilityPlacementData LoadEntity(IMasterDataReader reader)
    {
      return (BattleFacilityPlacementData) null;
    }

    [Token(Token = "0x60057A1")]
    [Address(RVA = "0x3E41FC0", Offset = "0x3E41FC0", VA = "0x3E41FC0")]
    public BattleFacilityPlacementMaster()
    {
    }
  }
}
