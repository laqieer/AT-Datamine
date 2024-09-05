// Decompiled with JetBrains decompiler
// Type: Network.API.APIDeletionStartRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001C0F")]
  [Serializable]
  public class APIDeletionStartRequest
  {
    [Token(Token = "0x4007815")]
    [FieldOffset(Offset = "0x10")]
    public string device_id;
    [Token(Token = "0x4007816")]
    [FieldOffset(Offset = "0x18")]
    public string secret_key;

    [Token(Token = "0x600A4F5")]
    [Address(RVA = "0x190640C", Offset = "0x190640C", VA = "0x190640C")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600A4F6")]
    [Address(RVA = "0x1906454", Offset = "0x1906454", VA = "0x1906454")]
    public APIDeletionStartRequest()
    {
    }
  }
}
