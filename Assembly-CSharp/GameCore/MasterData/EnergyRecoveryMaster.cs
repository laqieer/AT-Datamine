// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.EnergyRecoveryMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200104D")]
  [Serializable]
  public sealed class EnergyRecoveryMaster : BaseMaster<EnergyRecoveryData>
  {
    [Token(Token = "0x40050C5")]
    public const string TEXT_AB = "text_masterdata_item";

    [Token(Token = "0x6005EAB")]
    [Address(RVA = "0x28C634C", Offset = "0x28C634C", VA = "0x28C634C")]
    public IReadOnlyDictionary<int, EnergyRecoveryData> GetEntities()
    {
      return (IReadOnlyDictionary<int, EnergyRecoveryData>) null;
    }

    [Token(Token = "0x6005EAC")]
    [Address(RVA = "0x28C6354", Offset = "0x28C6354", VA = "0x28C6354", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005EAD")]
    [Address(RVA = "0x28C63B4", Offset = "0x28C63B4", VA = "0x28C63B4", Slot = "5")]
    protected override EnergyRecoveryData LoadEntity(IMasterDataReader reader)
    {
      return (EnergyRecoveryData) null;
    }

    [Token(Token = "0x6005EAE")]
    [Address(RVA = "0x28C640C", Offset = "0x28C640C", VA = "0x28C640C")]
    public EnergyRecoveryMaster()
    {
    }
  }
}
