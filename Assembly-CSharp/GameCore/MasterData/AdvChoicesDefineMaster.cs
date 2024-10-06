// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AdvChoicesDefineMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000DA5")]
  [Serializable]
  public sealed class AdvChoicesDefineMaster : BaseMaster<AdvChoicesDefineData>
  {
    [Token(Token = "0x6005397")]
    [Address(RVA = "0x3A9B77C", Offset = "0x3A9B77C", VA = "0x3A9B77C")]
    public IReadOnlyDictionary<int, AdvChoicesDefineData> GetEntities()
    {
      return (IReadOnlyDictionary<int, AdvChoicesDefineData>) null;
    }

    [Token(Token = "0x6005398")]
    [Address(RVA = "0x3A9B784", Offset = "0x3A9B784", VA = "0x3A9B784", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005399")]
    [Address(RVA = "0x3A9B7E4", Offset = "0x3A9B7E4", VA = "0x3A9B7E4", Slot = "5")]
    protected override AdvChoicesDefineData LoadEntity(IMasterDataReader reader)
    {
      return (AdvChoicesDefineData) null;
    }

    [Token(Token = "0x600539A")]
    [Address(RVA = "0x3A9B83C", Offset = "0x3A9B83C", VA = "0x3A9B83C")]
    public AdvChoicesDefineMaster()
    {
    }
  }
}
