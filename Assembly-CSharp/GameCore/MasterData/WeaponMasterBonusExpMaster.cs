// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.WeaponMasterBonusExpMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20010D5")]
  [Serializable]
  public sealed class WeaponMasterBonusExpMaster : BaseMaster<WeaponMasterBonusExpData>
  {
    [Token(Token = "0x6006140")]
    [Address(RVA = "0x28DF5AC", Offset = "0x28DF5AC", VA = "0x28DF5AC")]
    public IReadOnlyDictionary<int, WeaponMasterBonusExpData> GetEntities()
    {
      return (IReadOnlyDictionary<int, WeaponMasterBonusExpData>) null;
    }

    [Token(Token = "0x6006141")]
    [Address(RVA = "0x28DF5B4", Offset = "0x28DF5B4", VA = "0x28DF5B4", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006142")]
    [Address(RVA = "0x28DF614", Offset = "0x28DF614", VA = "0x28DF614", Slot = "5")]
    protected override WeaponMasterBonusExpData LoadEntity(IMasterDataReader reader)
    {
      return (WeaponMasterBonusExpData) null;
    }

    [Token(Token = "0x6006143")]
    [Address(RVA = "0x28DF66C", Offset = "0x28DF66C", VA = "0x28DF66C")]
    public IReadOnlyCollection<WeaponMasterBonusExpData> GetList()
    {
      return (IReadOnlyCollection<WeaponMasterBonusExpData>) null;
    }

    [Token(Token = "0x6006144")]
    [Address(RVA = "0x28DF6BC", Offset = "0x28DF6BC", VA = "0x28DF6BC")]
    public WeaponMasterBonusExpData GetLevelByExp(int exp) => (WeaponMasterBonusExpData) null;

    [Token(Token = "0x6006145")]
    [Address(RVA = "0x28DF99C", Offset = "0x28DF99C", VA = "0x28DF99C")]
    public WeaponMasterBonusExpData GetNextLevelByExp(int exp) => (WeaponMasterBonusExpData) null;

    [Token(Token = "0x6006146")]
    [Address(RVA = "0x28DFD70", Offset = "0x28DFD70", VA = "0x28DFD70")]
    public WeaponMasterBonusExpMaster()
    {
    }
  }
}
