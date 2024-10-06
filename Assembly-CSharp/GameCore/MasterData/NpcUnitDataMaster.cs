// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.NpcUnitDataMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E59")]
  [Serializable]
  public sealed class NpcUnitDataMaster : BaseMaster<NpcUnitDataData>
  {
    [Token(Token = "0x6005770")]
    [Address(RVA = "0x3E3E088", Offset = "0x3E3E088", VA = "0x3E3E088")]
    public IReadOnlyDictionary<int, NpcUnitDataData> GetEntities()
    {
      return (IReadOnlyDictionary<int, NpcUnitDataData>) null;
    }

    [Token(Token = "0x6005771")]
    [Address(RVA = "0x3E3E090", Offset = "0x3E3E090", VA = "0x3E3E090", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005772")]
    [Address(RVA = "0x3E3E0F0", Offset = "0x3E3E0F0", VA = "0x3E3E0F0", Slot = "5")]
    protected override NpcUnitDataData LoadEntity(IMasterDataReader reader)
    {
      return (NpcUnitDataData) null;
    }

    [Token(Token = "0x6005773")]
    [Address(RVA = "0x3E3E160", Offset = "0x3E3E160", VA = "0x3E3E160")]
    private void OnLoadEntity(NpcUnitDataData entity)
    {
    }

    [Token(Token = "0x6005774")]
    [Address(RVA = "0x3E3EF30", Offset = "0x3E3EF30", VA = "0x3E3EF30")]
    public NpcUnitDataMaster()
    {
    }
  }
}
