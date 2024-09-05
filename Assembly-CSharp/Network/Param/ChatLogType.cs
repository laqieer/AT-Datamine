// Decompiled with JetBrains decompiler
// Type: Network.Param.ChatLogType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001A4B")]
  [Serializable]
  public class ChatLogType
  {
    [Token(Token = "0x400706C")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int room_id;
    [Token(Token = "0x400706D")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private List<ChatMessageType> messages;

    [Token(Token = "0x170018A2")]
    public int RoomId
    {
      [Token(Token = "0x6009625"), Address(RVA = "0x48EEF64", Offset = "0x48EEF64", VA = "0x48EEF64")] get
      {
        return new int();
      }
      [Token(Token = "0x6009626"), Address(RVA = "0x48EEF6C", Offset = "0x48EEF6C", VA = "0x48EEF6C")] set
      {
      }
    }

    [Token(Token = "0x170018A3")]
    public List<ChatMessageType> Messages
    {
      [Token(Token = "0x6009627"), Address(RVA = "0x48EEF74", Offset = "0x48EEF74", VA = "0x48EEF74")] get
      {
        return (List<ChatMessageType>) null;
      }
      [Token(Token = "0x6009628"), Address(RVA = "0x48EEF7C", Offset = "0x48EEF7C", VA = "0x48EEF7C")] set
      {
      }
    }

    [Token(Token = "0x6009629")]
    [Address(RVA = "0x48EEF84", Offset = "0x48EEF84", VA = "0x48EEF84")]
    public ChatLogType()
    {
    }
  }
}
