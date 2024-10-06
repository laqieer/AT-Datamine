// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.QuestSelect.QuestSelectListItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using GameCore.Tween;
using Il2CppDummyDll;
using StaqData;
using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.QuestSelect
{
  [Token(Token = "0x20033EC")]
  public class QuestSelectListItem : MonoBehaviour
  {
    [Token(Token = "0x400E19E")]
    private const string TYPE_STORY_NAME = "Type_Story";
    [Token(Token = "0x400E19F")]
    private const string TYPE_FREE_NAME = "Type_Free";
    [Token(Token = "0x400E1A0")]
    private const string MISSION_ON = "Mission_{0:D2}_On";
    [Token(Token = "0x400E1A1")]
    private const string MISSION_OFF = "Mission_{0:D2}_Off";
    [Token(Token = "0x400E1A2")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x400E1A3")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text questName;
    [Token(Token = "0x400E1A4")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Text gamePeriod;
    [Token(Token = "0x400E1A5")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Text consumeAp;
    [Token(Token = "0x400E1A6")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private TextMeshProUGUI categoryBlueText;
    [Token(Token = "0x400E1A7")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private TextMeshProUGUI categoryGreenText;
    [Token(Token = "0x400E1A8")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private GameObject grayOutImage;
    [Token(Token = "0x400E1A9")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private RectTransform rectTransform;
    [Token(Token = "0x400E1AC")]
    [FieldOffset(Offset = "0x60")]
    private Action<int> questDetailAction;
    [Token(Token = "0x400E1AD")]
    [FieldOffset(Offset = "0x68")]
    private Action<int> questSelectAction;
    [Token(Token = "0x400E1AE")]
    [FieldOffset(Offset = "0x70")]
    private Action<int> lockSelectAction;
    [Token(Token = "0x400E1AF")]
    [FieldOffset(Offset = "0x78")]
    private readonly Dictionary<QuestSelectListItem.TweenType, string> tweenMap;

    [Token(Token = "0x170043FD")]
    public RectTransform RectTransform
    {
      [Token(Token = "0x6014676"), Address(RVA = "0x188BD20", Offset = "0x188BD20", VA = "0x188BD20")] get
      {
        return (RectTransform) null;
      }
    }

    [Token(Token = "0x170043FE")]
    public int Index
    {
      [Token(Token = "0x6014677"), Address(RVA = "0x188BD28", Offset = "0x188BD28", VA = "0x188BD28")] get
      {
        return new int();
      }
      [Token(Token = "0x6014678"), Address(RVA = "0x188BD30", Offset = "0x188BD30", VA = "0x188BD30")] private set
      {
      }
    }

    [Token(Token = "0x170043FF")]
    public int QuestId
    {
      [Token(Token = "0x6014679"), Address(RVA = "0x188BD38", Offset = "0x188BD38", VA = "0x188BD38")] get
      {
        return new int();
      }
      [Token(Token = "0x601467A"), Address(RVA = "0x188BD40", Offset = "0x188BD40", VA = "0x188BD40")] private set
      {
      }
    }

    [Token(Token = "0x601467B")]
    [Address(RVA = "0x188BD48", Offset = "0x188BD48", VA = "0x188BD48")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x601467C")]
    [Address(RVA = "0x188B72C", Offset = "0x188B72C", VA = "0x188B72C")]
    public void Initialize(int index, QuestInfo questInfo)
    {
    }

    [Token(Token = "0x601467D")]
    [Address(RVA = "0x188BF3C", Offset = "0x188BF3C", VA = "0x188BF3C")]
    private void UpdateButtonEnable(bool buttonEnable)
    {
    }

    [Token(Token = "0x601467E")]
    [Address(RVA = "0x188BFF8", Offset = "0x188BFF8", VA = "0x188BFF8")]
    public void OnClickToDetail()
    {
    }

    [Token(Token = "0x601467F")]
    [Address(RVA = "0x188C018", Offset = "0x188C018", VA = "0x188C018")]
    public void SetClickToDetailAction(Action<int> action)
    {
    }

    [Token(Token = "0x6014680")]
    [Address(RVA = "0x188C020", Offset = "0x188C020", VA = "0x188C020")]
    public void OnClickToQuestSelect()
    {
    }

    [Token(Token = "0x6014681")]
    [Address(RVA = "0x188C0A4", Offset = "0x188C0A4", VA = "0x188C0A4")]
    public void SetClickToQuestSelectAction(Action<int> action)
    {
    }

    [Token(Token = "0x6014682")]
    [Address(RVA = "0x188C0AC", Offset = "0x188C0AC", VA = "0x188C0AC")]
    public void OnClickToLockQuestSelect()
    {
    }

    [Token(Token = "0x6014683")]
    [Address(RVA = "0x188C0CC", Offset = "0x188C0CC", VA = "0x188C0CC")]
    public void SetClickToLockQuestSelect(Action<int> action)
    {
    }

    [Token(Token = "0x6014684")]
    [Address(RVA = "0x188BEA4", Offset = "0x188BEA4", VA = "0x188BEA4")]
    private string GetQuestCategoryName(QuestTypeEnum questType) => (string) null;

    [Token(Token = "0x6014685")]
    [Address(RVA = "0x188BE00", Offset = "0x188BE00", VA = "0x188BE00")]
    private string GetBgAnimationKey(QuestSelectListItem.CategoryType categoryType)
    {
      return (string) null;
    }

    [Token(Token = "0x6014686")]
    [Address(RVA = "0x188BDE0", Offset = "0x188BDE0", VA = "0x188BDE0")]
    private QuestSelectListItem.CategoryType GetCategoryType(QuestTypeEnum questType)
    {
      return new QuestSelectListItem.CategoryType();
    }

    [Token(Token = "0x6014687")]
    [Address(RVA = "0x188C0D4", Offset = "0x188C0D4", VA = "0x188C0D4")]
    public QuestSelectListItem()
    {
    }

    [Token(Token = "0x20033ED")]
    public enum TweenType
    {
      [Token(Token = "0x400E1B1")] TypeStory,
      [Token(Token = "0x400E1B2")] TypeFree,
      [Token(Token = "0x400E1B3")] MissionOn,
      [Token(Token = "0x400E1B4")] MissionOff,
    }

    [Token(Token = "0x20033EE")]
    public enum CategoryType
    {
      [Token(Token = "0x400E1B6")] WithinChapters,
      [Token(Token = "0x400E1B7")] OutOfChapter,
    }
  }
}
