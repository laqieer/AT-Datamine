// Decompiled with JetBrains decompiler
// Type: StaqData.SuspendResumeData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using Network.API;
using Network.Param;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x20020F8")]
  public class SuspendResumeData
  {
    [Token(Token = "0x17002B3A")]
    public SuspendResumeTypeEnum TypeId
    {
      [Token(Token = "0x600C812"), Address(RVA = "0x1CE1590", Offset = "0x1CE1590", VA = "0x1CE1590")] get
      {
        return new SuspendResumeTypeEnum();
      }
      [Token(Token = "0x600C813"), Address(RVA = "0x1CE1598", Offset = "0x1CE1598", VA = "0x1CE1598")] private set
      {
      }
    }

    [Token(Token = "0x17002B3B")]
    public PlayerWeaponOptionChangePending WeaponOptionPending
    {
      [Token(Token = "0x600C814"), Address(RVA = "0x1CE15A0", Offset = "0x1CE15A0", VA = "0x1CE15A0")] get
      {
        return (PlayerWeaponOptionChangePending) null;
      }
      [Token(Token = "0x600C815"), Address(RVA = "0x1CE15A8", Offset = "0x1CE15A8", VA = "0x1CE15A8")] private set
      {
      }
    }

    [Token(Token = "0x17002B3C")]
    public PlayerAccessoriesOptionChangePending AccessoryOptionPending
    {
      [Token(Token = "0x600C816"), Address(RVA = "0x1CE15B0", Offset = "0x1CE15B0", VA = "0x1CE15B0")] get
      {
        return (PlayerAccessoriesOptionChangePending) null;
      }
      [Token(Token = "0x600C817"), Address(RVA = "0x1CE15B8", Offset = "0x1CE15B8", VA = "0x1CE15B8")] private set
      {
      }
    }

    [Token(Token = "0x17002B3D")]
    public bool IsNotExist
    {
      [Token(Token = "0x600C818"), Address(RVA = "0x1CE15C0", Offset = "0x1CE15C0", VA = "0x1CE15C0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600C819")]
    [Address(RVA = "0x1CE1604", Offset = "0x1CE1604", VA = "0x1CE1604")]
    public bool TryGetWeaponOptionPending(out PlayerWeaponOptionChangePending pending)
    {
      return new bool();
    }

    [Token(Token = "0x600C81A")]
    [Address(RVA = "0x1CE1674", Offset = "0x1CE1674", VA = "0x1CE1674")]
    public bool TryGetAccessoryOptionPending(out PlayerAccessoriesOptionChangePending pending)
    {
      return new bool();
    }

    [Token(Token = "0x600C81B")]
    [Address(RVA = "0x1CE16E4", Offset = "0x1CE16E4", VA = "0x1CE16E4")]
    public void Apply(APIPlayerSigninResponse response)
    {
    }

    [Token(Token = "0x600C81C")]
    [Address(RVA = "0x1CE1710", Offset = "0x1CE1710", VA = "0x1CE1710")]
    public void Reset()
    {
    }

    [Token(Token = "0x600C81D")]
    [Address(RVA = "0x1CE1720", Offset = "0x1CE1720", VA = "0x1CE1720")]
    public SuspendResumeData()
    {
    }
  }
}
