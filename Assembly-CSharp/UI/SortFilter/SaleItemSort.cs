// Decompiled with JetBrains decompiler
// Type: UI.SortFilter.SaleItemSort
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Scenes.OutGame;
using System.Collections.Generic;

#nullable disable
namespace UI.SortFilter
{
  [Token(Token = "0x2000921")]
  public static class SaleItemSort
  {
    [Token(Token = "0x6003364")]
    [Address(RVA = "0x3626DC0", Offset = "0x3626DC0", VA = "0x3626DC0")]
    public static SaleItemSortPopup.SaleSortType GetCurrentSortCondition()
    {
      return new SaleItemSortPopup.SaleSortType();
    }

    [Token(Token = "0x6003365")]
    [Address(RVA = "0x3626E48", Offset = "0x3626E48", VA = "0x3626E48")]
    public static string GetCurrenttLocalizedSorText() => (string) null;

    [Token(Token = "0x6003366")]
    [Address(RVA = "0x3626E58", Offset = "0x3626E58", VA = "0x3626E58")]
    public static void Sort(
      SaleItemSortPopup.SaleSortType saleSortType,
      bool isSortOrder,
      ref Dictionary<int, List<ItemListData>> categoryItemMap)
    {
    }
  }
}
