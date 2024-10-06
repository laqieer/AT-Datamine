// Decompiled with JetBrains decompiler
// Type: Scenes.Title.BattlePauseDataPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using GameCore.Popup;
using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Title
{
  [Token(Token = "0x20028C5")]
  public class BattlePauseDataPopup : PopupBase
  {
    [Token(Token = "0x400ADD6")]
    private const string UI_TWEEN_IN = "in";
    [Token(Token = "0x400ADD7")]
    private const string UI_TWEEN_OUT = "out";
    [Token(Token = "0x400ADD8")]
    [FieldOffset(Offset = "0x88")]
    [Space(5f)]
    [SerializeField]
    [Header("Item")]
    private TextMeshProUGUI[] itemCountLabel;
    [Token(Token = "0x400ADD9")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    [Header("QuestInfo")]
    [Space(5f)]
    private Text questName;
    [Token(Token = "0x400ADDA")]
    [FieldOffset(Offset = "0x98")]
    [Header("Toggle")]
    [SerializeField]
    [Space(5f)]
    private Toggle isDiscardToggle;
    [Token(Token = "0x400ADDB")]
    [FieldOffset(Offset = "0xA0")]
    [FormerlySerializedAs("RestartBtn")]
    [Header("Button")]
    [Space(5f)]
    [SerializeField]
    private Button restartBtn;
    [Token(Token = "0x400ADDC")]
    [FieldOffset(Offset = "0xA8")]
    [FormerlySerializedAs("DiscardBtn")]
    [SerializeField]
    private Button discardBtn;
    [Token(Token = "0x400ADDD")]
    [FieldOffset(Offset = "0xB0")]
    [Header("DifficultIcon")]
    [Space(5f)]
    [SerializeField]
    private GameObject difficultIconRoot;
    [Token(Token = "0x400ADDE")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    private GameObject hardIcon;
    [Token(Token = "0x400ADDF")]
    [FieldOffset(Offset = "0xC0")]
    [SerializeField]
    private GameObject veryHardIcon;
    [Token(Token = "0x400ADE0")]
    [FieldOffset(Offset = "0xC8")]
    private Action _onClickDiscard;
    [Token(Token = "0x400ADE1")]
    [FieldOffset(Offset = "0xD0")]
    private Action _onClickRestart;
    [Token(Token = "0x400ADE2")]
    [FieldOffset(Offset = "0xD8")]
    private BattlePauseDataPopup.ErrorEnum _errorType;

    [Token(Token = "0x60100A1")]
    [Address(RVA = "0x4167790", Offset = "0x4167790", VA = "0x4167790")]
    public void Initialize(BoardData bData, Action onClickDiscard, Action onClickRestart)
    {
    }

    [Token(Token = "0x60100A2")]
    [Address(RVA = "0x4167A30", Offset = "0x4167A30", VA = "0x4167A30")]
    private void ButtonSetting()
    {
    }

    [Token(Token = "0x60100A3")]
    [Address(RVA = "0x4167C48", Offset = "0x4167C48", VA = "0x4167C48")]
    private void SetItemNum(IReadOnlyDictionary<int, int> itemDic)
    {
    }

    [Token(Token = "0x60100A4")]
    [Address(RVA = "0x4167FA0", Offset = "0x4167FA0", VA = "0x4167FA0")]
    public void SetErrorType(BattlePauseDataPopup.ErrorEnum errorType)
    {
    }

    [Token(Token = "0x60100A5")]
    [Address(RVA = "0x4167FA8", Offset = "0x4167FA8", VA = "0x4167FA8")]
    public void ABLoadAI(Action cb)
    {
    }

    [Token(Token = "0x60100A6")]
    [Address(RVA = "0x4167FC8", Offset = "0x4167FC8", VA = "0x4167FC8")]
    private IEnumerator LoadAI(Action callBack) => (IEnumerator) null;

    [Token(Token = "0x60100A7")]
    [Address(RVA = "0x4168058", Offset = "0x4168058", VA = "0x4168058", Slot = "8")]
    public override void Open()
    {
    }

    [Token(Token = "0x60100A8")]
    [Address(RVA = "0x416837C", Offset = "0x416837C", VA = "0x416837C", Slot = "9")]
    public override void Close()
    {
    }

    [Token(Token = "0x60100A9")]
    [Address(RVA = "0x4168380", Offset = "0x4168380", VA = "0x4168380")]
    public void OnClickDiscard()
    {
    }

    [Token(Token = "0x60100AA")]
    [Address(RVA = "0x41684F8", Offset = "0x41684F8", VA = "0x41684F8")]
    public bool IsCheckDiscard() => new bool();

    [Token(Token = "0x60100AB")]
    [Address(RVA = "0x4168514", Offset = "0x4168514", VA = "0x4168514")]
    public BattlePauseDataPopup()
    {
    }

    [Token(Token = "0x20028C6")]
    public enum ErrorEnum
    {
      [Token(Token = "0x400ADE4")] None,
      [Token(Token = "0x400ADE5")] DataBroken,
      [Token(Token = "0x400ADE6")] DlcVersionDifferent,
      [Token(Token = "0x400ADE7")] AppVersionDifferent,
      [Token(Token = "0x400ADE8")] OutOfPeriod,
    }

    [Token(Token = "0x20028C7")]
    private class BattlePauseDataText
    {
      [Token(Token = "0x400ADE9")]
      [FieldOffset(Offset = "0x0")]
      public static Func<string> ErrorButtonText;
      [Token(Token = "0x400ADEA")]
      [FieldOffset(Offset = "0x8")]
      public static Func<string> AppVersionErrorText;
      [Token(Token = "0x400ADEB")]
      [FieldOffset(Offset = "0x10")]
      public static Func<string> DlcVersionErrorText;
      [Token(Token = "0x400ADEC")]
      [FieldOffset(Offset = "0x18")]
      public static Func<string> DataBrokenErrorText;
      [Token(Token = "0x400ADED")]
      [FieldOffset(Offset = "0x20")]
      public static Func<string> OutOfPeriodErrorText;
      [Token(Token = "0x400ADEE")]
      [FieldOffset(Offset = "0x28")]
      public static Func<string> DiscardTitle;
      [Token(Token = "0x400ADEF")]
      [FieldOffset(Offset = "0x30")]
      public static Func<string> DiscardSummary;

      [Token(Token = "0x60100AF")]
      [Address(RVA = "0x41686A8", Offset = "0x41686A8", VA = "0x41686A8")]
      public BattlePauseDataText()
      {
      }

      [Token(Token = "0x60100B0")]
      [Address(RVA = "0x41686B0", Offset = "0x41686B0", VA = "0x41686B0")]
      static BattlePauseDataText()
      {
      }
    }
  }
}
