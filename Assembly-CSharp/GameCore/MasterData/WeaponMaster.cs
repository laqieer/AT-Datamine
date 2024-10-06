// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.WeaponMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000F7F")]
  [Serializable]
  public sealed class WeaponMaster : BaseMaster<WeaponData>
  {
    [Token(Token = "0x4004DFD")]
    public const string TEXT_AB = "text_masterdata_equipment";

    [Token(Token = "0x6005B1B")]
    [Address(RVA = "0x277D544", Offset = "0x277D544", VA = "0x277D544")]
    public IReadOnlyDictionary<int, WeaponData> GetEntities()
    {
      return (IReadOnlyDictionary<int, WeaponData>) null;
    }

    [Token(Token = "0x6005B1C")]
    [Address(RVA = "0x277D54C", Offset = "0x277D54C", VA = "0x277D54C", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005B1D")]
    [Address(RVA = "0x277D5AC", Offset = "0x277D5AC", VA = "0x277D5AC", Slot = "5")]
    protected override WeaponData LoadEntity(IMasterDataReader reader) => (WeaponData) null;

    [Token(Token = "0x6005B1E")]
    [Address(RVA = "0x277D604", Offset = "0x277D604", VA = "0x277D604")]
    public IReadOnlyCollection<WeaponData> GetList() => (IReadOnlyCollection<WeaponData>) null;

    [Token(Token = "0x6005B1F")]
    [Address(RVA = "0x277D654", Offset = "0x277D654", VA = "0x277D654")]
    public WeaponMaster()
    {
    }
  }
}
