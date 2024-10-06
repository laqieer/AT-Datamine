// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerAdvOptionLogType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001A80")]
  [Serializable]
  public class PlayerAdvOptionLogType
  {
    [Token(Token = "0x40071A1")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int option_id;
    [Token(Token = "0x40071A2")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private bool is_selected;
    [Token(Token = "0x40071A3")]
    [FieldOffset(Offset = "0x15")]
    [SerializeField]
    private bool is_unlocked;

    [Token(Token = "0x170019E5")]
    public int OptionId
    {
      [Token(Token = "0x60098D3"), Address(RVA = "0x48F048C", Offset = "0x48F048C", VA = "0x48F048C")] get
      {
        return new int();
      }
      [Token(Token = "0x60098D4"), Address(RVA = "0x48F0494", Offset = "0x48F0494", VA = "0x48F0494")] set
      {
      }
    }

    [Token(Token = "0x170019E6")]
    public bool IsSelected
    {
      [Token(Token = "0x60098D5"), Address(RVA = "0x48F049C", Offset = "0x48F049C", VA = "0x48F049C")] get
      {
        return new bool();
      }
      [Token(Token = "0x60098D6"), Address(RVA = "0x48F04A4", Offset = "0x48F04A4", VA = "0x48F04A4")] set
      {
      }
    }

    [Token(Token = "0x170019E7")]
    public bool IsUnlocked
    {
      [Token(Token = "0x60098D7"), Address(RVA = "0x48F04B0", Offset = "0x48F04B0", VA = "0x48F04B0")] get
      {
        return new bool();
      }
      [Token(Token = "0x60098D8"), Address(RVA = "0x48F04B8", Offset = "0x48F04B8", VA = "0x48F04B8")] set
      {
      }
    }

    [Token(Token = "0x60098D9")]
    [Address(RVA = "0x48F04C4", Offset = "0x48F04C4", VA = "0x48F04C4")]
    public PlayerAdvOptionLogType()
    {
    }
  }
}
