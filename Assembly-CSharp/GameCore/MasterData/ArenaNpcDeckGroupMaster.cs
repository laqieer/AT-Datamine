// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ArenaNpcDeckGroupMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000DDC")]
  [Serializable]
  public sealed class ArenaNpcDeckGroupMaster : BaseMaster<ArenaNpcDeckGroupData>
  {
    [Token(Token = "0x60054B0")]
    [Address(RVA = "0x3AA7228", Offset = "0x3AA7228", VA = "0x3AA7228")]
    public IReadOnlyDictionary<int, ArenaNpcDeckGroupData> GetEntities()
    {
      return (IReadOnlyDictionary<int, ArenaNpcDeckGroupData>) null;
    }

    [Token(Token = "0x60054B1")]
    [Address(RVA = "0x3AA7230", Offset = "0x3AA7230", VA = "0x3AA7230", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60054B2")]
    [Address(RVA = "0x3AA7290", Offset = "0x3AA7290", VA = "0x3AA7290", Slot = "5")]
    protected override ArenaNpcDeckGroupData LoadEntity(IMasterDataReader reader)
    {
      return (ArenaNpcDeckGroupData) null;
    }

    [Token(Token = "0x60054B3")]
    [Address(RVA = "0x3AA72E8", Offset = "0x3AA72E8", VA = "0x3AA72E8")]
    public List<ArenaNpcDeckGroupData> GetDeckGroup(int group)
    {
      return (List<ArenaNpcDeckGroupData>) null;
    }

    [Token(Token = "0x60054B4")]
    [Address(RVA = "0x3AA750C", Offset = "0x3AA750C", VA = "0x3AA750C")]
    public ArenaNpcDeckGroupMaster()
    {
    }
  }
}
