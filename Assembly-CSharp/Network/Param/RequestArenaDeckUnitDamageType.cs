// Decompiled with JetBrains decompiler
// Type: Network.Param.RequestArenaDeckUnitDamageType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001B08")]
  [Serializable]
  public class RequestArenaDeckUnitDamageType
  {
    [Token(Token = "0x4007429")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int position_id;
    [Token(Token = "0x400742A")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private int damage;

    [Token(Token = "0x17001C8B")]
    public int PositionId
    {
      [Token(Token = "0x6009E89"), Address(RVA = "0x48F3524", Offset = "0x48F3524", VA = "0x48F3524")] get
      {
        return new int();
      }
      [Token(Token = "0x6009E8A"), Address(RVA = "0x48F352C", Offset = "0x48F352C", VA = "0x48F352C")] set
      {
      }
    }

    [Token(Token = "0x17001C8C")]
    public int Damage
    {
      [Token(Token = "0x6009E8B"), Address(RVA = "0x48F3534", Offset = "0x48F3534", VA = "0x48F3534")] get
      {
        return new int();
      }
      [Token(Token = "0x6009E8C"), Address(RVA = "0x48F353C", Offset = "0x48F353C", VA = "0x48F353C")] set
      {
      }
    }

    [Token(Token = "0x6009E8D")]
    [Address(RVA = "0x48F3544", Offset = "0x48F3544", VA = "0x48F3544")]
    public RequestArenaDeckUnitDamageType()
    {
    }
  }
}
