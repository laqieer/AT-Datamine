// Decompiled with JetBrains decompiler
// Type: Network.API.APIAccessoryFavoriteRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001B37")]
  [Serializable]
  public class APIAccessoryFavoriteRequest
  {
    [Token(Token = "0x40074C4")]
    [FieldOffset(Offset = "0x10")]
    public List<string> lock_accessory_ids;
    [Token(Token = "0x40074C5")]
    [FieldOffset(Offset = "0x18")]
    public List<string> unlock_accessory_ids;

    [Token(Token = "0x6009FCA")]
    [Address(RVA = "0x46C21B8", Offset = "0x46C21B8", VA = "0x46C21B8")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x6009FCB")]
    [Address(RVA = "0x46C2200", Offset = "0x46C2200", VA = "0x46C2200")]
    public APIAccessoryFavoriteRequest()
    {
    }
  }
}
