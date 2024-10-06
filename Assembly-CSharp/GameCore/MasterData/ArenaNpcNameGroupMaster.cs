// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ArenaNpcNameGroupMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000DDE")]
  [Serializable]
  public sealed class ArenaNpcNameGroupMaster : BaseMaster<ArenaNpcNameGroupData>
  {
    [Token(Token = "0x60054B9")]
    [Address(RVA = "0x3AA7764", Offset = "0x3AA7764", VA = "0x3AA7764")]
    public IReadOnlyDictionary<int, ArenaNpcNameGroupData> GetEntities()
    {
      return (IReadOnlyDictionary<int, ArenaNpcNameGroupData>) null;
    }

    [Token(Token = "0x60054BA")]
    [Address(RVA = "0x3AA776C", Offset = "0x3AA776C", VA = "0x3AA776C", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60054BB")]
    [Address(RVA = "0x3AA77CC", Offset = "0x3AA77CC", VA = "0x3AA77CC", Slot = "5")]
    protected override ArenaNpcNameGroupData LoadEntity(IMasterDataReader reader)
    {
      return (ArenaNpcNameGroupData) null;
    }

    [Token(Token = "0x60054BC")]
    [Address(RVA = "0x3AA7824", Offset = "0x3AA7824", VA = "0x3AA7824")]
    public List<ArenaNpcNameGroupData> GetDeckGroup(int group)
    {
      return (List<ArenaNpcNameGroupData>) null;
    }

    [Token(Token = "0x60054BD")]
    [Address(RVA = "0x3AA7A48", Offset = "0x3AA7A48", VA = "0x3AA7A48")]
    public ArenaNpcNameGroupMaster()
    {
    }
  }
}
