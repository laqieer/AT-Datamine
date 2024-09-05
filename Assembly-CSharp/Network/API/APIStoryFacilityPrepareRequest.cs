// Decompiled with JetBrains decompiler
// Type: Network.API.APIStoryFacilityPrepareRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001E33")]
  [Serializable]
  public class APIStoryFacilityPrepareRequest
  {
    [Token(Token = "0x4008167")]
    [FieldOffset(Offset = "0x10")]
    public int facility_id;

    [Token(Token = "0x600B2DE")]
    [Address(RVA = "0x22E1384", Offset = "0x22E1384", VA = "0x22E1384")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600B2DF")]
    [Address(RVA = "0x22E13CC", Offset = "0x22E13CC", VA = "0x22E13CC")]
    public APIStoryFacilityPrepareRequest()
    {
    }
  }
}
