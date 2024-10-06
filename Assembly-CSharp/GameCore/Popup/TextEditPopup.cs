// Decompiled with JetBrains decompiler
// Type: GameCore.Popup.TextEditPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace GameCore.Popup
{
  [Token(Token = "0x2000D13")]
  public class TextEditPopup : PopupBase
  {
    [Token(Token = "0x4003A51")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private InputField inputField;
    [Token(Token = "0x4003A52")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private Text countText;
    [Token(Token = "0x4003A53")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private Text placeHolder;
    [Token(Token = "0x4003A54")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private CommonButton executeButton;
    [Token(Token = "0x4003A55")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    [Tooltip("InputField のオブジェクト構成によってはCaret が表示出来ない対策用")]
    private bool isSwapCaretTargetgraphic;
    [Token(Token = "0x4003A58")]
    [FieldOffset(Offset = "0xC0")]
    private int maxCharCount;
    [Token(Token = "0x4003A59")]
    [FieldOffset(Offset = "0xC8")]
    private string firstText;
    [Token(Token = "0x4003A5A")]
    [FieldOffset(Offset = "0xD0")]
    private string inputText;

    [Token(Token = "0x17000B01")]
    public Action<string> OnClickExecute
    {
      [Token(Token = "0x6004B25"), Address(RVA = "0x32E3010", Offset = "0x32E3010", VA = "0x32E3010")] get
      {
        return (Action<string>) null;
      }
      [Token(Token = "0x6004B26"), Address(RVA = "0x32E3018", Offset = "0x32E3018", VA = "0x32E3018")] private set
      {
      }
    }

    [Token(Token = "0x17000B02")]
    public Action OnClickCancel
    {
      [Token(Token = "0x6004B27"), Address(RVA = "0x32E3020", Offset = "0x32E3020", VA = "0x32E3020")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x6004B28"), Address(RVA = "0x32E3028", Offset = "0x32E3028", VA = "0x32E3028")] private set
      {
      }
    }

    [Token(Token = "0x6004B29")]
    [Address(RVA = "0x32E3030", Offset = "0x32E3030", VA = "0x32E3030")]
    public void SetPartyNameChangeData(int maxCharCount)
    {
    }

    [Token(Token = "0x6004B2A")]
    [Address(RVA = "0x32E3334", Offset = "0x32E3334", VA = "0x32E3334")]
    public void SetPlayerNameChangeData(int maxCharCount, string noteText)
    {
    }

    [Token(Token = "0x6004B2B")]
    [Address(RVA = "0x32E3410", Offset = "0x32E3410", VA = "0x32E3410")]
    public void SetCommentEditData(int maxCharCount, string nowComment)
    {
    }

    [Token(Token = "0x6004B2C")]
    [Address(RVA = "0x32E35B8", Offset = "0x32E35B8", VA = "0x32E35B8")]
    public void SetUserNameEditData(int maxCharCount)
    {
    }

    [Token(Token = "0x6004B2D")]
    [Address(RVA = "0x32E3714", Offset = "0x32E3714", VA = "0x32E3714")]
    public void SetGuildNameEditData(int maxCharCount)
    {
    }

    [Token(Token = "0x6004B2E")]
    [Address(RVA = "0x32E3870", Offset = "0x32E3870", VA = "0x32E3870")]
    public void SetGuildIntroductionEditData(int maxCharCount)
    {
    }

    [Token(Token = "0x6004B2F")]
    [Address(RVA = "0x32E39CC", Offset = "0x32E39CC", VA = "0x32E39CC")]
    public void SetGuildBulletinBoardEditData(int maxCharCount)
    {
    }

    [Token(Token = "0x6004B30")]
    [Address(RVA = "0x32E3B28", Offset = "0x32E3B28", VA = "0x32E3B28")]
    public void SetGuildInviteEditData(int maxCharCount)
    {
    }

    [Token(Token = "0x6004B31")]
    [Address(RVA = "0x32E318C", Offset = "0x32E318C", VA = "0x32E318C")]
    private void SetData(int maxCharCount)
    {
    }

    [Token(Token = "0x6004B32")]
    [Address(RVA = "0x32E3584", Offset = "0x32E3584", VA = "0x32E3584")]
    public void UpdateInputField(string inputMessage)
    {
    }

    [Token(Token = "0x6004B33")]
    [Address(RVA = "0x32E3C84", Offset = "0x32E3C84", VA = "0x32E3C84")]
    private void SetExecuteButtonInteractable()
    {
    }

    [Token(Token = "0x6004B34")]
    [Address(RVA = "0x32E3D0C", Offset = "0x32E3D0C", VA = "0x32E3D0C")]
    public void OnValueChange()
    {
    }

    [Token(Token = "0x6004B35")]
    [Address(RVA = "0x32E3D10", Offset = "0x32E3D10", VA = "0x32E3D10")]
    public void OnEndEdit()
    {
    }

    [Token(Token = "0x6004B36")]
    [Address(RVA = "0x32E3D78", Offset = "0x32E3D78", VA = "0x32E3D78")]
    public void SetCallbackByExecute(Action<string> onClickExecute)
    {
    }

    [Token(Token = "0x6004B37")]
    [Address(RVA = "0x32E3D80", Offset = "0x32E3D80", VA = "0x32E3D80")]
    public void SetCallbackByCancel(Action onClickCancel)
    {
    }

    [Token(Token = "0x6004B38")]
    [Address(RVA = "0x32E3D88", Offset = "0x32E3D88", VA = "0x32E3D88")]
    public void OnClickToExecuteButton()
    {
    }

    [Token(Token = "0x6004B39")]
    [Address(RVA = "0x32E3DA8", Offset = "0x32E3DA8", VA = "0x32E3DA8")]
    public void OnClickToCancelButton()
    {
    }

    [Token(Token = "0x6004B3A")]
    [Address(RVA = "0x32E3DC4", Offset = "0x32E3DC4", VA = "0x32E3DC4", Slot = "4")]
    public override void Destroy()
    {
    }

    [Token(Token = "0x6004B3B")]
    [Address(RVA = "0x32E3E98", Offset = "0x32E3E98", VA = "0x32E3E98")]
    private IEnumerator Start() => (IEnumerator) null;

    [Token(Token = "0x6004B3C")]
    [Address(RVA = "0x32E3F28", Offset = "0x32E3F28", VA = "0x32E3F28")]
    public TextEditPopup()
    {
    }
  }
}
