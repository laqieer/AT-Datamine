// Decompiled with JetBrains decompiler
// Type: Network.Param.ChatPhraseRequestType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001A4D")]
  [Serializable]
  public class ChatPhraseRequestType
  {
    [Token(Token = "0x4007079")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int slot;
    [Token(Token = "0x400707A")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private string content;

    [Token(Token = "0x170018AF")]
    public int Slot
    {
      [Token(Token = "0x6009641"), Address(RVA = "0x48EF044", Offset = "0x48EF044", VA = "0x48EF044")] get
      {
        return new int();
      }
      [Token(Token = "0x6009642"), Address(RVA = "0x48EF04C", Offset = "0x48EF04C", VA = "0x48EF04C")] set
      {
      }
    }

    [Token(Token = "0x170018B0")]
    public string Content
    {
      [Token(Token = "0x6009643"), Address(RVA = "0x48EF054", Offset = "0x48EF054", VA = "0x48EF054")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009644"), Address(RVA = "0x48EF05C", Offset = "0x48EF05C", VA = "0x48EF05C")] set
      {
      }
    }

    [Token(Token = "0x6009645")]
    [Address(RVA = "0x48EF064", Offset = "0x48EF064", VA = "0x48EF064")]
    public ChatPhraseRequestType()
    {
    }
  }
}
