// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AdvArithmeticTypeMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000DA3")]
  [Serializable]
  public sealed class AdvArithmeticTypeMaster : BaseMaster<AdvArithmeticTypeData>
  {
    [Token(Token = "0x600538F")]
    [Address(RVA = "0x3A9B45C", Offset = "0x3A9B45C", VA = "0x3A9B45C")]
    public IReadOnlyDictionary<int, AdvArithmeticTypeData> GetEntities()
    {
      return (IReadOnlyDictionary<int, AdvArithmeticTypeData>) null;
    }

    [Token(Token = "0x6005390")]
    [Address(RVA = "0x3A9B464", Offset = "0x3A9B464", VA = "0x3A9B464", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005391")]
    [Address(RVA = "0x3A9B4C4", Offset = "0x3A9B4C4", VA = "0x3A9B4C4", Slot = "5")]
    protected override AdvArithmeticTypeData LoadEntity(IMasterDataReader reader)
    {
      return (AdvArithmeticTypeData) null;
    }

    [Token(Token = "0x6005392")]
    [Address(RVA = "0x3A9B51C", Offset = "0x3A9B51C", VA = "0x3A9B51C")]
    public AdvArithmeticTypeMaster()
    {
    }
  }
}
