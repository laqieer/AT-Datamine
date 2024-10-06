// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.EquipmentClassificationMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E8B")]
  [Serializable]
  public sealed class EquipmentClassificationMaster : BaseMaster<EquipmentClassificationData>
  {
    [Token(Token = "0x6005887")]
    [Address(RVA = "0x3C2B66C", Offset = "0x3C2B66C", VA = "0x3C2B66C")]
    public IReadOnlyDictionary<int, EquipmentClassificationData> GetEntities()
    {
      return (IReadOnlyDictionary<int, EquipmentClassificationData>) null;
    }

    [Token(Token = "0x6005888")]
    [Address(RVA = "0x3C2B674", Offset = "0x3C2B674", VA = "0x3C2B674", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005889")]
    [Address(RVA = "0x3C2B6D4", Offset = "0x3C2B6D4", VA = "0x3C2B6D4", Slot = "5")]
    protected override EquipmentClassificationData LoadEntity(IMasterDataReader reader)
    {
      return (EquipmentClassificationData) null;
    }

    [Token(Token = "0x600588A")]
    [Address(RVA = "0x3C2B72C", Offset = "0x3C2B72C", VA = "0x3C2B72C")]
    public IReadOnlyCollection<EquipmentClassificationData> GetList()
    {
      return (IReadOnlyCollection<EquipmentClassificationData>) null;
    }

    [Token(Token = "0x600588B")]
    [Address(RVA = "0x3C2B77C", Offset = "0x3C2B77C", VA = "0x3C2B77C")]
    public EquipmentClassificationMaster()
    {
    }
  }
}
