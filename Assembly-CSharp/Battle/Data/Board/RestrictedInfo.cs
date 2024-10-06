// Decompiled with JetBrains decompiler
// Type: Battle.Data.Board.RestrictedInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Battle.Data.Board
{
  [Token(Token = "0x2002783")]
  public struct RestrictedInfo : IRestrictedInfo
  {
    [Token(Token = "0x170034DC")]
    public bool DisableControl
    {
      [Token(Token = "0x600F6A7"), Address(RVA = "0x1ED72C8", Offset = "0x1ED72C8", VA = "0x1ED72C8", Slot = "4")] readonly get
      {
        return new bool();
      }
      [Token(Token = "0x600F6A8"), Address(RVA = "0x1ED72D0", Offset = "0x1ED72D0", VA = "0x1ED72D0")] private set
      {
      }
    }

    [Token(Token = "0x170034DD")]
    public bool DisableAction
    {
      [Token(Token = "0x600F6A9"), Address(RVA = "0x1ED72DC", Offset = "0x1ED72DC", VA = "0x1ED72DC", Slot = "5")] readonly get
      {
        return new bool();
      }
      [Token(Token = "0x600F6AA"), Address(RVA = "0x1ED72E4", Offset = "0x1ED72E4", VA = "0x1ED72E4")] private set
      {
      }
    }

    [Token(Token = "0x170034DE")]
    public bool DisableMove
    {
      [Token(Token = "0x600F6AB"), Address(RVA = "0x1ED72F0", Offset = "0x1ED72F0", VA = "0x1ED72F0", Slot = "6")] readonly get
      {
        return new bool();
      }
      [Token(Token = "0x600F6AC"), Address(RVA = "0x1ED72F8", Offset = "0x1ED72F8", VA = "0x1ED72F8")] private set
      {
      }
    }

    [Token(Token = "0x170034DF")]
    public bool DisableAvoid
    {
      [Token(Token = "0x600F6AD"), Address(RVA = "0x1ED7304", Offset = "0x1ED7304", VA = "0x1ED7304", Slot = "7")] readonly get
      {
        return new bool();
      }
      [Token(Token = "0x600F6AE"), Address(RVA = "0x1ED730C", Offset = "0x1ED730C", VA = "0x1ED730C")] private set
      {
      }
    }

    [Token(Token = "0x170034E0")]
    public bool DisableHit
    {
      [Token(Token = "0x600F6AF"), Address(RVA = "0x1ED7318", Offset = "0x1ED7318", VA = "0x1ED7318", Slot = "8")] readonly get
      {
        return new bool();
      }
      [Token(Token = "0x600F6B0"), Address(RVA = "0x1ED7320", Offset = "0x1ED7320", VA = "0x1ED7320")] private set
      {
      }
    }

    [Token(Token = "0x170034E1")]
    public bool DisableSecondAttack
    {
      [Token(Token = "0x600F6B1"), Address(RVA = "0x1ED732C", Offset = "0x1ED732C", VA = "0x1ED732C", Slot = "9")] readonly get
      {
        return new bool();
      }
      [Token(Token = "0x600F6B2"), Address(RVA = "0x1ED7334", Offset = "0x1ED7334", VA = "0x1ED7334")] private set
      {
      }
    }

    [Token(Token = "0x170034E2")]
    public List<SkillCategoryTypeEnum> DisableUseSkillCategories
    {
      [Token(Token = "0x600F6B3"), Address(RVA = "0x1ED7340", Offset = "0x1ED7340", VA = "0x1ED7340", Slot = "10")] readonly get
      {
        return (List<SkillCategoryTypeEnum>) null;
      }
      [Token(Token = "0x600F6B4"), Address(RVA = "0x1ED7348", Offset = "0x1ED7348", VA = "0x1ED7348")] private set
      {
      }
    }

    [Token(Token = "0x170034E3")]
    public bool DisableBattle
    {
      [Token(Token = "0x600F6B5"), Address(RVA = "0x1ED7350", Offset = "0x1ED7350", VA = "0x1ED7350", Slot = "11")] readonly get
      {
        return new bool();
      }
      [Token(Token = "0x600F6B6"), Address(RVA = "0x1ED7358", Offset = "0x1ED7358", VA = "0x1ED7358")] private set
      {
      }
    }

    [Token(Token = "0x600F6B7")]
    [Address(RVA = "0x1ED6AE0", Offset = "0x1ED6AE0", VA = "0x1ED6AE0")]
    public RestrictedInfo(
      bool disableControl = false,
      bool disableAction = false,
      bool disableMove = false,
      bool disableAvoid = false,
      bool disableHit = false,
      bool disableSecondAttack = false,
      List<SkillCategoryTypeEnum> disableUseSkillCategories = null,
      bool disableBattle = false)
    {
    }
  }
}
