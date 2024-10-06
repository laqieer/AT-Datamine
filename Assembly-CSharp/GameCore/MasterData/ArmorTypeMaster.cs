// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ArmorTypeMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000EB2")]
  [Serializable]
  public sealed class ArmorTypeMaster : BaseMaster<ArmorTypeData>
  {
    [Token(Token = "0x6005919")]
    [Address(RVA = "0x3C302E0", Offset = "0x3C302E0", VA = "0x3C302E0")]
    public IReadOnlyDictionary<int, ArmorTypeData> GetEntities()
    {
      return (IReadOnlyDictionary<int, ArmorTypeData>) null;
    }

    [Token(Token = "0x600591A")]
    [Address(RVA = "0x3C302E8", Offset = "0x3C302E8", VA = "0x3C302E8", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x600591B")]
    [Address(RVA = "0x3C30348", Offset = "0x3C30348", VA = "0x3C30348", Slot = "5")]
    protected override ArmorTypeData LoadEntity(IMasterDataReader reader) => (ArmorTypeData) null;

    [Token(Token = "0x600591C")]
    [Address(RVA = "0x3C303A0", Offset = "0x3C303A0", VA = "0x3C303A0")]
    public ArmorTypeMaster()
    {
    }
  }
}
