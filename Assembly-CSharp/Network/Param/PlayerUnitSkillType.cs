// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerUnitSkillType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001B00")]
  [Serializable]
  public class PlayerUnitSkillType
  {
    [Token(Token = "0x40073F0")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private string id;
    [Token(Token = "0x40073F1")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private int skill_id;
    [Token(Token = "0x40073F2")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private int level;

    [Token(Token = "0x17001C52")]
    public string Id
    {
      [Token(Token = "0x6009E0F"), Address(RVA = "0x48F312C", Offset = "0x48F312C", VA = "0x48F312C")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009E10"), Address(RVA = "0x48F3134", Offset = "0x48F3134", VA = "0x48F3134")] set
      {
      }
    }

    [Token(Token = "0x17001C53")]
    public int SkillId
    {
      [Token(Token = "0x6009E11"), Address(RVA = "0x48F313C", Offset = "0x48F313C", VA = "0x48F313C")] get
      {
        return new int();
      }
      [Token(Token = "0x6009E12"), Address(RVA = "0x48F3144", Offset = "0x48F3144", VA = "0x48F3144")] set
      {
      }
    }

    [Token(Token = "0x17001C54")]
    public int Level
    {
      [Token(Token = "0x6009E13"), Address(RVA = "0x48F314C", Offset = "0x48F314C", VA = "0x48F314C")] get
      {
        return new int();
      }
      [Token(Token = "0x6009E14"), Address(RVA = "0x48F3154", Offset = "0x48F3154", VA = "0x48F3154")] set
      {
      }
    }

    [Token(Token = "0x6009E15")]
    [Address(RVA = "0x48F315C", Offset = "0x48F315C", VA = "0x48F315C")]
    public PlayerUnitSkillType()
    {
    }
  }
}
