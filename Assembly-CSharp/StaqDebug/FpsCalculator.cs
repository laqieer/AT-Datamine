// Decompiled with JetBrains decompiler
// Type: StaqDebug.FpsCalculator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace StaqDebug
{
  [Token(Token = "0x2001F64")]
  public class FpsCalculator
  {
    [Token(Token = "0x4008670")]
    private const int frameCount = 10;
    [Token(Token = "0x4008671")]
    private const int averageFrameCount = 30;
    [Token(Token = "0x4008672")]
    [FieldOffset(Offset = "0x10")]
    private float[] times;
    [Token(Token = "0x4008673")]
    [FieldOffset(Offset = "0x18")]
    private float averageTime;
    [Token(Token = "0x4008674")]
    [FieldOffset(Offset = "0x1C")]
    private float averageTotalTime;
    [Token(Token = "0x4008675")]
    [FieldOffset(Offset = "0x20")]
    private int currentAverageCount;
    [Token(Token = "0x4008676")]
    [FieldOffset(Offset = "0x24")]
    private float beforeUpdateTime;
    [Token(Token = "0x4008677")]
    [FieldOffset(Offset = "0x28")]
    private float updateTime;
    [Token(Token = "0x4008678")]
    [FieldOffset(Offset = "0x2C")]
    private float currentFPS;

    [Token(Token = "0x170026AD")]
    public float FPS
    {
      [Token(Token = "0x600BA5A"), Address(RVA = "0x1E44EE0", Offset = "0x1E44EE0", VA = "0x1E44EE0")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x170026AE")]
    public float AverageTime
    {
      [Token(Token = "0x600BA5B"), Address(RVA = "0x1E44EE8", Offset = "0x1E44EE8", VA = "0x1E44EE8")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x600BA5C")]
    [Address(RVA = "0x1E44EF0", Offset = "0x1E44EF0", VA = "0x1E44EF0")]
    public void Initialize()
    {
    }

    [Token(Token = "0x600BA5D")]
    [Address(RVA = "0x1E44F38", Offset = "0x1E44F38", VA = "0x1E44F38")]
    public void Update()
    {
    }

    [Token(Token = "0x600BA5E")]
    [Address(RVA = "0x1E44FB4", Offset = "0x1E44FB4", VA = "0x1E44FB4")]
    private float Average(float[] values, float value) => new float();

    [Token(Token = "0x600BA5F")]
    [Address(RVA = "0x1E4504C", Offset = "0x1E4504C", VA = "0x1E4504C")]
    public FpsCalculator()
    {
    }
  }
}
