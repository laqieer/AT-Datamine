// Decompiled with JetBrains decompiler
// Type: Network.API.APIArenaBattleHistoryResponse
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
  [Token(Token = "0x2001B88")]
  [Serializable]
  public class APIArenaBattleHistoryResponse
  {
    [Token(Token = "0x4007610")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private List<ArenaBattleHistoryType> arena_battle_histories;

    [Token(Token = "0x17001DB3")]
    public List<ArenaBattleHistoryType> ArenaBattleHistories
    {
      [Token(Token = "0x600A1BC"), Address(RVA = "0x46C8DB8", Offset = "0x46C8DB8", VA = "0x46C8DB8")] get
      {
        return (List<ArenaBattleHistoryType>) null;
      }
    }

    [Token(Token = "0x600A1BD")]
    [Address(RVA = "0x46C8DC0", Offset = "0x46C8DC0", VA = "0x46C8DC0")]
    public APIArenaBattleHistoryResponse()
    {
    }
  }
}
