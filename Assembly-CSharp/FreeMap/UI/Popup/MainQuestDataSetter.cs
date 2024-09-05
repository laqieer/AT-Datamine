// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.Popup.MainQuestDataSetter
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
  [Token(Token = "0x2001623")]
  public class MainQuestDataSetter : IQuestDataSetter
  {
    [Token(Token = "0x40064A3")]
    [FieldOffset(Offset = "0x10")]
    protected StoryMainQuestSequenceSummaryData summary;

    [Token(Token = "0x6007D6F")]
    [Address(RVA = "0x21A8BF0", Offset = "0x21A8BF0", VA = "0x21A8BF0")]
    public MainQuestDataSetter(int sequenceID)
    {
    }

    [Token(Token = "0x6007D70")]
    [Address(RVA = "0x21A8D18", Offset = "0x21A8D18", VA = "0x21A8D18", Slot = "4")]
    public void SetTitle(TextAccessor title)
    {
    }

    [Token(Token = "0x6007D71")]
    [Address(RVA = "0x21A8D4C", Offset = "0x21A8D4C", VA = "0x21A8D4C", Slot = "5")]
    public void SetDescription(TextAccessor description)
    {
    }

    [Token(Token = "0x6007D72")]
    [Address(RVA = "0x21A8D80", Offset = "0x21A8D80", VA = "0x21A8D80", Slot = "6")]
    public void SetConditions(TextAccessor conditions)
    {
    }

    [Token(Token = "0x6007D73")]
    [Address(RVA = "0x21A8D84", Offset = "0x21A8D84", VA = "0x21A8D84", Slot = "8")]
    public void SetRepeat(Image repeatUI)
    {
    }

    [Token(Token = "0x6007D74")]
    [Address(RVA = "0x21A8DB0", Offset = "0x21A8DB0", VA = "0x21A8DB0", Slot = "7")]
    public void SetPeriod(QuestPeriodUI period)
    {
    }

    [Token(Token = "0x6007D75")]
    [Address(RVA = "0x21A8DC8", Offset = "0x21A8DC8", VA = "0x21A8DC8", Slot = "9")]
    public void SetProgress(QuestProgressUI progress)
    {
    }

    [Token(Token = "0x6007D76")]
    [Address(RVA = "0x21A8EA8", Offset = "0x21A8EA8", VA = "0x21A8EA8", Slot = "10")]
    public void SetReward(
      QuestRewardUI rewardUI,
      QuestRewardCustomSkillUI rewarCustomSkillUI,
      Action<RewardTypeEnum, int> action)
    {
    }

    [Token(Token = "0x6007D77")]
    [Address(RVA = "0x21A8EF8", Offset = "0x21A8EF8", VA = "0x21A8EF8", Slot = "11")]
    public void SetRepeatObj(GameObject repeatObj)
    {
    }

    [Token(Token = "0x6007D78")]
    [Address(RVA = "0x21A8F10", Offset = "0x21A8F10", VA = "0x21A8F10", Slot = "12")]
    public IEnumerator LoadItemResource(Action finishAction = null) => (IEnumerator) null;

    [Token(Token = "0x6007D79")]
    [Address(RVA = "0x21A8FA0", Offset = "0x21A8FA0", VA = "0x21A8FA0", Slot = "13")]
    public void ResourceUnload()
    {
    }
  }
}
