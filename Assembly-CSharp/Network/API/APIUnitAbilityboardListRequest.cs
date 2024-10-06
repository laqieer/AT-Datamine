// Decompiled with JetBrains decompiler
// Type: Network.API.APIUnitAbilityboardListRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001E9B")]
  [Serializable]
  public class APIUnitAbilityboardListRequest
  {
    [Token(Token = "0x400838A")]
    [FieldOffset(Offset = "0x10")]
    public string player_unit_id;

    [Token(Token = "0x600B5BA")]
    [Address(RVA = "0x22EA23C", Offset = "0x22EA23C", VA = "0x22EA23C")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600B5BB")]
    [Address(RVA = "0x22EA284", Offset = "0x22EA284", VA = "0x22EA284")]
    public APIUnitAbilityboardListRequest()
    {
    }
  }
}
