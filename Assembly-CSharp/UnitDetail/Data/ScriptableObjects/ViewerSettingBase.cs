// Decompiled with JetBrains decompiler
// Type: UnitDetail.Data.ScriptableObjects.ViewerSettingBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace UnitDetail.Data.ScriptableObjects
{
  [Token(Token = "0x20004DC")]
  [Serializable]
  public class ViewerSettingBase
  {
    [Token(Token = "0x400195E")]
    [FieldOffset(Offset = "0x10")]
    [Header("移動速度")]
    public float translateSpeed;
    [Token(Token = "0x400195F")]
    [FieldOffset(Offset = "0x14")]
    [Header("ピンチ速度")]
    public float pinchSpeed;
    [Token(Token = "0x4001960")]
    [FieldOffset(Offset = "0x18")]
    [Header("遷移実行時間")]
    public float transitionDuration;

    [Token(Token = "0x6001BA6")]
    [Address(RVA = "0x2C2CD88", Offset = "0x2C2CD88", VA = "0x2C2CD88")]
    public ViewerSettingBase()
    {
    }
  }
}
