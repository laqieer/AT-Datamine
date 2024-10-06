// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.WeaponOptionSlotMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000F83")]
  [Serializable]
  public sealed class WeaponOptionSlotMaster : BaseMaster<WeaponOptionSlotData>
  {
    [Token(Token = "0x6005B3B")]
    [Address(RVA = "0x27808F4", Offset = "0x27808F4", VA = "0x27808F4")]
    public IReadOnlyDictionary<int, WeaponOptionSlotData> GetEntities()
    {
      return (IReadOnlyDictionary<int, WeaponOptionSlotData>) null;
    }

    [Token(Token = "0x6005B3C")]
    [Address(RVA = "0x27808FC", Offset = "0x27808FC", VA = "0x27808FC", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005B3D")]
    [Address(RVA = "0x278095C", Offset = "0x278095C", VA = "0x278095C", Slot = "5")]
    protected override WeaponOptionSlotData LoadEntity(IMasterDataReader reader)
    {
      return (WeaponOptionSlotData) null;
    }

    [Token(Token = "0x6005B3E")]
    [Address(RVA = "0x27809B4", Offset = "0x27809B4", VA = "0x27809B4")]
    public WeaponOptionSlotData GetDataByLimitBreakNum(int limitBreakNum)
    {
      return (WeaponOptionSlotData) null;
    }

    [Token(Token = "0x6005B3F")]
    [Address(RVA = "0x2780B38", Offset = "0x2780B38", VA = "0x2780B38")]
    public WeaponOptionSlotMaster()
    {
    }
  }
}
