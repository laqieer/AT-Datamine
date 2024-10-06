// Decompiled with JetBrains decompiler
// Type: StaqData.SubQuestClearReward
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x20020DF")]
  public class SubQuestClearReward
  {
    [Token(Token = "0x4008B4E")]
    [FieldOffset(Offset = "0x10")]
    private List<RewardData> rewardDataList;

    [Token(Token = "0x600C723")]
    [Address(RVA = "0x1CDC6CC", Offset = "0x1CDC6CC", VA = "0x1CDC6CC")]
    public IEnumerable<RewardData> GetRewards() => (IEnumerable<RewardData>) null;

    [Token(Token = "0x600C724")]
    [Address(RVA = "0x1CDC6D4", Offset = "0x1CDC6D4", VA = "0x1CDC6D4")]
    public void Apply(int subquestID, int clearCount)
    {
    }

    [Token(Token = "0x600C725")]
    [Address(RVA = "0x1CDCCBC", Offset = "0x1CDCCBC", VA = "0x1CDCCBC")]
    private bool ReachedClearCount(StorySubquestRewardsData reward, int clearCount) => new bool();

    [Token(Token = "0x600C726")]
    [Address(RVA = "0x1CDCCF0", Offset = "0x1CDCCF0", VA = "0x1CDCCF0")]
    public void ClearRewardList()
    {
    }

    [Token(Token = "0x600C727")]
    [Address(RVA = "0x1CDCD6C", Offset = "0x1CDCD6C", VA = "0x1CDCD6C")]
    public SubQuestClearReward()
    {
    }
  }
}
