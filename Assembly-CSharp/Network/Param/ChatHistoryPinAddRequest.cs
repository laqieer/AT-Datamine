// Decompiled with JetBrains decompiler
// Type: Network.Param.ChatHistoryPinAddRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001A49")]
  [Serializable]
  public class ChatHistoryPinAddRequest
  {
    [Token(Token = "0x4007068")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private string content;
    [Token(Token = "0x4007069")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private int message_type_id;

    [Token(Token = "0x1700189E")]
    public string Content
    {
      [Token(Token = "0x600961B"), Address(RVA = "0x48EEF14", Offset = "0x48EEF14", VA = "0x48EEF14")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600961C"), Address(RVA = "0x48EEF1C", Offset = "0x48EEF1C", VA = "0x48EEF1C")] set
      {
      }
    }

    [Token(Token = "0x1700189F")]
    public int MessageTypeId
    {
      [Token(Token = "0x600961D"), Address(RVA = "0x48EEF24", Offset = "0x48EEF24", VA = "0x48EEF24")] get
      {
        return new int();
      }
      [Token(Token = "0x600961E"), Address(RVA = "0x48EEF2C", Offset = "0x48EEF2C", VA = "0x48EEF2C")] set
      {
      }
    }

    [Token(Token = "0x600961F")]
    [Address(RVA = "0x48EEF34", Offset = "0x48EEF34", VA = "0x48EEF34")]
    public ChatHistoryPinAddRequest()
    {
    }
  }
}
