// Decompiled with JetBrains decompiler
// Type: Network.API.APIUnitCharacterConfirmed_comebackRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001EAF")]
  [Serializable]
  public class APIUnitCharacterConfirmed_comebackRequest
  {
    [Token(Token = "0x40083D9")]
    [FieldOffset(Offset = "0x10")]
    public List<int> character_ids;

    [Token(Token = "0x600B638")]
    [Address(RVA = "0x22EBD38", Offset = "0x22EBD38", VA = "0x22EBD38")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600B639")]
    [Address(RVA = "0x22EBD80", Offset = "0x22EBD80", VA = "0x22EBD80")]
    public APIUnitCharacterConfirmed_comebackRequest()
    {
    }
  }
}
