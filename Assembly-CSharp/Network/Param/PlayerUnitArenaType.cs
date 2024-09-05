// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerUnitArenaType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001AF4")]
  [Serializable]
  public class PlayerUnitArenaType
  {
    [Token(Token = "0x40073A7")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private string id;
    [Token(Token = "0x40073A8")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private int style_id;
    [Token(Token = "0x40073A9")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private int experience;
    [Token(Token = "0x40073AA")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private int rarity_star;

    [Token(Token = "0x17001C09")]
    public string Id
    {
      [Token(Token = "0x6009D71"), Address(RVA = "0x48F2C38", Offset = "0x48F2C38", VA = "0x48F2C38")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009D72"), Address(RVA = "0x48F2C40", Offset = "0x48F2C40", VA = "0x48F2C40")] set
      {
      }
    }

    [Token(Token = "0x17001C0A")]
    public int StyleId
    {
      [Token(Token = "0x6009D73"), Address(RVA = "0x48F2C48", Offset = "0x48F2C48", VA = "0x48F2C48")] get
      {
        return new int();
      }
      [Token(Token = "0x6009D74"), Address(RVA = "0x48F2C50", Offset = "0x48F2C50", VA = "0x48F2C50")] set
      {
      }
    }

    [Token(Token = "0x17001C0B")]
    public int Experience
    {
      [Token(Token = "0x6009D75"), Address(RVA = "0x48F2C58", Offset = "0x48F2C58", VA = "0x48F2C58")] get
      {
        return new int();
      }
      [Token(Token = "0x6009D76"), Address(RVA = "0x48F2C60", Offset = "0x48F2C60", VA = "0x48F2C60")] set
      {
      }
    }

    [Token(Token = "0x17001C0C")]
    public int RarityStar
    {
      [Token(Token = "0x6009D77"), Address(RVA = "0x48F2C68", Offset = "0x48F2C68", VA = "0x48F2C68")] get
      {
        return new int();
      }
      [Token(Token = "0x6009D78"), Address(RVA = "0x48F2C70", Offset = "0x48F2C70", VA = "0x48F2C70")] set
      {
      }
    }

    [Token(Token = "0x6009D79")]
    [Address(RVA = "0x48F2C78", Offset = "0x48F2C78", VA = "0x48F2C78")]
    public PlayerUnitArenaType()
    {
    }
  }
}
