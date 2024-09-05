// Decompiled with JetBrains decompiler
// Type: StaqData.WeaponOptionEffect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using Network.Param;
using staq.SaveSchema;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x2002031")]
  public class WeaponOptionEffect : IOptionEffect
  {
    [Token(Token = "0x17002841")]
    public int Slot
    {
      [Token(Token = "0x600C0C3"), Address(RVA = "0x20109B0", Offset = "0x20109B0", VA = "0x20109B0")] get
      {
        return new int();
      }
      [Token(Token = "0x600C0C4"), Address(RVA = "0x20109B8", Offset = "0x20109B8", VA = "0x20109B8")] private set
      {
      }
    }

    [Token(Token = "0x17002842")]
    public int EffectId
    {
      [Token(Token = "0x600C0C5"), Address(RVA = "0x20109C0", Offset = "0x20109C0", VA = "0x20109C0")] get
      {
        return new int();
      }
      [Token(Token = "0x600C0C6"), Address(RVA = "0x20109C8", Offset = "0x20109C8", VA = "0x20109C8")] private set
      {
      }
    }

    [Token(Token = "0x17002843")]
    public float EffectValue
    {
      [Token(Token = "0x600C0C7"), Address(RVA = "0x20109D0", Offset = "0x20109D0", VA = "0x20109D0", Slot = "5")] get
      {
        return new float();
      }
      [Token(Token = "0x600C0C8"), Address(RVA = "0x20109D8", Offset = "0x20109D8", VA = "0x20109D8")] private set
      {
      }
    }

    [Token(Token = "0x17002844")]
    public WeaponOptionData MasterData
    {
      [Token(Token = "0x600C0C9"), Address(RVA = "0x20109E0", Offset = "0x20109E0", VA = "0x20109E0")] get
      {
        return (WeaponOptionData) null;
      }
      [Token(Token = "0x600C0CA"), Address(RVA = "0x20109E8", Offset = "0x20109E8", VA = "0x20109E8")] private set
      {
      }
    }

    [Token(Token = "0x17002845")]
    public string Name
    {
      [Token(Token = "0x600C0CB"), Address(RVA = "0x20109F0", Offset = "0x20109F0", VA = "0x20109F0", Slot = "4")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17002846")]
    public int Grade
    {
      [Token(Token = "0x600C0CC"), Address(RVA = "0x2010A0C", Offset = "0x2010A0C", VA = "0x2010A0C", Slot = "6")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002847")]
    public int IconSpriteId
    {
      [Token(Token = "0x600C0CD"), Address(RVA = "0x2010A28", Offset = "0x2010A28", VA = "0x2010A28", Slot = "7")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002848")]
    public bool IsUnLocked
    {
      [Token(Token = "0x600C0CE"), Address(RVA = "0x2010AB0", Offset = "0x2010AB0", VA = "0x2010AB0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600C0CF")]
    [Address(RVA = "0x20104F8", Offset = "0x20104F8", VA = "0x20104F8")]
    public WeaponOptionEffect(PlayerGearOptionType entity)
    {
    }

    [Token(Token = "0x600C0D0")]
    [Address(RVA = "0x2010AD4", Offset = "0x2010AD4", VA = "0x2010AD4")]
    public WeaponOptionEffect(EquipmentOption schema)
    {
    }

    [Token(Token = "0x600C0D1")]
    [Address(RVA = "0x2010BC0", Offset = "0x2010BC0", VA = "0x2010BC0")]
    public string ToJson() => (string) null;
  }
}
