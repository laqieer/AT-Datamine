// Decompiled with JetBrains decompiler
// Type: IntroChapter.PlayerEditPopupDummy
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Popup;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace IntroChapter
{
  [Token(Token = "0x2000A77")]
  public class PlayerEditPopupDummy : PopupBase
  {
    [Token(Token = "0x4003073")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private InputField inputField;
    [Token(Token = "0x4003074")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private InputField inputFieldAvatarID;
    [Token(Token = "0x4003075")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private CommonButton executeButton;
    [Token(Token = "0x4003076")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private CommonButton retryExecuteButton;
    [Token(Token = "0x4003079")]
    [FieldOffset(Offset = "0xB8")]
    private int maxCharCount;
    [Token(Token = "0x400307A")]
    [FieldOffset(Offset = "0xBC")]
    private int maxAvatarID;
    [Token(Token = "0x400307B")]
    [FieldOffset(Offset = "0xC0")]
    private int minAvatarID;
    [Token(Token = "0x400307C")]
    [FieldOffset(Offset = "0xC8")]
    private string inputText;
    [Token(Token = "0x400307D")]
    [FieldOffset(Offset = "0xD0")]
    private int inputAvatarId;

    [Token(Token = "0x17000877")]
    public Action<string, int> OnClickExecute
    {
      [Token(Token = "0x6003B6A"), Address(RVA = "0x331D950", Offset = "0x331D950", VA = "0x331D950")] get
      {
        return (Action<string, int>) null;
      }
      [Token(Token = "0x6003B6B"), Address(RVA = "0x331D958", Offset = "0x331D958", VA = "0x331D958")] private set
      {
      }
    }

    [Token(Token = "0x17000878")]
    public Action<string, int> OnClickRetryExecute
    {
      [Token(Token = "0x6003B6C"), Address(RVA = "0x331D960", Offset = "0x331D960", VA = "0x331D960")] get
      {
        return (Action<string, int>) null;
      }
      [Token(Token = "0x6003B6D"), Address(RVA = "0x331D968", Offset = "0x331D968", VA = "0x331D968")] private set
      {
      }
    }

    [Token(Token = "0x6003B6E")]
    [Address(RVA = "0x331D970", Offset = "0x331D970", VA = "0x331D970")]
    private void Awake()
    {
    }

    [Token(Token = "0x6003B6F")]
    [Address(RVA = "0x331DB64", Offset = "0x331DB64", VA = "0x331DB64")]
    private void SetExecuteButtonInteractable()
    {
    }

    [Token(Token = "0x6003B70")]
    [Address(RVA = "0x331DBDC", Offset = "0x331DBDC", VA = "0x331DBDC")]
    public void OnValueChange()
    {
    }

    [Token(Token = "0x6003B71")]
    [Address(RVA = "0x331DBE0", Offset = "0x331DBE0", VA = "0x331DBE0")]
    public void OnEndEdit()
    {
    }

    [Token(Token = "0x6003B72")]
    [Address(RVA = "0x331DC48", Offset = "0x331DC48", VA = "0x331DC48")]
    public void OnValueChangeAvatarId()
    {
    }

    [Token(Token = "0x6003B73")]
    [Address(RVA = "0x331DC4C", Offset = "0x331DC4C", VA = "0x331DC4C")]
    public void OnEndEditAvatarId()
    {
    }

    [Token(Token = "0x6003B74")]
    [Address(RVA = "0x331DCCC", Offset = "0x331DCCC", VA = "0x331DCCC")]
    public void SetCallbackByExecute(Action<string, int> onClickExecute)
    {
    }

    [Token(Token = "0x6003B75")]
    [Address(RVA = "0x331DCD4", Offset = "0x331DCD4", VA = "0x331DCD4")]
    public void SetCallbackByRetryExecute(Action<string, int> onClickExecute)
    {
    }

    [Token(Token = "0x6003B76")]
    [Address(RVA = "0x331DCDC", Offset = "0x331DCDC", VA = "0x331DCDC")]
    public void OnClickToExecuteButton()
    {
    }

    [Token(Token = "0x6003B77")]
    [Address(RVA = "0x331DD00", Offset = "0x331DD00", VA = "0x331DD00")]
    public void OnClickToExecuteRetryButton()
    {
    }

    [Token(Token = "0x6003B78")]
    [Address(RVA = "0x331DD24", Offset = "0x331DD24", VA = "0x331DD24", Slot = "4")]
    public override void Destroy()
    {
    }

    [Token(Token = "0x6003B79")]
    [Address(RVA = "0x331DDF8", Offset = "0x331DDF8", VA = "0x331DDF8")]
    public PlayerEditPopupDummy()
    {
    }
  }
}
