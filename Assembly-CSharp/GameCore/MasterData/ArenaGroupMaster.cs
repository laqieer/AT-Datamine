// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ArenaGroupMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000DE4")]
  [Serializable]
  public sealed class ArenaGroupMaster : BaseMaster<ArenaGroupData>
  {
    [Token(Token = "0x60054D6")]
    [Address(RVA = "0x3AA8DD4", Offset = "0x3AA8DD4", VA = "0x3AA8DD4")]
    public IReadOnlyDictionary<int, ArenaGroupData> GetEntities()
    {
      return (IReadOnlyDictionary<int, ArenaGroupData>) null;
    }

    [Token(Token = "0x60054D7")]
    [Address(RVA = "0x3AA8DDC", Offset = "0x3AA8DDC", VA = "0x3AA8DDC", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60054D8")]
    [Address(RVA = "0x3AA8E3C", Offset = "0x3AA8E3C", VA = "0x3AA8E3C", Slot = "5")]
    protected override ArenaGroupData LoadEntity(IMasterDataReader reader) => (ArenaGroupData) null;

    [Token(Token = "0x60054D9")]
    [Address(RVA = "0x3AA8E94", Offset = "0x3AA8E94", VA = "0x3AA8E94")]
    public ArenaGroupMaster()
    {
    }
  }
}
