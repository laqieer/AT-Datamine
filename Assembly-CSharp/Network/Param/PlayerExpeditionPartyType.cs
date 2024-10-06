// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerExpeditionPartyType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001AA9")]
  [Serializable]
  public class PlayerExpeditionPartyType
  {
    [Token(Token = "0x4007242")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private string id;
    [Token(Token = "0x4007243")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private int party_no;
    [Token(Token = "0x4007244")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private List<PlayerExpeditionPartyCharacterType> player_expedition_party_characters;
    [Token(Token = "0x4007245")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private string player_expedition_stage_id;

    [Token(Token = "0x17001A8F")]
    public string Id
    {
      [Token(Token = "0x6009A47"), Address(RVA = "0x48F1134", Offset = "0x48F1134", VA = "0x48F1134")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009A48"), Address(RVA = "0x48F113C", Offset = "0x48F113C", VA = "0x48F113C")] set
      {
      }
    }

    [Token(Token = "0x17001A90")]
    public int PartyNo
    {
      [Token(Token = "0x6009A49"), Address(RVA = "0x48F1144", Offset = "0x48F1144", VA = "0x48F1144")] get
      {
        return new int();
      }
      [Token(Token = "0x6009A4A"), Address(RVA = "0x48F114C", Offset = "0x48F114C", VA = "0x48F114C")] set
      {
      }
    }

    [Token(Token = "0x17001A91")]
    public List<PlayerExpeditionPartyCharacterType> PlayerExpeditionPartyCharacters
    {
      [Token(Token = "0x6009A4B"), Address(RVA = "0x48F1154", Offset = "0x48F1154", VA = "0x48F1154")] get
      {
        return (List<PlayerExpeditionPartyCharacterType>) null;
      }
      [Token(Token = "0x6009A4C"), Address(RVA = "0x48F115C", Offset = "0x48F115C", VA = "0x48F115C")] set
      {
      }
    }

    [Token(Token = "0x17001A92")]
    public string PlayerExpeditionStageId
    {
      [Token(Token = "0x6009A4D"), Address(RVA = "0x48F1164", Offset = "0x48F1164", VA = "0x48F1164")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009A4E"), Address(RVA = "0x48F116C", Offset = "0x48F116C", VA = "0x48F116C")] set
      {
      }
    }

    [Token(Token = "0x6009A4F")]
    [Address(RVA = "0x48F1174", Offset = "0x48F1174", VA = "0x48F1174")]
    public PlayerExpeditionPartyType()
    {
    }
  }
}
