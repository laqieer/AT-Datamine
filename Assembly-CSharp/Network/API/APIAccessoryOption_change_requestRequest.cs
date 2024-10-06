// Decompiled with JetBrains decompiler
// Type: Network.API.APIAccessoryOption_change_requestRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001B47")]
  [Serializable]
  public class APIAccessoryOption_change_requestRequest
  {
    [Token(Token = "0x40074FD")]
    [FieldOffset(Offset = "0x10")]
    public string player_accessory_id;
    [Token(Token = "0x40074FE")]
    [FieldOffset(Offset = "0x18")]
    public int reroll_num;

    [Token(Token = "0x600A029")]
    [Address(RVA = "0x46C3720", Offset = "0x46C3720", VA = "0x46C3720")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600A02A")]
    [Address(RVA = "0x46C3768", Offset = "0x46C3768", VA = "0x46C3768")]
    public APIAccessoryOption_change_requestRequest()
    {
    }
  }
}
