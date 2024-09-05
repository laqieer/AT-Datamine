// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.RideTypeMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000F10")]
  [Serializable]
  public sealed class RideTypeMaster : BaseMaster<RideTypeData>
  {
    [Token(Token = "0x600597A")]
    [Address(RVA = "0x3C32584", Offset = "0x3C32584", VA = "0x3C32584")]
    public IReadOnlyDictionary<int, RideTypeData> GetEntities()
    {
      return (IReadOnlyDictionary<int, RideTypeData>) null;
    }

    [Token(Token = "0x600597B")]
    [Address(RVA = "0x3C3258C", Offset = "0x3C3258C", VA = "0x3C3258C", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x600597C")]
    [Address(RVA = "0x3C325EC", Offset = "0x3C325EC", VA = "0x3C325EC", Slot = "5")]
    protected override RideTypeData LoadEntity(IMasterDataReader reader) => (RideTypeData) null;

    [Token(Token = "0x600597D")]
    [Address(RVA = "0x3C32644", Offset = "0x3C32644", VA = "0x3C32644")]
    public RideTypeMaster()
    {
    }
  }
}
