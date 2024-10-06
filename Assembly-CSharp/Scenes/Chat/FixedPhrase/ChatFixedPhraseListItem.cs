// Decompiled with JetBrains decompiler
// Type: Scenes.Chat.FixedPhrase.ChatFixedPhraseListItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.Param;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Chat.FixedPhrase
{
  [Token(Token = "0x20030C3")]
  public class ChatFixedPhraseListItem : MonoBehaviour
  {
    [Token(Token = "0x400CF6C")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text stampText;
    [Token(Token = "0x400CF6D")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Button bgBtn;
    [Token(Token = "0x400CF6E")]
    [FieldOffset(Offset = "0x28")]
    private int fixedPhraseID;
    [Token(Token = "0x400CF6F")]
    [FieldOffset(Offset = "0x30")]
    private Action<string> onClick;

    [Token(Token = "0x60130C4")]
    [Address(RVA = "0x432ED80", Offset = "0x432ED80", VA = "0x432ED80")]
    private void Awake()
    {
    }

    [Token(Token = "0x60130C5")]
    [Address(RVA = "0x432EE2C", Offset = "0x432EE2C", VA = "0x432EE2C")]
    public void SetData(PlayerChatPhraseType phrase, Action<string> onclick)
    {
    }

    [Token(Token = "0x60130C6")]
    [Address(RVA = "0x432EE78", Offset = "0x432EE78", VA = "0x432EE78")]
    public void ChangeState(bool state)
    {
    }

    [Token(Token = "0x60130C7")]
    [Address(RVA = "0x432EEF8", Offset = "0x432EEF8", VA = "0x432EEF8")]
    public ChatFixedPhraseListItem()
    {
    }
  }
}
