// Decompiled with JetBrains decompiler
// Type: GameCore.Popup.CommonPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Input;
using HTMLViewer;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace GameCore.Popup
{
  [Token(Token = "0x2000CE2")]
  public class CommonPopup : PopupBase
  {
    [Token(Token = "0x400399F")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private GameObject titleRoot;
    [Token(Token = "0x40039A0")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private Text newTitle;
    [Token(Token = "0x40039A1")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private Text message;
    [Token(Token = "0x40039A2")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    protected Button confirmButton;
    [Token(Token = "0x40039A3")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    protected Button cancelButton;
    [Token(Token = "0x40039A4")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private Text confirmButtonText;
    [Token(Token = "0x40039A5")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    private Text cancelButtonText;
    [Token(Token = "0x40039A6")]
    [FieldOffset(Offset = "0xC0")]
    [SerializeField]
    private CommonButton[] leftButtons;
    [Token(Token = "0x40039A7")]
    [FieldOffset(Offset = "0xC8")]
    [SerializeField]
    private Text[] leftButtonTexts;
    [Token(Token = "0x40039A8")]
    [FieldOffset(Offset = "0xD0")]
    [SerializeField]
    private CommonButton[] rightButtons;
    [Token(Token = "0x40039A9")]
    [FieldOffset(Offset = "0xD8")]
    [SerializeField]
    private Text[] rightButtonTexts;
    [Token(Token = "0x40039AA")]
    [FieldOffset(Offset = "0xE0")]
    [Tooltip("ボタンの配列")]
    [SerializeField]
    protected CommonButtonGroup[] buttons;
    [Token(Token = "0x40039AB")]
    [FieldOffset(Offset = "0xE8")]
    [Tooltip("ボタンのレイアウト（間隔）を自動で制御するか？")]
    [SerializeField]
    private bool isLayoutAutoSet;
    [Token(Token = "0x40039AC")]
    [FieldOffset(Offset = "0xF0")]
    [Tooltip("ボタンのレイアウト（間隔）を制御する為に使用します")]
    [SerializeField]
    private HorizontalLayoutGroup layoutGroup;
    [Token(Token = "0x40039AD")]
    [FieldOffset(Offset = "0xF8")]
    [Tooltip("HTML用コンポーネント")]
    [SerializeField]
    private HTMLView htmlView;
    [Token(Token = "0x40039AE")]
    [FieldOffset(Offset = "0x100")]
    [Tooltip("バックキーハンドラ")]
    [SerializeField]
    private BackKeyHandlerComponent backKeyHandler;
    [Token(Token = "0x40039B1")]
    [FieldOffset(Offset = "0x118")]
    private CommonPopup.ButtonLayoutGroupSetting[] buttonLayoutSetting;
    [Token(Token = "0x40039B2")]
    [FieldOffset(Offset = "0x120")]
    private List<Text> messages;

    [Token(Token = "0x17000AD2")]
    public Action OnClickToConfirmAction
    {
      [Token(Token = "0x6004A0E"), Address(RVA = "0x313CA10", Offset = "0x313CA10", VA = "0x313CA10")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x6004A0F"), Address(RVA = "0x313CA18", Offset = "0x313CA18", VA = "0x313CA18")] set
      {
      }
    }

    [Token(Token = "0x17000AD3")]
    public Action OnClickToCancelAction
    {
      [Token(Token = "0x6004A10"), Address(RVA = "0x313CA20", Offset = "0x313CA20", VA = "0x313CA20")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x6004A11"), Address(RVA = "0x313CA28", Offset = "0x313CA28", VA = "0x313CA28")] set
      {
      }
    }

    [Token(Token = "0x17000AD4")]
    public Action OnBackKeyAction
    {
      [Token(Token = "0x6004A12"), Address(RVA = "0x313CA30", Offset = "0x313CA30", VA = "0x313CA30")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x6004A13"), Address(RVA = "0x313CA48", Offset = "0x313CA48", VA = "0x313CA48")] set
      {
      }
    }

    [Token(Token = "0x6004A14")]
    [Address(RVA = "0x313CAE0", Offset = "0x313CAE0", VA = "0x313CAE0")]
    public void SetupContent(CommonPopupContent commonPopupContent)
    {
    }

    [Token(Token = "0x6004A15")]
    [Address(RVA = "0x313CF3C", Offset = "0x313CF3C", VA = "0x313CF3C")]
    private void CreateMessages(int messageNum)
    {
    }

    [Token(Token = "0x6004A16")]
    [Address(RVA = "0x313D184", Offset = "0x313D184", VA = "0x313D184")]
    private void ClearMessages()
    {
    }

    [Token(Token = "0x6004A17")]
    [Address(RVA = "0x313CDC8", Offset = "0x313CDC8", VA = "0x313CDC8")]
    private void EnableHtml(bool isEnabled)
    {
    }

    [Token(Token = "0x6004A18")]
    [Address(RVA = "0x313CEB8", Offset = "0x313CEB8", VA = "0x313CEB8")]
    private bool IsEnabledHtml(CommonPopupContent commonPopupContent) => new bool();

    [Token(Token = "0x6004A19")]
    [Address(RVA = "0x313D284", Offset = "0x313D284", VA = "0x313D284")]
    public void OnClickLink(string url)
    {
    }

    [Token(Token = "0x6004A1A")]
    [Address(RVA = "0x313D31C", Offset = "0x313D31C", VA = "0x313D31C")]
    public void SetupButtons(params CommonButtonContent[] commonButtonContents)
    {
    }

    [Token(Token = "0x6004A1B")]
    [Address(RVA = "0x313D4C0", Offset = "0x313D4C0", VA = "0x313D4C0")]
    private void SetButtonLayoutByButtonCount(int buttonCount)
    {
    }

    [Token(Token = "0x6004A1C")]
    [Address(RVA = "0x313D4F0", Offset = "0x313D4F0", VA = "0x313D4F0")]
    private CommonPopup.ButtonLayoutGroupSetting GetButtonLayoutByButtonCount(int buttonCount)
    {
      return (CommonPopup.ButtonLayoutGroupSetting) null;
    }

    [Token(Token = "0x6004A1D")]
    [Address(RVA = "0x313D54C", Offset = "0x313D54C", VA = "0x313D54C")]
    private void SetButtonLayout(CommonPopup.ButtonLayoutGroupSetting layout)
    {
    }

    [Token(Token = "0x6004A1E")]
    [Address(RVA = "0x313D574", Offset = "0x313D574", VA = "0x313D574")]
    public void OnConfirmButton()
    {
    }

    [Token(Token = "0x6004A1F")]
    [Address(RVA = "0x313D590", Offset = "0x313D590", VA = "0x313D590")]
    public void OnCancelButton()
    {
    }

    [Token(Token = "0x6004A20")]
    [Address(RVA = "0x313AEF4", Offset = "0x313AEF4", VA = "0x313AEF4")]
    public CommonPopup()
    {
    }

    [Token(Token = "0x2000CE3")]
    public enum ButtonType
    {
      [Token(Token = "0x40039B4")] Cancel,
      [Token(Token = "0x40039B5")] Play,
      [Token(Token = "0x40039B6")] Confrim,
      [Token(Token = "0x40039B7")] Deactive,
    }

    [Token(Token = "0x2000CE4")]
    private class ButtonLayoutGroupSetting
    {
      [Token(Token = "0x40039B8")]
      public const int TwoButtonSpacing = 206;
      [Token(Token = "0x40039B9")]
      public const int ThreeButtonSpacing = 70;

      [Token(Token = "0x17000AD5")]
      public int ButtonCount
      {
        [Token(Token = "0x6004A21"), Address(RVA = "0x313D630", Offset = "0x313D630", VA = "0x313D630")] get
        {
          return new int();
        }
      }

      [Token(Token = "0x17000AD6")]
      public int Spacing
      {
        [Token(Token = "0x6004A22"), Address(RVA = "0x313D638", Offset = "0x313D638", VA = "0x313D638")] get
        {
          return new int();
        }
      }

      [Token(Token = "0x6004A23")]
      [Address(RVA = "0x313D5AC", Offset = "0x313D5AC", VA = "0x313D5AC")]
      public ButtonLayoutGroupSetting(int buttonCount, int spacing)
      {
      }
    }
  }
}
