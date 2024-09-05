// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.CustomSkillTypeEquipmentLimitMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20011AB")]
  [Serializable]
  public sealed class CustomSkillTypeEquipmentLimitMaster : 
    BaseMaster<CustomSkillTypeEquipmentLimitData>
  {
    [Token(Token = "0x600653B")]
    [Address(RVA = "0x4AF6C9C", Offset = "0x4AF6C9C", VA = "0x4AF6C9C")]
    public IReadOnlyDictionary<int, CustomSkillTypeEquipmentLimitData> GetEntities()
    {
      return (IReadOnlyDictionary<int, CustomSkillTypeEquipmentLimitData>) null;
    }

    [Token(Token = "0x600653C")]
    [Address(RVA = "0x4AF6CA4", Offset = "0x4AF6CA4", VA = "0x4AF6CA4", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x600653D")]
    [Address(RVA = "0x4AF6D04", Offset = "0x4AF6D04", VA = "0x4AF6D04", Slot = "5")]
    protected override CustomSkillTypeEquipmentLimitData LoadEntity(IMasterDataReader reader)
    {
      return (CustomSkillTypeEquipmentLimitData) null;
    }

    [Token(Token = "0x600653E")]
    [Address(RVA = "0x4AF6D5C", Offset = "0x4AF6D5C", VA = "0x4AF6D5C")]
    public CustomSkillTypeEquipmentLimitMaster()
    {
    }
  }
}
