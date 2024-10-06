// Decompiled with JetBrains decompiler
// Type: staq.Camera.PinchScale
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace staq.Camera
{
  [Token(Token = "0x2003D66")]
  public class PinchScale : ScalerBase
  {
    [Token(Token = "0x4010DCA")]
    [FieldOffset(Offset = "0x18")]
    private float userInputValue;
    [Token(Token = "0x4010DCB")]
    [FieldOffset(Offset = "0x1C")]
    private bool userInputValueDirty;
    [Token(Token = "0x4010DCC")]
    [FieldOffset(Offset = "0x20")]
    private float pinchLength;
    [Token(Token = "0x4010DCD")]
    [FieldOffset(Offset = "0x24")]
    private bool pinchLengthEnable;
    [Token(Token = "0x4010DCE")]
    [FieldOffset(Offset = "0x28")]
    public Action onStartPinch;

    [Token(Token = "0x6018B46")]
    [Address(RVA = "0x2643500", Offset = "0x2643500", VA = "0x2643500")]
    public PinchScale(float inputPosition)
    {
    }

    [Token(Token = "0x6018B47")]
    [Address(RVA = "0x2643540", Offset = "0x2643540", VA = "0x2643540", Slot = "7")]
    public override float GetValue() => new float();

    [Token(Token = "0x6018B48")]
    [Address(RVA = "0x264358C", Offset = "0x264358C", VA = "0x264358C", Slot = "8")]
    public override bool GetDirty() => new bool();

    [Token(Token = "0x6018B49")]
    [Address(RVA = "0x26435AC", Offset = "0x26435AC", VA = "0x26435AC", Slot = "5")]
    public override void SetDirty(bool inputValue)
    {
    }

    [Token(Token = "0x6018B4A")]
    [Address(RVA = "0x26435BC", Offset = "0x26435BC", VA = "0x26435BC", Slot = "4")]
    public override void TimeUpdate(float deltaTime)
    {
    }
  }
}
