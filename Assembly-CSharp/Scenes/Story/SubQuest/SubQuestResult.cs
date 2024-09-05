// Decompiled with JetBrains decompiler
// Type: Scenes.Story.SubQuest.SubQuestResult
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using GameCore.UIControls;
using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Story.SubQuest
{
  [Token(Token = "0x2002D92")]
  public class SubQuestResult : MonoBehaviour
  {
    [Token(Token = "0x400C3B2")]
    private const string TWEEN_REWARD_OUT = "Reward_Out";
    [Token(Token = "0x400C3B3")]
    private const string TWEEN_REWARD_IN = "Reward_In";
    [Token(Token = "0x400C3B4")]
    private const string TWEEN_QUEST_RESULT_ACTIVATE = "QuestResult_Activate";
    [Token(Token = "0x400C3B5")]
    private const string TWEEN_PLAYER_INFO_ACTIVATE = "PlayerInfo_Activate";
    [Token(Token = "0x400C3B6")]
    private const string TWEEN_PLAYER_GAINED_ACTIVATE = "PlayerGained_Activate";
    [Token(Token = "0x400C3B7")]
    [FieldOffset(Offset = "0x18")]
    private readonly string[] playTweenGroupKey;
    [Token(Token = "0x400C3B8")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private RectTransform rectTransform;
    [Token(Token = "0x400C3B9")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x400C3BA")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Text subQuestTitle;
    [Token(Token = "0x400C3BB")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Text possessionCoinValue;
    [Token(Token = "0x400C3BC")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private TextMeshProUGUI gainedCoinValue;
    [Token(Token = "0x400C3BD")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Text possessionMoneyValue;
    [Token(Token = "0x400C3BE")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private TextMeshProUGUI gainedMoneyValue;
    [Token(Token = "0x400C3BF")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private RewardItem baseRewardItem;
    [Token(Token = "0x400C3C0")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private RectTransform rewardItemParent;
    [Token(Token = "0x400C3C1")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private GridLayoutGroup gridLayout;
    [Token(Token = "0x400C3C2")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private float valueDuration;
    [Token(Token = "0x400C3C3")]
    [FieldOffset(Offset = "0x78")]
    private List<RewardItem> rewardList;
    [Token(Token = "0x400C3C5")]
    [FieldOffset(Offset = "0x88")]
    private int finishCount;

    [Token(Token = "0x17003CE0")]
    public RectTransform RectTransform
    {
      [Token(Token = "0x6011D18"), Address(RVA = "0x3FA0550", Offset = "0x3FA0550", VA = "0x3FA0550")] get
      {
        return (RectTransform) null;
      }
    }

    [Token(Token = "0x17003CE1")]
    public Action OnFinish
    {
      [Token(Token = "0x6011D19"), Address(RVA = "0x3FA0558", Offset = "0x3FA0558", VA = "0x3FA0558")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x6011D1A"), Address(RVA = "0x3FA0560", Offset = "0x3FA0560", VA = "0x3FA0560")] set
      {
      }
    }

    [Token(Token = "0x6011D1B")]
    [Address(RVA = "0x3FA0568", Offset = "0x3FA0568", VA = "0x3FA0568")]
    private IEnumerator SetValue(
      int now,
      int add,
      Text targetText,
      string targetUnit,
      TextMeshProUGUI addText,
      Action onFinish)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6011D1C")]
    [Address(RVA = "0x3FA0634", Offset = "0x3FA0634", VA = "0x3FA0634")]
    public IEnumerator ViewResultData(int subQuestId) => (IEnumerator) null;

    [Token(Token = "0x6011D1D")]
    [Address(RVA = "0x3FA06D4", Offset = "0x3FA06D4", VA = "0x3FA06D4")]
    public void OnClickToNextButton()
    {
    }

    [Token(Token = "0x6011D1E")]
    [Address(RVA = "0x3FA0758", Offset = "0x3FA0758", VA = "0x3FA0758")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6011D1F")]
    [Address(RVA = "0x3FA0860", Offset = "0x3FA0860", VA = "0x3FA0860")]
    public SubQuestResult()
    {
    }
  }
}
