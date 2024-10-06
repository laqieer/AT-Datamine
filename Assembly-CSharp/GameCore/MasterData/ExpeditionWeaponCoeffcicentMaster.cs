// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ExpeditionWeaponCoeffcicentMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000F9F")]
  [Serializable]
  public sealed class ExpeditionWeaponCoeffcicentMaster : BaseMaster<ExpeditionWeaponCoeffcicentData>
  {
    [Token(Token = "0x6005BC1")]
    [Address(RVA = "0x2785ECC", Offset = "0x2785ECC", VA = "0x2785ECC")]
    public IReadOnlyDictionary<int, ExpeditionWeaponCoeffcicentData> GetEntities()
    {
      return (IReadOnlyDictionary<int, ExpeditionWeaponCoeffcicentData>) null;
    }

    [Token(Token = "0x6005BC2")]
    [Address(RVA = "0x2785ED4", Offset = "0x2785ED4", VA = "0x2785ED4", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005BC3")]
    [Address(RVA = "0x2785F34", Offset = "0x2785F34", VA = "0x2785F34", Slot = "5")]
    protected override ExpeditionWeaponCoeffcicentData LoadEntity(IMasterDataReader reader)
    {
      return (ExpeditionWeaponCoeffcicentData) null;
    }

    [Token(Token = "0x6005BC4")]
    [Address(RVA = "0x2785F8C", Offset = "0x2785F8C", VA = "0x2785F8C")]
    public ExpeditionWeaponCoeffcicentData Get(
      int classification,
      ProficiencyTypeEnum proficiencyType)
    {
      return (ExpeditionWeaponCoeffcicentData) null;
    }

    [Token(Token = "0x6005BC5")]
    [Address(RVA = "0x2786110", Offset = "0x2786110", VA = "0x2786110")]
    public ExpeditionWeaponCoeffcicentMaster()
    {
    }
  }
}
