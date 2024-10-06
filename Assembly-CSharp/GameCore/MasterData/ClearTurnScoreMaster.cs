// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ClearTurnScoreMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001109")]
  [Serializable]
  public sealed class ClearTurnScoreMaster : BaseMaster<ClearTurnScoreData>
  {
    [Token(Token = "0x600622E")]
    [Address(RVA = "0x4ADD58C", Offset = "0x4ADD58C", VA = "0x4ADD58C")]
    public IReadOnlyDictionary<int, ClearTurnScoreData> GetEntities()
    {
      return (IReadOnlyDictionary<int, ClearTurnScoreData>) null;
    }

    [Token(Token = "0x600622F")]
    [Address(RVA = "0x4ADD594", Offset = "0x4ADD594", VA = "0x4ADD594", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006230")]
    [Address(RVA = "0x4ADD5F4", Offset = "0x4ADD5F4", VA = "0x4ADD5F4", Slot = "5")]
    protected override ClearTurnScoreData LoadEntity(IMasterDataReader reader)
    {
      return (ClearTurnScoreData) null;
    }

    [Token(Token = "0x6006231")]
    [Address(RVA = "0x4ADD64C", Offset = "0x4ADD64C", VA = "0x4ADD64C")]
    public IReadOnlyCollection<ClearTurnScoreData> GetListByGroupID(int groupId)
    {
      return (IReadOnlyCollection<ClearTurnScoreData>) null;
    }

    [Token(Token = "0x6006232")]
    [Address(RVA = "0x4ADD840", Offset = "0x4ADD840", VA = "0x4ADD840")]
    public ClearTurnScoreMaster()
    {
    }
  }
}
