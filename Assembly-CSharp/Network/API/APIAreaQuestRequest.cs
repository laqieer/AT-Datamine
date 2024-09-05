// Decompiled with JetBrains decompiler
// Type: Network.API.APIAreaQuestRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001B6B")]
  [Serializable]
  public class APIAreaQuestRequest
  {
    [Token(Token = "0x4007580")]
    [FieldOffset(Offset = "0x10")]
    public int area_group_id;

    [Token(Token = "0x600A100")]
    [Address(RVA = "0x46C6754", Offset = "0x46C6754", VA = "0x46C6754")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600A101")]
    [Address(RVA = "0x46C679C", Offset = "0x46C679C", VA = "0x46C679C")]
    public APIAreaQuestRequest()
    {
    }
  }
}
