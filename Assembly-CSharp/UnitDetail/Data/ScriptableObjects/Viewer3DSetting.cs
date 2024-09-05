// Decompiled with JetBrains decompiler
// Type: UnitDetail.Data.ScriptableObjects.Viewer3DSetting
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace UnitDetail.Data.ScriptableObjects
{
  [Token(Token = "0x20004DE")]
  [Serializable]
  public class Viewer3DSetting : ViewerSettingBase
  {
    [Token(Token = "0x4001965")]
    [FieldOffset(Offset = "0x1C")]
    [Header("上下回転角制限")]
    public float angleSpeed;
    [Token(Token = "0x4001966")]
    [FieldOffset(Offset = "0x20")]
    [Header("上下角度制限")]
    public LimitFloat xAngleLimit;
    [Token(Token = "0x4001967")]
    [FieldOffset(Offset = "0x28")]
    [Header("ズーム制限")]
    public LimitFloat zTranslateLimit;
    [Token(Token = "0x4001968")]
    [FieldOffset(Offset = "0x30")]
    [Header("上下左右移動制限")]
    public LimitVector2 xyTranslateLimit;
    [Token(Token = "0x4001969")]
    [FieldOffset(Offset = "0x38")]
    [Header("ズーム: 遊びの値")]
    public LimitFloat playZTranslateLimit;
    [Token(Token = "0x400196A")]
    [FieldOffset(Offset = "0x40")]
    [Header("上下左右移動制限: 遊びの値")]
    public LimitVector2 playXyTranslateLimit;

    [Token(Token = "0x6001BA8")]
    [Address(RVA = "0x2C2CD98", Offset = "0x2C2CD98", VA = "0x2C2CD98")]
    public Viewer3DSetting()
    {
    }
  }
}
