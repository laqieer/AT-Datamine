// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.WeaponMasterBonusGainExpMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20010DC")]
  [Serializable]
  public sealed class WeaponMasterBonusGainExpMaster : BaseMaster<WeaponMasterBonusGainExpData>
  {
    [Token(Token = "0x600615B")]
    [Address(RVA = "0x28E025C", Offset = "0x28E025C", VA = "0x28E025C")]
    public IReadOnlyDictionary<int, WeaponMasterBonusGainExpData> GetEntities()
    {
      return (IReadOnlyDictionary<int, WeaponMasterBonusGainExpData>) null;
    }

    [Token(Token = "0x600615C")]
    [Address(RVA = "0x28E0264", Offset = "0x28E0264", VA = "0x28E0264", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x600615D")]
    [Address(RVA = "0x28E02C4", Offset = "0x28E02C4", VA = "0x28E02C4", Slot = "5")]
    protected override WeaponMasterBonusGainExpData LoadEntity(IMasterDataReader reader)
    {
      return (WeaponMasterBonusGainExpData) null;
    }

    [Token(Token = "0x600615E")]
    [Address(RVA = "0x28E031C", Offset = "0x28E031C", VA = "0x28E031C")]
    public IReadOnlyCollection<WeaponMasterBonusGainExpData> GetList()
    {
      return (IReadOnlyCollection<WeaponMasterBonusGainExpData>) null;
    }

    [Token(Token = "0x600615F")]
    [Address(RVA = "0x28E036C", Offset = "0x28E036C", VA = "0x28E036C")]
    public WeaponMasterBonusGainExpData GetGainExpData(int level)
    {
      return (WeaponMasterBonusGainExpData) null;
    }

    [Token(Token = "0x6006160")]
    [Address(RVA = "0x28E0458", Offset = "0x28E0458", VA = "0x28E0458")]
    public WeaponMasterBonusGainExpMaster()
    {
    }
  }
}
