// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.SexTypeMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000F14")]
  [Serializable]
  public sealed class SexTypeMaster : BaseMaster<SexTypeData>
  {
    [Token(Token = "0x6005982")]
    [Address(RVA = "0x3C328A4", Offset = "0x3C328A4", VA = "0x3C328A4")]
    public IReadOnlyDictionary<int, SexTypeData> GetEntities()
    {
      return (IReadOnlyDictionary<int, SexTypeData>) null;
    }

    [Token(Token = "0x6005983")]
    [Address(RVA = "0x3C328AC", Offset = "0x3C328AC", VA = "0x3C328AC", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005984")]
    [Address(RVA = "0x3C3290C", Offset = "0x3C3290C", VA = "0x3C3290C", Slot = "5")]
    protected override SexTypeData LoadEntity(IMasterDataReader reader) => (SexTypeData) null;

    [Token(Token = "0x6005985")]
    [Address(RVA = "0x3C32964", Offset = "0x3C32964", VA = "0x3C32964")]
    public SexTypeMaster()
    {
    }
  }
}
