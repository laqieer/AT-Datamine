// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.Popup.SubQuestDataSetter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using StaqData;
using System;
using System.Collections;
using System.Collections.Generic;
using UI;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace FreeMap.UI.Popup
{
  [Token(Token = "0x2001626")]
  public class SubQuestDataSetter : IQuestDataSetter
  {
    [Token(Token = "0x40064A7")]
    [FieldOffset(Offset = "0x10")]
    protected SubQuestData subquest;
    [Token(Token = "0x40064A8")]
    [FieldOffset(Offset = "0x18")]
    private List<string> loadList;

    [Token(Token = "0x6007D81")]
    [Address(RVA = "0x21A907C", Offset = "0x21A907C", VA = "0x21A907C")]
    public SubQuestDataSetter(SubQuestData subquest)
    {
    }

    [Token(Token = "0x6007D82")]
    [Address(RVA = "0x21A9118", Offset = "0x21A9118", VA = "0x21A9118", Slot = "4")]
    public void SetTitle(TextAccessor title)
    {
    }

    [Token(Token = "0x6007D83")]
    [Address(RVA = "0x21A9140", Offset = "0x21A9140", VA = "0x21A9140", Slot = "5")]
    public void SetDescription(TextAccessor descriptionUI)
    {
    }

    [Token(Token = "0x6007D84")]
    [Address(RVA = "0x21A9168", Offset = "0x21A9168", VA = "0x21A9168", Slot = "6")]
    public void SetConditions(TextAccessor conditions)
    {
    }

    [Token(Token = "0x6007D85")]
    [Address(RVA = "0x21A91D4", Offset = "0x21A91D4", VA = "0x21A91D4", Slot = "8")]
    public void SetRepeat(Image repeatUI)
    {
    }

    [Token(Token = "0x6007D86")]
    [Address(RVA = "0x21A9228", Offset = "0x21A9228", VA = "0x21A9228", Slot = "7")]
    public void SetPeriod(QuestPeriodUI periodUI)
    {
    }

    [Token(Token = "0x6007D87")]
    [Address(RVA = "0x21A9358", Offset = "0x21A9358", VA = "0x21A9358", Slot = "9")]
    public void SetProgress(QuestProgressUI progressUI)
    {
    }

    [Token(Token = "0x6007D88")]
    [Address(RVA = "0x21A978C", Offset = "0x21A978C", VA = "0x21A978C", Slot = "12")]
    public IEnumerator LoadItemResource(Action finishAction = null) => (IEnumerator) null;

    [Token(Token = "0x6007D89")]
    [Address(RVA = "0x21A9828", Offset = "0x21A9828", VA = "0x21A9828", Slot = "13")]
    public void ResourceUnload()
    {
    }

    [Token(Token = "0x6007D8A")]
    [Address(RVA = "0x21A9954", Offset = "0x21A9954", VA = "0x21A9954", Slot = "10")]
    public void SetReward(
      QuestRewardUI rewardUI,
      QuestRewardCustomSkillUI rewarCustomSkillUI,
      Action<RewardTypeEnum, int> action)
    {
    }

    [Token(Token = "0x6007D8B")]
    [Address(RVA = "0x21AA610", Offset = "0x21AA610", VA = "0x21AA610", Slot = "11")]
    public void SetRepeatObj(GameObject repeatObj)
    {
    }
  }
}
