// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StyleMasterBonusMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20010D0")]
  [Serializable]
  public sealed class StyleMasterBonusMaster : BaseMaster<StyleMasterBonusData>
  {
    [Token(Token = "0x600612C")]
    [Address(RVA = "0x28DE910", Offset = "0x28DE910", VA = "0x28DE910")]
    public IReadOnlyDictionary<int, StyleMasterBonusData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StyleMasterBonusData>) null;
    }

    [Token(Token = "0x600612D")]
    [Address(RVA = "0x28DE918", Offset = "0x28DE918", VA = "0x28DE918", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x600612E")]
    [Address(RVA = "0x28DE978", Offset = "0x28DE978", VA = "0x28DE978", Slot = "5")]
    protected override StyleMasterBonusData LoadEntity(IMasterDataReader reader)
    {
      return (StyleMasterBonusData) null;
    }

    [Token(Token = "0x600612F")]
    [Address(RVA = "0x28DE9D0", Offset = "0x28DE9D0", VA = "0x28DE9D0")]
    public StyleMasterBonusMaster()
    {
    }
  }
}
