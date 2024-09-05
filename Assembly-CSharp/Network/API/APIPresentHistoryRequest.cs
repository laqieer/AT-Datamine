// Decompiled with JetBrains decompiler
// Type: Network.API.APIPresentHistoryRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001DBF")]
  [Serializable]
  public class APIPresentHistoryRequest
  {
    [Token(Token = "0x4007F16")]
    [FieldOffset(Offset = "0x10")]
    public int page_number;

    [Token(Token = "0x600AFD2")]
    [Address(RVA = "0x1A51724", Offset = "0x1A51724", VA = "0x1A51724")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600AFD3")]
    [Address(RVA = "0x1A5176C", Offset = "0x1A5176C", VA = "0x1A5176C")]
    public APIPresentHistoryRequest()
    {
    }
  }
}
