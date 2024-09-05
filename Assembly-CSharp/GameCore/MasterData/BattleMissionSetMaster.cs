// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.BattleMissionSetMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E55")]
  [Serializable]
  public sealed class BattleMissionSetMaster : BaseMaster<BattleMissionSetData>
  {
    [Token(Token = "0x600574C")]
    [Address(RVA = "0x3E3CFD4", Offset = "0x3E3CFD4", VA = "0x3E3CFD4")]
    public IReadOnlyDictionary<int, BattleMissionSetData> GetEntities()
    {
      return (IReadOnlyDictionary<int, BattleMissionSetData>) null;
    }

    [Token(Token = "0x600574D")]
    [Address(RVA = "0x3E3CFDC", Offset = "0x3E3CFDC", VA = "0x3E3CFDC", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x600574E")]
    [Address(RVA = "0x3E3D03C", Offset = "0x3E3D03C", VA = "0x3E3D03C", Slot = "5")]
    protected override BattleMissionSetData LoadEntity(IMasterDataReader reader)
    {
      return (BattleMissionSetData) null;
    }

    [Token(Token = "0x600574F")]
    [Address(RVA = "0x3E3D094", Offset = "0x3E3D094", VA = "0x3E3D094")]
    public BattleMissionSetMaster()
    {
    }
  }
}
