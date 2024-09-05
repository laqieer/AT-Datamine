// Decompiled with JetBrains decompiler
// Type: Network.API.APIChatLogResponse
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
  [Token(Token = "0x2001BD0")]
  [Serializable]
  public class APIChatLogResponse
  {
    [Token(Token = "0x4007726")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private List<ChatLogType> logs;

    [Token(Token = "0x17001E4E")]
    public List<ChatLogType> Logs
    {
      [Token(Token = "0x600A377"), Address(RVA = "0x46CEE88", Offset = "0x46CEE88", VA = "0x46CEE88")] get
      {
        return (List<ChatLogType>) null;
      }
    }

    [Token(Token = "0x600A378")]
    [Address(RVA = "0x46CEE90", Offset = "0x46CEE90", VA = "0x46CEE90")]
    public APIChatLogResponse()
    {
    }
  }
}
