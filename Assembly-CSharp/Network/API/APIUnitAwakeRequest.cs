// Decompiled with JetBrains decompiler
// Type: Network.API.APIUnitAwakeRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001EA7")]
  [Serializable]
  public class APIUnitAwakeRequest
  {
    [Token(Token = "0x40083BC")]
    [FieldOffset(Offset = "0x10")]
    public string player_unit_id;

    [Token(Token = "0x600B608")]
    [Address(RVA = "0x22EB280", Offset = "0x22EB280", VA = "0x22EB280")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600B609")]
    [Address(RVA = "0x22EB2C8", Offset = "0x22EB2C8", VA = "0x22EB2C8")]
    public APIUnitAwakeRequest()
    {
    }
  }
}
