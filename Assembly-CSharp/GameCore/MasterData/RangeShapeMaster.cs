// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.RangeShapeMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20011B3")]
  [Serializable]
  public sealed class RangeShapeMaster : BaseMaster<RangeShapeData>
  {
    [Token(Token = "0x6006561")]
    [Address(RVA = "0x4D1A820", Offset = "0x4D1A820", VA = "0x4D1A820")]
    public IReadOnlyDictionary<int, RangeShapeData> GetEntities()
    {
      return (IReadOnlyDictionary<int, RangeShapeData>) null;
    }

    [Token(Token = "0x6006562")]
    [Address(RVA = "0x4D1A828", Offset = "0x4D1A828", VA = "0x4D1A828", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006563")]
    [Address(RVA = "0x4D1A888", Offset = "0x4D1A888", VA = "0x4D1A888", Slot = "5")]
    protected override RangeShapeData LoadEntity(IMasterDataReader reader) => (RangeShapeData) null;

    [Token(Token = "0x6006564")]
    [Address(RVA = "0x4D1A8E0", Offset = "0x4D1A8E0", VA = "0x4D1A8E0")]
    public RangeShapeMaster()
    {
    }
  }
}
