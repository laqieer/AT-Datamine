// Decompiled with JetBrains decompiler
// Type: UI.ItemDetail.ItemDetailRecommendModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using StaqData;
using System;
using System.Collections.Generic;

#nullable disable
namespace UI.ItemDetail
{
  [Token(Token = "0x20008D2")]
  public class ItemDetailRecommendModel
  {
    [Token(Token = "0x4002963")]
    private const int TakeCountSingle = 20;
    [Token(Token = "0x4002964")]
    private const int TakeCountMulti = 10;
    [Token(Token = "0x4002965")]
    private const int TakeAllQuestLock = 1;
    [Token(Token = "0x4002966")]
    [FieldOffset(Offset = "0x10")]
    private List<ItemDetailRecommendModel.IContent> _contents;
    [Token(Token = "0x4002967")]
    [FieldOffset(Offset = "0x18")]
    private bool _isEventLock;
    [Token(Token = "0x4002968")]
    [FieldOffset(Offset = "0x20")]
    private string _eventLockedName;

    [Token(Token = "0x6003210")]
    [Address(RVA = "0x3C1E618", Offset = "0x3C1E618", VA = "0x3C1E618")]
    public ItemDetailRecommendModel(
      ItemTypeEnum itemType,
      int itemId,
      IReadOnlyList<ItemSupplierSearcher.ISearchResult> searchResults = null)
    {
    }

    [Token(Token = "0x6003211")]
    [Address(RVA = "0x3C1F1F8", Offset = "0x3C1F1F8", VA = "0x3C1F1F8")]
    private ItemDetailRecommendModel.IContent CreateContent(ItemSupplierSearcher.Quest quest)
    {
      return (ItemDetailRecommendModel.IContent) null;
    }

    [Token(Token = "0x6003212")]
    [Address(RVA = "0x3C1F754", Offset = "0x3C1F754", VA = "0x3C1F754")]
    private (string, bool) GetStatus(QuestInfo questInfo) => ();

    [Token(Token = "0x6003213")]
    [Address(RVA = "0x3C1F43C", Offset = "0x3C1F43C", VA = "0x3C1F43C")]
    private ItemDetailRecommendModel.IContent CreateContent(
      ItemSupplierSearcher.Expedition expedition,
      ItemTypeEnum itemType,
      int itemId)
    {
      return (ItemDetailRecommendModel.IContent) null;
    }

    [Token(Token = "0x6003214")]
    [Address(RVA = "0x3C1F828", Offset = "0x3C1F828", VA = "0x3C1F828")]
    private string GetTitle(
      ItemSupplierSearcher.Expedition expedition,
      ItemTypeEnum itemType,
      int itemId)
    {
      return (string) null;
    }

    [Token(Token = "0x6003215")]
    [Address(RVA = "0x3C1F4C4", Offset = "0x3C1F4C4", VA = "0x3C1F4C4")]
    private ItemDetailRecommendModel.IContent CreateContent(
      ItemSupplierSearcher.ExpeditionBoss expeditionBoss)
    {
      return (ItemDetailRecommendModel.IContent) null;
    }

    [Token(Token = "0x6003216")]
    [Address(RVA = "0x3C1F98C", Offset = "0x3C1F98C", VA = "0x3C1F98C")]
    private string GetTitle(ItemSupplierSearcher.ExpeditionBoss expeditionBoss) => (string) null;

    [Token(Token = "0x6003217")]
    [Address(RVA = "0x3C1F534", Offset = "0x3C1F534", VA = "0x3C1F534")]
    private ItemDetailRecommendModel.IContent CreateContent(
      ItemSupplierSearcher.MedalTrade medalTrade)
    {
      return (ItemDetailRecommendModel.IContent) null;
    }

