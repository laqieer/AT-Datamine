// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ExpeditionWeaponBaseMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000F9D")]
  [Serializable]
  public sealed class ExpeditionWeaponBaseMaster : BaseMaster<ExpeditionWeaponBaseData>
  {
    [Token(Token = "0x6005BB9")]
    [Address(RVA = "0x2785C24", Offset = "0x2785C24", VA = "0x2785C24")]
    public IReadOnlyDictionary<int, ExpeditionWeaponBaseData> GetEntities()
    {
      return (IReadOnlyDictionary<int, ExpeditionWeaponBaseData>) null;
    }

    [Token(Token = "0x6005BBA")]
    [Address(RVA = "0x2785C2C", Offset = "0x2785C2C", VA = "0x2785C2C", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005BBB")]
    [Address(RVA = "0x2785C8C", Offset = "0x2785C8C", VA = "0x2785C8C", Slot = "5")]
    protected override ExpeditionWeaponBaseData LoadEntity(IMasterDataReader reader)
    {
      return (ExpeditionWeaponBaseData) null;
    }

    [Token(Token = "0x6005BBC")]
    [Address(RVA = "0x2785CE4", Offset = "0x2785CE4", VA = "0x2785CE4")]
    public ExpeditionWeaponBaseMaster()
    {
    }
  }
}
