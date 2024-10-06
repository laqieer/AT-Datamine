// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.ConsumableMaterialList.ItemGroup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Scenes.OutGame.OutGameMenu.ConsumableMaterialList
{
  [Token(Token = "0x2003BED")]
  public class ItemGroup
  {
    [Token(Token = "0x401098C")]
    [FieldOffset(Offset = "0x18")]
    private List<ItemParam> _items;

    [Token(Token = "0x60178DF")]
    [Address(RVA = "0x237A080", Offset = "0x237A080", VA = "0x237A080")]
    public ItemGroup(string name, List<ItemParam> items)
    {
    }

    [Token(Token = "0x17004C80")]
    public string Name
    {
      [Token(Token = "0x60178E0"), Address(RVA = "0x237A0AC", Offset = "0x237A0AC", VA = "0x237A0AC")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17004C81")]
    public IReadOnlyList<ItemParam> ItemList
    {
      [Token(Token = "0x60178E1"), Address(RVA = "0x237A0B4", Offset = "0x237A0B4", VA = "0x237A0B4")] get
      {
        return (IReadOnlyList<ItemParam>) null;
      }
    }

    [Token(Token = "0x17004C82")]
    public int ItemCount
    {
      [Token(Token = "0x60178E2"), Address(RVA = "0x2378F54", Offset = "0x2378F54", VA = "0x2378F54")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004C83")]
    public bool ItemEmpty
    {
      [Token(Token = "0x60178E3"), Address(RVA = "0x237A0BC", Offset = "0x237A0BC", VA = "0x237A0BC")] get
      {
        return new bool();
      }
    }
  }
}
