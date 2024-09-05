// Decompiled with JetBrains decompiler
// Type: staq.Camera.MoveScaler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace staq.Camera
{
  [Token(Token = "0x2003D68")]
  public class MoveScaler : ScalerBase
  {
    [Token(Token = "0x4010DDA")]
    [FieldOffset(Offset = "0x18")]
    private ScalerBase source;
    [Token(Token = "0x4010DDB")]
    [FieldOffset(Offset = "0x20")]
    private ScalerBase destination;
    [Token(Token = "0x4010DDC")]
    [FieldOffset(Offset = "0x28")]
    private float moveTime;
    [Token(Token = "0x4010DDD")]
    [FieldOffset(Offset = "0x2C")]
    private float time;
    [Token(Token = "0x4010DDE")]
    [FieldOffset(Offset = "0x30")]
    private bool timeDirty;

    [Token(Token = "0x6018B55")]
    [Address(RVA = "0x2643A90", Offset = "0x2643A90", VA = "0x2643A90")]
    public MoveScaler(ScalerBase inputSource, ScalerBase inputDestination, float inputMoveTime)
    {
    }

    [Token(Token = "0x6018B56")]
    [Address(RVA = "0x2643AE0", Offset = "0x2643AE0", VA = "0x2643AE0", Slot = "7")]
    public override float GetValue() => new float();

    [Token(Token = "0x6018B57")]
    [Address(RVA = "0x2643B6C", Offset = "0x2643B6C", VA = "0x2643B6C", Slot = "8")]
    public override bool GetDirty() => new bool();

    [Token(Token = "0x6018B58")]
    [Address(RVA = "0x2643BCC", Offset = "0x2643BCC", VA = "0x2643BCC", Slot = "5")]
    public override void SetDirty(bool inputValue)
    {
    }

    [Token(Token = "0x6018B59")]
    [Address(RVA = "0x2643C28", Offset = "0x2643C28", VA = "0x2643C28", Slot = "4")]
    public override void TimeUpdate(float deltaTime)
    {
    }

    [Token(Token = "0x6018B5A")]
    [Address(RVA = "0x2643C50", Offset = "0x2643C50", VA = "0x2643C50", Slot = "10")]
    public override ScalerBase GetDestination() => (ScalerBase) null;

    [Token(Token = "0x6018B5B")]
    [Address(RVA = "0x2643C58", Offset = "0x2643C58", VA = "0x2643C58", Slot = "11")]
    public override bool GetWaitIdle() => new bool();

    [Token(Token = "0x6018B5C")]
    [Address(RVA = "0x2643C68", Offset = "0x2643C68", VA = "0x2643C68", Slot = "6")]
    public override void RegistContainer(GeometryContainer inputGeometryContainer)
    {
    }
  }
}
