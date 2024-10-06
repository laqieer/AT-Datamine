// Decompiled with JetBrains decompiler
// Type: Network.API.APIPlayerSymbol_unitEditRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001DB7")]
  [Serializable]
  public class APIPlayerSymbol_unitEditRequest
  {
    [Token(Token = "0x4007EFA")]
    [FieldOffset(Offset = "0x10")]
    public int symbol_unit_master_id;

    [Token(Token = "0x600AFA4")]
    [Address(RVA = "0x1A50C7C", Offset = "0x1A50C7C", VA = "0x1A50C7C")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600AFA5")]
    [Address(RVA = "0x1A50CC4", Offset = "0x1A50CC4", VA = "0x1A50CC4")]
    public APIPlayerSymbol_unitEditRequest()
    {
    }
  }
}
