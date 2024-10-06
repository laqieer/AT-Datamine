// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerExpeditionPartyCharacterType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001AA8")]
  [Serializable]
  public class PlayerExpeditionPartyCharacterType
  {
    [Token(Token = "0x400723D")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private string id;
    [Token(Token = "0x400723E")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private int party_no;
    [Token(Token = "0x400723F")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private int slot;
    [Token(Token = "0x4007240")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private string player_unit_character_id;
    [Token(Token = "0x4007241")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private int stored_experience;

    [Token(Token = "0x17001A8A")]
    public string Id
    {
      [Token(Token = "0x6009A3C"), Address(RVA = "0x48F10DC", Offset = "0x48F10DC", VA = "0x48F10DC")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009A3D"), Address(RVA = "0x48F10E4", Offset = "0x48F10E4", VA = "0x48F10E4")] set
      {
      }
    }

    [Token(Token = "0x17001A8B")]
    public int PartyNo
    {
      [Token(Token = "0x6009A3E"), Address(RVA = "0x48F10EC", Offset = "0x48F10EC", VA = "0x48F10EC")] get
      {
        return new int();
      }
      [Token(Token = "0x6009A3F"), Address(RVA = "0x48F10F4", Offset = "0x48F10F4", VA = "0x48F10F4")] set
      {
      }
    }

    [Token(Token = "0x17001A8C")]
    public int Slot
    {
      [Token(Token = "0x6009A40"), Address(RVA = "0x48F10FC", Offset = "0x48F10FC", VA = "0x48F10FC")] get
      {
        return new int();
      }
      [Token(Token = "0x6009A41"), Address(RVA = "0x48F1104", Offset = "0x48F1104", VA = "0x48F1104")] set
      {
      }
    }

    [Token(Token = "0x17001A8D")]
    public string PlayerUnitCharacterId
    {
      [Token(Token = "0x6009A42"), Address(RVA = "0x48F110C", Offset = "0x48F110C", VA = "0x48F110C")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009A43"), Address(RVA = "0x48F1114", Offset = "0x48F1114", VA = "0x48F1114")] set
      {
      }
    }

    [Token(Token = "0x17001A8E")]
    public int StoredExperience
    {
      [Token(Token = "0x6009A44"), Address(RVA = "0x48F111C", Offset = "0x48F111C", VA = "0x48F111C")] get
      {
        return new int();
      }
      [Token(Token = "0x6009A45"), Address(RVA = "0x48F1124", Offset = "0x48F1124", VA = "0x48F1124")] set
      {
      }
    }

    [Token(Token = "0x6009A46")]
    [Address(RVA = "0x48F112C", Offset = "0x48F112C", VA = "0x48F112C")]
    public PlayerExpeditionPartyCharacterType()
    {
    }
  }
}
