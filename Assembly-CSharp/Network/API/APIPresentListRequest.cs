// Decompiled with JetBrains decompiler
// Type: Network.API.APIPresentListRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001DC3")]
  [Serializable]
  public class APIPresentListRequest
  {
    [Token(Token = "0x4007F24")]
    [FieldOffset(Offset = "0x10")]
    public bool limited_present_flag;
    [Token(Token = "0x4007F25")]
    [FieldOffset(Offset = "0x14")]
    public int page_number;
    [Token(Token = "0x4007F26")]
    [FieldOffset(Offset = "0x18")]
    public bool non_active_page1_flag;

    [Token(Token = "0x600AFEA")]
    [Address(RVA = "0x1A51C80", Offset = "0x1A51C80", VA = "0x1A51C80")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600AFEB")]
    [Address(RVA = "0x1A51CC8", Offset = "0x1A51CC8", VA = "0x1A51CC8")]
    public APIPresentListRequest()
    {
    }
  }
}
