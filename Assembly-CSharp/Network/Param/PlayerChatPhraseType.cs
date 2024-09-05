// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerChatPhraseType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001A99")]
  [Serializable]
  public class PlayerChatPhraseType
  {
    [Token(Token = "0x4007202")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int slot;
    [Token(Token = "0x4007203")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private string content;

    [Token(Token = "0x17001A4F")]
    public int Slot
    {
      [Token(Token = "0x60099B7"), Address(RVA = "0x48F0CB0", Offset = "0x48F0CB0", VA = "0x48F0CB0")] get
      {
        return new int();
      }
      [Token(Token = "0x60099B8"), Address(RVA = "0x48F0CB8", Offset = "0x48F0CB8", VA = "0x48F0CB8")] set
      {
      }
    }

    [Token(Token = "0x17001A50")]
    public string Content
    {
      [Token(Token = "0x60099B9"), Address(RVA = "0x48F0CC0", Offset = "0x48F0CC0", VA = "0x48F0CC0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x60099BA"), Address(RVA = "0x48F0CC8", Offset = "0x48F0CC8", VA = "0x48F0CC8")] set
      {
      }
    }

    [Token(Token = "0x60099BB")]
    [Address(RVA = "0x48F0CD0", Offset = "0x48F0CD0", VA = "0x48F0CD0")]
    public PlayerChatPhraseType()
    {
    }
  }
}
