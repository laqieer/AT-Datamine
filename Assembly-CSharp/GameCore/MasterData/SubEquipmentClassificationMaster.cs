// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.SubEquipmentClassificationMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E90")]
  [Serializable]
  public sealed class SubEquipmentClassificationMaster : BaseMaster<SubEquipmentClassificationData>
  {
    [Token(Token = "0x600589D")]
    [Address(RVA = "0x3C2C7C8", Offset = "0x3C2C7C8", VA = "0x3C2C7C8")]
    public IReadOnlyDictionary<int, SubEquipmentClassificationData> GetEntities()
    {
      return (IReadOnlyDictionary<int, SubEquipmentClassificationData>) null;
    }

    [Token(Token = "0x600589E")]
    [Address(RVA = "0x3C2C7D0", Offset = "0x3C2C7D0", VA = "0x3C2C7D0", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x600589F")]
    [Address(RVA = "0x3C2C830", Offset = "0x3C2C830", VA = "0x3C2C830", Slot = "5")]
    protected override SubEquipmentClassificationData LoadEntity(IMasterDataReader reader)
    {
      return (SubEquipmentClassificationData) null;
    }

    [Token(Token = "0x60058A0")]
    [Address(RVA = "0x3C2C888", Offset = "0x3C2C888", VA = "0x3C2C888")]
    public SubEquipmentClassificationMaster()
    {
    }
  }
}
