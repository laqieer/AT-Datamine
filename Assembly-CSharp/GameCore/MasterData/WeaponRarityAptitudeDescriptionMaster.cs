// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.WeaponRarityAptitudeDescriptionMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000F7B")]
  [Serializable]
  public sealed class WeaponRarityAptitudeDescriptionMaster : 
    BaseMaster<WeaponRarityAptitudeDescriptionData>
  {
    [Token(Token = "0x6005B0B")]
    [Address(RVA = "0x277CCE4", Offset = "0x277CCE4", VA = "0x277CCE4")]
    public IReadOnlyDictionary<int, WeaponRarityAptitudeDescriptionData> GetEntities()
    {
      return (IReadOnlyDictionary<int, WeaponRarityAptitudeDescriptionData>) null;
    }

    [Token(Token = "0x6005B0C")]
    [Address(RVA = "0x277CCEC", Offset = "0x277CCEC", VA = "0x277CCEC", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005B0D")]
    [Address(RVA = "0x277CD4C", Offset = "0x277CD4C", VA = "0x277CD4C", Slot = "5")]
    protected override WeaponRarityAptitudeDescriptionData LoadEntity(IMasterDataReader reader)
    {
      return (WeaponRarityAptitudeDescriptionData) null;
    }

    [Token(Token = "0x6005B0E")]
    [Address(RVA = "0x277CDA4", Offset = "0x277CDA4", VA = "0x277CDA4")]
    public WeaponRarityAptitudeDescriptionMaster()
    {
    }
  }
}
