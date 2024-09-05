// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ArenaWeeklyRewardGroupMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000DEE")]
  [Serializable]
  public sealed class ArenaWeeklyRewardGroupMaster : BaseMaster<ArenaWeeklyRewardGroupData>
  {
    [Token(Token = "0x60054FE")]
    [Address(RVA = "0x3AAA184", Offset = "0x3AAA184", VA = "0x3AAA184")]
    public IReadOnlyDictionary<int, ArenaWeeklyRewardGroupData> GetEntities()
    {
      return (IReadOnlyDictionary<int, ArenaWeeklyRewardGroupData>) null;
    }

    [Token(Token = "0x60054FF")]
    [Address(RVA = "0x3AAA18C", Offset = "0x3AAA18C", VA = "0x3AAA18C", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005500")]
    [Address(RVA = "0x3AAA1EC", Offset = "0x3AAA1EC", VA = "0x3AAA1EC", Slot = "5")]
    protected override ArenaWeeklyRewardGroupData LoadEntity(IMasterDataReader reader)
    {
      return (ArenaWeeklyRewardGroupData) null;
    }

    [Token(Token = "0x6005501")]
    [Address(RVA = "0x3AAA244", Offset = "0x3AAA244", VA = "0x3AAA244")]
    public ArenaWeeklyRewardGroupMaster()
    {
    }
  }
}
