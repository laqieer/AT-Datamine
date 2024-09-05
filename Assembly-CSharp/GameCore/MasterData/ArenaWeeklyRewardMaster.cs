// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ArenaWeeklyRewardMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000DF2")]
  [Serializable]
  public sealed class ArenaWeeklyRewardMaster : BaseMaster<ArenaWeeklyRewardData>
  {
    [Token(Token = "0x600550E")]
    [Address(RVA = "0x3AAA82C", Offset = "0x3AAA82C", VA = "0x3AAA82C")]
    public IReadOnlyDictionary<int, ArenaWeeklyRewardData> GetEntities()
    {
      return (IReadOnlyDictionary<int, ArenaWeeklyRewardData>) null;
    }

    [Token(Token = "0x600550F")]
    [Address(RVA = "0x3AAA834", Offset = "0x3AAA834", VA = "0x3AAA834", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005510")]
    [Address(RVA = "0x3AAA894", Offset = "0x3AAA894", VA = "0x3AAA894", Slot = "5")]
    protected override ArenaWeeklyRewardData LoadEntity(IMasterDataReader reader)
    {
      return (ArenaWeeklyRewardData) null;
    }

    [Token(Token = "0x6005511")]
    [Address(RVA = "0x3AAA8EC", Offset = "0x3AAA8EC", VA = "0x3AAA8EC")]
    public ArenaWeeklyRewardMaster()
    {
    }
  }
}
