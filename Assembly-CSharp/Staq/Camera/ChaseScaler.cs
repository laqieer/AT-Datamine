// Decompiled with JetBrains decompiler
// Type: staq.Camera.ChaseScaler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace staq.Camera
{
  [Token(Token = "0x2003D67")]
  public class ChaseScaler : ScalerBase
  {
    [Token(Token = "0x4010DCF")]
    [FieldOffset(Offset = "0x18")]
    private ScalerBase destination;
    [Token(Token = "0x4010DD0")]
    [FieldOffset(Offset = "0x20")]
    private float position;
    [Token(Token = "0x4010DD1")]
    [FieldOffset(Offset = "0x24")]
    private bool positionDirty;
    [Token(Token = "0x4010DD2")]
    [FieldOffset(Offset = "0x28")]
    private float velocity;
    [Token(Token = "0x4010DD3")]
    [FieldOffset(Offset = "0x2C")]
    private float accel;
    [Token(Token = "0x4010DD4")]
    private const float UpAccel = 20f;
    [Token(Token = "0x4010DD5")]
    private const float DownAccel = 15f;
    [Token(Token = "0x4010DD6")]
    private const float MaxVelocity = 5f;
    [Token(Token = "0x4010DD7")]
    private const float PositionEpsilon = 0.0001f;
    [Token(Token = "0x4010DD8")]
    private const float TimeEpsilon = 1E-06f;
    [Token(Token = "0x4010DD9")]
    [FieldOffset(Offset = "0x30")]
    private float RemainTime;

    [Token(Token = "0x6018B4B")]
    [Address(RVA = "0x26436DC", Offset = "0x26436DC", VA = "0x26436DC")]
    public ChaseScaler(ScalerBase inputDestination)
    {
    }

    [Token(Token = "0x6018B4C")]
    [Address(RVA = "0x2643730", Offset = "0x2643730", VA = "0x2643730", Slot = "7")]
    public override float GetValue() => new float();

    [Token(Token = "0x6018B4D")]
    [Address(RVA = "0x2643768", Offset = "0x2643768", VA = "0x2643768", Slot = "8")]
    public override bool GetDirty() => new bool();

    [Token(Token = "0x6018B4E")]
    [Address(RVA = "0x2643788", Offset = "0x2643788", VA = "0x2643788", Slot = "5")]
    public override void SetDirty(bool value)
    {
    }

    [Token(Token = "0x6018B4F")]
    [Address(RVA = "0x2643798", Offset = "0x2643798", VA = "0x2643798")]
    public void SetPosition(float inputPosition)
    {
    }

    [Token(Token = "0x6018B50")]
    [Address(RVA = "0x26437A8", Offset = "0x26437A8", VA = "0x26437A8")]
    public void AdvanceTimeAccel(float deltaTime, float Accel)
    {
    }

    [Token(Token = "0x6018B51")]
    [Address(RVA = "0x264380C", Offset = "0x264380C", VA = "0x264380C")]
    public void AdvanceTime(float deltaTime)
    {
    }

    [Token(Token = "0x6018B52")]
    [Address(RVA = "0x2643840", Offset = "0x2643840", VA = "0x2643840", Slot = "4")]
    public override void TimeUpdate(float deltaTime)
    {
    }

    [Token(Token = "0x6018B53")]
    [Address(RVA = "0x2643A48", Offset = "0x2643A48", VA = "0x2643A48", Slot = "10")]
    public override ScalerBase GetDestination() => (ScalerBase) null;

    [Token(Token = "0x6018B54")]
    [Address(RVA = "0x2643A50", Offset = "0x2643A50", VA = "0x2643A50", Slot = "6")]
    public override void RegistContainer(GeometryContainer geometryContainer)
    {
    }
  }
}
