// Decompiled with JetBrains decompiler
// Type: Scenes.Chat.ChatFixedPhraseSettingPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Popup;
using Il2CppDummyDll;
using Network;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Chat
{
  [Token(Token = "0x20030B8")]
  public class ChatFixedPhraseSettingPopup : PopupBase
  {
    [Token(Token = "0x400CF40")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private Button closeButton;
    [Token(Token = "0x400CF41")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private Button decisionButton;
    [Token(Token = "0x400CF42")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private InputField inputField;
    [Token(Token = "0x400CF43")]
    [FieldOffset(Offset = "0xA0")]
    private int index;
    [Token(Token = "0x400CF44")]
    [FieldOffset(Offset = "0xA8")]
    private string fixedPhraseText;
    [Token(Token = "0x400CF45")]
    [FieldOffset(Offset = "0xB0")]
    private Action<bool> closeAction;
    [Token(Token = "0x400CF46")]
    [FieldOffset(Offset = "0xB8")]
    private bool isCallApi;

    [Token(Token = "0x6013095")]
    [Address(RVA = "0x432D4E0", Offset = "0x432D4E0", VA = "0x432D4E0")]
    public void Initialize(Action<bool> closeAction)
    {
    }

    [Token(Token = "0x6013096")]
    [Address(RVA = "0x432D640", Offset = "0x432D640", VA = "0x432D640")]
    public void SetData(int index, string text)
    {
    }

    [Token(Token = "0x6013097")]
    [Address(RVA = "0x432D66C", Offset = "0x432D66C", VA = "0x432D66C")]
    private IEnumerator CallFixedPhraseEditApi() => (IEnumerator) null;

    [Token(Token = "0x6013098")]
    [Address(RVA = "0x432D6FC", Offset = "0x432D6FC", VA = "0x432D6FC")]
    private IEnumerator OnError(NetworkErrorResult networkErrorResult) => (IEnumerator) null;

    [Token(Token = "0x6013099")]
    [Address(RVA = "0x432D78C", Offset = "0x432D78C", VA = "0x432D78C")]
    public ChatFixedPhraseSettingPopup()
    {
    }

    [Token(Token = "0x20030B9")]
    [Serializable]
    private class ErrorMessage : JsonSerializable
    {
      [Token(Token = "0x400CF47")]
      [FieldOffset(Offset = "0x10")]
      public string error_code;
      [Token(Token = "0x400CF48")]
      [FieldOffset(Offset = "0x18")]
      public List<string> args;

      [Token(Token = "0x601309A")]
      [Address(RVA = "0x432D794", Offset = "0x432D794", VA = "0x432D794")]
      public ErrorMessage()
      {
      }
    }
  }
}
