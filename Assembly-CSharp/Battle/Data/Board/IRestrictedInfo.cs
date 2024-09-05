// Decompiled with JetBrains decompiler
// Type: Battle.Data.Board.IRestrictedInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Battle.Data.Board
{
  [Token(Token = "0x2002782")]
  public interface IRestrictedInfo
  {
    [Token(Token = "0x170034D4")]
    bool DisableControl { [Token(Token = "0x600F69F")] get; }

    [Token(Token = "0x170034D5")]
    bool DisableAction { [Token(Token = "0x600F6A0")] get; }

    [Token(Token = "0x170034D6")]
    bool DisableMove { [Token(Token = "0x600F6A1")] get; }

    [Token(Token = "0x170034D7")]
    bool DisableAvoid { [Token(Token = "0x600F6A2")] get; }

    [Token(Token = "0x170034D8")]
    bool DisableHit { [Token(Token = "0x600F6A3")] get; }

    [Token(Token = "0x170034D9")]
    bool DisableSecondAttack { [Token(Token = "0x600F6A4")] get; }

    [Token(Token = "0x170034DA")]
    List<SkillCategoryTypeEnum> DisableUseSkillCategories { [Token(Token = "0x600F6A5")] get; }

    [Token(Token = "0x170034DB")]
    bool DisableBattle { [Token(Token = "0x600F6A6")] get; }
  }
}
