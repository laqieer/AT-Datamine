// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ItemSupplierSearcher
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001411")]
  public class ItemSupplierSearcher
  {
    [Token(Token = "0x4005CF8")]
    [FieldOffset(Offset = "0x10")]
    private MonoBehaviour _coroutineController;
    [Token(Token = "0x4005CF9")]
    [FieldOffset(Offset = "0x18")]
    private Coroutine _waitFindAllCoroutine;
    [Token(Token = "0x4005CFA")]
    [FieldOffset(Offset = "0x20")]
    private Dictionary<(ItemTypeEnum itemType, int id), (IEnumerator e, CancellationTokenSource cts, Func<bool> checkCancel)> _findCoroutines;
    [Token(Token = "0x4005CFB")]
    [FieldOffset(Offset = "0x28")]
    private Dictionary<ItemTypeEnum, RewardTypeEnum> _observedItemType;
    [Token(Token = "0x4005CFC")]
    [FieldOffset(Offset = "0x30")]
    private Dictionary<ItemTypeEnum, Dictionary<int, List<ItemSupplierSearcher.ISearchResult>>> _results;

    [Token(Token = "0x600710F")]
    [Address(RVA = "0x4041F94", Offset = "0x4041F94", VA = "0x4041F94")]
    public void Reset()
    {
    }

    [Token(Token = "0x6007110")]
    [Address(RVA = "0x4042234", Offset = "0x4042234", VA = "0x4042234")]
    public void RequestFindAsync(
      MonoBehaviour coroutineController,
      ItemTypeEnum itemType,
      int id,
      Action<IReadOnlyList<ItemSupplierSearcher.ISearchResult>> callback,
      Func<bool> checkCancel = null)
    {
    }

    [Token(Token = "0x6007111")]
    [Address(RVA = "0x4042AAC", Offset = "0x4042AAC", VA = "0x4042AAC")]
    public void Close()
    {
    }

    [Token(Token = "0x6007112")]
    [Address(RVA = "0x4042A44", Offset = "0x4042A44", VA = "0x4042A44")]
    private IEnumerator WaitFindAll() => (IEnumerator) null;

    [Token(Token = "0x6007113")]
    [Address(RVA = "0x40429B4", Offset = "0x40429B4", VA = "0x40429B4")]
    private IEnumerator FindAsync(
      CancellationToken token,
      ItemTypeEnum itemType,
      int id,
      Action<IReadOnlyList<ItemSupplierSearcher.ISearchResult>> callback)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6007114")]
    [Address(RVA = "0x4042924", Offset = "0x4042924", VA = "0x4042924")]
    private IEnumerator WaitFind(
      ItemTypeEnum itemType,
      int id,
      Action<IReadOnlyList<ItemSupplierSearcher.ISearchResult>> callback,
      Func<bool> checkCancel)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6007115")]
    [Address(RVA = "0x4042B28", Offset = "0x4042B28", VA = "0x4042B28")]
    private IReadOnlyList<ItemSupplierSearcher.ISearchResult> Sort(
      IEnumerable<ItemSupplierSearcher.ISearchResult> results)
    {
      return (IReadOnlyList<ItemSupplierSearcher.ISearchResult>) null;
    }

    [Token(Token = "0x6007116")]
    [Address(RVA = "0x4042610", Offset = "0x4042610", VA = "0x4042610")]
    private IReadOnlyList<ItemSupplierSearcher.ISearchResult> TryGetResult(
      ItemTypeEnum itemType,
      int itemId)
    {
      return (IReadOnlyList<ItemSupplierSearcher.ISearchResult>) null;
    }

    [Token(Token = "0x6007117")]
    [Address(RVA = "0x40426D0", Offset = "0x40426D0", VA = "0x40426D0")]
    private bool CheckObserved(ItemTypeEnum itemType, int itemId) => new bool();

    [Token(Token = "0x170010ED")]
    private Dictionary<ItemTypeEnum, RewardTypeEnum> ObservedItemType
    {
      [Token(Token = "0x6007118"), Address(RVA = "0x4042C3C", Offset = "0x4042C3C", VA = "0x4042C3C")] get
      {
        return (Dictionary<ItemTypeEnum, RewardTypeEnum>) null;
      }
    }

    [Token(Token = "0x6007119")]
    [Address(RVA = "0x4042D5C", Offset = "0x4042D5C", VA = "0x4042D5C")]
    private ItemTypeEnum? ToObservedItemType(RewardTypeEnum rewardType) => new ItemTypeEnum?();

    [Token(Token = "0x600711A")]
    [Address(RVA = "0x4042E44", Offset = "0x4042E44", VA = "0x4042E44")]
    private IReadOnlyList<ItemSupplierSearcher.ISearchResult> Find(ItemTypeEnum itemType, int id)
    {
      return (IReadOnlyList<ItemSupplierSearcher.ISearchResult>) null;
    }

    [Token(Token = "0x600711B")]
    [Address(RVA = "0x40431A0", Offset = "0x40431A0", VA = "0x40431A0")]
    public ItemSupplierSearcher()
    {
    }

    [Token(Token = "0x2001412")]
    public enum DataType
    {
      [Token(Token = "0x4005CFE")] Quest,
      [Token(Token = "0x4005CFF")] Expedition,
      [Token(Token = "0x4005D00")] ExpeditionBoss,
      [Token(Token = "0x4005D01")] MedalTrade,
    }

    [Token(Token = "0x2001413")]
    public enum SortCategory
    {
      [Token(Token = "0x4005D03")] ScenarioQuestFree = 0,
      [Token(Token = "0x4005D04")] LimitedEvent = 1,
      [Token(Token = "0x4005D05")] Free = 2,
      [Token(Token = "0x4005D06")] AreaQuestMain = 3,
      [Token(Token = "0x4005D07")] MedalTrade = 4,
      [Token(Token = "0x4005D08")] Expedition = 5,
      [Token(Token = "0x4005D09")] ExpeditionBoss = 6,
      [Token(Token = "0x4005D0A")] Unknown = 999, // 0x000003E7
    }

    [Token(Token = "0x2001414")]
    [Flags]
    public enum ObtainedFrom
    {
      [Token(Token = "0x4005D0C")] Clear = 1,
      [Token(Token = "0x4005D0D")] Drop = 2,
    }

    [Token(Token = "0x2001415")]
    public interface ISearchResult
    {
      [Token(Token = "0x170010EE")]
      ItemSupplierSearcher.DataType DataType { [Token(Token = "0x600711C")] get; }

      [Token(Token = "0x170010EF")]
      ItemSupplierSearcher.SortCategory SortCategory { [Token(Token = "0x600711D")] get; }

      [Token(Token = "0x170010F0")]
      int SortKey { [Token(Token = "0x600711E")] get; }

      [Token(Token = "0x170010F1")]
      ItemSupplierSearcher.Quest AsQuest { [Token(Token = "0x600711F")] get; }

      [Token(Token = "0x170010F2")]
      ItemSupplierSearcher.Expedition AsExpedition { [Token(Token = "0x6007120")] get; }

      [Token(Token = "0x170010F3")]
      ItemSupplierSearcher.ExpeditionBoss AsExpeditionBoss { [Token(Token = "0x6007121")] get; }

      [Token(Token = "0x170010F4")]
      ItemSupplierSearcher.MedalTrade AsMedalTrade { [Token(Token = "0x6007122")] get; }
    }

    [Token(Token = "0x2001416")]
    public class Quest : ItemSupplierSearcher.ISearchResult
    {
      [Token(Token = "0x4005D0E")]
      [FieldOffset(Offset = "0x10")]
      private readonly ItemSupplierSearcher.SortCategory _sortCategory;
      [Token(Token = "0x4005D0F")]
      [FieldOffset(Offset = "0x14")]
      private readonly bool _isInEventRoom;
      [Token(Token = "0x4005D10")]
      [FieldOffset(Offset = "0x18")]
      public QuestTypeEnum questType;
      [Token(Token = "0x4005D11")]
      [FieldOffset(Offset = "0x1C")]
      public int questId;
      [Token(Token = "0x4005D12")]
      [FieldOffset(Offset = "0x20")]
      public ItemSupplierSearcher.ObtainedFrom obtainedFrom;

      [Token(Token = "0x170010F5")]
      public ItemSupplierSearcher.DataType DataType
      {
        [Token(Token = "0x6007123"), Address(RVA = "0x4043260", Offset = "0x4043260", VA = "0x4043260", Slot = "4")] get
        {
          return new ItemSupplierSearcher.DataType();
        }
      }

      [Token(Token = "0x170010F6")]
      public ItemSupplierSearcher.Quest AsQuest
      {
        [Token(Token = "0x6007124"), Address(RVA = "0x4043268", Offset = "0x4043268", VA = "0x4043268", Slot = "7")] get
        {
          return (ItemSupplierSearcher.Quest) null;
        }
      }

      [Token(Token = "0x170010F7")]
      public ItemSupplierSearcher.Expedition AsExpedition
      {
        [Token(Token = "0x6007125"), Address(RVA = "0x404326C", Offset = "0x404326C", VA = "0x404326C", Slot = "8")] get
        {
          return (ItemSupplierSearcher.Expedition) null;
        }
      }

      [Token(Token = "0x170010F8")]
      public ItemSupplierSearcher.ExpeditionBoss AsExpeditionBoss
      {
        [Token(Token = "0x6007126"), Address(RVA = "0x4043274", Offset = "0x4043274", VA = "0x4043274", Slot = "9")] get
        {
          return (ItemSupplierSearcher.ExpeditionBoss) null;
        }
      }

      [Token(Token = "0x170010F9")]
      public ItemSupplierSearcher.MedalTrade AsMedalTrade
      {
        [Token(Token = "0x6007127"), Address(RVA = "0x404327C", Offset = "0x404327C", VA = "0x404327C", Slot = "10")] get
        {
          return (ItemSupplierSearcher.MedalTrade) null;
        }
      }

      [Token(Token = "0x170010FA")]
      public int SortKey
      {
        [Token(Token = "0x6007128"), Address(RVA = "0x4043284", Offset = "0x4043284", VA = "0x4043284", Slot = "6")] get
        {
          return new int();
        }
      }

      [Token(Token = "0x170010FB")]
      public ItemSupplierSearcher.SortCategory SortCategory
      {
        [Token(Token = "0x6007129"), Address(RVA = "0x404328C", Offset = "0x404328C", VA = "0x404328C", Slot = "5")] get
        {
          return new ItemSupplierSearcher.SortCategory();
        }
      }

      [Token(Token = "0x600712A")]
      [Address(RVA = "0x4043294", Offset = "0x4043294", VA = "0x4043294")]
      public Quest(ItemSupplierSearcher.SortCategory sortCategory, bool isInEventRoom = true)
      {
      }

      [Token(Token = "0x170010FC")]
      public bool IsInEventRoom
      {
        [Token(Token = "0x600712B"), Address(RVA = "0x40432D4", Offset = "0x40432D4", VA = "0x40432D4")] get
        {
          return new bool();
        }
      }
    }

    [Token(Token = "0x2001417")]
    public class Expedition : ItemSupplierSearcher.ISearchResult
    {
      [Token(Token = "0x4005D13")]
      [FieldOffset(Offset = "0x10")]
      public int stageDescriptionId;

      [Token(Token = "0x170010FD")]
      public ItemSupplierSearcher.DataType DataType
      {
        [Token(Token = "0x600712C"), Address(RVA = "0x40432DC", Offset = "0x40432DC", VA = "0x40432DC", Slot = "4")] get
        {
          return new ItemSupplierSearcher.DataType();
        }
      }

      [Token(Token = "0x170010FE")]
      public ItemSupplierSearcher.SortCategory SortCategory
      {
        [Token(Token = "0x600712D"), Address(RVA = "0x40432E4", Offset = "0x40432E4", VA = "0x40432E4", Slot = "5")] get
        {
          return new ItemSupplierSearcher.SortCategory();
        }
      }

      [Token(Token = "0x170010FF")]
      public int SortKey
      {
        [Token(Token = "0x600712E"), Address(RVA = "0x40432EC", Offset = "0x40432EC", VA = "0x40432EC", Slot = "6")] get
        {
          return new int();
        }
      }

      [Token(Token = "0x17001100")]
      public ItemSupplierSearcher.Quest AsQuest
      {
        [Token(Token = "0x600712F"), Address(RVA = "0x40432F4", Offset = "0x40432F4", VA = "0x40432F4", Slot = "7")] get
        {
          return (ItemSupplierSearcher.Quest) null;
        }
      }

      [Token(Token = "0x17001101")]
      public ItemSupplierSearcher.Expedition AsExpedition
      {
        [Token(Token = "0x6007130"), Address(RVA = "0x40432FC", Offset = "0x40432FC", VA = "0x40432FC", Slot = "8")] get
        {
          return (ItemSupplierSearcher.Expedition) null;
        }
      }

      [Token(Token = "0x17001102")]
      public ItemSupplierSearcher.ExpeditionBoss AsExpeditionBoss
      {
        [Token(Token = "0x6007131"), Address(RVA = "0x4043300", Offset = "0x4043300", VA = "0x4043300", Slot = "9")] get
        {
          return (ItemSupplierSearcher.ExpeditionBoss) null;
        }
      }

      [Token(Token = "0x17001103")]
      public ItemSupplierSearcher.MedalTrade AsMedalTrade
      {
        [Token(Token = "0x6007132"), Address(RVA = "0x4043308", Offset = "0x4043308", VA = "0x4043308", Slot = "10")] get
        {
          return (ItemSupplierSearcher.MedalTrade) null;
        }
      }

      [Token(Token = "0x6007133")]
      [Address(RVA = "0x4043310", Offset = "0x4043310", VA = "0x4043310")]
      public Expedition()
      {
      }
    }

    [Token(Token = "0x2001418")]
    public class ExpeditionSoulSpot : ItemSupplierSearcher.Expedition
    {
      [Token(Token = "0x6007134")]
      [Address(RVA = "0x4043318", Offset = "0x4043318", VA = "0x4043318")]
      public ExpeditionSoulSpot()
      {
      }
    }

    [Token(Token = "0x2001419")]
    public class ExpeditionBoss : ItemSupplierSearcher.ISearchResult
    {
      [Token(Token = "0x4005D14")]
      [FieldOffset(Offset = "0x10")]
      public int bossDescriptionId;

      [Token(Token = "0x17001104")]
      public ItemSupplierSearcher.DataType DataType
      {
        [Token(Token = "0x6007135"), Address(RVA = "0x4043320", Offset = "0x4043320", VA = "0x4043320", Slot = "4")] get
        {
          return new ItemSupplierSearcher.DataType();
        }
      }

      [Token(Token = "0x17001105")]
      public ItemSupplierSearcher.SortCategory SortCategory
      {
        [Token(Token = "0x6007136"), Address(RVA = "0x4043328", Offset = "0x4043328", VA = "0x4043328", Slot = "5")] get
        {
          return new ItemSupplierSearcher.SortCategory();
        }
      }

      [Token(Token = "0x17001106")]
      public int SortKey
      {
        [Token(Token = "0x6007137"), Address(RVA = "0x4043330", Offset = "0x4043330", VA = "0x4043330", Slot = "6")] get
        {
          return new int();
        }
      }

      [Token(Token = "0x17001107")]
      public ItemSupplierSearcher.Quest AsQuest
      {
        [Token(Token = "0x6007138"), Address(RVA = "0x4043338", Offset = "0x4043338", VA = "0x4043338", Slot = "7")] get
        {
          return (ItemSupplierSearcher.Quest) null;
        }
      }

      [Token(Token = "0x17001108")]
      public ItemSupplierSearcher.Expedition AsExpedition
      {
        [Token(Token = "0x6007139"), Address(RVA = "0x4043340", Offset = "0x4043340", VA = "0x4043340", Slot = "8")] get
        {
          return (ItemSupplierSearcher.Expedition) null;
        }
      }

      [Token(Token = "0x17001109")]
      public ItemSupplierSearcher.ExpeditionBoss AsExpeditionBoss
      {
        [Token(Token = "0x600713A"), Address(RVA = "0x4043348", Offset = "0x4043348", VA = "0x4043348", Slot = "9")] get
        {
          return (ItemSupplierSearcher.ExpeditionBoss) null;
        }
      }

      [Token(Token = "0x1700110A")]
      public ItemSupplierSearcher.MedalTrade AsMedalTrade
      {
        [Token(Token = "0x600713B"), Address(RVA = "0x404334C", Offset = "0x404334C", VA = "0x404334C", Slot = "10")] get
        {
          return (ItemSupplierSearcher.MedalTrade) null;
        }
      }

      [Token(Token = "0x600713C")]
      [Address(RVA = "0x4043354", Offset = "0x4043354", VA = "0x4043354")]
      public ExpeditionBoss()
      {
      }
    }

    [Token(Token = "0x200141A")]
    public class MedalTrade : ItemSupplierSearcher.ISearchResult
    {
      [Token(Token = "0x4005D15")]
      [FieldOffset(Offset = "0x10")]
      public int medalTradeShopDescriptionId;

      [Token(Token = "0x1700110B")]
      public ItemSupplierSearcher.DataType DataType
      {
        [Token(Token = "0x600713D"), Address(RVA = "0x404335C", Offset = "0x404335C", VA = "0x404335C", Slot = "4")] get
        {
          return new ItemSupplierSearcher.DataType();
        }
      }

      [Token(Token = "0x1700110C")]
      public ItemSupplierSearcher.SortCategory SortCategory
      {
        [Token(Token = "0x600713E"), Address(RVA = "0x4043364", Offset = "0x4043364", VA = "0x4043364", Slot = "5")] get
        {
          return new ItemSupplierSearcher.SortCategory();
        }
      }

      [Token(Token = "0x1700110D")]
      public int SortKey
      {
        [Token(Token = "0x600713F"), Address(RVA = "0x404336C", Offset = "0x404336C", VA = "0x404336C", Slot = "6")] get
        {
          return new int();
        }
      }

      [Token(Token = "0x1700110E")]
      public ItemSupplierSearcher.Quest AsQuest
      {
        [Token(Token = "0x6007140"), Address(RVA = "0x4043374", Offset = "0x4043374", VA = "0x4043374", Slot = "7")] get
        {
          return (ItemSupplierSearcher.Quest) null;
        }
      }

      [Token(Token = "0x1700110F")]
      public ItemSupplierSearcher.Expedition AsExpedition
      {
        [Token(Token = "0x6007141"), Address(RVA = "0x404337C", Offset = "0x404337C", VA = "0x404337C", Slot = "8")] get
        {
          return (ItemSupplierSearcher.Expedition) null;
        }
      }

      [Token(Token = "0x17001110")]
      public ItemSupplierSearcher.ExpeditionBoss AsExpeditionBoss
      {
        [Token(Token = "0x6007142"), Address(RVA = "0x4043384", Offset = "0x4043384", VA = "0x4043384", Slot = "9")] get
        {
          return (ItemSupplierSearcher.ExpeditionBoss) null;
        }
      }

      [Token(Token = "0x17001111")]
      public ItemSupplierSearcher.MedalTrade AsMedalTrade
      {
        [Token(Token = "0x6007143"), Address(RVA = "0x404338C", Offset = "0x404338C", VA = "0x404338C", Slot = "10")] get
        {
          return (ItemSupplierSearcher.MedalTrade) null;
        }
      }

      [Token(Token = "0x6007144")]
      [Address(RVA = "0x4043390", Offset = "0x4043390", VA = "0x4043390")]
      public MedalTrade()
      {
      }
    }

    [Token(Token = "0x200141B")]
    private class Collector
    {
      [Token(Token = "0x4005D16")]
      [FieldOffset(Offset = "0x10")]
      private CancellationToken token;
      [Token(Token = "0x4005D17")]
      [FieldOffset(Offset = "0x18")]
      private (RewardTypeEnum rewardType, int rewardId) target;

      [Token(Token = "0x17001112")]
      public bool IsDone
      {
        [Token(Token = "0x6007145"), Address(RVA = "0x4043398", Offset = "0x4043398", VA = "0x4043398")] get
        {
          return new bool();
        }
        [Token(Token = "0x6007146"), Address(RVA = "0x40433A0", Offset = "0x40433A0", VA = "0x40433A0")] private set
        {
        }
      }

      [Token(Token = "0x17001113")]
      public bool IsCanceled
      {
        [Token(Token = "0x6007147"), Address(RVA = "0x40433AC", Offset = "0x40433AC", VA = "0x40433AC")] get
        {
          return new bool();
        }
        [Token(Token = "0x6007148"), Address(RVA = "0x40433B4", Offset = "0x40433B4", VA = "0x40433B4")] private set
        {
        }
      }

      [Token(Token = "0x17001114")]
      public bool IsError
      {
        [Token(Token = "0x6007149"), Address(RVA = "0x40433C0", Offset = "0x40433C0", VA = "0x40433C0")] get
        {
          return new bool();
        }
        [Token(Token = "0x600714A"), Address(RVA = "0x40433C8", Offset = "0x40433C8", VA = "0x40433C8")] private set
        {
        }
      }

      [Token(Token = "0x17001115")]
      public List<ItemSupplierSearcher.ISearchResult> Result
      {
        [Token(Token = "0x600714B"), Address(RVA = "0x40433D4", Offset = "0x40433D4", VA = "0x40433D4")] get
        {
          return (List<ItemSupplierSearcher.ISearchResult>) null;
        }
        [Token(Token = "0x600714C"), Address(RVA = "0x40433DC", Offset = "0x40433DC", VA = "0x40433DC")] private set
        {
        }
      }

      [Token(Token = "0x600714D")]
      [Address(RVA = "0x40433E4", Offset = "0x40433E4", VA = "0x40433E4")]
      public Collector(CancellationToken cancelToken, RewardTypeEnum rewardType, int rewardId)
      {
      }

      [Token(Token = "0x600714E")]
      [Address(RVA = "0x40434B8", Offset = "0x40434B8", VA = "0x40434B8")]
      public void Start()
      {
      }

      [Token(Token = "0x600714F")]
      [Address(RVA = "0x40430A4", Offset = "0x40430A4", VA = "0x40430A4")]
      public static Task<List<ItemSupplierSearcher.ISearchResult>> RunAsync(
        CancellationToken token,
        RewardTypeEnum rewardType,
        int rewardId)
      {
        return (Task<List<ItemSupplierSearcher.ISearchResult>>) null;
      }

      [Token(Token = "0x6007150")]
      [Address(RVA = "0x40435A4", Offset = "0x40435A4", VA = "0x40435A4")]
      private List<ItemSupplierSearcher.ISearchResult> RunAsync()
      {
        return (List<ItemSupplierSearcher.ISearchResult>) null;
      }

      [Token(Token = "0x6007151")]
      [Address(RVA = "0x4046694", Offset = "0x4046694", VA = "0x4046694")]
      private void CollecteRewardsInQuest(
        int questStageId,
        int clearRewardGroupID,
        Dictionary<int, List<(RewardTypeEnum, int)>> dropRewardMap,
        Action<ItemSupplierSearcher.ObtainedFrom> callbackRegister)
      {
      }

      [Token(Token = "0x6007152")]
      [Address(RVA = "0x40476D0", Offset = "0x40476D0", VA = "0x40476D0")]
      private void Register(
        in StoryFreeQuestData freeQuest,
        ItemSupplierSearcher.ObtainedFrom obtained)
      {
      }

      [Token(Token = "0x6007153")]
      [Address(RVA = "0x4047788", Offset = "0x4047788", VA = "0x4047788")]
      private void Register(
        in StoryScenarioQuestFreeData scenarioFree,
        ItemSupplierSearcher.ObtainedFrom obtained)
      {
      }

      [Token(Token = "0x6007154")]
      [Address(RVA = "0x4047840", Offset = "0x4047840", VA = "0x4047840")]
      private void Register(
        in LimitedEventQuestStageData eventQuest,
        ItemSupplierSearcher.ObtainedFrom obtained)
      {
      }

      [Token(Token = "0x6007155")]
      [Address(RVA = "0x40478F8", Offset = "0x40478F8", VA = "0x40478F8")]
      private void Register(
        in AreaQuestAreaNodeQuestData quest,
        ItemSupplierSearcher.ObtainedFrom obtained)
      {
      }

      [Token(Token = "0x6007156")]
      [Address(RVA = "0x40472FC", Offset = "0x40472FC", VA = "0x40472FC")]
      private void Register(in ItemSupplierSearcher.ISearchResult result)
      {
      }
    }
  }
}
