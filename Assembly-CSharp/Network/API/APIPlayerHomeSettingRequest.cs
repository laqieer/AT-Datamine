// Decompiled with JetBrains decompiler
// Type: Network.API.APIPlayerHomeSettingRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.Param;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001D97")]
  [Serializable]
  public class APIPlayerHomeSettingRequest
  {
    [Token(Token = "0x4007E53")]
    [FieldOffset(Offset = "0x10")]
    public PlayerHomeSettingType home_setting;

    [Token(Token = "0x600AEAD")]
    [Address(RVA = "0x1A4DFF4", Offset = "0x1A4DFF4", VA = "0x1A4DFF4")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600AEAE")]
    [Address(RVA = "0x1A4E03C", Offset = "0x1A4E03C", VA = "0x1A4E03C")]
    public APIPlayerHomeSettingRequest()
    {
    }
  }
}
