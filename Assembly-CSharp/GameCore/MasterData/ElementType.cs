// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ElementType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200143E")]
  public class ElementType
  {
    [Token(Token = "0x4005D56")]
    [FieldOffset(Offset = "0x0")]
    public static Dictionary<ElementType, ElementTypeEnum> ElementTypeDic;
    [Token(Token = "0x4005D57")]
    [FieldOffset(Offset = "0x8")]
    public static Dictionary<ElementType, AttackTypeEnum> AttackTypeDic;
    [Token(Token = "0x4005D58")]
    [FieldOffset(Offset = "0x10")]
    public static Dictionary<ElementType, BattleBadStatusTypeEnum> BadStatusTypeDic;

    [Token(Token = "0x17001147")]
    public string Name
    {
      [Token(Token = "0x60071D6"), Address(RVA = "0x404C6B0", Offset = "0x404C6B0", VA = "0x404C6B0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x60071D7"), Address(RVA = "0x404C6B8", Offset = "0x404C6B8", VA = "0x404C6B8")] private set
      {
      }
    }

    [Token(Token = "0x60071D8")]
    [Address(RVA = "0x404C6C0", Offset = "0x404C6C0", VA = "0x404C6C0")]
    public string GetName() => (string) null;

    [Token(Token = "0x17001148")]
    public static ElementType Fire
    {
      [Token(Token = "0x60071D9"), Address(RVA = "0x404A720", Offset = "0x404A720", VA = "0x404A720")] get
      {
        return (ElementType) null;
      }
    }

    [Token(Token = "0x17001149")]
    public static ElementType Ice
    {
      [Token(Token = "0x60071DA"), Address(RVA = "0x404A7D4", Offset = "0x404A7D4", VA = "0x404A7D4")] get
      {
        return (ElementType) null;
      }
    }

    [Token(Token = "0x1700114A")]
    public static ElementType Thunder
    {
      [Token(Token = "0x60071DB"), Address(RVA = "0x404A864", Offset = "0x404A864", VA = "0x404A864")] get
      {
        return (ElementType) null;
      }
    }

    [Token(Token = "0x1700114B")]
    public static ElementType Wind
    {
      [Token(Token = "0x60071DC"), Address(RVA = "0x404A8F4", Offset = "0x404A8F4", VA = "0x404A8F4")] get
      {
        return (ElementType) null;
      }
    }

    [Token(Token = "0x1700114C")]
    public static ElementType Light
    {
      [Token(Token = "0x60071DD"), Address(RVA = "0x404A984", Offset = "0x404A984", VA = "0x404A984")] get
      {
        return (ElementType) null;
      }
    }

    [Token(Token = "0x1700114D")]
    public static ElementType Dark
    {
      [Token(Token = "0x60071DE"), Address(RVA = "0x404AA14", Offset = "0x404AA14", VA = "0x404AA14")] get
      {
        return (ElementType) null;
      }
    }

    [Token(Token = "0x1700114E")]
    public static ElementType Slash
    {
      [Token(Token = "0x60071DF"), Address(RVA = "0x404AAA4", Offset = "0x404AAA4", VA = "0x404AAA4")] get
      {
        return (ElementType) null;
      }
    }

    [Token(Token = "0x1700114F")]
    public static ElementType Blow
    {
      [Token(Token = "0x60071E0"), Address(RVA = "0x404AB34", Offset = "0x404AB34", VA = "0x404AB34")] get
      {
        return (ElementType) null;
      }
    }

    [Token(Token = "0x17001150")]
    public static ElementType Pierce
    {
      [Token(Token = "0x60071E1"), Address(RVA = "0x404ABC4", Offset = "0x404ABC4", VA = "0x404ABC4")] get
      {
        return (ElementType) null;
      }
    }

    [Token(Token = "0x17001151")]
    public static ElementType Shot
    {
      [Token(Token = "0x60071E2"), Address(RVA = "0x404AC54", Offset = "0x404AC54", VA = "0x404AC54")] get
      {
        return (ElementType) null;
      }
    }

    [Token(Token = "0x17001152")]
    public static ElementType Magic
    {
      [Token(Token = "0x60071E3"), Address(RVA = "0x404ACE4", Offset = "0x404ACE4", VA = "0x404ACE4")] get
      {
        return (ElementType) null;
      }
    }

    [Token(Token = "0x17001153")]
    public static ElementType Provocation
    {
      [Token(Token = "0x60071E4"), Address(RVA = "0x404AD74", Offset = "0x404AD74", VA = "0x404AD74")] get
      {
        return (ElementType) null;
      }
    }

    [Token(Token = "0x17001154")]
    public static ElementType Confusion
    {
      [Token(Token = "0x60071E5"), Address(RVA = "0x404AE04", Offset = "0x404AE04", VA = "0x404AE04")] get
      {
        return (ElementType) null;
      }
    }

    [Token(Token = "0x17001155")]
    public static ElementType ShakenUp
    {
      [Token(Token = "0x60071E6"), Address(RVA = "0x404AE94", Offset = "0x404AE94", VA = "0x404AE94")] get
      {
        return (ElementType) null;
      }
    }

    [Token(Token = "0x17001156")]
    public static ElementType Charmed
    {
      [Token(Token = "0x60071E7"), Address(RVA = "0x404AF24", Offset = "0x404AF24", VA = "0x404AF24")] get
      {
        return (ElementType) null;
      }
    }

    [Token(Token = "0x17001157")]
    public static ElementType Berserk
    {
      [Token(Token = "0x60071E8"), Address(RVA = "0x404AFB4", Offset = "0x404AFB4", VA = "0x404AFB4")] get
      {
        return (ElementType) null;
      }
    }

    [Token(Token = "0x17001158")]
    public static ElementType Burned
    {
      [Token(Token = "0x60071E9"), Address(RVA = "0x404B044", Offset = "0x404B044", VA = "0x404B044")] get
      {
        return (ElementType) null;
      }
    }

    [Token(Token = "0x17001159")]
    public static ElementType Sleep
    {
      [Token(Token = "0x60071EA"), Address(RVA = "0x404B0D4", Offset = "0x404B0D4", VA = "0x404B0D4")] get
      {
        return (ElementType) null;
      }
    }

    [Token(Token = "0x1700115A")]
    public static ElementType Paralysis
    {
      [Token(Token = "0x60071EB"), Address(RVA = "0x404B164", Offset = "0x404B164", VA = "0x404B164")] get
      {
        return (ElementType) null;
      }
    }

    [Token(Token = "0x1700115B")]
    public static ElementType Poison
    {
      [Token(Token = "0x60071EC"), Address(RVA = "0x404B1F4", Offset = "0x404B1F4", VA = "0x404B1F4")] get
      {
        return (ElementType) null;
      }
    }

    [Token(Token = "0x1700115C")]
    public static ElementType Bleeding
    {
      [Token(Token = "0x60071ED"), Address(RVA = "0x404B284", Offset = "0x404B284", VA = "0x404B284")] get
      {
        return (ElementType) null;
      }
    }

    [Token(Token = "0x1700115D")]
    public static ElementType Dazzlement
    {
      [Token(Token = "0x60071EE"), Address(RVA = "0x404B314", Offset = "0x404B314", VA = "0x404B314")] get
      {
        return (ElementType) null;
      }
    }

    [Token(Token = "0x1700115E")]
    public static ElementType Darkness
    {
      [Token(Token = "0x60071EF"), Address(RVA = "0x404B3A4", Offset = "0x404B3A4", VA = "0x404B3A4")] get
      {
        return (ElementType) null;
      }
    }

    [Token(Token = "0x1700115F")]
    public static ElementType Petrifaction
    {
      [Token(Token = "0x60071F0"), Address(RVA = "0x404B434", Offset = "0x404B434", VA = "0x404B434")] get
      {
        return (ElementType) null;
      }
    }

    [Token(Token = "0x17001160")]
    public static ElementType DontAction
    {
      [Token(Token = "0x60071F1"), Address(RVA = "0x404B4C4", Offset = "0x404B4C4", VA = "0x404B4C4")] get
      {
        return (ElementType) null;
      }
    }

    [Token(Token = "0x17001161")]
    public static ElementType DontMove
    {
      [Token(Token = "0x60071F2"), Address(RVA = "0x404B554", Offset = "0x404B554", VA = "0x404B554")] get
      {
        return (ElementType) null;
      }
    }

    [Token(Token = "0x17001162")]
    public static ElementType DontUseSkill
    {
      [Token(Token = "0x60071F3"), Address(RVA = "0x404B5E4", Offset = "0x404B5E4", VA = "0x404B5E4")] get
      {
        return (ElementType) null;
      }
    }

    [Token(Token = "0x17001163")]
    public static ElementType Doom
    {
      [Token(Token = "0x60071F4"), Address(RVA = "0x404B674", Offset = "0x404B674", VA = "0x404B674")] get
      {
        return (ElementType) null;
      }
    }

    [Token(Token = "0x17001164")]
    public static ElementType MoveInfantry
    {
      [Token(Token = "0x60071F5"), Address(RVA = "0x404BB44", Offset = "0x404BB44", VA = "0x404BB44")] get
      {
        return (ElementType) null;
      }
    }

    [Token(Token = "0x17001165")]
    public static ElementType Fly
    {
      [Token(Token = "0x60071F6"), Address(RVA = "0x404BC40", Offset = "0x404BC40", VA = "0x404BC40")] get
      {
        return (ElementType) null;
      }
    }

    [Token(Token = "0x17001166")]
    public static ElementType Equestrian
    {
      [Token(Token = "0x60071F7"), Address(RVA = "0x404BBD4", Offset = "0x404BBD4", VA = "0x404BBD4")] get
      {
        return (ElementType) null;
      }
    }

    [Token(Token = "0x17001167")]
    public static ElementType Floating
    {
      [Token(Token = "0x60071F8"), Address(RVA = "0x404BCAC", Offset = "0x404BCAC", VA = "0x404BCAC")] get
      {
        return (ElementType) null;
      }
    }

    [Token(Token = "0x17001168")]
    public static ElementType ArmorHeavy
    {
      [Token(Token = "0x60071F9"), Address(RVA = "0x404BD84", Offset = "0x404BD84", VA = "0x404BD84")] get
      {
        return (ElementType) null;
      }
    }

    [Token(Token = "0x17001169")]
    public static ElementType ArmorLight
    {
      [Token(Token = "0x60071FA"), Address(RVA = "0x404BDF0", Offset = "0x404BDF0", VA = "0x404BDF0")] get
      {
        return (ElementType) null;
      }
    }

    [Token(Token = "0x1700116A")]
    public static ElementType ArmorNormal
    {
      [Token(Token = "0x60071FB"), Address(RVA = "0x404BD18", Offset = "0x404BD18", VA = "0x404BD18")] get
      {
        return (ElementType) null;
      }
    }

    [Token(Token = "0x1700116B")]
    public static ElementType RideInfantry
    {
      [Token(Token = "0x60071FC"), Address(RVA = "0x404BE5C", Offset = "0x404BE5C", VA = "0x404BE5C")] get
      {
        return (ElementType) null;
      }
    }

    [Token(Token = "0x1700116C")]
    public static ElementType Cavalry
    {
      [Token(Token = "0x60071FD"), Address(RVA = "0x404BEC8", Offset = "0x404BEC8", VA = "0x404BEC8")] get
      {
        return (ElementType) null;
      }
    }

    [Token(Token = "0x1700116D")]
    public static ElementType RideBeast
    {
      [Token(Token = "0x60071FE"), Address(RVA = "0x404BF34", Offset = "0x404BF34", VA = "0x404BF34")] get
      {
        return (ElementType) null;
      }
    }

    [Token(Token = "0x1700116E")]
    public static ElementType Human
    {
      [Token(Token = "0x60071FF"), Address(RVA = "0x404BFA0", Offset = "0x404BFA0", VA = "0x404BFA0")] get
      {
        return (ElementType) null;
      }
    }

    [Token(Token = "0x1700116F")]
    public static ElementType Dragon
    {
      [Token(Token = "0x6007200"), Address(RVA = "0x404C00C", Offset = "0x404C00C", VA = "0x404C00C")] get
      {
        return (ElementType) null;
      }
    }

    [Token(Token = "0x17001170")]
    public static ElementType SpeciesBeast
    {
      [Token(Token = "0x6007201"), Address(RVA = "0x404C078", Offset = "0x404C078", VA = "0x404C078")] get
      {
        return (ElementType) null;
      }
    }

    [Token(Token = "0x17001171")]
    public static ElementType Barbaroy
    {
      [Token(Token = "0x6007202"), Address(RVA = "0x404C0E4", Offset = "0x404C0E4", VA = "0x404C0E4")] get
      {
        return (ElementType) null;
      }
    }

    [Token(Token = "0x17001172")]
    public static ElementType God
    {
      [Token(Token = "0x6007203"), Address(RVA = "0x404C150", Offset = "0x404C150", VA = "0x404C150")] get
      {
        return (ElementType) null;
      }
    }

    [Token(Token = "0x17001173")]
    public static ElementType Evil
    {
      [Token(Token = "0x6007204"), Address(RVA = "0x404C1BC", Offset = "0x404C1BC", VA = "0x404C1BC")] get
      {
        return (ElementType) null;
      }
    }

    [Token(Token = "0x6007205")]
    [Address(RVA = "0x404C6C8", Offset = "0x404C6C8", VA = "0x404C6C8")]
    public ElementType()
    {
    }

    [Token(Token = "0x6007206")]
    [Address(RVA = "0x404C6D0", Offset = "0x404C6D0", VA = "0x404C6D0")]
    static ElementType()
    {
    }
  }
}
