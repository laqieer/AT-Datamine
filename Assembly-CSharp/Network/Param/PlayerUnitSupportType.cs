// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerUnitSupportType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001B01")]
  [Serializable]
  public class PlayerUnitSupportType
  {
    [Token(Token = "0x40073F3")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int character1_id;
    [Token(Token = "0x40073F4")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private int character2_id;
    [Token(Token = "0x40073F5")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private int experience;

    [Token(Token = "0x17001C55")]
    public int Character1Id
    {
      [Token(Token = "0x6009E16"), Address(RVA = "0x48F3164", Offset = "0x48F3164", VA = "0x48F3164")] get
      {
        return new int();
      }
      [Token(Token = "0x6009E17"), Address(RVA = "0x48F316C", Offset = "0x48F316C", VA = "0x48F316C")] set
      {
      }
    }

    [Token(Token = "0x17001C56")]
    public int Character2Id
    {
      [Token(Token = "0x6009E18"), Address(RVA = "0x48F3174", Offset = "0x48F3174", VA = "0x48F3174")] get
      {
        return new int();
      }
      [Token(Token = "0x6009E19"), Address(RVA = "0x48F317C", Offset = "0x48F317C", VA = "0x48F317C")] set
      {
      }
    }

    [Token(Token = "0x17001C57")]
    public int Experience
    {
      [Token(Token = "0x6009E1A"), Address(RVA = "0x48F3184", Offset = "0x48F3184", VA = "0x48F3184")] get
      {
        return new int();
      }
      [Token(Token = "0x6009E1B"), Address(RVA = "0x48F318C", Offset = "0x48F318C", VA = "0x48F318C")] set
      {
      }
    }

    [Token(Token = "0x6009E1C")]
    [Address(RVA = "0x48F3194", Offset = "0x48F3194", VA = "0x48F3194")]
    public PlayerUnitSupportType()
    {
    }
  }
}
