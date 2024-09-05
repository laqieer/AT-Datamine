// Decompiled with JetBrains decompiler
// Type: Network.API.APIPlayerLanguageEditRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001D9F")]
  [Serializable]
  public class APIPlayerLanguageEditRequest
  {
    [Token(Token = "0x4007E6C")]
    [FieldOffset(Offset = "0x10")]
    public int language_type;

    [Token(Token = "0x600AEDB")]
    [Address(RVA = "0x1A4EA9C", Offset = "0x1A4EA9C", VA = "0x1A4EA9C")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600AEDC")]
    [Address(RVA = "0x1A4EAE4", Offset = "0x1A4EAE4", VA = "0x1A4EAE4")]
    public APIPlayerLanguageEditRequest()
    {
    }
  }
}
