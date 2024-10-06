// Decompiled with JetBrains decompiler
// Type: UnitEquipmentView.UI.Element
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace UnitEquipmentView.UI
{
  [Token(Token = "0x2000448")]
  public struct Element
  {
    [Token(Token = "0x170002DA")]
    public string Name
    {
      [Token(Token = "0x600184C"), Address(RVA = "0x2490570", Offset = "0x2490570", VA = "0x2490570")] readonly get
      {
        return (string) null;
      }
      [Token(Token = "0x600184D"), Address(RVA = "0x2490578", Offset = "0x2490578", VA = "0x2490578")] private set
      {
      }
    }

    [Token(Token = "0x170002DB")]
    public string ColorCode
    {
      [Token(Token = "0x600184E"), Address(RVA = "0x2490580", Offset = "0x2490580", VA = "0x2490580")] readonly get
      {
        return (string) null;
      }
      [Token(Token = "0x600184F"), Address(RVA = "0x2490588", Offset = "0x2490588", VA = "0x2490588")] private set
      {
      }
    }

    [Token(Token = "0x6001850")]
    [Address(RVA = "0x2490590", Offset = "0x2490590", VA = "0x2490590")]
    private Element(string name, string colorCode)
    {
    }

    [Token(Token = "0x6001851")]
    [Address(RVA = "0x2490598", Offset = "0x2490598", VA = "0x2490598")]
    public static Element Create(Element.NatureType nature) => new Element();

    [Token(Token = "0x6001852")]
    [Address(RVA = "0x249068C", Offset = "0x249068C", VA = "0x249068C")]
    public static Element Create(Element.AttackType attack) => new Element();

    [Token(Token = "0x6001853")]
    [Address(RVA = "0x24904D0", Offset = "0x24904D0", VA = "0x24904D0")]
    public static Element RandomNatureElementData() => new Element();

    [Token(Token = "0x6001854")]
    [Address(RVA = "0x2490430", Offset = "0x2490430", VA = "0x2490430")]
    public static Element RandomAttackElementData() => new Element();

    [Token(Token = "0x6001855")]
    [Address(RVA = "0x2490780", Offset = "0x2490780", VA = "0x2490780")]
    private static Element ChoiceRandom(Element[] elements) => new Element();

    [Token(Token = "0x2000449")]
    public enum NatureType
    {
      [Token(Token = "0x40017C8")] Fire,
      [Token(Token = "0x40017C9")] Water,
      [Token(Token = "0x40017CA")] Wind,
    }

    [Token(Token = "0x200044A")]
    public enum AttackType
    {
      [Token(Token = "0x40017CC")] Slash,
      [Token(Token = "0x40017CD")] Spear,
      [Token(Token = "0x40017CE")] Strength,
    }
  }
}
