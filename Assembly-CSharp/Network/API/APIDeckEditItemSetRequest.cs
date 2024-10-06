// Decompiled with JetBrains decompiler
// Type: Network.API.APIDeckEditItemSetRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001BFB")]
  [Serializable]
  public class APIDeckEditItemSetRequest
  {
    [Token(Token = "0x40077CE")]
    [FieldOffset(Offset = "0x10")]
    public int player_item_set_id;
    [Token(Token = "0x40077CF")]
    [FieldOffset(Offset = "0x18")]
    public List<int> player_item_ids;

    [Token(Token = "0x600A484")]
    [Address(RVA = "0x46D2964", Offset = "0x46D2964", VA = "0x46D2964")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600A485")]
    [Address(RVA = "0x46D29AC", Offset = "0x46D29AC", VA = "0x46D29AC")]
    public APIDeckEditItemSetRequest()
    {
    }
  }
}
