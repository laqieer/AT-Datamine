// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AccessoryOptionSlotMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000F41")]
  [Serializable]
  public sealed class AccessoryOptionSlotMaster : BaseMaster<AccessoryOptionSlotData>
  {
    [Token(Token = "0x60059EC")]
    [Address(RVA = "0x3C3A094", Offset = "0x3C3A094", VA = "0x3C3A094")]
    public IReadOnlyDictionary<int, AccessoryOptionSlotData> GetEntities()
    {
      return (IReadOnlyDictionary<int, AccessoryOptionSlotData>) null;
    }

    [Token(Token = "0x60059ED")]
    [Address(RVA = "0x3C3A09C", Offset = "0x3C3A09C", VA = "0x3C3A09C", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60059EE")]
    [Address(RVA = "0x3C3A0FC", Offset = "0x3C3A0FC", VA = "0x3C3A0FC", Slot = "5")]
    protected override AccessoryOptionSlotData LoadEntity(IMasterDataReader reader)
    {
      return (AccessoryOptionSlotData) null;
    }

    [Token(Token = "0x60059EF")]
    [Address(RVA = "0x3C3A154", Offset = "0x3C3A154", VA = "0x3C3A154")]
    public AccessoryOptionSlotData GetDataByLimitBreakNum(int limitBreakNum)
    {
      return (AccessoryOptionSlotData) null;
    }

    [Token(Token = "0x60059F0")]
    [Address(RVA = "0x3C3A2D8", Offset = "0x3C3A2D8", VA = "0x3C3A2D8")]
    public AccessoryOptionSlotMaster()
    {
    }
  }
}
