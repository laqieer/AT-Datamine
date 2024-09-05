// Decompiled with JetBrains decompiler
// Type: Network.API.APIChatPostResponse
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
  [Token(Token = "0x2001BD4")]
  [Serializable]
  public class APIChatPostResponse
  {
    [Token(Token = "0x4007736")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private List<ChatMessageType> messages;

    [Token(Token = "0x17001E55")]
    public List<ChatMessageType> Messages
    {
      [Token(Token = "0x600A38E"), Address(RVA = "0x46CF3DC", Offset = "0x46CF3DC", VA = "0x46CF3DC")] get
      {
        return (List<ChatMessageType>) null;
      }
    }

    [Token(Token = "0x600A38F")]
    [Address(RVA = "0x46CF3E4", Offset = "0x46CF3E4", VA = "0x46CF3E4")]
    public APIChatPostResponse()
    {
    }
  }
}
