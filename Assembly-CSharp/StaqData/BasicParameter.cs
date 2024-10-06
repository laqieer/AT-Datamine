// Decompiled with JetBrains decompiler
// Type: StaqData.BasicParameter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x2001FE6")]
  public class BasicParameter : IBasicParameter
  {
    [Token(Token = "0x17002738")]
    public static BasicParameter Zero
    {
      [Token(Token = "0x600BD6D"), Address(RVA = "0x1E58034", Offset = "0x1E58034", VA = "0x1E58034")] get
      {
        return (BasicParameter) null;
      }
    }

    [Token(Token = "0x17002739")]
    public int Life
    {
      [Token(Token = "0x600BD6E"), Address(RVA = "0x1E58100", Offset = "0x1E58100", VA = "0x1E58100", Slot = "4")] get
      {
        return new int();
      }
      [Token(Token = "0x600BD6F"), Address(RVA = "0x1E58108", Offset = "0x1E58108", VA = "0x1E58108")] protected set
      {
      }
    }

    [Token(Token = "0x1700273A")]
    public int Strength
    {
      [Token(Token = "0x600BD70"), Address(RVA = "0x1E58110", Offset = "0x1E58110", VA = "0x1E58110", Slot = "5")] get
      {
        return new int();
      }
      [Token(Token = "0x600BD71"), Address(RVA = "0x1E58118", Offset = "0x1E58118", VA = "0x1E58118")] protected set
      {
      }
    }

    [Token(Token = "0x1700273B")]
    public int Intelligence
    {
      [Token(Token = "0x600BD72"), Address(RVA = "0x1E58120", Offset = "0x1E58120", VA = "0x1E58120", Slot = "6")] get
      {
        return new int();
      }
      [Token(Token = "0x600BD73"), Address(RVA = "0x1E58128", Offset = "0x1E58128", VA = "0x1E58128")] protected set
      {
      }
    }

    [Token(Token = "0x1700273C")]
    public int Vitality
    {
      [Token(Token = "0x600BD74"), Address(RVA = "0x1E58130", Offset = "0x1E58130", VA = "0x1E58130", Slot = "7")] get
      {
        return new int();
      }
      [Token(Token = "0x600BD75"), Address(RVA = "0x1E58138", Offset = "0x1E58138", VA = "0x1E58138")] protected set
      {
      }
    }

    [Token(Token = "0x1700273D")]
    public int Mind
    {
      [Token(Token = "0x600BD76"), Address(RVA = "0x1E58140", Offset = "0x1E58140", VA = "0x1E58140", Slot = "8")] get
      {
        return new int();
      }
      [Token(Token = "0x600BD77"), Address(RVA = "0x1E58148", Offset = "0x1E58148", VA = "0x1E58148")] protected set
      {
      }
    }

    [Token(Token = "0x1700273E")]
    public int Agility
    {
      [Token(Token = "0x600BD78"), Address(RVA = "0x1E58150", Offset = "0x1E58150", VA = "0x1E58150", Slot = "9")] get
      {
        return new int();
      }
      [Token(Token = "0x600BD79"), Address(RVA = "0x1E58158", Offset = "0x1E58158", VA = "0x1E58158")] protected set
      {
      }
    }

    [Token(Token = "0x1700273F")]
    public int Dexterity
    {
      [Token(Token = "0x600BD7A"), Address(RVA = "0x1E58160", Offset = "0x1E58160", VA = "0x1E58160", Slot = "10")] get
      {
        return new int();
      }
      [Token(Token = "0x600BD7B"), Address(RVA = "0x1E58168", Offset = "0x1E58168", VA = "0x1E58168")] protected set
      {
      }
    }

    [Token(Token = "0x17002740")]
    public int Lucky
    {
      [Token(Token = "0x600BD7C"), Address(RVA = "0x1E58170", Offset = "0x1E58170", VA = "0x1E58170", Slot = "11")] get
      {
        return new int();
      }
      [Token(Token = "0x600BD7D"), Address(RVA = "0x1E58178", Offset = "0x1E58178", VA = "0x1E58178")] protected set
      {
      }
    }

    [Token(Token = "0x600BD7E")]
    [Address(RVA = "0x1E58180", Offset = "0x1E58180", VA = "0x1E58180")]
    public BasicParameter Copy() => (BasicParameter) null;

    [Token(Token = "0x600BD7F")]
    [Address(RVA = "0x1E58098", Offset = "0x1E58098", VA = "0x1E58098")]
    public BasicParameter(
      int life = 0,
      int str = 0,
      int intl = 0,
      int vit = 0,
      int mnd = 0,
      int agi = 0,
      int dex = 0,
      int luc = 0)
    {
    }

    [Token(Token = "0x600BD80")]
    [Address(RVA = "0x1E58218", Offset = "0x1E58218", VA = "0x1E58218")]
    public BasicParameter(IBasicParameter param)
    {
    }

    [Token(Token = "0x600BD81")]
    [Address(RVA = "0x1E5858C", Offset = "0x1E5858C", VA = "0x1E5858C")]
    public BasicParameter(IBasicParameter param, int influenceRate)
    {
    }

    [Token(Token = "0x600BD82")]
    [Address(RVA = "0x1E58200", Offset = "0x1E58200", VA = "0x1E58200")]
    public void Update(
      int life,
      int str,
      int intl,
      int vit,
      int mnd,
      int agi,
      int dex,
      int luc)
    {
    }

    [Token(Token = "0x600BD83")]
    [Address(RVA = "0x1E58244", Offset = "0x1E58244", VA = "0x1E58244")]
    public void Update(IBasicParameter param)
    {
    }

    [Token(Token = "0x600BD84")]
    [Address(RVA = "0x1E58BA0", Offset = "0x1E58BA0", VA = "0x1E58BA0")]
    public void Add(int life, int str, int intl, int vit, int mnd, int agi, int dex, int luc)
    {
    }

    [Token(Token = "0x600BD85")]
    [Address(RVA = "0x1E58BE8", Offset = "0x1E58BE8", VA = "0x1E58BE8")]
    public void Add(IBasicParameter param)
    {
    }

    [Token(Token = "0x600BD86")]
    [Address(RVA = "0x1E58F84", Offset = "0x1E58F84", VA = "0x1E58F84")]
    public string ToJson() => (string) null;

    [Token(Token = "0x600BD87")]
    [Address(RVA = "0x1E59230", Offset = "0x1E59230", VA = "0x1E59230")]
    public static BasicParameter CreateRandomDummy(int min, int max) => (BasicParameter) null;
  }
}
