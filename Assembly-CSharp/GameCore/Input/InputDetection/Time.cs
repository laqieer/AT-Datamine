// Decompiled with JetBrains decompiler
// Type: GameCore.Input.InputDetection.Time
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace GameCore.Input.InputDetection
{
  [Token(Token = "0x2001457")]
  public class Time
  {
    [Token(Token = "0x4005DC6")]
    [FieldOffset(Offset = "0x0")]
    private static float globalDeltaTime;
    [Token(Token = "0x4005DC7")]
    [FieldOffset(Offset = "0x4")]
    private static float unScaledGlobalDeltaTime;
    [Token(Token = "0x4005DC8")]
    [FieldOffset(Offset = "0x10")]
    protected float time;
    [Token(Token = "0x4005DC9")]
    [FieldOffset(Offset = "0x14")]
    protected float signalTime;
    [Token(Token = "0x4005DCA")]
    [FieldOffset(Offset = "0x18")]
    protected bool signal;
    [Token(Token = "0x4005DCB")]
    [FieldOffset(Offset = "0x19")]
    protected bool start;
    [Token(Token = "0x4005DCC")]
    [FieldOffset(Offset = "0x1A")]
    protected bool useUnScaledDeltaTimeIfNotTimeScale;

    [Token(Token = "0x17001198")]
    public static float DeltaTime
    {
      [Token(Token = "0x60072AB"), Address(RVA = "0x4051960", Offset = "0x4051960", VA = "0x4051960")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x17001199")]
    public static float UnScaledDeltaTime
    {
      [Token(Token = "0x60072AC"), Address(RVA = "0x40519A8", Offset = "0x40519A8", VA = "0x40519A8")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x60072AD")]
    [Address(RVA = "0x40519F0", Offset = "0x40519F0", VA = "0x40519F0")]
    public static void InitializeGlobalTime()
    {
    }

    [Token(Token = "0x60072AE")]
    [Address(RVA = "0x40519F4", Offset = "0x40519F4", VA = "0x40519F4")]
    public static void UpdateGlobalTime()
    {
    }

    [Token(Token = "0x60072AF")]
    [Address(RVA = "0x4051A58", Offset = "0x4051A58", VA = "0x4051A58")]
    public void Update()
    {
    }

    [Token(Token = "0x60072B0")]
    [Address(RVA = "0x4051B1C", Offset = "0x4051B1C", VA = "0x4051B1C")]
    public void StartTime()
    {
    }

    [Token(Token = "0x60072B1")]
    [Address(RVA = "0x4051B34", Offset = "0x4051B34", VA = "0x4051B34")]
    public void StartTime(float signalTime)
    {
    }

    [Token(Token = "0x60072B2")]
    [Address(RVA = "0x4051B48", Offset = "0x4051B48", VA = "0x4051B48")]
    public void StopTime()
    {
    }

    [Token(Token = "0x60072B3")]
    [Address(RVA = "0x4051B50", Offset = "0x4051B50", VA = "0x4051B50")]
    public void Restart()
    {
    }

    [Token(Token = "0x60072B4")]
    [Address(RVA = "0x4051B5C", Offset = "0x4051B5C", VA = "0x4051B5C")]
    public float GetTime() => new float();

    [Token(Token = "0x60072B5")]
    [Address(RVA = "0x4051B64", Offset = "0x4051B64", VA = "0x4051B64")]
    public bool Signal() => new bool();

    [Token(Token = "0x60072B6")]
    [Address(RVA = "0x4051B6C", Offset = "0x4051B6C", VA = "0x4051B6C")]
    public void UseUnScaledDeltaTimeIfNotTimeScale()
    {
    }

    [Token(Token = "0x60072B7")]
    [Address(RVA = "0x4051B78", Offset = "0x4051B78", VA = "0x4051B78")]
    public bool GetStart() => new bool();

    [Token(Token = "0x60072B8")]
    [Address(RVA = "0x40515C8", Offset = "0x40515C8", VA = "0x40515C8")]
    public Time()
    {
    }
  }
}
