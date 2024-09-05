// Decompiled with JetBrains decompiler
// Type: Network.API.APIAccessoryOption_change_confirmRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001B43")]
  [Serializable]
  public class APIAccessoryOption_change_confirmRequest
  {
    [Token(Token = "0x40074EF")]
    [FieldOffset(Offset = "0x10")]
    public string player_accessory_id;
    [Token(Token = "0x40074F0")]
    [FieldOffset(Offset = "0x18")]
    public int candidate_id;

    [Token(Token = "0x600A012")]
    [Address(RVA = "0x46C31CC", Offset = "0x46C31CC", VA = "0x46C31CC")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600A013")]
    [Address(RVA = "0x46C3214", Offset = "0x46C3214", VA = "0x46C3214")]
    public APIAccessoryOption_change_confirmRequest()
    {
    }
  }
}
