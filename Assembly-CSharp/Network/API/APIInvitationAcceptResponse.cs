// Decompiled with JetBrains decompiler
// Type: Network.API.APIInvitationAcceptResponse
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
  [Token(Token = "0x2001D3C")]
  [Serializable]
  public class APIInvitationAcceptResponse
  {
    [Token(Token = "0x4007CD8")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private bool is_success;
    [Token(Token = "0x4007CD9")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private List<Reward> rewards;

    [Token(Token = "0x1700218A")]
    public bool IsSuccess
    {
      [Token(Token = "0x600AC63"), Address(RVA = "0x1A46400", Offset = "0x1A46400", VA = "0x1A46400")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700218B")]
    public List<Reward> Rewards
    {
      [Token(Token = "0x600AC64"), Address(RVA = "0x1A46408", Offset = "0x1A46408", VA = "0x1A46408")] get
      {
        return (List<Reward>) null;
      }
    }

    [Token(Token = "0x600AC65")]
    [Address(RVA = "0x1A46410", Offset = "0x1A46410", VA = "0x1A46410")]
    public APIInvitationAcceptResponse()
    {
    }
  }
}
