// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerFggIDRegisterGame
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001AB4")]
  [Serializable]
  public class PlayerFggIDRegisterGame
  {
    [Token(Token = "0x4007274")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int game_id;
    [Token(Token = "0x4007275")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private bool is_register;
    [Token(Token = "0x4007276")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private string thumbnail;
    [Token(Token = "0x4007277")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private string app_store_url;
    [Token(Token = "0x4007278")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private string google_play_url;

    [Token(Token = "0x17001AC1")]
    public int GameId
    {
      [Token(Token = "0x6009AB6"), Address(RVA = "0x48F14B4", Offset = "0x48F14B4", VA = "0x48F14B4")] get
      {
        return new int();
      }
      [Token(Token = "0x6009AB7"), Address(RVA = "0x48F14BC", Offset = "0x48F14BC", VA = "0x48F14BC")] set
      {
      }
    }

    [Token(Token = "0x17001AC2")]
    public bool IsRegister
    {
      [Token(Token = "0x6009AB8"), Address(RVA = "0x48F14C4", Offset = "0x48F14C4", VA = "0x48F14C4")] get
      {
        return new bool();
      }
      [Token(Token = "0x6009AB9"), Address(RVA = "0x48F14CC", Offset = "0x48F14CC", VA = "0x48F14CC")] set
      {
      }
    }

    [Token(Token = "0x17001AC3")]
    public string Thumbnail
    {
      [Token(Token = "0x6009ABA"), Address(RVA = "0x48F14D8", Offset = "0x48F14D8", VA = "0x48F14D8")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009ABB"), Address(RVA = "0x48F14E0", Offset = "0x48F14E0", VA = "0x48F14E0")] set
      {
      }
    }

    [Token(Token = "0x17001AC4")]
    public string AppStoreUrl
    {
      [Token(Token = "0x6009ABC"), Address(RVA = "0x48F14E8", Offset = "0x48F14E8", VA = "0x48F14E8")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009ABD"), Address(RVA = "0x48F14F0", Offset = "0x48F14F0", VA = "0x48F14F0")] set
      {
      }
    }

    [Token(Token = "0x17001AC5")]
    public string GooglePlayUrl
    {
      [Token(Token = "0x6009ABE"), Address(RVA = "0x48F14F8", Offset = "0x48F14F8", VA = "0x48F14F8")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009ABF"), Address(RVA = "0x48F1500", Offset = "0x48F1500", VA = "0x48F1500")] set
      {
      }
    }

    [Token(Token = "0x6009AC0")]
    [Address(RVA = "0x48F1508", Offset = "0x48F1508", VA = "0x48F1508")]
    public PlayerFggIDRegisterGame()
    {
    }
  }
}
