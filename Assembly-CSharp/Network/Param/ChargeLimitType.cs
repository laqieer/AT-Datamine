// Decompiled with JetBrains decompiler
// Type: Network.Param.ChargeLimitType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001A47")]
  [Serializable]
  public class ChargeLimitType
  {
    [Token(Token = "0x400705C")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int age;
    [Token(Token = "0x400705D")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private float limit;

    [Token(Token = "0x17001892")]
    public int Age
    {
      [Token(Token = "0x6009601"), Address(RVA = "0x48EEE44", Offset = "0x48EEE44", VA = "0x48EEE44")] get
      {
        return new int();
      }
      [Token(Token = "0x6009602"), Address(RVA = "0x48EEE4C", Offset = "0x48EEE4C", VA = "0x48EEE4C")] set
      {
      }
    }

    [Token(Token = "0x17001893")]
    public float Limit
    {
      [Token(Token = "0x6009603"), Address(RVA = "0x48EEE54", Offset = "0x48EEE54", VA = "0x48EEE54")] get
      {
        return new float();
      }
      [Token(Token = "0x6009604"), Address(RVA = "0x48EEE5C", Offset = "0x48EEE5C", VA = "0x48EEE5C")] set
      {
      }
    }

    [Token(Token = "0x6009605")]
    [Address(RVA = "0x48EEE64", Offset = "0x48EEE64", VA = "0x48EEE64")]
    public ChargeLimitType()
    {
    }
  }
}
