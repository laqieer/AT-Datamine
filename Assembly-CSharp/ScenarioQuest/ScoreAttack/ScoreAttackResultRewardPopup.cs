// Decompiled with JetBrains decompiler
// Type: ScenarioQuest.ScoreAttack.ScoreAttackResultRewardPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace ScenarioQuest.ScoreAttack
{
  [Token(Token = "0x200084B")]
  public class ScoreAttackResultRewardPopup : BaseScoreAttackRewardReceivePopup
  {
    [Token(Token = "0x6002FC5")]
    [Address(RVA = "0x3E7484C", Offset = "0x3E7484C", VA = "0x3E7484C")]
    public void Initialize(
      List<Network.Param.Reward> rewards,
      AssetCachedSpawner spawner,
      BaseScoreAttackRewardReceivePopup.RewardType type,
      Action closeAction = null)
    {
    }

    [Token(Token = "0x6002FC6")]
    [Address(RVA = "0x3E7489C", Offset = "0x3E7489C", VA = "0x3E7489C")]
    private void SetTitleText(BaseScoreAttackRewardReceivePopup.RewardType type)
    {
    }

    [Token(Token = "0x6002FC7")]
    [Address(RVA = "0x3E74988", Offset = "0x3E74988", VA = "0x3E74988")]
    private void OpenSe(BaseScoreAttackRewardReceivePopup.RewardType type)
    {
    }

    [Token(Token = "0x6002FC8")]
    [Address(RVA = "0x3E74A88", Offset = "0x3E74A88", VA = "0x3E74A88")]
    public ScoreAttackResultRewardPopup()
    {
    }
  }
}
