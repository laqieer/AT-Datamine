// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.WeaponMasterBonusDescriptionMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20010D2")]
  [Serializable]
  public sealed class WeaponMasterBonusDescriptionMaster : 
    BaseMaster<WeaponMasterBonusDescriptionData>
  {
    [Token(Token = "0x4005281")]
    private const int masterLevelMax = 50;

    [Token(Token = "0x6006134")]
    [Address(RVA = "0x28DED0C", Offset = "0x28DED0C", VA = "0x28DED0C")]
    public IReadOnlyDictionary<int, WeaponMasterBonusDescriptionData> GetEntities()
    {
      return (IReadOnlyDictionary<int, WeaponMasterBonusDescriptionData>) null;
    }

    [Token(Token = "0x6006135")]
    [Address(RVA = "0x28DED14", Offset = "0x28DED14", VA = "0x28DED14", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006136")]
    [Address(RVA = "0x28DED74", Offset = "0x28DED74", VA = "0x28DED74", Slot = "5")]
    protected override WeaponMasterBonusDescriptionData LoadEntity(IMasterDataReader reader)
    {
      return (WeaponMasterBonusDescriptionData) null;
    }

    [Token(Token = "0x6006137")]
    [Address(RVA = "0x28DEDCC", Offset = "0x28DEDCC", VA = "0x28DEDCC")]
    public IReadOnlyCollection<WeaponMasterBonusDescriptionData> GetList()
    {
      return (IReadOnlyCollection<WeaponMasterBonusDescriptionData>) null;
    }

    [Token(Token = "0x6006138")]
    [Address(RVA = "0x28DEE1C", Offset = "0x28DEE1C", VA = "0x28DEE1C")]
    public WeaponMasterBonusDescriptionData GetData(int id, int level)
    {
      return (WeaponMasterBonusDescriptionData) null;
    }

    [Token(Token = "0x6006139")]
    [Address(RVA = "0x28DEF28", Offset = "0x28DEF28", VA = "0x28DEF28")]
    public WeaponMasterBonusDescriptionMaster()
    {
    }
  }
}
