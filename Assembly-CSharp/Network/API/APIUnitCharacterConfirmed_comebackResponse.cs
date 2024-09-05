// Decompiled with JetBrains decompiler
// Type: Network.API.APIUnitCharacterConfirmed_comebackResponse
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.Param;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001EB0")]
  [Serializable]
  public class APIUnitCharacterConfirmed_comebackResponse
  {
    [Token(Token = "0x40083DA")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private List<PlayerUnitCharacterType> updated_player_unit_characters;

    [Token(Token = "0x17002591")]
    public List<PlayerUnitCharacterType> UpdatedPlayerUnitCharacters
    {
      [Token(Token = "0x600B63A"), Address(RVA = "0x22EBD88", Offset = "0x22EBD88", VA = "0x22EBD88")] get
      {
        return (List<PlayerUnitCharacterType>) null;
      }
    }

    [Token(Token = "0x600B63B")]
    [Address(RVA = "0x22EBD90", Offset = "0x22EBD90", VA = "0x22EBD90")]
    public APIUnitCharacterConfirmed_comebackResponse()
    {
    }
  }
}
