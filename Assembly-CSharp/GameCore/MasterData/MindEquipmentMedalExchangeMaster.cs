// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.MindEquipmentMedalExchangeMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000F62")]
  [Serializable]
  public sealed class MindEquipmentMedalExchangeMaster : BaseMaster<MindEquipmentMedalExchangeData>
  {
    [Token(Token = "0x6005A80")]
    [Address(RVA = "0x3C3EC28", Offset = "0x3C3EC28", VA = "0x3C3EC28")]
    public IReadOnlyDictionary<int, MindEquipmentMedalExchangeData> GetEntities()
    {
      return (IReadOnlyDictionary<int, MindEquipmentMedalExchangeData>) null;
    }

    [Token(Token = "0x6005A81")]
    [Address(RVA = "0x3C3EC30", Offset = "0x3C3EC30", VA = "0x3C3EC30", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005A82")]
    [Address(RVA = "0x3C3EC90", Offset = "0x3C3EC90", VA = "0x3C3EC90", Slot = "5")]
    protected override MindEquipmentMedalExchangeData LoadEntity(IMasterDataReader reader)
    {
      return (MindEquipmentMedalExchangeData) null;
    }

    [Token(Token = "0x6005A83")]
    [Address(RVA = "0x3C3ECE8", Offset = "0x3C3ECE8", VA = "0x3C3ECE8")]
    public MindEquipmentMedalExchangeMaster()
    {
    }
  }
}
