// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.BattleFacilityMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E60")]
  [Serializable]
  public sealed class BattleFacilityMaster : BaseMaster<BattleFacilityData>
  {
    [Token(Token = "0x60057A6")]
    [Address(RVA = "0x3E421AC", Offset = "0x3E421AC", VA = "0x3E421AC")]
    public IReadOnlyDictionary<int, BattleFacilityData> GetEntities()
    {
      return (IReadOnlyDictionary<int, BattleFacilityData>) null;
    }

    [Token(Token = "0x60057A7")]
    [Address(RVA = "0x3E421B4", Offset = "0x3E421B4", VA = "0x3E421B4", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60057A8")]
    [Address(RVA = "0x3E42214", Offset = "0x3E42214", VA = "0x3E42214", Slot = "5")]
    protected override BattleFacilityData LoadEntity(IMasterDataReader reader)
    {
      return (BattleFacilityData) null;
    }

    [Token(Token = "0x60057A9")]
    [Address(RVA = "0x3E4226C", Offset = "0x3E4226C", VA = "0x3E4226C")]
    public BattleFacilityMaster()
    {
    }
  }
}
