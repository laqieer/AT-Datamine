// Decompiled with JetBrains decompiler
// Type: Gacha.GachaTabTypeExtension
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Gacha
{
  [Token(Token = "0x200150D")]
  internal static class GachaTabTypeExtension
  {
    [Token(Token = "0x6007735")]
    [Address(RVA = "0x44F07C8", Offset = "0x44F07C8", VA = "0x44F07C8")]
    public static GachaPayButtonGroupType ToGroupType(this GachaTabType gachaTabType)
    {
      return new GachaPayButtonGroupType();
    }
  }
}
