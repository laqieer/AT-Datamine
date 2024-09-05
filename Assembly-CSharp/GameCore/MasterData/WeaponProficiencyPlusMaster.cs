// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.WeaponProficiencyPlusMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000F79")]
  [Serializable]
  public sealed class WeaponProficiencyPlusMaster : BaseMaster<WeaponProficiencyPlusData>
  {
    [Token(Token = "0x6005B03")]
    [Address(RVA = "0x277C87C", Offset = "0x277C87C", VA = "0x277C87C")]
    public IReadOnlyDictionary<int, WeaponProficiencyPlusData> GetEntities()
    {
      return (IReadOnlyDictionary<int, WeaponProficiencyPlusData>) null;
    }

    [Token(Token = "0x6005B04")]
    [Address(RVA = "0x277C884", Offset = "0x277C884", VA = "0x277C884", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005B05")]
    [Address(RVA = "0x277C8E4", Offset = "0x277C8E4", VA = "0x277C8E4", Slot = "5")]
    protected override WeaponProficiencyPlusData LoadEntity(IMasterDataReader reader)
    {
      return (WeaponProficiencyPlusData) null;
    }

    [Token(Token = "0x6005B06")]
    [Address(RVA = "0x277C93C", Offset = "0x277C93C", VA = "0x277C93C")]
    public WeaponProficiencyPlusMaster()
    {
    }
  }
}
