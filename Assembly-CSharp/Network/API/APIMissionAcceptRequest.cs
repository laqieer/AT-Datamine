// Decompiled with JetBrains decompiler
// Type: Network.API.APIMissionAcceptRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001D67")]
  [Serializable]
  public class APIMissionAcceptRequest
  {
    [Token(Token = "0x4007D99")]
    [FieldOffset(Offset = "0x10")]
    public int group_id;
    [Token(Token = "0x4007D9A")]
    [FieldOffset(Offset = "0x18")]
    public List<int> mission_ids;

    [Token(Token = "0x600AD7D")]
    [Address(RVA = "0x1A49F34", Offset = "0x1A49F34", VA = "0x1A49F34")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600AD7E")]
    [Address(RVA = "0x1A49F7C", Offset = "0x1A49F7C", VA = "0x1A49F7C")]
    public APIMissionAcceptRequest()
    {
    }
  }
}
