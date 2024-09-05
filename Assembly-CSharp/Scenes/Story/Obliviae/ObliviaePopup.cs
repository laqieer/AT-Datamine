// Decompiled with JetBrains decompiler
// Type: Scenes.Story.Obliviae.ObliviaePopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using GameCore.Popup;
using Il2CppDummyDll;
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Story.Obliviae
{
  [Token(Token = "0x2002E57")]
  public class ObliviaePopup : PopupBase
  {
    [Token(Token = "0x400C6CC")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private Text textContent;
    [Token(Token = "0x400C6CD")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private CommonButton alwaysActiveButton;
    [Token(Token = "0x400C6CE")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private Text alwaysActiveButtonText;
    [Token(Token = "0x400C6CF")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private CommonButton activeControlButton;
    [Token(Token = "0x400C6D0")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private Text activeControlButtonText;
    [Token(Token = "0x400C6D1")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private UnlockConditionView unlockConditionView;
    [Token(Token = "0x400C6D2")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    private ScrollRect scrollRect;
    [Token(Token = "0x400C6D3")]
    [FieldOffset(Offset = "0xC0")]
    [SerializeField]
    private GameObject unlockListGroup;
    [Token(Token = "0x400C6D4")]
    [FieldOffset(Offset = "0xC8")]
    [SerializeField]
    private RectTransform scrollContent;
    [Token(Token = "0x400C6D5")]
    [FieldOffset(Offset = "0xD0")]
    [SerializeField]
    private GameObject unlockDescriptionTextObj;

    [Token(Token = "0x60121B4")]
    [Address(RVA = "0x4586EE0", Offset = "0x4586EE0", VA = "0x4586EE0")]
    public void InitializeByUnlockCondition(
      StoryObliviaeQuestData questData,
      UnityAction onClickToCloseAction,
      Action<int> onClickReleaseCommuAction)
    {
    }

    [Token(Token = "0x60121B5")]
    [Address(RVA = "0x45879B8", Offset = "0x45879B8", VA = "0x45879B8")]
    public void InitializeByCheckUnlock(
      string title,
      string message,
      UnityAction onClickToCloseAction)
    {
    }

    [Token(Token = "0x60121B6")]
    [Address(RVA = "0x4587BD4", Offset = "0x4587BD4", VA = "0x4587BD4")]
    private IEnumerator InitializeWaitPos() => (IEnumerator) null;

    [Token(Token = "0x60121B7")]
    [Address(RVA = "0x4587C64", Offset = "0x4587C64", VA = "0x4587C64")]
    public void InitialzeByReturn(UnityAction onClickToCancel, UnityAction onClickToReturn)
    {
    }

    [Token(Token = "0x60121B8")]
    [Address(RVA = "0x4587F80", Offset = "0x4587F80", VA = "0x4587F80")]
    public ObliviaePopup()
    {
    }
  }
}
