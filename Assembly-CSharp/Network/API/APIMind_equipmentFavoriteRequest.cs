// Decompiled with JetBrains decompiler
// Type: Network.API.APIMind_equipmentFavoriteRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001D5B")]
  [Serializable]
  public class APIMind_equipmentFavoriteRequest
  {
    [Token(Token = "0x4007D69")]
    [FieldOffset(Offset = "0x10")]
    public List<string> lock_player_mind_equipment_ids;
    [Token(Token = "0x4007D6A")]
    [FieldOffset(Offset = "0x18")]
    public List<string> unlock_player_mind_equipment_ids;

    [Token(Token = "0x600AD31")]
    [Address(RVA = "0x1A48F00", Offset = "0x1A48F00", VA = "0x1A48F00")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600AD32")]
    [Address(RVA = "0x1A48F48", Offset = "0x1A48F48", VA = "0x1A48F48")]
    public APIMind_equipmentFavoriteRequest()
    {
    }
  }
}
