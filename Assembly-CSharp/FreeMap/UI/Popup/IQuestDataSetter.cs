// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.Popup.IQuestDataSetter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System;
using System.Collections;
using UI;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace FreeMap.UI.Popup
{
  [Token(Token = "0x2001622")]
  public interface IQuestDataSetter
  {
    [Token(Token = "0x6007D65")]
    void SetTitle(TextAccessor title);

    [Token(Token = "0x6007D66")]
    void SetDescription(TextAccessor description);

    [Token(Token = "0x6007D67")]
    void SetConditions(TextAccessor conditions);

    [Token(Token = "0x6007D68")]
    void SetPeriod(QuestPeriodUI periodUI);

    [Token(Token = "0x6007D69")]
    void SetRepeat(Image cycleUI);

    [Token(Token = "0x6007D6A")]
    void SetProgress(QuestProgressUI progressUI);

    [Token(Token = "0x6007D6B")]
    void SetReward(
      QuestRewardUI rewardUI,
      QuestRewardCustomSkillUI rewarCustomSkillUI,
      Action<RewardTypeEnum, int> action = null);

    [Token(Token = "0x6007D6C")]
    void SetRepeatObj(GameObject repeatObj);

    [Token(Token = "0x6007D6D")]
    IEnumerator LoadItemResource(Action finishAction = null);

    [Token(Token = "0x6007D6E")]
    void ResourceUnload();
  }
}
