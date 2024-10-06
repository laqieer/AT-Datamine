// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.BloodTypeMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000ED1")]
  [Serializable]
  public sealed class BloodTypeMaster : BaseMaster<BloodTypeData>
  {
    [Token(Token = "0x6005939")]
    [Address(RVA = "0x3C30EEC", Offset = "0x3C30EEC", VA = "0x3C30EEC")]
    public IReadOnlyDictionary<int, BloodTypeData> GetEntities()
    {
      return (IReadOnlyDictionary<int, BloodTypeData>) null;
    }

    [Token(Token = "0x600593A")]
    [Address(RVA = "0x3C30EF4", Offset = "0x3C30EF4", VA = "0x3C30EF4", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x600593B")]
    [Address(RVA = "0x3C30F54", Offset = "0x3C30F54", VA = "0x3C30F54", Slot = "5")]
    protected override BloodTypeData LoadEntity(IMasterDataReader reader) => (BloodTypeData) null;

    [Token(Token = "0x600593C")]
    [Address(RVA = "0x3C30FAC", Offset = "0x3C30FAC", VA = "0x3C30FAC")]
    public BloodTypeMaster()
    {
    }
  }
}
