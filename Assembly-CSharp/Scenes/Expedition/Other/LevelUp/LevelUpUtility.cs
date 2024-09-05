// Decompiled with JetBrains decompiler
// Type: Scenes.Expedition.Other.LevelUp.LevelUpUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.Param;

#nullable disable
namespace Scenes.Expedition.Other.LevelUp
{
  [Token(Token = "0x2002C92")]
  public class LevelUpUtility
  {
    [Token(Token = "0x6011711")]
    [Address(RVA = "0x49370D4", Offset = "0x49370D4", VA = "0x49370D4")]
    public static LevelUpUtility.PlayerLevelUpData GetPlayerLevelUpData(
      PlayerType beforePlayer,
      PlayerType nowPlayer)
    {
      return (LevelUpUtility.PlayerLevelUpData) null;
    }

    [Token(Token = "0x6011712")]
    [Address(RVA = "0x493765C", Offset = "0x493765C", VA = "0x493765C")]
    public LevelUpUtility()
    {
    }

    [Token(Token = "0x2002C93")]
    public class ExpData
    {
      [Token(Token = "0x17003C15")]
      public int Level
      {
        [Token(Token = "0x6011713"), Address(RVA = "0x4937664", Offset = "0x4937664", VA = "0x4937664")] get
        {
          return new int();
        }
        [Token(Token = "0x6011714"), Address(RVA = "0x493766C", Offset = "0x493766C", VA = "0x493766C")] private set
        {
        }
      }

      [Token(Token = "0x17003C16")]
      public int Exp
      {
        [Token(Token = "0x6011715"), Address(RVA = "0x4937674", Offset = "0x4937674", VA = "0x4937674")] get
        {
          return new int();
        }
        [Token(Token = "0x6011716"), Address(RVA = "0x493767C", Offset = "0x493767C", VA = "0x493767C")] private set
        {
        }
      }

      [Token(Token = "0x17003C17")]
      public int FromExp
      {
        [Token(Token = "0x6011717"), Address(RVA = "0x4937684", Offset = "0x4937684", VA = "0x4937684")] get
        {
          return new int();
        }
        [Token(Token = "0x6011718"), Address(RVA = "0x493768C", Offset = "0x493768C", VA = "0x493768C")] private set
        {
        }
      }

      [Token(Token = "0x17003C18")]
      public int ToExp
      {
        [Token(Token = "0x6011719"), Address(RVA = "0x4937694", Offset = "0x4937694", VA = "0x4937694")] get
        {
          return new int();
        }
        [Token(Token = "0x601171A"), Address(RVA = "0x493769C", Offset = "0x493769C", VA = "0x493769C")] private set
        {
        }
      }

      [Token(Token = "0x601171B")]
      [Address(RVA = "0x49375D0", Offset = "0x49375D0", VA = "0x49375D0")]
      public ExpData(int level, int exp, int fromExp, int toExp)
      {
      }
    }

    [Token(Token = "0x2002C94")]
    public class PlayerLevelUpData
    {
      [Token(Token = "0x17003C19")]
      public LevelUpUtility.ExpData BeforeExpData
      {
        [Token(Token = "0x601171C"), Address(RVA = "0x49376A4", Offset = "0x49376A4", VA = "0x49376A4")] get
        {
          return (LevelUpUtility.ExpData) null;
        }
        [Token(Token = "0x601171D"), Address(RVA = "0x49376AC", Offset = "0x49376AC", VA = "0x49376AC")] private set
        {
        }
      }

      [Token(Token = "0x17003C1A")]
      public LevelUpUtility.ExpData NowExpData
      {
        [Token(Token = "0x601171E"), Address(RVA = "0x49376B4", Offset = "0x49376B4", VA = "0x49376B4")] get
        {
          return (LevelUpUtility.ExpData) null;
        }
        [Token(Token = "0x601171F"), Address(RVA = "0x49376BC", Offset = "0x49376BC", VA = "0x49376BC")] private set
        {
        }
      }

      [Token(Token = "0x17003C1B")]
      public bool IsLevelUp
      {
        [Token(Token = "0x6011720"), Address(RVA = "0x49376C4", Offset = "0x49376C4", VA = "0x49376C4")] get
        {
          return new bool();
        }
        [Token(Token = "0x6011721"), Address(RVA = "0x49376CC", Offset = "0x49376CC", VA = "0x49376CC")] private set
        {
        }
      }

      [Token(Token = "0x6011722")]
      [Address(RVA = "0x4937610", Offset = "0x4937610", VA = "0x4937610")]
      public PlayerLevelUpData(LevelUpUtility.ExpData before, LevelUpUtility.ExpData now)
      {
      }
    }
  }
}
