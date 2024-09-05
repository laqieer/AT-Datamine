// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.MissionAchievementConditionMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001097")]
  [Serializable]
  public sealed class MissionAchievementConditionMaster : BaseMaster<MissionAchievementConditionData>
  {
    [Token(Token = "0x6006018")]
    [Address(RVA = "0x28D4920", Offset = "0x28D4920", VA = "0x28D4920")]
    public IReadOnlyDictionary<int, MissionAchievementConditionData> GetEntities()
    {
      return (IReadOnlyDictionary<int, MissionAchievementConditionData>) null;
    }

    [Token(Token = "0x6006019")]
    [Address(RVA = "0x28D4928", Offset = "0x28D4928", VA = "0x28D4928", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x600601A")]
    [Address(RVA = "0x28D4988", Offset = "0x28D4988", VA = "0x28D4988", Slot = "5")]
    protected override MissionAchievementConditionData LoadEntity(IMasterDataReader reader)
    {
      return (MissionAchievementConditionData) null;
    }

    [Token(Token = "0x600601B")]
    [Address(RVA = "0x28D49E0", Offset = "0x28D49E0", VA = "0x28D49E0")]
    public MissionAchievementConditionMaster()
    {
    }
  }
}
