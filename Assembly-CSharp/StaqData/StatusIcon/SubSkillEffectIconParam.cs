// Decompiled with JetBrains decompiler
// Type: StaqData.StatusIcon.SubSkillEffectIconParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace StaqData.StatusIcon
{
  [Token(Token = "0x2002169")]
  [Serializable]
  public sealed class SubSkillEffectIconParam
  {
    [Token(Token = "0x4008D77")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int masterId;
    [Token(Token = "0x4008D78")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private string iconName;

    [Token(Token = "0x17002CE4")]
    public int MasterId
    {
      [Token(Token = "0x600CCBB"), Address(RVA = "0x1BB16AC", Offset = "0x1BB16AC", VA = "0x1BB16AC")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002CE5")]
    public string IconName
    {
      [Token(Token = "0x600CCBC"), Address(RVA = "0x1BB16B4", Offset = "0x1BB16B4", VA = "0x1BB16B4")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x600CCBD")]
    [Address(RVA = "0x1BB16BC", Offset = "0x1BB16BC", VA = "0x1BB16BC")]
    public SubSkillEffectIconParam()
    {
    }
  }
}
