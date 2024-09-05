// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AbilityBoardRewardPatternMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001359")]
  [Serializable]
  public sealed class AbilityBoardRewardPatternMaster : BaseMaster<AbilityBoardRewardPatternData>
  {
    [Token(Token = "0x4005AEC")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, List<AbilityBoardRewardPatternData>> descriptionTable;

    [Token(Token = "0x6006D01")]
    [Address(RVA = "0x46F8B38", Offset = "0x46F8B38", VA = "0x46F8B38")]
    public IReadOnlyDictionary<int, AbilityBoardRewardPatternData> GetEntities()
    {
      return (IReadOnlyDictionary<int, AbilityBoardRewardPatternData>) null;
    }

    [Token(Token = "0x6006D02")]
    [Address(RVA = "0x46F8B40", Offset = "0x46F8B40", VA = "0x46F8B40", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006D03")]
    [Address(RVA = "0x46F8E04", Offset = "0x46F8E04", VA = "0x46F8E04", Slot = "5")]
    protected override AbilityBoardRewardPatternData LoadEntity(IMasterDataReader reader)
    {
      return (AbilityBoardRewardPatternData) null;
    }

    [Token(Token = "0x6006D04")]
    [Address(RVA = "0x46F8E74", Offset = "0x46F8E74", VA = "0x46F8E74")]
    private void OnLoadEntity(AbilityBoardRewardPatternData entity)
    {
    }

    [Token(Token = "0x6006D05")]
    [Address(RVA = "0x46F8BA8", Offset = "0x46F8BA8", VA = "0x46F8BA8")]
    private void OnCompletedLoading()
    {
    }

    [Token(Token = "0x6006D06")]
    [Address(RVA = "0x46F8E78", Offset = "0x46F8E78", VA = "0x46F8E78")]
    private void GroupingByGroupId(AbilityBoardRewardPatternData entity)
    {
    }

    [Token(Token = "0x6006D07")]
    [Address(RVA = "0x46F9034", Offset = "0x46F9034", VA = "0x46F9034")]
    public AbilityBoardRewardPatternData GetDataByRewardTypeAndPatternId(
      int rewardType,
      int patternId)
    {
      return (AbilityBoardRewardPatternData) null;
    }

    [Token(Token = "0x6006D08")]
    [Address(RVA = "0x46F91D8", Offset = "0x46F91D8", VA = "0x46F91D8")]
    public AbilityBoardRewardPatternMaster()
    {
    }
  }
}
