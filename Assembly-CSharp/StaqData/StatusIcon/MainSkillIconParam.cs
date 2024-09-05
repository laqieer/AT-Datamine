// Decompiled with JetBrains decompiler
// Type: StaqData.StatusIcon.MainSkillIconParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace StaqData.StatusIcon
{
  [Token(Token = "0x2002164")]
  [Serializable]
  public sealed class MainSkillIconParam
  {
    [Token(Token = "0x4008D6F")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int masterId;
    [Token(Token = "0x4008D70")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private string iconName;

    [Token(Token = "0x17002CDE")]
    public int MasterId
    {
      [Token(Token = "0x600CCAD"), Address(RVA = "0x1BB15B0", Offset = "0x1BB15B0", VA = "0x1BB15B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002CDF")]
    public string IconName
    {
      [Token(Token = "0x600CCAE"), Address(RVA = "0x1BB15B8", Offset = "0x1BB15B8", VA = "0x1BB15B8")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x600CCAF")]
    [Address(RVA = "0x1BB15C0", Offset = "0x1BB15C0", VA = "0x1BB15C0")]
    public MainSkillIconParam()
    {
    }
  }
}
