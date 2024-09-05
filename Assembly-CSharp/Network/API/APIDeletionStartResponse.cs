// Decompiled with JetBrains decompiler
// Type: Network.API.APIDeletionStartResponse
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001C10")]
  [Serializable]
  public class APIDeletionStartResponse
  {
    [Token(Token = "0x4007817")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private string flow_token;

    [Token(Token = "0x17001ECE")]
    public string FlowToken
    {
      [Token(Token = "0x600A4F7"), Address(RVA = "0x190645C", Offset = "0x190645C", VA = "0x190645C")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x600A4F8")]
    [Address(RVA = "0x1906464", Offset = "0x1906464", VA = "0x1906464")]
    public APIDeletionStartResponse()
    {
    }
  }
}
