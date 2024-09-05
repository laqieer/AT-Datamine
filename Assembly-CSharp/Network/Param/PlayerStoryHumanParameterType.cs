// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerStoryHumanParameterType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001AE9")]
  [Serializable]
  public class PlayerStoryHumanParameterType
  {
    [Token(Token = "0x4007366")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int human_parameter_id;
    [Token(Token = "0x4007367")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private int value;

    [Token(Token = "0x17001BC8")]
    public int HumanParameterId
    {
      [Token(Token = "0x6009CE4"), Address(RVA = "0x48F27C8", Offset = "0x48F27C8", VA = "0x48F27C8")] get
      {
        return new int();
      }
      [Token(Token = "0x6009CE5"), Address(RVA = "0x48F27D0", Offset = "0x48F27D0", VA = "0x48F27D0")] set
      {
      }
    }

    [Token(Token = "0x17001BC9")]
    public int Value
    {
      [Token(Token = "0x6009CE6"), Address(RVA = "0x48F27D8", Offset = "0x48F27D8", VA = "0x48F27D8")] get
      {
        return new int();
      }
      [Token(Token = "0x6009CE7"), Address(RVA = "0x48F27E0", Offset = "0x48F27E0", VA = "0x48F27E0")] set
      {
      }
    }

    [Token(Token = "0x6009CE8")]
    [Address(RVA = "0x48F27E4", Offset = "0x48F27E4", VA = "0x48F27E4")]
    public PlayerStoryHumanParameterType()
    {
    }
  }
}
