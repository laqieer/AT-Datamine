// Decompiled with JetBrains decompiler
// Type: Network.API.APIBlockAddRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001BB3")]
  [Serializable]
  public class APIBlockAddRequest
  {
    [Token(Token = "0x40076C2")]
    [FieldOffset(Offset = "0x10")]
    public string target_player_id;

    [Token(Token = "0x600A2CF")]
    [Address(RVA = "0x46CC8C4", Offset = "0x46CC8C4", VA = "0x46CC8C4")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600A2D0")]
    [Address(RVA = "0x46CC90C", Offset = "0x46CC90C", VA = "0x46CC90C")]
    public APIBlockAddRequest()
    {
    }
  }
}
