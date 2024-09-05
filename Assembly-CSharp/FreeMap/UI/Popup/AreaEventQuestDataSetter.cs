// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.Popup.AreaEventQuestDataSetter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using StaqData.AreaEvent;
using System;
using System.Collections;
using System.Collections.Generic;
using UI;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace FreeMap.UI.Popup
{
  [Token(Token = "0x2001620")]
  public class AreaEventQuestDataSetter : IQuestDataSetter
  {
    [Token(Token = "0x400649E")]
    [FieldOffset(Offset = "0x10")]
    protected AreaEventQuestData areaeventquest;
    [Token(Token = "0x400649F")]
    [FieldOffset(Offset = "0x18")]
    private List<string> loadList;

    [Token(Token = "0x6007D54")]
    [Address(RVA = "0x21A8030", Offset = "0x21A8030", VA = "0x21A8030")]
    public AreaEventQuestDataSetter(AreaEventQuestData areaeventquest)
    {
    }

    [Token(Token = "0x6007D55")]
    [Address(RVA = "0x21A80C0", Offset = "0x21A80C0", VA = "0x21A80C0", Slot = "4")]
    public void SetTitle(TextAccessor title)
    {
    }

    [Token(Token = "0x6007D56")]
    [Address(RVA = "0x21A80FC", Offset = "0x21A80FC", VA = "0x21A80FC", Slot = "5")]
    public void SetDescription(TextAccessor description)
    {
    }

    [Token(Token = "0x6007D57")]
    [Address(RVA = "0x21A8138", Offset = "0x21A8138", VA = "0x21A8138", Slot = "6")]
    public void SetConditions(TextAccessor condition)
    {
    }

    [Token(Token = "0x6007D58")]
    [Address(RVA = "0x21A813C", Offset = "0x21A813C", VA = "0x21A813C", Slot = "11")]
    public void SetRepeatObj(GameObject repeatObj)
    {
    }

    [Token(Token = "0x6007D59")]
    [Address(RVA = "0x21A8154", Offset = "0x21A8154", VA = "0x21A8154", Slot = "8")]
    public void SetRepeat(Image repeatUI)
    {
    }

    [Token(Token = "0x6007D5A")]
    [Address(RVA = "0x21A8180", Offset = "0x21A8180", VA = "0x21A8180", Slot = "7")]
    public void SetPeriod(QuestPeriodUI period)
    {
    }

    [Token(Token = "0x6007D5B")]
    [Address(RVA = "0x21A81F4", Offset = "0x21A81F4", VA = "0x21A81F4", Slot = "9")]
    public void SetProgress(QuestProgressUI progressUI)
    {
    }

    [Token(Token = "0x6007D5C")]
    [Address(RVA = "0x21A893C", Offset = "0x21A893C", VA = "0x21A893C", Slot = "12")]
    public IEnumerator LoadItemResource(Action finishAction = null) => (IEnumerator) null;

    [Token(Token = "0x6007D5D")]
    [Address(RVA = "0x21A89CC", Offset = "0x21A89CC", VA = "0x21A89CC", Slot = "13")]
    public void ResourceUnload()
    {
    }

    [Token(Token = "0x6007D5E")]
    [Address(RVA = "0x21A8AF8", Offset = "0x21A8AF8", VA = "0x21A8AF8", Slot = "10")]
    public void SetReward(
      QuestRewardUI rewardUI,
      QuestRewardCustomSkillUI rewarCustomSkillUI,
      Action<RewardTypeEnum, int> action)
    {
    }
  }
}
