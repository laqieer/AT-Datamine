// Decompiled with JetBrains decompiler
// Type: StaqData.IBattleParameter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x2001FEB")]
  public interface IBattleParameter
  {
    [Token(Token = "0x17002744")]
    int HP { [Token(Token = "0x600BDA3")] get; }

    [Token(Token = "0x17002745")]
    int PhysicalAtk { [Token(Token = "0x600BDA4")] get; }

    [Token(Token = "0x17002746")]
    int PhysicalDef { [Token(Token = "0x600BDA5")] get; }

    [Token(Token = "0x17002747")]
    int MagicalAtk { [Token(Token = "0x600BDA6")] get; }

    [Token(Token = "0x17002748")]
    int MagicalDef { [Token(Token = "0x600BDA7")] get; }

    [Token(Token = "0x17002749")]
    int Hit { [Token(Token = "0x600BDA8")] get; }

    [Token(Token = "0x1700274A")]
    int Avoid { [Token(Token = "0x600BDA9")] get; }

    [Token(Token = "0x1700274B")]
    int Critical { [Token(Token = "0x600BDAA")] get; }

    [Token(Token = "0x1700274C")]
    int CriticalAvoid { [Token(Token = "0x600BDAB")] get; }

    [Token(Token = "0x1700274D")]
    int AtkSpeed { [Token(Token = "0x600BDAC")] get; }
  }
}
