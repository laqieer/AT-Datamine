// Decompiled with JetBrains decompiler
// Type: Network.API.APISerialRegisterResponse
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
  [Token(Token = "0x2001E08")]
  [Serializable]
  public class APISerialRegisterResponse
  {
    [Token(Token = "0x4008090")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private string message_success;
    [Token(Token = "0x4008091")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private List<Reward> rewards;
    [Token(Token = "0x4008092")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private bool is_present_limited;

    [Token(Token = "0x170023A9")]
    public string MessageSuccess
    {
      [Token(Token = "0x600B1B2"), Address(RVA = "0x22DD7B0", Offset = "0x22DD7B0", VA = "0x22DD7B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170023AA")]
    public List<Reward> Rewards
    {
      [Token(Token = "0x600B1B3"), Address(RVA = "0x22DD7B8", Offset = "0x22DD7B8", VA = "0x22DD7B8")] get
      {
        return (List<Reward>) null;
      }
    }

    [Token(Token = "0x170023AB")]
    public bool IsPresentLimited
    {
      [Token(Token = "0x600B1B4"), Address(RVA = "0x22DD7C0", Offset = "0x22DD7C0", VA = "0x22DD7C0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600B1B5")]
    [Address(RVA = "0x22DD7C8", Offset = "0x22DD7C8", VA = "0x22DD7C8")]
    public APISerialRegisterResponse()
    {
    }
  }
}
