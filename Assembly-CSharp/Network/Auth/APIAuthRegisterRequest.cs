// Decompiled with JetBrains decompiler
// Type: Network.Auth.APIAuthRegisterRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.Auth
{
  [Token(Token = "0x2001B20")]
  [Serializable]
  public class APIAuthRegisterRequest
  {
    [Token(Token = "0x4007496")]
    [FieldOffset(Offset = "0x10")]
    public string secret_key;

    [Token(Token = "0x6009F70")]
    [Address(RVA = "0x46BFDE4", Offset = "0x46BFDE4", VA = "0x46BFDE4")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x6009F71")]
    [Address(RVA = "0x46BFE2C", Offset = "0x46BFE2C", VA = "0x46BFE2C")]
    public APIAuthRegisterRequest()
    {
    }
  }
}
