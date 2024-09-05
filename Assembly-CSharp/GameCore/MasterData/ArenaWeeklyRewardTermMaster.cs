// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ArenaWeeklyRewardTermMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000DF4")]
  [Serializable]
  public sealed class ArenaWeeklyRewardTermMaster : BaseMaster<ArenaWeeklyRewardTermData>
  {
    [Token(Token = "0x6005516")]
    [Address(RVA = "0x3AAAC24", Offset = "0x3AAAC24", VA = "0x3AAAC24")]
    public IReadOnlyDictionary<int, ArenaWeeklyRewardTermData> GetEntities()
    {
      return (IReadOnlyDictionary<int, ArenaWeeklyRewardTermData>) null;
    }

    [Token(Token = "0x6005517")]
    [Address(RVA = "0x3AAAC2C", Offset = "0x3AAAC2C", VA = "0x3AAAC2C", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005518")]
    [Address(RVA = "0x3AAAC8C", Offset = "0x3AAAC8C", VA = "0x3AAAC8C", Slot = "5")]
    protected override ArenaWeeklyRewardTermData LoadEntity(IMasterDataReader reader)
    {
      return (ArenaWeeklyRewardTermData) null;
    }

    [Token(Token = "0x6005519")]
    [Address(RVA = "0x3AAACE4", Offset = "0x3AAACE4", VA = "0x3AAACE4")]
    public ArenaWeeklyRewardTermMaster()
    {
    }
  }
}
