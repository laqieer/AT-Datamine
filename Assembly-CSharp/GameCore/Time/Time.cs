// Decompiled with JetBrains decompiler
// Type: GameCore.Time.Time
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace GameCore.Time
{
  [Token(Token = "0x2000C3A")]
  public class Time
  {
    [Token(Token = "0x17000A2F")]
    public bool Start
    {
      [Token(Token = "0x600464A"), Address(RVA = "0x351613C", Offset = "0x351613C", VA = "0x351613C")] get
      {
        return new bool();
      }
      [Token(Token = "0x600464B"), Address(RVA = "0x3516144", Offset = "0x3516144", VA = "0x3516144")] private set
      {
      }
    }

    [Token(Token = "0x17000A30")]
    public float DeltaTime
    {
      [Token(Token = "0x600464C"), Address(RVA = "0x3516150", Offset = "0x3516150", VA = "0x3516150")] get
      {
        return new float();
      }
      [Token(Token = "0x600464D"), Address(RVA = "0x3516158", Offset = "0x3516158", VA = "0x3516158")] private set
      {
      }
    }

    [Token(Token = "0x17000A31")]
    public bool UseUnScaledDeltaTimeIfNotTimeScale
    {
      [Token(Token = "0x600464E"), Address(RVA = "0x3516160", Offset = "0x3516160", VA = "0x3516160")] get
      {
        return new bool();
      }
      [Token(Token = "0x600464F"), Address(RVA = "0x3516168", Offset = "0x3516168", VA = "0x3516168")] set
      {
      }
    }

    [Token(Token = "0x6004650")]
    [Address(RVA = "0x3516174", Offset = "0x3516174", VA = "0x3516174")]
    public void Update()
    {
    }

    [Token(Token = "0x6004651")]
    [Address(RVA = "0x35161B4", Offset = "0x35161B4", VA = "0x35161B4")]
    public void StartTime()
    {
    }

    [Token(Token = "0x6004652")]
    [Address(RVA = "0x35161C4", Offset = "0x35161C4", VA = "0x35161C4")]
    public void StopTime()
    {
    }

    [Token(Token = "0x6004653")]
    [Address(RVA = "0x35161CC", Offset = "0x35161CC", VA = "0x35161CC")]
    public void Restart()
    {
    }

    [Token(Token = "0x6004654")]
    [Address(RVA = "0x35161D8", Offset = "0x35161D8", VA = "0x35161D8")]
    public Time()
    {
    }
  }
}
