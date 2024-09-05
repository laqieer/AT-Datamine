// Decompiled with JetBrains decompiler
// Type: Network.API.APISerialRegisterRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001E07")]
  [Serializable]
  public class APISerialRegisterRequest
  {
    [Token(Token = "0x400808E")]
    [FieldOffset(Offset = "0x10")]
    public int campaign_id;
    [Token(Token = "0x400808F")]
    [FieldOffset(Offset = "0x18")]
    public string serial_code;

    [Token(Token = "0x600B1B0")]
    [Address(RVA = "0x22DD760", Offset = "0x22DD760", VA = "0x22DD760")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600B1B1")]
    [Address(RVA = "0x22DD7A8", Offset = "0x22DD7A8", VA = "0x22DD7A8")]
    public APISerialRegisterRequest()
    {
    }
  }
}
