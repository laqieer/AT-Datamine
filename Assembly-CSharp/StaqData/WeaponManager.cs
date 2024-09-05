// Decompiled with JetBrains decompiler
// Type: StaqData.WeaponManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.Param;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x2002030")]
  public sealed class WeaponManager : Items<System.Collections.Generic.List<PlayerGearWeaponType>, Weapon>
  {
    [Token(Token = "0x600C0C0")]
    [Address(RVA = "0x20107E0", Offset = "0x20107E0", VA = "0x20107E0", Slot = "6")]
    public override void Apply(System.Collections.Generic.List<PlayerGearWeaponType> entities)
    {
    }

    [Token(Token = "0x600C0C1")]
    [Address(RVA = "0x2009924", Offset = "0x2009924", VA = "0x2009924")]
    public WeaponManager()
    {
    }
  }
}
