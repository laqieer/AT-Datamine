// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ArenaConstMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000DE2")]
  [Serializable]
  public sealed class ArenaConstMaster : BaseMaster<ArenaConstData>
  {
    [Token(Token = "0x4004277")]
    private const int key = 1;

    [Token(Token = "0x60054CD")]
    [Address(RVA = "0x3AA8840", Offset = "0x3AA8840", VA = "0x3AA8840")]
    public IReadOnlyDictionary<int, ArenaConstData> GetEntities()
    {
      return (IReadOnlyDictionary<int, ArenaConstData>) null;
    }

    [Token(Token = "0x60054CE")]
    [Address(RVA = "0x3AA8848", Offset = "0x3AA8848", VA = "0x3AA8848", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60054CF")]
    [Address(RVA = "0x3AA88A8", Offset = "0x3AA88A8", VA = "0x3AA88A8", Slot = "5")]
    protected override ArenaConstData LoadEntity(IMasterDataReader reader) => (ArenaConstData) null;

    [Token(Token = "0x60054D0")]
    [Address(RVA = "0x3AA8900", Offset = "0x3AA8900", VA = "0x3AA8900")]
    public ArenaConstData GetData() => (ArenaConstData) null;

    [Token(Token = "0x60054D1")]
    [Address(RVA = "0x3AA894C", Offset = "0x3AA894C", VA = "0x3AA894C")]
    public ArenaConstMaster()
    {
    }
  }
}
