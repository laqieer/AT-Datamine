// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.WeaponLimitBreakDescriptionMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000F74")]
  [Serializable]
  public sealed class WeaponLimitBreakDescriptionMaster : BaseMaster<WeaponLimitBreakDescriptionData>
  {
    [Token(Token = "0x6005AF0")]
    [Address(RVA = "0x277C054", Offset = "0x277C054", VA = "0x277C054")]
    public IReadOnlyDictionary<int, WeaponLimitBreakDescriptionData> GetEntities()
    {
      return (IReadOnlyDictionary<int, WeaponLimitBreakDescriptionData>) null;
    }

    [Token(Token = "0x6005AF1")]
    [Address(RVA = "0x277C05C", Offset = "0x277C05C", VA = "0x277C05C", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005AF2")]
    [Address(RVA = "0x277C0BC", Offset = "0x277C0BC", VA = "0x277C0BC", Slot = "5")]
    protected override WeaponLimitBreakDescriptionData LoadEntity(IMasterDataReader reader)
    {
      return (WeaponLimitBreakDescriptionData) null;
    }

    [Token(Token = "0x6005AF3")]
    [Address(RVA = "0x277C114", Offset = "0x277C114", VA = "0x277C114")]
    public WeaponLimitBreakDescriptionData GetData(
      int weaponLimitBreak,
      int limitBreakCount,
      RarityTypeEnum rarity)
    {
      return (WeaponLimitBreakDescriptionData) null;
    }

    [Token(Token = "0x6005AF4")]
    [Address(RVA = "0x277C21C", Offset = "0x277C21C", VA = "0x277C21C")]
    public WeaponLimitBreakDescriptionMaster()
    {
    }
  }
}
