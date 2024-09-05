// Decompiled with JetBrains decompiler
// Type: UnitView.ModelView.ViewerDotSetting
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace UnitView.ModelView
{
  [Token(Token = "0x20003CF")]
  [Serializable]
  public class ViewerDotSetting
  {
    [Token(Token = "0x4001669")]
    [FieldOffset(Offset = "0x10")]
    public Limit playZTranslateLimit;
    [Token(Token = "0x400166A")]
    [FieldOffset(Offset = "0x18")]
    public Limit zTranslateLimit;
    [Token(Token = "0x400166B")]
    [FieldOffset(Offset = "0x20")]
    public Vector2 playXyTranslateMin;
    [Token(Token = "0x400166C")]
    [FieldOffset(Offset = "0x28")]
    public Vector2 xyTranslateMin;
    [Token(Token = "0x400166D")]
    [FieldOffset(Offset = "0x30")]
    public Vector2 playXyTranslateMax;
    [Token(Token = "0x400166E")]
    [FieldOffset(Offset = "0x38")]
    public Vector2 xyTranslateMax;
    [Token(Token = "0x400166F")]
    [FieldOffset(Offset = "0x40")]
    public float translateSpeed;
    [Token(Token = "0x4001670")]
    [FieldOffset(Offset = "0x44")]
    public float pinchSpeed;
    [Token(Token = "0x4001671")]
    [FieldOffset(Offset = "0x48")]
    public float duration;

    [Token(Token = "0x6001628")]
    [Address(RVA = "0x2485AA4", Offset = "0x2485AA4", VA = "0x2485AA4")]
    public ViewerDotSetting()
    {
    }
  }
}
