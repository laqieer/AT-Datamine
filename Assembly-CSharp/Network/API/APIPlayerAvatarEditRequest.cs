// Decompiled with JetBrains decompiler
// Type: Network.API.APIPlayerAvatarEditRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001D87")]
  [Serializable]
  public class APIPlayerAvatarEditRequest
  {
    [Token(Token = "0x4007E1C")]
    [FieldOffset(Offset = "0x10")]
    public int avatar_id;

    [Token(Token = "0x600AE4E")]
    [Address(RVA = "0x1A4CA8C", Offset = "0x1A4CA8C", VA = "0x1A4CA8C")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600AE4F")]
    [Address(RVA = "0x1A4CAD4", Offset = "0x1A4CAD4", VA = "0x1A4CAD4")]
    public APIPlayerAvatarEditRequest()
    {
    }
  }
}
