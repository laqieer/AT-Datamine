// Decompiled with JetBrains decompiler
// Type: Battle.Data.IReadableHPStockData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Battle.Data
{
  [Token(Token = "0x200272D")]
  public interface IReadableHPStockData
  {
    [Token(Token = "0x170033FA")]
    bool IsCalculatedFromParam { [Token(Token = "0x600F3BE")] get; }

    [Token(Token = "0x170033FB")]
    HP[] HPList { [Token(Token = "0x600F3BF")] get; }

    [Token(Token = "0x170033FC")]
    HP HP { [Token(Token = "0x600F3C0")] get; }

    [Token(Token = "0x170033FD")]
    int CurrentHPStockIndex { [Token(Token = "0x600F3C1")] get; }

    [Token(Token = "0x170033FE")]
    int RemainingStock { [Token(Token = "0x600F3C2")] get; }

    [Token(Token = "0x170033FF")]
    Decimal CurrentHPPercentage { [Token(Token = "0x600F3C3")] get; }

    [Token(Token = "0x17003400")]
    int CurrentHPPercentageInt { [Token(Token = "0x600F3C4")] get; }

    [Token(Token = "0x17003401")]
    float CurrentHPRatio { [Token(Token = "0x600F3C5")] get; }

    [Token(Token = "0x17003402")]
    int BaseHP { [Token(Token = "0x600F3C6")] get; }

    [Token(Token = "0x17003403")]
    int MaxHP { [Token(Token = "0x600F3C7")] get; }

    [Token(Token = "0x17003404")]
    int CurrentHP { [Token(Token = "0x600F3C8")] get; }

    [Token(Token = "0x17003405")]
    bool IsAlive { [Token(Token = "0x600F3C9")] get; }

    [Token(Token = "0x600F3CA")]
    void SwitchNextHP();
  }
}
