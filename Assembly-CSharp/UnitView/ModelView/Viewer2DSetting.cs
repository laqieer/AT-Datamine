// Decompiled with JetBrains decompiler
// Type: UnitView.ModelView.Viewer2DSetting
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace UnitView.ModelView
{
  [Token(Token = "0x20003CE")]
  [Serializable]
  public class Viewer2DSetting
  {
    [Token(Token = "0x4001660")]
    [FieldOffset(Offset = "0x10")]
    public Limit playScaleLimit;
    [Token(Token = "0x4001661")]
    [FieldOffset(Offset = "0x18")]
    public Limit scaleLimit;
    [Token(Token = "0x4001662")]
    [FieldOffset(Offset = "0x20")]
    public Vector2 playXyTranslateMin;
    [Token(Token = "0x4001663")]
    [FieldOffset(Offset = "0x28")]
    public Vector2 xyTranslateMin;
    [Token(Token = "0x4001664")]
    [FieldOffset(Offset = "0x30")]
    public Vector2 playXyTranslateMax;
    [Token(Token = "0x4001665")]
    [FieldOffset(Offset = "0x38")]
    public Vector2 xyTranslateMax;
    [Token(Token = "0x4001666")]
    [FieldOffset(Offset = "0x40")]
    public float translateSpeed;
    [Token(Token = "0x4001667")]
    [FieldOffset(Offset = "0x44")]
    public float pinchSpeed;
    [Token(Token = "0x4001668")]
    [FieldOffset(Offset = "0x48")]
    public float duration;

    [Token(Token = "0x6001627")]
    [Address(RVA = "0x2485A08", Offset = "0x2485A08", VA = "0x2485A08")]
    public Viewer2DSetting()
    {
    }
  }
}
