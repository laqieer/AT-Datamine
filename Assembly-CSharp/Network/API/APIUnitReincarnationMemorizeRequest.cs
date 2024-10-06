// Decompiled with JetBrains decompiler
// Type: Network.API.APIUnitReincarnationMemorizeRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001EC7")]
  [Serializable]
  public class APIUnitReincarnationMemorizeRequest
  {
    [Token(Token = "0x4008433")]
    [FieldOffset(Offset = "0x10")]
    public string player_unit_id;

    [Token(Token = "0x600B6CA")]
    [Address(RVA = "0x22EDD70", Offset = "0x22EDD70", VA = "0x22EDD70")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600B6CB")]
    [Address(RVA = "0x22EDDB8", Offset = "0x22EDDB8", VA = "0x22EDDB8")]
    public APIUnitReincarnationMemorizeRequest()
    {
    }
  }
}
