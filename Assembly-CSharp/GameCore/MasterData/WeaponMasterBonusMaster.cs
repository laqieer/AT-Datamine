// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.WeaponMasterBonusMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20010DF")]
  [Serializable]
  public sealed class WeaponMasterBonusMaster : BaseMaster<WeaponMasterBonusData>
  {
    [Token(Token = "0x6006167")]
    [Address(RVA = "0x28E06D4", Offset = "0x28E06D4", VA = "0x28E06D4")]
    public IReadOnlyDictionary<int, WeaponMasterBonusData> GetEntities()
    {
      return (IReadOnlyDictionary<int, WeaponMasterBonusData>) null;
    }

    [Token(Token = "0x6006168")]
    [Address(RVA = "0x28E06DC", Offset = "0x28E06DC", VA = "0x28E06DC", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006169")]
    [Address(RVA = "0x28E073C", Offset = "0x28E073C", VA = "0x28E073C", Slot = "5")]
    protected override WeaponMasterBonusData LoadEntity(IMasterDataReader reader)
    {
      return (WeaponMasterBonusData) null;
    }

    [Token(Token = "0x600616A")]
    [Address(RVA = "0x28E0794", Offset = "0x28E0794", VA = "0x28E0794")]
    public IReadOnlyCollection<WeaponMasterBonusData> GetList()
    {
      return (IReadOnlyCollection<WeaponMasterBonusData>) null;
    }

    [Token(Token = "0x600616B")]
    [Address(RVA = "0x28E07E4", Offset = "0x28E07E4", VA = "0x28E07E4")]
    public WeaponMasterBonusData GetData(int classification) => (WeaponMasterBonusData) null;

    [Token(Token = "0x600616C")]
    [Address(RVA = "0x28E08D0", Offset = "0x28E08D0", VA = "0x28E08D0")]
    public WeaponMasterBonusMaster()
    {
    }
  }
}
