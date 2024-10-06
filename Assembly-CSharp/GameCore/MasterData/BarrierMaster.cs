// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.BarrierMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000DFD")]
  [Serializable]
  public sealed class BarrierMaster : BaseMaster<BarrierData>
  {
    [Token(Token = "0x6005552")]
    [Address(RVA = "0x3AAF440", Offset = "0x3AAF440", VA = "0x3AAF440")]
    public IReadOnlyDictionary<int, BarrierData> GetEntities()
    {
      return (IReadOnlyDictionary<int, BarrierData>) null;
    }

    [Token(Token = "0x6005553")]
    [Address(RVA = "0x3AAF448", Offset = "0x3AAF448", VA = "0x3AAF448", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005554")]
    [Address(RVA = "0x3AAF4A8", Offset = "0x3AAF4A8", VA = "0x3AAF4A8", Slot = "5")]
    protected override BarrierData LoadEntity(IMasterDataReader reader) => (BarrierData) null;

    [Token(Token = "0x6005555")]
    [Address(RVA = "0x3AAF518", Offset = "0x3AAF518", VA = "0x3AAF518")]
    private void OnLoadEntity(BarrierData entity)
    {
    }

    [Token(Token = "0x6005556")]
    [Address(RVA = "0x3AAF5F8", Offset = "0x3AAF5F8", VA = "0x3AAF5F8")]
    public BarrierMaster()
    {
    }
  }
}