    [Token(Token = "0x1700073B")]
    public bool IsEmpty
    {
      [Token(Token = "0x6003218"), Address(RVA = "0x3C1FB6C", Offset = "0x3C1FB6C", VA = "0x3C1FB6C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6003219")]
    [Address(RVA = "0x3C1FBC0", Offset = "0x3C1FBC0", VA = "0x3C1FBC0")]
    public void ApplyView(
      Action<IReadOnlyList<ItemDetailRecommendModel.IContent>> callback)
    {
    }

    [Token(Token = "0x600321A")]
    [Address(RVA = "0x3C1EF5C", Offset = "0x3C1EF5C", VA = "0x3C1EF5C")]
    private IEnumerable<ItemSupplierSearcher.ISearchResult> Sort(
      IReadOnlyList<ItemSupplierSearcher.ISearchResult> searchDatas)
    {
      return (IEnumerable<ItemSupplierSearcher.ISearchResult>) null;
    }

    [Token(Token = "0x1700073C")]
    private List<int> ElementToPriority
    {
      [Token(Token = "0x600321B"), Address(RVA = "0x3C1FC48", Offset = "0x3C1FC48", VA = "0x3C1FC48")] get
      {
        return (List<int>) null;
      }
    }

    [Token(Token = "0x600321C")]
    [Address(RVA = "0x3C1F638", Offset = "0x3C1F638", VA = "0x3C1F638")]
    private string GetTitle(ItemSupplierSearcher.SortCategory category) => (string) null;

    [Token(Token = "0x600321D")]
    [Address(RVA = "0x3C1EEEC", Offset = "0x3C1EEEC", VA = "0x3C1EEEC")]
    private string GetText(string key) => (string) null;

    [Token(Token = "0x20008D3")]
    public interface IContent
    {
      [Token(Token = "0x1700073D")]
      string Title { [Token(Token = "0x600321E")] get; }
    }

    [Token(Token = "0x20008D4")]
    public interface IStatus
    {
      [Token(Token = "0x1700073E")]
      bool IsLock { [Token(Token = "0x600321F")] get; }
    }

    [Token(Token = "0x20008D5")]
    public struct Label : ItemDetailRecommendModel.IContent
    {
      [Token(Token = "0x1700073F")]
      public string Title
      {
        [Token(Token = "0x6003220"), Address(RVA = "0x3C1FF30", Offset = "0x3C1FF30", VA = "0x3C1FF30", Slot = "4")] readonly get
        {
          return (string) null;
        }
        [Token(Token = "0x6003221"), Address(RVA = "0x3C1FF38", Offset = "0x3C1FF38", VA = "0x3C1FF38")] set
        {
        }
      }
    }

    [Token(Token = "0x20008D6")]
    public struct Quest : ItemDetailRecommendModel.IContent, ItemDetailRecommendModel.IStatus
    {
      [Token(Token = "0x400296C")]
      [FieldOffset(Offset = "0x10")]
      public ItemSupplierSearcher.Quest Data;
      [Token(Token = "0x400296D")]
      [FieldOffset(Offset = "0x18")]
      public bool DropRewars;
      [Token(Token = "0x400296E")]
      [FieldOffset(Offset = "0x19")]
      public bool ClearRewars;
      [Token(Token = "0x400296F")]
      [FieldOffset(Offset = "0x1A")]
      public bool CanSkip;
      [Token(Token = "0x4002970")]
      [FieldOffset(Offset = "0x1C")]
      public int? ConsumeAp;
      [Token(Token = "0x4002971")]
      [FieldOffset(Offset = "0x24")]
      public int? ConsumeEp;
      [Token(Token = "0x4002972")]
      [FieldOffset(Offset = "0x2C")]
      public QuestDifficultyTypeEnum? DifficultyType;

      [Token(Token = "0x17000740")]
      public string Title
      {
        [Token(Token = "0x6003222"), Address(RVA = "0x3C1FF40", Offset = "0x3C1FF40", VA = "0x3C1FF40", Slot = "4")] readonly get
        {
          return (string) null;
        }
        [Token(Token = "0x6003223"), Address(RVA = "0x3C1FF48", Offset = "0x3C1FF48", VA = "0x3C1FF48")] set
        {
        }
      }

      [Token(Token = "0x17000741")]
      public bool IsLock
      {
        [Token(Token = "0x6003224"), Address(RVA = "0x3C1FF50", Offset = "0x3C1FF50", VA = "0x3C1FF50", Slot = "5")] readonly get
        {
          return new bool();
        }
        [Token(Token = "0x6003225"), Address(RVA = "0x3C1FF58", Offset = "0x3C1FF58", VA = "0x3C1FF58")] set
        {
        }
      }
    }

    [Token(Token = "0x20008D7")]
    public struct LockedQuest : ItemDetailRecommendModel.IContent
    {
      [Token(Token = "0x17000742")]
      public string Title
      {
        [Token(Token = "0x6003226"), Address(RVA = "0x3C1FF64", Offset = "0x3C1FF64", VA = "0x3C1FF64", Slot = "4")] readonly get
        {
          return (string) null;
        }
        [Token(Token = "0x6003227"), Address(RVA = "0x3C1FF6C", Offset = "0x3C1FF6C", VA = "0x3C1FF6C")] set
        {
        }
      }
    }

    [Token(Token = "0x20008D8")]
    public struct Expedition : ItemDetailRecommendModel.IContent, ItemDetailRecommendModel.IStatus
    {
      [Token(Token = "0x4002976")]
      [FieldOffset(Offset = "0x10")]
      public ItemSupplierSearcher.Expedition Data;

      [Token(Token = "0x17000743")]
      public string Title
      {
        [Token(Token = "0x6003228"), Address(RVA = "0x3C1FF74", Offset = "0x3C1FF74", VA = "0x3C1FF74", Slot = "4")] readonly get
        {
          return (string) null;
        }
        [Token(Token = "0x6003229"), Address(RVA = "0x3C1FF7C", Offset = "0x3C1FF7C", VA = "0x3C1FF7C")] set
        {
        }
      }

      [Token(Token = "0x17000744")]
      public bool IsLock
      {
        [Token(Token = "0x600322A"), Address(RVA = "0x3C1FF84", Offset = "0x3C1FF84", VA = "0x3C1FF84", Slot = "5")] readonly get
        {
          return new bool();
        }
        [Token(Token = "0x600322B"), Address(RVA = "0x3C1FF8C", Offset = "0x3C1FF8C", VA = "0x3C1FF8C")] set
        {
        }
      }
    }

    [Token(Token = "0x20008D9")]
    public struct ExpeditionBoss : 
      ItemDetailRecommendModel.IContent,
      ItemDetailRecommendModel.IStatus
    {
      [Token(Token = "0x4002979")]
      [FieldOffset(Offset = "0x10")]
      public ItemSupplierSearcher.ExpeditionBoss Data;

      [Token(Token = "0x17000745")]
      public string Title
      {
        [Token(Token = "0x600322C"), Address(RVA = "0x3C1FF98", Offset = "0x3C1FF98", VA = "0x3C1FF98", Slot = "4")] readonly get
        {
          return (string) null;
        }
        [Token(Token = "0x600322D"), Address(RVA = "0x3C1FFA0", Offset = "0x3C1FFA0", VA = "0x3C1FFA0")] set
        {
        }
      }

      [Token(Token = "0x17000746")]
      public bool IsLock
      {
        [Token(Token = "0x600322E"), Address(RVA = "0x3C1FFA8", Offset = "0x3C1FFA8", VA = "0x3C1FFA8", Slot = "5")] readonly get
        {
          return new bool();
        }
        [Token(Token = "0x600322F"), Address(RVA = "0x3C1FFB0", Offset = "0x3C1FFB0", VA = "0x3C1FFB0")] set
        {
        }
      }
    }

    [Token(Token = "0x20008DA")]
    public struct MedalTrade : ItemDetailRecommendModel.IContent, ItemDetailRecommendModel.IStatus
    {
      [Token(Token = "0x400297C")]
      [FieldOffset(Offset = "0x10")]
      public ItemSupplierSearcher.MedalTrade Data;

      [Token(Token = "0x17000747")]
      public string Title
      {
        [Token(Token = "0x6003230"), Address(RVA = "0x3C1FFBC", Offset = "0x3C1FFBC", VA = "0x3C1FFBC", Slot = "4")] readonly get
        {
          return (string) null;
        }
        [Token(Token = "0x6003231"), Address(RVA = "0x3C1FFC4", Offset = "0x3C1FFC4", VA = "0x3C1FFC4")] set
        {
        }
      }

      [Token(Token = "0x17000748")]
      public bool IsLock
      {
        [Token(Token = "0x6003232"), Address(RVA = "0x3C1FFCC", Offset = "0x3C1FFCC", VA = "0x3C1FFCC", Slot = "5")] readonly get
        {
          return new bool();
        }
        [Token(Token = "0x6003233"), Address(RVA = "0x3C1FFD4", Offset = "0x3C1FFD4", VA = "0x3C1FFD4")] set
        {
        }
      }
    }
  }
}
