// Decompiled with JetBrains decompiler
// Type: Network.Param.RequestPlayerExpeditionPartyCharacter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001B0A")]
  [Serializable]
  public class RequestPlayerExpeditionPartyCharacter
  {
    [Token(Token = "0x400742D")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private string id;
    [Token(Token = "0x400742E")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private string expedition_player_unit_id;

    [Token(Token = "0x17001C8F")]
    public string Id
    {
      [Token(Token = "0x6009E93"), Address(RVA = "0x48F3574", Offset = "0x48F3574", VA = "0x48F3574")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009E94"), Address(RVA = "0x48F357C", Offset = "0x48F357C", VA = "0x48F357C")] set
      {
      }
    }

    [Token(Token = "0x17001C90")]
    public string ExpeditionPlayerUnitId
    {
      [Token(Token = "0x6009E95"), Address(RVA = "0x48F3584", Offset = "0x48F3584", VA = "0x48F3584")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009E96"), Address(RVA = "0x48F358C", Offset = "0x48F358C", VA = "0x48F358C")] set
      {
      }
    }

    [Token(Token = "0x6009E97")]
    [Address(RVA = "0x48F3594", Offset = "0x48F3594", VA = "0x48F3594")]
    public RequestPlayerExpeditionPartyCharacter()
    {
    }
  }
}
