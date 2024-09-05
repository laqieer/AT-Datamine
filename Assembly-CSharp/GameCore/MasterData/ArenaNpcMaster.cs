// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ArenaNpcMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000DE0")]
  [Serializable]
  public sealed class ArenaNpcMaster : BaseMaster<ArenaNpcData>
  {
    [Token(Token = "0x60054C2")]
    [Address(RVA = "0x3AA7CA4", Offset = "0x3AA7CA4", VA = "0x3AA7CA4")]
    public IReadOnlyDictionary<int, ArenaNpcData> GetEntities()
    {
      return (IReadOnlyDictionary<int, ArenaNpcData>) null;
    }

    [Token(Token = "0x60054C3")]
    [Address(RVA = "0x3AA7CAC", Offset = "0x3AA7CAC", VA = "0x3AA7CAC", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60054C4")]
    [Address(RVA = "0x3AA7D0C", Offset = "0x3AA7D0C", VA = "0x3AA7D0C", Slot = "5")]
    protected override ArenaNpcData LoadEntity(IMasterDataReader reader) => (ArenaNpcData) null;

    [Token(Token = "0x60054C5")]
    [Address(RVA = "0x3AA7D64", Offset = "0x3AA7D64", VA = "0x3AA7D64")]
    public ArenaNpcData GetByRanking(int ranking) => (ArenaNpcData) null;

    [Token(Token = "0x60054C6")]
    [Address(RVA = "0x3AA7EDC", Offset = "0x3AA7EDC", VA = "0x3AA7EDC")]
    public ArenaNpcMaster()
    {
    }
  }
}
