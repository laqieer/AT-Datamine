// Decompiled with JetBrains decompiler
// Type: Network.API.APIDeckEditPlacementRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.Param;
using System;
using System.Collections.Generic;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001BFF")]
  [Serializable]
  public class APIDeckEditPlacementRequest
  {
    [Token(Token = "0x40077DC")]
    [FieldOffset(Offset = "0x10")]
    public int deck_type_id;
    [Token(Token = "0x40077DD")]
    [FieldOffset(Offset = "0x14")]
    public int deck_number;
    [Token(Token = "0x40077DE")]
    [FieldOffset(Offset = "0x18")]
    public List<PlayerDeckPlacementInfo> deck_placements;

    [Token(Token = "0x600A49B")]
    [Address(RVA = "0x46D2EB8", Offset = "0x46D2EB8", VA = "0x46D2EB8")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600A49C")]
    [Address(RVA = "0x46D2F00", Offset = "0x46D2F00", VA = "0x46D2F00")]
    public APIDeckEditPlacementRequest()
    {
    }
  }
}
