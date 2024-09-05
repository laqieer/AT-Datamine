// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerScoreAttackProfileType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001AD5")]
  [Serializable]
  public class PlayerScoreAttackProfileType
  {
    [Token(Token = "0x4007302")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private string id;
    [Token(Token = "0x4007303")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private int symbol_unit_master_id;
    [Token(Token = "0x4007304")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private string name;
    [Token(Token = "0x4007305")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private string guild_name;

    [Token(Token = "0x17001B64")]
    public string Id
    {
      [Token(Token = "0x6009C08"), Address(RVA = "0x48F20D0", Offset = "0x48F20D0", VA = "0x48F20D0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009C09"), Address(RVA = "0x48F20D8", Offset = "0x48F20D8", VA = "0x48F20D8")] set
      {
      }
    }

    [Token(Token = "0x17001B65")]
    public int SymbolUnitMasterId
    {
      [Token(Token = "0x6009C0A"), Address(RVA = "0x48F20E0", Offset = "0x48F20E0", VA = "0x48F20E0")] get
      {
        return new int();
      }
      [Token(Token = "0x6009C0B"), Address(RVA = "0x48F20E8", Offset = "0x48F20E8", VA = "0x48F20E8")] set
      {
      }
    }

    [Token(Token = "0x17001B66")]
    public string Name
    {
      [Token(Token = "0x6009C0C"), Address(RVA = "0x48F20F0", Offset = "0x48F20F0", VA = "0x48F20F0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009C0D"), Address(RVA = "0x48F20F8", Offset = "0x48F20F8", VA = "0x48F20F8")] set
      {
      }
    }

    [Token(Token = "0x17001B67")]
    public string GuildName
    {
      [Token(Token = "0x6009C0E"), Address(RVA = "0x48F2100", Offset = "0x48F2100", VA = "0x48F2100")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009C0F"), Address(RVA = "0x48F2108", Offset = "0x48F2108", VA = "0x48F2108")] set
      {
      }
    }

    [Token(Token = "0x6009C10")]
    [Address(RVA = "0x48F2110", Offset = "0x48F2110", VA = "0x48F2110")]
    public PlayerScoreAttackProfileType()
    {
    }
  }
}
