// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerRewardPassType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001AD3")]
  [Serializable]
  public class PlayerRewardPassType
  {
    [Token(Token = "0x40072FC")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int pass_id;
    [Token(Token = "0x40072FD")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private string end_at;

    [Token(Token = "0x17001B5E")]
    public int PassId
    {
      [Token(Token = "0x6009BFA"), Address(RVA = "0x48F205C", Offset = "0x48F205C", VA = "0x48F205C")] get
      {
        return new int();
      }
      [Token(Token = "0x6009BFB"), Address(RVA = "0x48F2064", Offset = "0x48F2064", VA = "0x48F2064")] set
      {
      }
    }

    [Token(Token = "0x17001B5F")]
    public string EndAt
    {
      [Token(Token = "0x6009BFC"), Address(RVA = "0x48F206C", Offset = "0x48F206C", VA = "0x48F206C")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009BFD"), Address(RVA = "0x48F2074", Offset = "0x48F2074", VA = "0x48F2074")] set
      {
      }
    }

    [Token(Token = "0x6009BFE")]
    [Address(RVA = "0x48F207C", Offset = "0x48F207C", VA = "0x48F207C")]
    public PlayerRewardPassType()
    {
    }
  }
}
