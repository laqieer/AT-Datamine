// Decompiled with JetBrains decompiler
// Type: Network.API.APIMissionData_linkResponse
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.Param;
using System;
using UnityEngine;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001D70")]
  [Serializable]
  public class APIMissionData_linkResponse : ICommonApiResult
  {
    [Token(Token = "0x4007DC7")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private NoticeData notice;

    [Token(Token = "0x17002216")]
    public NoticeData Notice
    {
      [Token(Token = "0x600ADBF"), Address(RVA = "0x1A4AABC", Offset = "0x1A4AABC", VA = "0x1A4AABC", Slot = "4")] get
      {
        return (NoticeData) null;
      }
    }

    [Token(Token = "0x600ADC0")]
    [Address(RVA = "0x1A4AAC4", Offset = "0x1A4AAC4", VA = "0x1A4AAC4")]
    public APIMissionData_linkResponse()
    {
    }
  }
}
