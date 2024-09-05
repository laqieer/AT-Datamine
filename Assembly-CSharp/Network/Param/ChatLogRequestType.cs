// Decompiled with JetBrains decompiler
// Type: Network.Param.ChatLogRequestType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001A4A")]
  [Serializable]
  public class ChatLogRequestType
  {
    [Token(Token = "0x400706A")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int room_id;
    [Token(Token = "0x400706B")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private string latest_message_id;

    [Token(Token = "0x170018A0")]
    public int RoomId
    {
      [Token(Token = "0x6009620"), Address(RVA = "0x48EEF3C", Offset = "0x48EEF3C", VA = "0x48EEF3C")] get
      {
        return new int();
      }
      [Token(Token = "0x6009621"), Address(RVA = "0x48EEF44", Offset = "0x48EEF44", VA = "0x48EEF44")] set
      {
      }
    }

    [Token(Token = "0x170018A1")]
    public string LatestMessageId
    {
      [Token(Token = "0x6009622"), Address(RVA = "0x48EEF4C", Offset = "0x48EEF4C", VA = "0x48EEF4C")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009623"), Address(RVA = "0x48EEF54", Offset = "0x48EEF54", VA = "0x48EEF54")] set
      {
      }
    }

    [Token(Token = "0x6009624")]
    [Address(RVA = "0x48EEF5C", Offset = "0x48EEF5C", VA = "0x48EEF5C")]
    public ChatLogRequestType()
    {
    }
  }
}
