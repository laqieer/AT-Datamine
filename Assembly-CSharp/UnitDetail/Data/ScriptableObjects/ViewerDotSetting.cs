// Decompiled with JetBrains decompiler
// Type: UnitDetail.Data.ScriptableObjects.ViewerDotSetting
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace UnitDetail.Data.ScriptableObjects
{
  [Token(Token = "0x20004DF")]
  [Serializable]
  public class ViewerDotSetting : ViewerSettingBase
  {
    [Token(Token = "0x400196B")]
    [FieldOffset(Offset = "0x20")]
    [Header("ズーム制限")]
    public LimitFloat zTranslateLimit;
    [Token(Token = "0x400196C")]
    [FieldOffset(Offset = "0x28")]
    [Header("上下左右移動制限")]
    public LimitVector2 xyTranslateLimit;
    [Token(Token = "0x400196D")]
    [FieldOffset(Offset = "0x30")]
    [Header("ズーム制限: 遊びの値")]
    public LimitFloat playZTranslateLimit;
    [Token(Token = "0x400196E")]
    [FieldOffset(Offset = "0x38")]
    [Header("上下左右移動制限: 遊びの値")]
    public LimitVector2 playXyTranslateLimit;

    [Token(Token = "0x6001BA9")]
    [Address(RVA = "0x2C2CDA0", Offset = "0x2C2CDA0", VA = "0x2C2CDA0")]
    public ViewerDotSetting()
    {
    }
  }
}
