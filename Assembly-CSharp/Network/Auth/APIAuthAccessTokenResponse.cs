// Decompiled with JetBrains decompiler
// Type: Network.Auth.APIAuthAccessTokenResponse
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Auth
{
  [Token(Token = "0x2001B1D")]
  [Serializable]
  public class APIAuthAccessTokenResponse
  {
    [Token(Token = "0x400748A")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private string access_token;
    [Token(Token = "0x400748B")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private long expires_in;

    [Token(Token = "0x17001CE7")]
    public string AccessToken
    {
      [Token(Token = "0x6009F5A"), Address(RVA = "0x46BF908", Offset = "0x46BF908", VA = "0x46BF908")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001CE8")]
    public long ExpiresIn
    {
      [Token(Token = "0x6009F5B"), Address(RVA = "0x46BF910", Offset = "0x46BF910", VA = "0x46BF910")] get
      {
        return new long();
      }
    }

    [Token(Token = "0x6009F5C")]
    [Address(RVA = "0x46BF918", Offset = "0x46BF918", VA = "0x46BF918")]
    public APIAuthAccessTokenResponse()
    {
    }
  }
}
