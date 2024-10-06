// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.RangeShapeDetailMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20011B0")]
  [Serializable]
  public sealed class RangeShapeDetailMaster : BaseMaster<RangeShapeDetailData>
  {
    [Token(Token = "0x4005530")]
    private const int CenterCellValue = 100;
    [Token(Token = "0x4005531")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, RangeData> rangeMap;

    [Token(Token = "0x6006555")]
    [Address(RVA = "0x4D19F38", Offset = "0x4D19F38", VA = "0x4D19F38")]
    public IReadOnlyDictionary<int, RangeShapeDetailData> GetEntities()
    {
      return (IReadOnlyDictionary<int, RangeShapeDetailData>) null;
    }

    [Token(Token = "0x6006556")]
    [Address(RVA = "0x4D19F40", Offset = "0x4D19F40", VA = "0x4D19F40", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006557")]
    [Address(RVA = "0x4D1A444", Offset = "0x4D1A444", VA = "0x4D1A444", Slot = "5")]
    protected override RangeShapeDetailData LoadEntity(IMasterDataReader reader)
    {
      return (RangeShapeDetailData) null;
    }

    [Token(Token = "0x6006558")]
    [Address(RVA = "0x4D19FA8", Offset = "0x4D19FA8", VA = "0x4D19FA8")]
    private void OnCompletedLoading()
    {
    }

    [Token(Token = "0x6006559")]
    [Address(RVA = "0x4D1A49C", Offset = "0x4D1A49C", VA = "0x4D1A49C")]
    public RangeData GetListByGroupID(int groupId) => (RangeData) null;

    [Token(Token = "0x600655A")]
    [Address(RVA = "0x4D1A50C", Offset = "0x4D1A50C", VA = "0x4D1A50C")]
    public RangeShapeDetailMaster()
    {
    }
  }
}
