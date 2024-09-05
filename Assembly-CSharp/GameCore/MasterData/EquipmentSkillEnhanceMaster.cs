// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.EquipmentSkillEnhanceMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001051")]
  [Serializable]
  public sealed class EquipmentSkillEnhanceMaster : BaseMaster<EquipmentSkillEnhanceData>
  {
    [Token(Token = "0x40050D5")]
    public const string TEXT_AB = "text_masterdata_item";

    [Token(Token = "0x6005EC0")]
    [Address(RVA = "0x28C711C", Offset = "0x28C711C", VA = "0x28C711C")]
    public IReadOnlyDictionary<int, EquipmentSkillEnhanceData> GetEntities()
    {
      return (IReadOnlyDictionary<int, EquipmentSkillEnhanceData>) null;
    }

    [Token(Token = "0x6005EC1")]
    [Address(RVA = "0x28C7124", Offset = "0x28C7124", VA = "0x28C7124", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005EC2")]
    [Address(RVA = "0x28C7184", Offset = "0x28C7184", VA = "0x28C7184", Slot = "5")]
    protected override EquipmentSkillEnhanceData LoadEntity(IMasterDataReader reader)
    {
      return (EquipmentSkillEnhanceData) null;
    }

    [Token(Token = "0x6005EC3")]
    [Address(RVA = "0x28C71DC", Offset = "0x28C71DC", VA = "0x28C71DC")]
    public EquipmentSkillEnhanceMaster()
    {
    }
  }
}
