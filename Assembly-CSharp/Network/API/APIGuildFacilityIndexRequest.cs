// Decompiled with JetBrains decompiler
// Type: Network.API.APIGuildFacilityIndexRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001CBF")]
  [Serializable]
  public class APIGuildFacilityIndexRequest
  {
    [Token(Token = "0x4007AE6")]
    [FieldOffset(Offset = "0x10")]
    public string guild_id;

    [Token(Token = "0x600A960")]
    [Address(RVA = "0x1915224", Offset = "0x1915224", VA = "0x1915224")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600A961")]
    [Address(RVA = "0x191526C", Offset = "0x191526C", VA = "0x191526C")]
    public APIGuildFacilityIndexRequest()
    {
    }
  }
}
