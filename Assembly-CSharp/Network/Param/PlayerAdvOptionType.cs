// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerAdvOptionType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001A81")]
  [Serializable]
  public class PlayerAdvOptionType
  {
    [Token(Token = "0x40071A4")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int sequence_id;
    [Token(Token = "0x40071A5")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private int option_id;

    [Token(Token = "0x170019E8")]
    public int SequenceId
    {
      [Token(Token = "0x60098DA"), Address(RVA = "0x48F04CC", Offset = "0x48F04CC", VA = "0x48F04CC")] get
      {
        return new int();
      }
      [Token(Token = "0x60098DB"), Address(RVA = "0x48F04D4", Offset = "0x48F04D4", VA = "0x48F04D4")] set
      {
      }
    }

    [Token(Token = "0x170019E9")]
    public int OptionId
    {
      [Token(Token = "0x60098DC"), Address(RVA = "0x48F04DC", Offset = "0x48F04DC", VA = "0x48F04DC")] get
      {
        return new int();
      }
      [Token(Token = "0x60098DD"), Address(RVA = "0x48F04E4", Offset = "0x48F04E4", VA = "0x48F04E4")] set
      {
      }
    }

    [Token(Token = "0x60098DE")]
    [Address(RVA = "0x48F04EC", Offset = "0x48F04EC", VA = "0x48F04EC")]
    public PlayerAdvOptionType()
    {
    }
  }
}
