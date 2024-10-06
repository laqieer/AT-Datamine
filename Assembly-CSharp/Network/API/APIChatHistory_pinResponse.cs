// Decompiled with JetBrains decompiler
// Type: Network.API.APIChatHistory_pinResponse
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.Param;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001BCC")]
  [Serializable]
  public class APIChatHistory_pinResponse
  {
    [Token(Token = "0x4007719")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private List<PlayerChatHistoryPin> history_pin;

    [Token(Token = "0x17001E47")]
    public List<PlayerChatHistoryPin> HistoryPin
    {
      [Token(Token = "0x600A360"), Address(RVA = "0x46CE934", Offset = "0x46CE934", VA = "0x46CE934")] get
      {
        return (List<PlayerChatHistoryPin>) null;
      }
    }

    [Token(Token = "0x600A361")]
    [Address(RVA = "0x46CE93C", Offset = "0x46CE93C", VA = "0x46CE93C")]
    public APIChatHistory_pinResponse()
    {
    }
  }
}
