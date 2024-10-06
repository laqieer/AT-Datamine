// Decompiled with JetBrains decompiler
// Type: Story.Adv.LuaObjects.LotteryItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MoonSharp.Interpreter;

#nullable disable
namespace Story.Adv.LuaObjects
{
  [Token(Token = "0x200075E")]
  [MoonSharpUserData]
  public class LotteryItem : MenuItem
  {
    [Token(Token = "0x40021BC")]
    [FieldOffset(Offset = "0x21")]
    public bool IsCharacterSelectable;
    [Token(Token = "0x40021BD")]
    [FieldOffset(Offset = "0x24")]
    public int RelationShipPoint;

    [Token(Token = "0x600295D")]
    [Address(RVA = "0x367C438", Offset = "0x367C438", VA = "0x367C438")]
    public LotteryItem()
    {
    }
  }
}
