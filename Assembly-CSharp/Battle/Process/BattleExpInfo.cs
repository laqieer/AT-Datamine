// Decompiled with JetBrains decompiler
// Type: Battle.Process.BattleExpInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Il2CppDummyDll;

#nullable disable
namespace Battle.Process
{
  [Token(Token = "0x2002690")]
  public class BattleExpInfo
  {
    [Token(Token = "0x400A56E")]
    [FieldOffset(Offset = "0x18")]
    public int GainStyleExp;
    [Token(Token = "0x400A574")]
    [FieldOffset(Offset = "0x38")]
    public int GainWeaponExp;

    [Token(Token = "0x17003294")]
    public UnitParameterData Unit
    {
      [Token(Token = "0x600EEAC"), Address(RVA = "0x444A31C", Offset = "0x444A31C", VA = "0x444A31C")] get
      {
        return (UnitParameterData) null;
      }
      [Token(Token = "0x600EEAD"), Address(RVA = "0x444A324", Offset = "0x444A324", VA = "0x444A324")] private set
      {
      }
    }

    [Token(Token = "0x17003295")]
    public int PreStyleExp
    {
      [Token(Token = "0x600EEAE"), Address(RVA = "0x444A32C", Offset = "0x444A32C", VA = "0x444A32C")] get
      {
        return new int();
      }
      [Token(Token = "0x600EEAF"), Address(RVA = "0x444A334", Offset = "0x444A334", VA = "0x444A334")] private set
      {
      }
    }

    [Token(Token = "0x17003296")]
    public int PostStyleExp
    {
      [Token(Token = "0x600EEB0"), Address(RVA = "0x444A33C", Offset = "0x444A33C", VA = "0x444A33C")] get
      {
        return new int();
      }
      [Token(Token = "0x600EEB1"), Address(RVA = "0x444A344", Offset = "0x444A344", VA = "0x444A344")] private set
      {
      }
    }

    [Token(Token = "0x17003297")]
    public int PreStyleLv
    {
      [Token(Token = "0x600EEB2"), Address(RVA = "0x444A34C", Offset = "0x444A34C", VA = "0x444A34C")] get
      {
        return new int();
      }
      [Token(Token = "0x600EEB3"), Address(RVA = "0x444A354", Offset = "0x444A354", VA = "0x444A354")] private set
      {
      }
    }

    [Token(Token = "0x17003298")]
    public int PostStyleLv
    {
      [Token(Token = "0x600EEB4"), Address(RVA = "0x444A35C", Offset = "0x444A35C", VA = "0x444A35C")] get
      {
        return new int();
      }
      [Token(Token = "0x600EEB5"), Address(RVA = "0x444A364", Offset = "0x444A364", VA = "0x444A364")] private set
      {
      }
    }

    [Token(Token = "0x17003299")]
    public WeaponParameterData Weapon
    {
      [Token(Token = "0x600EEB6"), Address(RVA = "0x444A36C", Offset = "0x444A36C", VA = "0x444A36C")] get
      {
        return (WeaponParameterData) null;
      }
      [Token(Token = "0x600EEB7"), Address(RVA = "0x444A374", Offset = "0x444A374", VA = "0x444A374")] private set
      {
      }
    }

    [Token(Token = "0x1700329A")]
    public int PreWeaponExp
    {
      [Token(Token = "0x600EEB8"), Address(RVA = "0x444A37C", Offset = "0x444A37C", VA = "0x444A37C")] get
      {
        return new int();
      }
      [Token(Token = "0x600EEB9"), Address(RVA = "0x444A384", Offset = "0x444A384", VA = "0x444A384")] private set
      {
      }
    }

    [Token(Token = "0x1700329B")]
    public int PostWeaponExp
    {
      [Token(Token = "0x600EEBA"), Address(RVA = "0x444A38C", Offset = "0x444A38C", VA = "0x444A38C")] get
      {
        return new int();
      }
      [Token(Token = "0x600EEBB"), Address(RVA = "0x444A394", Offset = "0x444A394", VA = "0x444A394")] private set
      {
      }
    }

    [Token(Token = "0x1700329C")]
    public int PreWeaponLv
    {
      [Token(Token = "0x600EEBC"), Address(RVA = "0x444A39C", Offset = "0x444A39C", VA = "0x444A39C")] get
      {
        return new int();
      }
      [Token(Token = "0x600EEBD"), Address(RVA = "0x444A3A4", Offset = "0x444A3A4", VA = "0x444A3A4")] private set
      {
      }
    }

    [Token(Token = "0x1700329D")]
    public int PostWeaponLv
    {
      [Token(Token = "0x600EEBE"), Address(RVA = "0x444A3AC", Offset = "0x444A3AC", VA = "0x444A3AC")] get
      {
        return new int();
      }
      [Token(Token = "0x600EEBF"), Address(RVA = "0x444A3B4", Offset = "0x444A3B4", VA = "0x444A3B4")] private set
      {
      }
    }

    [Token(Token = "0x600EEC0")]
    [Address(RVA = "0x444A3BC", Offset = "0x444A3BC", VA = "0x444A3BC")]
    public BattleExpInfo(UnitParameterData unit)
    {
    }

    [Token(Token = "0x600EEC1")]
    [Address(RVA = "0x444A420", Offset = "0x444A420", VA = "0x444A420")]
    public void InjectStyleExp()
    {
    }

    [Token(Token = "0x600EEC2")]
    [Address(RVA = "0x444A46C", Offset = "0x444A46C", VA = "0x444A46C")]
    public void InjectWeaponExp()
    {
    }
  }
}
