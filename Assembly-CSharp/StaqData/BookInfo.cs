// Decompiled with JetBrains decompiler
// Type: StaqData.BookInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using Story.Adv.LuaObjects;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x2002092")]
  public class BookInfo
  {
    [Token(Token = "0x4008A92")]
    [FieldOffset(Offset = "0x28")]
    private BookInfo.Effect effect;
    [Token(Token = "0x4008A93")]
    [FieldOffset(Offset = "0x30")]
    private BookInfo.Condition condition;
    [Token(Token = "0x4008A94")]
    [FieldOffset(Offset = "0x38")]
    private StoryBookEffectData bookEffect;

    [Token(Token = "0x17002A09")]
    public int ID
    {
      [Token(Token = "0x600C4FE"), Address(RVA = "0x19FF3E0", Offset = "0x19FF3E0", VA = "0x19FF3E0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002A0A")]
    public int EffectID
    {
      [Token(Token = "0x600C4FF"), Address(RVA = "0x19FF3E8", Offset = "0x19FF3E8", VA = "0x19FF3E8")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002A0B")]
    public string Name
    {
      [Token(Token = "0x600C500"), Address(RVA = "0x19FF3F0", Offset = "0x19FF3F0", VA = "0x19FF3F0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17002A0C")]
    public string OnCompleteText
    {
      [Token(Token = "0x600C501"), Address(RVA = "0x19FF3F8", Offset = "0x19FF3F8", VA = "0x19FF3F8")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17002A0D")]
    public bool CanComplete
    {
      [Token(Token = "0x600C502"), Address(RVA = "0x19FF42C", Offset = "0x19FF42C", VA = "0x19FF42C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002A0E")]
    public bool Completed
    {
      [Token(Token = "0x600C503"), Address(RVA = "0x19FF52C", Offset = "0x19FF52C", VA = "0x19FF52C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002A0F")]
    public bool IsRentalBook
    {
      [Token(Token = "0x600C504"), Address(RVA = "0x19FF54C", Offset = "0x19FF54C", VA = "0x19FF54C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002A10")]
    public bool Enable
    {
      [Token(Token = "0x600C505"), Address(RVA = "0x19FF570", Offset = "0x19FF570", VA = "0x19FF570")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002A11")]
    public bool IsLocked
    {
      [Token(Token = "0x600C506"), Address(RVA = "0x19FF58C", Offset = "0x19FF58C", VA = "0x19FF58C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002A12")]
    public int Current
    {
      [Token(Token = "0x600C507"), Address(RVA = "0x19FF4A8", Offset = "0x19FF4A8", VA = "0x19FF4A8")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002A13")]
    public int Max
    {
      [Token(Token = "0x600C508"), Address(RVA = "0x19FF628", Offset = "0x19FF628", VA = "0x19FF628")] get
      {
        return new int();
      }
      [Token(Token = "0x600C509"), Address(RVA = "0x19FF630", Offset = "0x19FF630", VA = "0x19FF630")] private set
      {
      }
    }

    [Token(Token = "0x17002A14")]
    public int ReadSpeedBuff
    {
      [Token(Token = "0x600C50A"), Address(RVA = "0x19FF638", Offset = "0x19FF638", VA = "0x19FF638")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002A15")]
    public bool IsFirst
    {
      [Token(Token = "0x600C50B"), Address(RVA = "0x19FF688", Offset = "0x19FF688", VA = "0x19FF688")] get
      {
        return new bool();
      }
      [Token(Token = "0x600C50C"), Address(RVA = "0x19FF690", Offset = "0x19FF690", VA = "0x19FF690")] private set
      {
      }
    }

    [Token(Token = "0x17002A16")]
    public int RewardsID
    {
      [Token(Token = "0x600C50D"), Address(RVA = "0x19FF69C", Offset = "0x19FF69C", VA = "0x19FF69C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002A17")]
    public bool IsNew
    {
      [Token(Token = "0x600C50E"), Address(RVA = "0x19FF6CC", Offset = "0x19FF6CC", VA = "0x19FF6CC")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600C50F")]
    [Address(RVA = "0x19FF778", Offset = "0x19FF778", VA = "0x19FF778")]
    public BookInfo(int chapterItemID)
    {
    }

    [Token(Token = "0x600C510")]
    [Address(RVA = "0x19FFA80", Offset = "0x19FFA80", VA = "0x19FFA80")]
    public BookInfo(int chapterItemID, bool isFirst)
    {
    }

    [Token(Token = "0x600C511")]
    [Address(RVA = "0x19FFAA8", Offset = "0x19FFAA8", VA = "0x19FFAA8")]
    public void First(bool first)
    {
    }

    [Token(Token = "0x600C512")]
    [Address(RVA = "0x19FFAB4", Offset = "0x19FFAB4", VA = "0x19FFAB4")]
    public bool HasAppendEffect() => new bool();

    [Token(Token = "0x600C513")]
    [Address(RVA = "0x19FFB08", Offset = "0x19FFB08", VA = "0x19FFB08")]
    public string GetAppendEffectText() => (string) null;

    [Token(Token = "0x600C514")]
    [Address(RVA = "0x19FFB78", Offset = "0x19FFB78", VA = "0x19FFB78")]
    public (RewardTypeEnum, int, int)? GetParameterBuff(int facilityID)
    {
      return new (RewardTypeEnum, int, int)?();
    }

    [Token(Token = "0x600C515")]
    [Address(RVA = "0x19FFCB0", Offset = "0x19FFCB0", VA = "0x19FFCB0")]
    public string GetLockedConditionText() => (string) null;

    [Token(Token = "0x2002093")]
    public struct Progress
    {
      [Token(Token = "0x17002A18")]
      public Reaction[] Reactions
      {
        [Token(Token = "0x600C516"), Address(RVA = "0x19FFDA0", Offset = "0x19FFDA0", VA = "0x19FFDA0")] readonly get
        {
          return (Reaction[]) null;
        }
        [Token(Token = "0x600C517"), Address(RVA = "0x19FFDA8", Offset = "0x19FFDA8", VA = "0x19FFDA8")] set
        {
        }
      }

      [Token(Token = "0x600C518")]
      [Address(RVA = "0x19FFDB0", Offset = "0x19FFDB0", VA = "0x19FFDB0")]
      public static BookInfo.Progress Get(int bookEffectID, int progress)
      {
        return new BookInfo.Progress();
      }
    }

    [Token(Token = "0x2002094")]
    private class Condition
    {
      [Token(Token = "0x4008A96")]
      [FieldOffset(Offset = "0x10")]
      private int conditionAbility;

      [Token(Token = "0x17002A19")]
      public string ConditionText
      {
        [Token(Token = "0x600C519"), Address(RVA = "0x19FFCC8", Offset = "0x19FFCC8", VA = "0x19FFCC8")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x17002A1A")]
      public bool IsValid
      {
        [Token(Token = "0x600C51A"), Address(RVA = "0x19FF588", Offset = "0x19FF588", VA = "0x19FF588")] get
        {
          return new bool();
        }
      }

      [Token(Token = "0x17002A1B")]
      public bool IsValidAbility
      {
        [Token(Token = "0x600C51B"), Address(RVA = "0x1A00328", Offset = "0x1A00328", VA = "0x1A00328")] get
        {
          return new bool();
        }
      }

      [Token(Token = "0x600C51C")]
      [Address(RVA = "0x19FFA4C", Offset = "0x19FFA4C", VA = "0x19FFA4C")]
      public Condition(StoryBookEffectData master)
      {
      }
    }

    [Token(Token = "0x2002095")]
    private class Effect
    {
      [Token(Token = "0x17002A1C")]
      public bool IsNone
      {
        [Token(Token = "0x600C51D"), Address(RVA = "0x19FFAE8", Offset = "0x19FFAE8", VA = "0x19FFAE8")] get
        {
          return new bool();
        }
      }

      [Token(Token = "0x17002A1D")]
      public BookInfo.ParameterBuffEffect ParameterBuff
      {
        [Token(Token = "0x600C51E"), Address(RVA = "0x1A003AC", Offset = "0x1A003AC", VA = "0x1A003AC")] get
        {
          return (BookInfo.ParameterBuffEffect) null;
        }
      }

      [Token(Token = "0x17002A1E")]
      public BookInfo.ReadSpeedBuffEffect ReadSpeedBuff
      {
        [Token(Token = "0x600C51F"), Address(RVA = "0x1A003B4", Offset = "0x1A003B4", VA = "0x1A003B4")] get
        {
          return (BookInfo.ReadSpeedBuffEffect) null;
        }
      }

      [Token(Token = "0x17002A1F")]
      public string Text
      {
        [Token(Token = "0x600C520"), Address(RVA = "0x1A003BC", Offset = "0x1A003BC", VA = "0x1A003BC")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x600C521")]
      [Address(RVA = "0x19FF94C", Offset = "0x19FF94C", VA = "0x19FF94C")]
      public Effect(StoryBookEffectData master)
      {
      }
    }

    [Token(Token = "0x2002096")]
    public class ParameterBuffEffect
    {
      [Token(Token = "0x4008A9A")]
      [FieldOffset(Offset = "0x10")]
      private StoryBookEffectData master;

      [Token(Token = "0x600C522")]
      [Address(RVA = "0x1A003C4", Offset = "0x1A003C4", VA = "0x1A003C4")]
      public ParameterBuffEffect(StoryBookEffectData master)
      {
      }

      [Token(Token = "0x17002A20")]
      public int FacilityID
      {
        [Token(Token = "0x600C523"), Address(RVA = "0x19FFC40", Offset = "0x19FFC40", VA = "0x19FFC40")] get
        {
          return new int();
        }
      }

      [Token(Token = "0x17002A21")]
      public int Category
      {
        [Token(Token = "0x600C524"), Address(RVA = "0x19FFC5C", Offset = "0x19FFC5C", VA = "0x19FFC5C")] get
        {
          return new int();
        }
      }

      [Token(Token = "0x17002A22")]
      public int TypeonID
      {
        [Token(Token = "0x600C525"), Address(RVA = "0x19FFC78", Offset = "0x19FFC78", VA = "0x19FFC78")] get
        {
          return new int();
        }
      }

      [Token(Token = "0x17002A23")]
      public int Value
      {
        [Token(Token = "0x600C526"), Address(RVA = "0x19FFC94", Offset = "0x19FFC94", VA = "0x19FFC94")] get
        {
          return new int();
        }
      }

      [Token(Token = "0x600C527")]
      [Address(RVA = "0x1A00414", Offset = "0x1A00414", VA = "0x1A00414")]
      public bool Equals(int facilityID, int categoryID, int parameterID) => new bool();
    }

    [Token(Token = "0x2002097")]
    public class ReadSpeedBuffEffect
    {
      [Token(Token = "0x4008A9B")]
      [FieldOffset(Offset = "0x10")]
      private StoryBookEffectData master;

      [Token(Token = "0x600C528")]
      [Address(RVA = "0x1A003EC", Offset = "0x1A003EC", VA = "0x1A003EC")]
      public ReadSpeedBuffEffect(StoryBookEffectData master)
      {
      }

      [Token(Token = "0x17002A24")]
      public int Value
      {
        [Token(Token = "0x600C529"), Address(RVA = "0x19FF66C", Offset = "0x19FF66C", VA = "0x19FF66C")] get
        {
          return new int();
        }
      }
    }
  }
}
