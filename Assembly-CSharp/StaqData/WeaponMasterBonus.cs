// Decompiled with JetBrains decompiler
// Type: StaqData.WeaponMasterBonus
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.Param;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x2002119")]
  public class WeaponMasterBonus
  {
    [Token(Token = "0x4008C7E")]
    private const int masterLevelMax = 50;

    [Token(Token = "0x17002C13")]
    public int WeaponMasterBonusId
    {
      [Token(Token = "0x600CA62"), Address(RVA = "0x1BA3BF8", Offset = "0x1BA3BF8", VA = "0x1BA3BF8")] get
      {
        return new int();
      }
      [Token(Token = "0x600CA63"), Address(RVA = "0x1BA3C00", Offset = "0x1BA3C00", VA = "0x1BA3C00")] private set
      {
      }
    }

    [Token(Token = "0x17002C14")]
    public int Exp
    {
      [Token(Token = "0x600CA64"), Address(RVA = "0x1BA3C08", Offset = "0x1BA3C08", VA = "0x1BA3C08")] get
      {
        return new int();
      }
      [Token(Token = "0x600CA65"), Address(RVA = "0x1BA3C10", Offset = "0x1BA3C10", VA = "0x1BA3C10")] private set
      {
      }
    }

    [Token(Token = "0x600CA66")]
    [Address(RVA = "0x1BA3C18", Offset = "0x1BA3C18", VA = "0x1BA3C18")]
    private WeaponMasterBonus()
    {
    }

    [Token(Token = "0x600CA67")]
    [Address(RVA = "0x1BA3C20", Offset = "0x1BA3C20", VA = "0x1BA3C20")]
    public void Apply(PlayerWeaponMasterBonusType entity)
    {
    }

    [Token(Token = "0x17002C15")]
    public int Level
    {
      [Token(Token = "0x600CA68"), Address(RVA = "0x1BA3C3C", Offset = "0x1BA3C3C", VA = "0x1BA3C3C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002C16")]
    public float Percent
    {
      [Token(Token = "0x600CA69"), Address(RVA = "0x1BA3CD8", Offset = "0x1BA3CD8", VA = "0x1BA3CD8")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x17002C17")]
    public int NextLevelExp
    {
      [Token(Token = "0x600CA6A"), Address(RVA = "0x1BA3D84", Offset = "0x1BA3D84", VA = "0x1BA3D84")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600CA6B")]
    [Address(RVA = "0x1BA3E40", Offset = "0x1BA3E40", VA = "0x1BA3E40")]
    public static WeaponMasterBonus CreateByServerData(PlayerWeaponMasterBonusType entity)
    {
      return (WeaponMasterBonus) null;
    }
  }
}
