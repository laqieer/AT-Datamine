// Decompiled with JetBrains decompiler
// Type: Story.Adv.Facility.LuaFunction
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using ADV2.LuaScript;
using GameCore.UIControls;
using Il2CppDummyDll;
using MoonSharp.Interpreter;
using Story.Adv.LuaObjects;
using System.Collections.Generic;

#nullable disable
namespace Story.Adv.Facility
{
  [Token(Token = "0x2000755")]
  public class LuaFunction
  {
    [Token(Token = "0x17000621")]
    public LuaFunction.Object Obj
    {
      [Token(Token = "0x600290B"), Address(RVA = "0x367AAE0", Offset = "0x367AAE0", VA = "0x367AAE0")] get
      {
        return (LuaFunction.Object) null;
      }
      [Token(Token = "0x600290C"), Address(RVA = "0x367AAE8", Offset = "0x367AAE8", VA = "0x367AAE8")] private set
      {
      }
    }

    [Token(Token = "0x600290D")]
    [Address(RVA = "0x3679C34", Offset = "0x3679C34", VA = "0x3679C34")]
    public void Initialize(int attachID)
    {
    }

    [Token(Token = "0x600290E")]
    [Address(RVA = "0x367A2F4", Offset = "0x367A2F4", VA = "0x367A2F4")]
    public void Initialize(int attachID, int targetWorkID)
    {
    }

    [Token(Token = "0x600290F")]
    [Address(RVA = "0x3679C0C", Offset = "0x3679C0C", VA = "0x3679C0C")]
    public LuaFunction()
    {
    }

    [Token(Token = "0x2000756")]
    [MoonSharpUserData]
    public class Object
    {
      [Token(Token = "0x17000622")]
      public string Name
      {
        [Token(Token = "0x6002910"), Address(RVA = "0x367BC54", Offset = "0x367BC54", VA = "0x367BC54")] get
        {
          return (string) null;
        }
        [Token(Token = "0x6002911"), Address(RVA = "0x367BC5C", Offset = "0x367BC5C", VA = "0x367BC5C")] set
        {
        }
      }

      [Token(Token = "0x17000623")]
      public int AttachID
      {
        [Token(Token = "0x6002912"), Address(RVA = "0x367BC64", Offset = "0x367BC64", VA = "0x367BC64")] get
        {
          return new int();
        }
        [Token(Token = "0x6002913"), Address(RVA = "0x367BC6C", Offset = "0x367BC6C", VA = "0x367BC6C")] set
        {
        }
      }

      [Token(Token = "0x17000624")]
      public bool ShowMenu
      {
        [Token(Token = "0x6002914"), Address(RVA = "0x367BC74", Offset = "0x367BC74", VA = "0x367BC74")] get
        {
          return new bool();
        }
        [Token(Token = "0x6002915"), Address(RVA = "0x367BC7C", Offset = "0x367BC7C", VA = "0x367BC7C")] set
        {
        }
      }

      [Token(Token = "0x17000625")]
      public bool IsTutorial
      {
        [Token(Token = "0x6002916"), Address(RVA = "0x367BC88", Offset = "0x367BC88", VA = "0x367BC88")] get
        {
          return new bool();
        }
        [Token(Token = "0x6002917"), Address(RVA = "0x367BC90", Offset = "0x367BC90", VA = "0x367BC90")] set
        {
        }
      }

      [Token(Token = "0x17000626")]
      public Book Book
      {
        [Token(Token = "0x6002918"), Address(RVA = "0x367BC9C", Offset = "0x367BC9C", VA = "0x367BC9C")] get
        {
          return (Book) null;
        }
        [Token(Token = "0x6002919"), Address(RVA = "0x367BCA4", Offset = "0x367BCA4", VA = "0x367BCA4")] set
        {
        }
      }

