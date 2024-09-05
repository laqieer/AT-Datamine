// Decompiled with JetBrains decompiler
// Type: Network.APIDascIDPasswordRegisterRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network
{
  [Token(Token = "0x20019E1")]
  [Serializable]
  public class APIDascIDPasswordRegisterRequest
  {
    [Token(Token = "0x4006EF0")]
    [FieldOffset(Offset = "0x10")]
    public string user_id;
    [Token(Token = "0x4006EF1")]
    [FieldOffset(Offset = "0x18")]
    public string user_secret;

    [Token(Token = "0x60093C8")]
    [Address(RVA = "0x4D12AB4", Offset = "0x4D12AB4", VA = "0x4D12AB4")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x60093C9")]
    [Address(RVA = "0x4D12AFC", Offset = "0x4D12AFC", VA = "0x4D12AFC")]
    public APIDascIDPasswordRegisterRequest()
    {
    }
  }
}
