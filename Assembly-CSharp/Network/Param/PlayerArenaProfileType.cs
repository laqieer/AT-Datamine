// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerArenaProfileType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001A87")]
  [Serializable]
  public class PlayerArenaProfileType
  {
    [Token(Token = "0x40071B2")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private string id;
    [Token(Token = "0x40071B3")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private int symbol_unit_master_id;
    [Token(Token = "0x40071B4")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private string name;
    [Token(Token = "0x40071B5")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private int experience;
    [Token(Token = "0x40071B6")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private int emblem_id;

    [Token(Token = "0x170019F6")]
    public string Id
    {
      [Token(Token = "0x60098FC"), Address(RVA = "0x48F05DC", Offset = "0x48F05DC", VA = "0x48F05DC")] get
      {
        return (string) null;
      }
      [Token(Token = "0x60098FD"), Address(RVA = "0x48F05E4", Offset = "0x48F05E4", VA = "0x48F05E4")] set
      {
      }
    }

    [Token(Token = "0x170019F7")]
    public int SymbolUnitMasterId
    {
      [Token(Token = "0x60098FE"), Address(RVA = "0x48F05EC", Offset = "0x48F05EC", VA = "0x48F05EC")] get
      {
        return new int();
      }
      [Token(Token = "0x60098FF"), Address(RVA = "0x48F05F4", Offset = "0x48F05F4", VA = "0x48F05F4")] set
      {
      }
    }

    [Token(Token = "0x170019F8")]
    public string Name
    {
      [Token(Token = "0x6009900"), Address(RVA = "0x48F05FC", Offset = "0x48F05FC", VA = "0x48F05FC")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009901"), Address(RVA = "0x48F0604", Offset = "0x48F0604", VA = "0x48F0604")] set
      {
      }
    }

    [Token(Token = "0x170019F9")]
    public int Experience
    {
      [Token(Token = "0x6009902"), Address(RVA = "0x48F060C", Offset = "0x48F060C", VA = "0x48F060C")] get
      {
        return new int();
      }
      [Token(Token = "0x6009903"), Address(RVA = "0x48F0614", Offset = "0x48F0614", VA = "0x48F0614")] set
      {
      }
    }

    [Token(Token = "0x170019FA")]
    public int EmblemId
    {
      [Token(Token = "0x6009904"), Address(RVA = "0x48F061C", Offset = "0x48F061C", VA = "0x48F061C")] get
      {
        return new int();
      }
      [Token(Token = "0x6009905"), Address(RVA = "0x48F0624", Offset = "0x48F0624", VA = "0x48F0624")] set
      {
      }
    }

    [Token(Token = "0x6009906")]
    [Address(RVA = "0x48F062C", Offset = "0x48F062C", VA = "0x48F062C")]
    public PlayerArenaProfileType()
    {
    }
  }
}
