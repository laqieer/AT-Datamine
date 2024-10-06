// Decompiled with JetBrains decompiler
// Type: Area.MovableMob.Data.MovableGeneralParameter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Area.MovableMob.Data
{
  [Token(Token = "0x200283A")]
  [Serializable]
  public class MovableGeneralParameter
  {
    [Token(Token = "0x400AB8B")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private float fadeMobCameraRadius;
    [Token(Token = "0x400AB8C")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private float fadeMobPlayerRadius;
    [Token(Token = "0x400AB8D")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private float fadeMobPlayerDistance;

    [Token(Token = "0x170037AA")]
    public float FadeMobCameraRadius
    {
      [Token(Token = "0x600FD42"), Address(RVA = "0x442E0E0", Offset = "0x442E0E0", VA = "0x442E0E0")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x170037AB")]
    public float FadeMobPlayerRadius
    {
      [Token(Token = "0x600FD43"), Address(RVA = "0x442E0E8", Offset = "0x442E0E8", VA = "0x442E0E8")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x170037AC")]
    public float FadeMobPlayerDistance
    {
      [Token(Token = "0x600FD44"), Address(RVA = "0x442E0F0", Offset = "0x442E0F0", VA = "0x442E0F0")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x600FD45")]
    [Address(RVA = "0x442E0F8", Offset = "0x442E0F8", VA = "0x442E0F8")]
    public MovableGeneralParameter()
    {
    }
  }
}
