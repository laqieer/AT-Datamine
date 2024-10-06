// Decompiled with JetBrains decompiler
// Type: StaqData.BattleParameter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x2001FED")]
  public class BattleParameter : IBattleParameter
  {
    [Token(Token = "0x1700274E")]
    public static BattleParameter Zero
    {
      [Token(Token = "0x600BDAD"), Address(RVA = "0x1E5A920", Offset = "0x1E5A920", VA = "0x1E5A920")] get
      {
        return (BattleParameter) null;
      }
    }

    [Token(Token = "0x1700274F")]
    public int HP
    {
      [Token(Token = "0x600BDAE"), Address(RVA = "0x1E5AA04", Offset = "0x1E5AA04", VA = "0x1E5AA04", Slot = "4")] get
      {
        return new int();
      }
      [Token(Token = "0x600BDAF"), Address(RVA = "0x1E5AA0C", Offset = "0x1E5AA0C", VA = "0x1E5AA0C")] private set
      {
      }
    }

    [Token(Token = "0x17002750")]
    public int PhysicalAtk
    {
      [Token(Token = "0x600BDB0"), Address(RVA = "0x1E5AA14", Offset = "0x1E5AA14", VA = "0x1E5AA14", Slot = "5")] get
      {
        return new int();
      }
      [Token(Token = "0x600BDB1"), Address(RVA = "0x1E5AA1C", Offset = "0x1E5AA1C", VA = "0x1E5AA1C")] private set
      {
      }
    }

    [Token(Token = "0x17002751")]
    public int PhysicalDef
    {
      [Token(Token = "0x600BDB2"), Address(RVA = "0x1E5AA24", Offset = "0x1E5AA24", VA = "0x1E5AA24", Slot = "6")] get
      {
        return new int();
      }
      [Token(Token = "0x600BDB3"), Address(RVA = "0x1E5AA2C", Offset = "0x1E5AA2C", VA = "0x1E5AA2C")] private set
      {
      }
    }

    [Token(Token = "0x17002752")]
    public int MagicalAtk
    {
      [Token(Token = "0x600BDB4"), Address(RVA = "0x1E5AA34", Offset = "0x1E5AA34", VA = "0x1E5AA34", Slot = "7")] get
      {
        return new int();
      }
      [Token(Token = "0x600BDB5"), Address(RVA = "0x1E5AA3C", Offset = "0x1E5AA3C", VA = "0x1E5AA3C")] private set
      {
      }
    }

    [Token(Token = "0x17002753")]
    public int MagicalDef
    {
      [Token(Token = "0x600BDB6"), Address(RVA = "0x1E5AA44", Offset = "0x1E5AA44", VA = "0x1E5AA44", Slot = "8")] get
      {
        return new int();
      }
      [Token(Token = "0x600BDB7"), Address(RVA = "0x1E5AA4C", Offset = "0x1E5AA4C", VA = "0x1E5AA4C")] private set
      {
      }
    }

    [Token(Token = "0x17002754")]
    public int Hit
    {
      [Token(Token = "0x600BDB8"), Address(RVA = "0x1E5AA54", Offset = "0x1E5AA54", VA = "0x1E5AA54", Slot = "9")] get
      {
        return new int();
      }
      [Token(Token = "0x600BDB9"), Address(RVA = "0x1E5AA5C", Offset = "0x1E5AA5C", VA = "0x1E5AA5C")] private set
      {
      }
    }

    [Token(Token = "0x17002755")]
    public int Avoid
    {
      [Token(Token = "0x600BDBA"), Address(RVA = "0x1E5AA64", Offset = "0x1E5AA64", VA = "0x1E5AA64", Slot = "10")] get
      {
        return new int();
      }
      [Token(Token = "0x600BDBB"), Address(RVA = "0x1E5AA6C", Offset = "0x1E5AA6C", VA = "0x1E5AA6C")] private set
      {
      }
    }

    [Token(Token = "0x17002756")]
    public int Critical
    {
      [Token(Token = "0x600BDBC"), Address(RVA = "0x1E5AA74", Offset = "0x1E5AA74", VA = "0x1E5AA74", Slot = "11")] get
      {
        return new int();
      }
      [Token(Token = "0x600BDBD"), Address(RVA = "0x1E5AA7C", Offset = "0x1E5AA7C", VA = "0x1E5AA7C")] private set
      {
      }
    }

    [Token(Token = "0x17002757")]
    public int CriticalAvoid
    {
      [Token(Token = "0x600BDBE"), Address(RVA = "0x1E5AA84", Offset = "0x1E5AA84", VA = "0x1E5AA84", Slot = "12")] get
      {
        return new int();
      }
      [Token(Token = "0x600BDBF"), Address(RVA = "0x1E5AA8C", Offset = "0x1E5AA8C", VA = "0x1E5AA8C")] private set
      {
      }
    }

    [Token(Token = "0x17002758")]
    public int AtkSpeed
    {
      [Token(Token = "0x600BDC0"), Address(RVA = "0x1E5AA94", Offset = "0x1E5AA94", VA = "0x1E5AA94", Slot = "13")] get
      {
        return new int();
      }
      [Token(Token = "0x600BDC1"), Address(RVA = "0x1E5AA9C", Offset = "0x1E5AA9C", VA = "0x1E5AA9C")] private set
      {
      }
    }

    [Token(Token = "0x600BDC2")]
    [Address(RVA = "0x1E5A988", Offset = "0x1E5A988", VA = "0x1E5A988")]
    public BattleParameter(
      int hp,
      int phyAtk,
      int magAtk,
      int phyDef,
      int magDef,
      int hit,
      int avd,
      int crt,
      int cvd,
      int atkSpd)
    {
    }

    [Token(Token = "0x600BDC3")]
    [Address(RVA = "0x1E5AAC8", Offset = "0x1E5AAC8", VA = "0x1E5AAC8")]
    public BattleParameter(IBattleParameter param)
    {
    }

    [Token(Token = "0x600BDC4")]
    [Address(RVA = "0x1E5AAA4", Offset = "0x1E5AAA4", VA = "0x1E5AAA4")]
    public void Update(
      int hp,
      int phyAtk,
      int magAtk,
      int phyDef,
      int magDef,
      int hit,
      int avd,
      int crt,
      int cvd,
      int atkSpd)
    {
    }

    [Token(Token = "0x600BDC5")]
    [Address(RVA = "0x1E5AAF4", Offset = "0x1E5AAF4", VA = "0x1E5AAF4")]
    public void Update(IBattleParameter param)
    {
    }

    [Token(Token = "0x600BDC6")]
    [Address(RVA = "0x1E5AF2C", Offset = "0x1E5AF2C", VA = "0x1E5AF2C")]
    public void Add(
      int hp = 0,
      int phyAtk = 0,
      int magAtk = 0,
      int phyDef = 0,
      int magDef = 0,
      int hit = 0,
      int avd = 0,
      int crt = 0,
      int cvd = 0,
      int atkSpd = 0)
    {
    }

    [Token(Token = "0x600BDC7")]
    [Address(RVA = "0x1E5AF8C", Offset = "0x1E5AF8C", VA = "0x1E5AF8C")]
    public void Add(IBattleParameter param)
    {
    }

    [Token(Token = "0x600BDC8")]
    [Address(RVA = "0x1E5B400", Offset = "0x1E5B400", VA = "0x1E5B400")]
    public string ToJson() => (string) null;
  }
}
