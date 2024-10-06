// Decompiled with JetBrains decompiler
// Type: UnitDetail.Data.ScriptableObjects.Viewer2DSetting
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace UnitDetail.Data.ScriptableObjects
{
  [Token(Token = "0x20004DD")]
  [Serializable]
  public class Viewer2DSetting : ViewerSettingBase
  {
    [Token(Token = "0x4001961")]
    [FieldOffset(Offset = "0x20")]
    [Header("拡縮制限")]
    public LimitFloat scaleLimit;
    [Token(Token = "0x4001962")]
    [FieldOffset(Offset = "0x28")]
    [Header("上下左右移動制限")]
    public LimitVector2 xyTranslateLimit;
    [Token(Token = "0x4001963")]
    [FieldOffset(Offset = "0x30")]
    [Header("拡縮制限: 遊びの値")]
    [Space(10f)]
    public LimitFloat playScaleLimit;
    [Token(Token = "0x4001964")]
    [FieldOffset(Offset = "0x38")]
    [Header("上下左右移動制限: 遊びの値")]
    public LimitVector2 playXyTranslateLimit;

    [Token(Token = "0x6001BA7")]
    [Address(RVA = "0x2C2CD90", Offset = "0x2C2CD90", VA = "0x2C2CD90")]
    public Viewer2DSetting()
    {
    }
  }
}
