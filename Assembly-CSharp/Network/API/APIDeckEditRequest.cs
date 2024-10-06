// Decompiled with JetBrains decompiler
// Type: Network.API.APIDeckEditRequest
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
  [Token(Token = "0x2001BF7")]
  [Serializable]
  public class APIDeckEditRequest
  {
    [Token(Token = "0x40077BD")]
    [FieldOffset(Offset = "0x10")]
    public int deck_type_id;
    [Token(Token = "0x40077BE")]
    [FieldOffset(Offset = "0x14")]
    public int deck_number;
    [Token(Token = "0x40077BF")]
    [FieldOffset(Offset = "0x18")]
    public List<PlayerDeckSlotInfo> deck_slot_infos;
    [Token(Token = "0x40077C0")]
    [FieldOffset(Offset = "0x20")]
    public int player_item_set_id;

    [Token(Token = "0x600A46C")]
    [Address(RVA = "0x46D2408", Offset = "0x46D2408", VA = "0x46D2408")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600A46D")]
    [Address(RVA = "0x46D2450", Offset = "0x46D2450", VA = "0x46D2450")]
    public APIDeckEditRequest()
    {
    }
  }
}
