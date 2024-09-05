// Decompiled with JetBrains decompiler
// Type: Network.API.APIArenaBattleReset_countResponse
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.Param;
using System;
using UnityEngine;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001B8C")]
  [Serializable]
  public class APIArenaBattleReset_countResponse
  {
    [Token(Token = "0x400761E")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private PlayerArenaType player_arena;
    [Token(Token = "0x400761F")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private PlayerType player;
    [Token(Token = "0x4007620")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private UpdatedPlayerItems updated_player_items;

    [Token(Token = "0x17001DBA")]
    public PlayerArenaType PlayerArena
    {
      [Token(Token = "0x600A1D3"), Address(RVA = "0x46C930C", Offset = "0x46C930C", VA = "0x46C930C")] get
      {
        return (PlayerArenaType) null;
      }
    }

    [Token(Token = "0x17001DBB")]
    public PlayerType Player
    {
      [Token(Token = "0x600A1D4"), Address(RVA = "0x46C9314", Offset = "0x46C9314", VA = "0x46C9314")] get
      {
        return (PlayerType) null;
      }
    }

    [Token(Token = "0x17001DBC")]
    public UpdatedPlayerItems UpdatedPlayerItems
    {
      [Token(Token = "0x600A1D5"), Address(RVA = "0x46C931C", Offset = "0x46C931C", VA = "0x46C931C")] get
      {
        return (UpdatedPlayerItems) null;
      }
    }

    [Token(Token = "0x600A1D6")]
    [Address(RVA = "0x46C9324", Offset = "0x46C9324", VA = "0x46C9324")]
    public APIArenaBattleReset_countResponse()
    {
    }
  }
}
