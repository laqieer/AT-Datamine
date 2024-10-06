// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ArenaWeeklyRewardSetMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000DF0")]
  [Serializable]
  public sealed class ArenaWeeklyRewardSetMaster : BaseMaster<ArenaWeeklyRewardSetData>
  {
    [Token(Token = "0x6005506")]
    [Address(RVA = "0x3AAA430", Offset = "0x3AAA430", VA = "0x3AAA430")]
    public IReadOnlyDictionary<int, ArenaWeeklyRewardSetData> GetEntities()
    {
      return (IReadOnlyDictionary<int, ArenaWeeklyRewardSetData>) null;
    }

    [Token(Token = "0x6005507")]
    [Address(RVA = "0x3AAA438", Offset = "0x3AAA438", VA = "0x3AAA438", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005508")]
    [Address(RVA = "0x3AAA498", Offset = "0x3AAA498", VA = "0x3AAA498", Slot = "5")]
    protected override ArenaWeeklyRewardSetData LoadEntity(IMasterDataReader reader)
    {
      return (ArenaWeeklyRewardSetData) null;
    }

    [Token(Token = "0x6005509")]
    [Address(RVA = "0x3AAA4F0", Offset = "0x3AAA4F0", VA = "0x3AAA4F0")]
    public ArenaWeeklyRewardSetMaster()
    {
    }
  }
}
