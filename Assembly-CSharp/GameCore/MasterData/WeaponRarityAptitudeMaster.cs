// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.WeaponRarityAptitudeMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000F7D")]
  [Serializable]
  public sealed class WeaponRarityAptitudeMaster : BaseMaster<WeaponRarityAptitudeData>
  {
    [Token(Token = "0x6005B13")]
    [Address(RVA = "0x277D1BC", Offset = "0x277D1BC", VA = "0x277D1BC")]
    public IReadOnlyDictionary<int, WeaponRarityAptitudeData> GetEntities()
    {
      return (IReadOnlyDictionary<int, WeaponRarityAptitudeData>) null;
    }

    [Token(Token = "0x6005B14")]
    [Address(RVA = "0x277D1C4", Offset = "0x277D1C4", VA = "0x277D1C4", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005B15")]
    [Address(RVA = "0x277D224", Offset = "0x277D224", VA = "0x277D224", Slot = "5")]
    protected override WeaponRarityAptitudeData LoadEntity(IMasterDataReader reader)
    {
      return (WeaponRarityAptitudeData) null;
    }

    [Token(Token = "0x6005B16")]
    [Address(RVA = "0x277D27C", Offset = "0x277D27C", VA = "0x277D27C")]
    public WeaponRarityAptitudeMaster()
    {
    }
  }
}