      [Token(Token = "0x17000627")]
      public WorkInfo WorkInfo
      {
        [Token(Token = "0x600291A"), Address(RVA = "0x367BCAC", Offset = "0x367BCAC", VA = "0x367BCAC")] get
        {
          return (WorkInfo) null;
        }
        [Token(Token = "0x600291B"), Address(RVA = "0x367BCB4", Offset = "0x367BCB4", VA = "0x367BCB4")] set
        {
        }
      }

      [Token(Token = "0x17000628")]
      public bool HaveReadableBook
      {
        [Token(Token = "0x600291C"), Address(RVA = "0x367BCBC", Offset = "0x367BCBC", VA = "0x367BCBC")] get
        {
          return new bool();
        }
      }

      [Token(Token = "0x17000629")]
      public Bonus Bonus
      {
        [Token(Token = "0x600291D"), Address(RVA = "0x367BCE4", Offset = "0x367BCE4", VA = "0x367BCE4")] get
        {
          return (Bonus) null;
        }
        [Token(Token = "0x600291E"), Address(RVA = "0x367BCEC", Offset = "0x367BCEC", VA = "0x367BCEC")] set
        {
        }
      }

      [Token(Token = "0x1700062A")]
      public Challenge Challenge
      {
        [Token(Token = "0x600291F"), Address(RVA = "0x367BCF4", Offset = "0x367BCF4", VA = "0x367BCF4")] get
        {
          return (Challenge) null;
        }
        [Token(Token = "0x6002920"), Address(RVA = "0x367BCFC", Offset = "0x367BCFC", VA = "0x367BCFC")] set
        {
        }
      }

      [Token(Token = "0x6002921")]
      [Address(RVA = "0x367BD04", Offset = "0x367BD04", VA = "0x367BD04")]
      public MenuItem[] GetMenuItems() => (MenuItem[]) null;

      [Token(Token = "0x6002922")]
      [Address(RVA = "0x367C0EC", Offset = "0x367C0EC", VA = "0x367C0EC")]
      public LotteryItem[] GetLotteryItems() => (LotteryItem[]) null;

      [Token(Token = "0x6002923")]
      [Address(RVA = "0x367C43C", Offset = "0x367C43C", VA = "0x367C43C")]
      public CommuCharacter[] GetCommuCharacters() => (CommuCharacter[]) null;

      [Token(Token = "0x6002924")]
      [Address(RVA = "0x367C938", Offset = "0x367C938", VA = "0x367C938")]
      public Book[] GetBooks() => (Book[]) null;

      [Token(Token = "0x6002925")]
      [Address(RVA = "0x367BCE0", Offset = "0x367BCE0", VA = "0x367BCE0")]
      public Book[] GetUserBooks() => (Book[]) null;

      [Token(Token = "0x6002926")]
      [Address(RVA = "0x367CCB0", Offset = "0x367CCB0", VA = "0x367CCB0")]
      public int GetReadSpeed() => new int();

      [Token(Token = "0x6002927")]
      [Address(RVA = "0x367CD04", Offset = "0x367CD04", VA = "0x367CD04")]
      public BuffItem[] GetBuffItems() => (BuffItem[]) null;

      [Token(Token = "0x6002928")]
      [Address(RVA = "0x367D0F4", Offset = "0x367D0F4", VA = "0x367D0F4")]
      public BuffItem[] GetSelectedBuffItems() => (BuffItem[]) null;

      [Token(Token = "0x6002929")]
      [Address(RVA = "0x367D518", Offset = "0x367D518", VA = "0x367D518")]
      public LuaSequence.ParamControl.HumanParameter GetHumanParam()
      {
        return (LuaSequence.ParamControl.HumanParameter) null;
      }

      [Token(Token = "0x600292A")]
      [Address(RVA = "0x367E1F4", Offset = "0x367E1F4", VA = "0x367E1F4")]
      public List<DisplayItemRewardInfoData> GetWorkReward()
      {
        return (List<DisplayItemRewardInfoData>) null;
      }

      [Token(Token = "0x600292B")]
      [Address(RVA = "0x367AA88", Offset = "0x367AA88", VA = "0x367AA88")]
      public Object()
      {
      }
    }
  }
}
