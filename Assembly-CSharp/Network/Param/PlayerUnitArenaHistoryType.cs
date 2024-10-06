// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerUnitArenaHistoryType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001AF3")]
  [Serializable]
  public class PlayerUnitArenaHistoryType
  {
    [Token(Token = "0x40073A3")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private string id;
    [Token(Token = "0x40073A4")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private int style_id;
    [Token(Token = "0x40073A5")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private int experience;
    [Token(Token = "0x40073A6")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private int rarity_star;

    [Token(Token = "0x17001C05")]
    public string Id
    {
      [Token(Token = "0x6009D68"), Address(RVA = "0x48F2BF0", Offset = "0x48F2BF0", VA = "0x48F2BF0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009D69"), Address(RVA = "0x48F2BF8", Offset = "0x48F2BF8", VA = "0x48F2BF8")] set
      {
      }
    }

    [Token(Token = "0x17001C06")]
    public int StyleId
    {
      [Token(Token = "0x6009D6A"), Address(RVA = "0x48F2C00", Offset = "0x48F2C00", VA = "0x48F2C00")] get
      {
        return new int();
      }
      [Token(Token = "0x6009D6B"), Address(RVA = "0x48F2C08", Offset = "0x48F2C08", VA = "0x48F2C08")] set
      {
      }
    }

    [Token(Token = "0x17001C07")]
    public int Experience
    {
      [Token(Token = "0x6009D6C"), Address(RVA = "0x48F2C10", Offset = "0x48F2C10", VA = "0x48F2C10")] get
      {
        return new int();
      }
      [Token(Token = "0x6009D6D"), Address(RVA = "0x48F2C18", Offset = "0x48F2C18", VA = "0x48F2C18")] set
      {
      }
    }

    [Token(Token = "0x17001C08")]
    public int RarityStar
    {
      [Token(Token = "0x6009D6E"), Address(RVA = "0x48F2C20", Offset = "0x48F2C20", VA = "0x48F2C20")] get
      {
        return new int();
      }
      [Token(Token = "0x6009D6F"), Address(RVA = "0x48F2C28", Offset = "0x48F2C28", VA = "0x48F2C28")] set
      {
      }
    }

    [Token(Token = "0x6009D70")]
    [Address(RVA = "0x48F2C30", Offset = "0x48F2C30", VA = "0x48F2C30")]
    public PlayerUnitArenaHistoryType()
    {
    }
  }
}
