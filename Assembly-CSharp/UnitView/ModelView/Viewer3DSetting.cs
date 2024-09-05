// Decompiled with JetBrains decompiler
// Type: UnitView.ModelView.Viewer3DSetting
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace UnitView.ModelView
{
  [Token(Token = "0x20003CD")]
  [Serializable]
  public class Viewer3DSetting
  {
    [Token(Token = "0x4001655")]
    [FieldOffset(Offset = "0x10")]
    public float angleSpeed;
    [Token(Token = "0x4001656")]
    [FieldOffset(Offset = "0x18")]
    public Limit xAngleLimit;
    [Token(Token = "0x4001657")]
    [FieldOffset(Offset = "0x20")]
    public Limit playZTranslateLimit;
    [Token(Token = "0x4001658")]
    [FieldOffset(Offset = "0x28")]
    public Limit zTranslateLimit;
    [Token(Token = "0x4001659")]
    [FieldOffset(Offset = "0x30")]
    public Vector2 playXyTranslateMin;
    [Token(Token = "0x400165A")]
    [FieldOffset(Offset = "0x38")]
    public Vector2 xyTranslateMin;
    [Token(Token = "0x400165B")]
    [FieldOffset(Offset = "0x40")]
    public Vector2 playXyTranslateMax;
    [Token(Token = "0x400165C")]
    [FieldOffset(Offset = "0x48")]
    public Vector2 xyTranslateMax;
    [Token(Token = "0x400165D")]
    [FieldOffset(Offset = "0x50")]
    public float translateSpeed;
    [Token(Token = "0x400165E")]
    [FieldOffset(Offset = "0x54")]
    public float pinchSpeed;
    [Token(Token = "0x400165F")]
    [FieldOffset(Offset = "0x58")]
    public float duration;

    [Token(Token = "0x6001626")]
    [Address(RVA = "0x248593C", Offset = "0x248593C", VA = "0x248593C")]
    public Viewer3DSetting()
    {
    }
  }
}
