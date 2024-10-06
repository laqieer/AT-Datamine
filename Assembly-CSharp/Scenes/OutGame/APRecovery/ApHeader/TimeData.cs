// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.APRecovery.ApHeader.TimeData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Scenes.OutGame.APRecovery.ApHeader
{
  [Token(Token = "0x200397D")]
  public readonly struct TimeData
  {
    [Token(Token = "0x400FB2C")]
    private const int HourMax = 99;

    [Token(Token = "0x6016996")]
    [Address(RVA = "0x42F1468", Offset = "0x42F1468", VA = "0x42F1468")]
    public static TimeData FromSec(float timeSec) => new TimeData();

    [Token(Token = "0x6016997")]
    [Address(RVA = "0x42F2F14", Offset = "0x42F2F14", VA = "0x42F2F14")]
    public TimeData(int h, int m, int s)
    {
    }

    [Token(Token = "0x17004A73")]
    public int H
    {
      [Token(Token = "0x6016998"), Address(RVA = "0x42F2F20", Offset = "0x42F2F20", VA = "0x42F2F20")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004A74")]
    public int M
    {
      [Token(Token = "0x6016999"), Address(RVA = "0x42F2F28", Offset = "0x42F2F28", VA = "0x42F2F28")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004A75")]
    public int S
    {
      [Token(Token = "0x601699A"), Address(RVA = "0x42F2F30", Offset = "0x42F2F30", VA = "0x42F2F30")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x601699B")]
    [Address(RVA = "0x42F15F8", Offset = "0x42F15F8", VA = "0x42F15F8", Slot = "3")]
    public override string ToString() => (string) null;
  }
}
