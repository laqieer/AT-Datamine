// Decompiled with JetBrains decompiler
// Type: Network.API.APIServiceStateResponse
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001E0C")]
  [Serializable]
  public class APIServiceStateResponse
  {
    [Token(Token = "0x400809E")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private string closed_datetime;

    [Token(Token = "0x170023B2")]
    public string ClosedDatetime
    {
      [Token(Token = "0x600B1CB"), Address(RVA = "0x22DDD14", Offset = "0x22DDD14", VA = "0x22DDD14")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x600B1CC")]
    [Address(RVA = "0x22DDD1C", Offset = "0x22DDD1C", VA = "0x22DDD1C")]
    public APIServiceStateResponse()
    {
    }
  }
}
