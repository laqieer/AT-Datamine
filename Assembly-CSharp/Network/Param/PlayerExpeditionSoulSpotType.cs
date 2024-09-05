// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerExpeditionSoulSpotType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001AAB")]
  [Serializable]
  public class PlayerExpeditionSoulSpotType
  {
    [Token(Token = "0x4007248")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private string id;
    [Token(Token = "0x4007249")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private int soul_type;
    [Token(Token = "0x400724A")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private int storage;
    [Token(Token = "0x400724B")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private int level;

    [Token(Token = "0x17001A95")]
    public string Id
    {
      [Token(Token = "0x6009A55"), Address(RVA = "0x48F11A4", Offset = "0x48F11A4", VA = "0x48F11A4")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009A56"), Address(RVA = "0x48F11AC", Offset = "0x48F11AC", VA = "0x48F11AC")] set
      {
      }
    }

    [Token(Token = "0x17001A96")]
    public int SoulType
    {
      [Token(Token = "0x6009A57"), Address(RVA = "0x48F11B4", Offset = "0x48F11B4", VA = "0x48F11B4")] get
      {
        return new int();
      }
      [Token(Token = "0x6009A58"), Address(RVA = "0x48F11BC", Offset = "0x48F11BC", VA = "0x48F11BC")] set
      {
      }
    }

    [Token(Token = "0x17001A97")]
    public int Storage
    {
      [Token(Token = "0x6009A59"), Address(RVA = "0x48F11C4", Offset = "0x48F11C4", VA = "0x48F11C4")] get
      {
        return new int();
      }
      [Token(Token = "0x6009A5A"), Address(RVA = "0x48F11CC", Offset = "0x48F11CC", VA = "0x48F11CC")] set
      {
      }
    }

    [Token(Token = "0x17001A98")]
    public int Level
    {
      [Token(Token = "0x6009A5B"), Address(RVA = "0x48F11D4", Offset = "0x48F11D4", VA = "0x48F11D4")] get
      {
        return new int();
      }
      [Token(Token = "0x6009A5C"), Address(RVA = "0x48F11DC", Offset = "0x48F11DC", VA = "0x48F11DC")] set
      {
      }
    }

    [Token(Token = "0x6009A5D")]
    [Address(RVA = "0x48F11E4", Offset = "0x48F11E4", VA = "0x48F11E4")]
    public PlayerExpeditionSoulSpotType()
    {
    }
  }
}
