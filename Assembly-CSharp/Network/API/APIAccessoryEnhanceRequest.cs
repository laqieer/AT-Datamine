// Decompiled with JetBrains decompiler
// Type: Network.API.APIAccessoryEnhanceRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001B33")]
  [Serializable]
  public class APIAccessoryEnhanceRequest
  {
    [Token(Token = "0x40074B2")]
    [FieldOffset(Offset = "0x10")]
    public string accessory_id;
    [Token(Token = "0x40074B3")]
    [FieldOffset(Offset = "0x18")]
    public int soul_num;

    [Token(Token = "0x6009FAF")]
    [Address(RVA = "0x46C1C44", Offset = "0x46C1C44", VA = "0x46C1C44")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x6009FB0")]
    [Address(RVA = "0x46C1C8C", Offset = "0x46C1C8C", VA = "0x46C1C8C")]
    public APIAccessoryEnhanceRequest()
    {
    }
  }
}
