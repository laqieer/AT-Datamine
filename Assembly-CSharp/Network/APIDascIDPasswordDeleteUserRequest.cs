// Decompiled with JetBrains decompiler
// Type: Network.APIDascIDPasswordDeleteUserRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network
{
  [Token(Token = "0x20019D9")]
  [Serializable]
  public class APIDascIDPasswordDeleteUserRequest
  {
    [Token(Token = "0x4006ED9")]
    [FieldOffset(Offset = "0x10")]
    public string user_id;
    [Token(Token = "0x4006EDA")]
    [FieldOffset(Offset = "0x18")]
    public string user_secret;

    [Token(Token = "0x60093A0")]
    [Address(RVA = "0x4D12250", Offset = "0x4D12250", VA = "0x4D12250")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x60093A1")]
    [Address(RVA = "0x4D12298", Offset = "0x4D12298", VA = "0x4D12298")]
    public APIDascIDPasswordDeleteUserRequest()
    {
    }
  }
}
