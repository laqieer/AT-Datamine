// Decompiled with JetBrains decompiler
// Type: Network.Auth.APIAuthAccessTokenRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.Auth
{
  [Token(Token = "0x2001B1C")]
  [Serializable]
  public class APIAuthAccessTokenRequest
  {
    [Token(Token = "0x4007488")]
    [FieldOffset(Offset = "0x10")]
    public string device_id;
    [Token(Token = "0x4007489")]
    [FieldOffset(Offset = "0x18")]
    public string secret_key;

    [Token(Token = "0x6009F58")]
    [Address(RVA = "0x46BF8B8", Offset = "0x46BF8B8", VA = "0x46BF8B8")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x6009F59")]
    [Address(RVA = "0x46BF900", Offset = "0x46BF900", VA = "0x46BF900")]
    public APIAuthAccessTokenRequest()
    {
    }
  }
}
