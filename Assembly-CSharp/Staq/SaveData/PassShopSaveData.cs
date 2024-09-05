// Decompiled with JetBrains decompiler
// Type: staq.SaveData.PassShopSaveData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;
using Network.Param;
using staq.SaveSchema;
using StaqData;
using System;
using System.Collections.Generic;

#nullable disable
namespace staq.SaveData
{
  [Token(Token = "0x2003D34")]
  public class PassShopSaveData
  {
    [Token(Token = "0x4010D32")]
    [FieldOffset(Offset = "0x18")]
    public Dictionary<int, PassShopSaveData.PassShopSave> PassShopLimitViewMap;

    [Token(Token = "0x1700505A")]
    public bool loaded
    {
      [Token(Token = "0x60189D2"), Address(RVA = "0x2636F1C", Offset = "0x2636F1C", VA = "0x2636F1C")] get
      {
        return new bool();
      }
      [Token(Token = "0x60189D3"), Address(RVA = "0x2636F24", Offset = "0x2636F24", VA = "0x2636F24")] private set
      {
      }
    }

    [Token(Token = "0x1700505B")]
    public static string Path
    {
      [Token(Token = "0x60189D4"), Address(RVA = "0x2636F30", Offset = "0x2636F30", VA = "0x2636F30")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x60189D5")]
    [Address(RVA = "0x2636F80", Offset = "0x2636F80", VA = "0x2636F80")]
    public string GetPath() => (string) null;

    [Token(Token = "0x60189D6")]
    [Address(RVA = "0x2636FC8", Offset = "0x2636FC8", VA = "0x2636FC8")]
    public void DeleteFile()
    {
    }

    [Token(Token = "0x60189D7")]
    [Address(RVA = "0x2636FF8", Offset = "0x2636FF8", VA = "0x2636FF8")]
    public void Delete()
    {
    }

    [Token(Token = "0x60189D8")]
    [Address(RVA = "0x2637014", Offset = "0x2637014", VA = "0x2637014")]
    public void Load()
    {
    }

    [Token(Token = "0x60189D9")]
    [Address(RVA = "0x263743C", Offset = "0x263743C", VA = "0x263743C")]
    public void Save()
    {
    }

    [Token(Token = "0x60189DA")]
    [Address(RVA = "0x26378C0", Offset = "0x26378C0", VA = "0x26378C0")]
    private Offset<PassShop> GetData(FlatBufferBuilder fbb, Offset<PassShopItem>[] offsets)
    {
      return new Offset<PassShop>();
    }

    [Token(Token = "0x60189DB")]
    [Address(RVA = "0x2637740", Offset = "0x2637740", VA = "0x2637740")]
    private Offset<PassShopItem> GetPassShopItemData(
      FlatBufferBuilder fbb,
      PassShopSaveData.PassShopSave passShopSave)
    {
      return new Offset<PassShopItem>();
    }

    [Token(Token = "0x60189DC")]
    [Address(RVA = "0x2637930", Offset = "0x2637930", VA = "0x2637930")]
    public void SetBuyPassShopItem(int passShopId, DateTime endAt)
    {
    }

    [Token(Token = "0x60189DD")]
    [Address(RVA = "0x2637AA8", Offset = "0x2637AA8", VA = "0x2637AA8")]
    public void SetBuyPassShopItems(List<PlayerRewardPassType> rewardPassTypes)
    {
    }

    [Token(Token = "0x60189DE")]
    [Address(RVA = "0x2637C40", Offset = "0x2637C40", VA = "0x2637C40")]
    public void ResetPassShopItem(int passShopId, DateTime endAt)
    {
    }

    [Token(Token = "0x60189DF")]
    [Address(RVA = "0x2637F28", Offset = "0x2637F28", VA = "0x2637F28")]
    public void SetDaysLeftFlag(PassData passData, bool isDaysLeft)
    {
    }

    [Token(Token = "0x60189E0")]
    [Address(RVA = "0x26380A0", Offset = "0x26380A0", VA = "0x26380A0")]
    public void SetOutPeriodFlag(int passShopId, bool isOutPeriod)
    {
    }

    [Token(Token = "0x60189E1")]
    [Address(RVA = "0x26381C4", Offset = "0x26381C4", VA = "0x26381C4")]
    public bool IsOpenCheckByDayLeft(int passId) => new bool();

    [Token(Token = "0x60189E2")]
    [Address(RVA = "0x2638350", Offset = "0x2638350", VA = "0x2638350")]
    public bool IsOpenedCheckByOutPeriod(int passId) => new bool();

    [Token(Token = "0x60189E3")]
    [Address(RVA = "0x26383DC", Offset = "0x26383DC", VA = "0x26383DC")]
    public PassShopSaveData()
    {
    }

    [Token(Token = "0x2003D35")]
    public class PassShopSave
    {
      [Token(Token = "0x1700505C")]
      public int PassShopID
      {
        [Token(Token = "0x60189E4"), Address(RVA = "0x2638458", Offset = "0x2638458", VA = "0x2638458")] get
        {
          return new int();
        }
        [Token(Token = "0x60189E5"), Address(RVA = "0x2638460", Offset = "0x2638460", VA = "0x2638460")] set
        {
        }
      }

      [Token(Token = "0x1700505D")]
      public DateTime? EndAt
      {
        [Token(Token = "0x60189E6"), Address(RVA = "0x2638468", Offset = "0x2638468", VA = "0x2638468")] get
        {
          return new DateTime?();
        }
        [Token(Token = "0x60189E7"), Address(RVA = "0x2638474", Offset = "0x2638474", VA = "0x2638474")] set
        {
        }
      }

      [Token(Token = "0x1700505E")]
      public DateTime? LastAt
      {
        [Token(Token = "0x60189E8"), Address(RVA = "0x263847C", Offset = "0x263847C", VA = "0x263847C")] get
        {
          return new DateTime?();
        }
        [Token(Token = "0x60189E9"), Address(RVA = "0x2638488", Offset = "0x2638488", VA = "0x2638488")] set
        {
        }
      }

      [Token(Token = "0x1700505F")]
      public bool OutPeriod
      {
        [Token(Token = "0x60189EA"), Address(RVA = "0x2638490", Offset = "0x2638490", VA = "0x2638490")] get
        {
          return new bool();
        }
        [Token(Token = "0x60189EB"), Address(RVA = "0x2638498", Offset = "0x2638498", VA = "0x2638498")] set
        {
        }
      }

      [Token(Token = "0x17005060")]
      public bool IsEndAtParseError
      {
        [Token(Token = "0x60189EC"), Address(RVA = "0x26384A4", Offset = "0x26384A4", VA = "0x26384A4")] get
        {
          return new bool();
        }
        [Token(Token = "0x60189ED"), Address(RVA = "0x26384AC", Offset = "0x26384AC", VA = "0x26384AC")] set
        {
        }
      }

      [Token(Token = "0x17005061")]
      public bool IsNextDay
      {
        [Token(Token = "0x60189EE"), Address(RVA = "0x263824C", Offset = "0x263824C", VA = "0x263824C")] get
        {
          return new bool();
        }
      }

      [Token(Token = "0x17005062")]
      public TimeSpan? LimitDate
      {
        [Token(Token = "0x60189EF"), Address(RVA = "0x2637E10", Offset = "0x2637E10", VA = "0x2637E10")] get
        {
          return new TimeSpan?();
        }
      }

      [Token(Token = "0x60189F0")]
      [Address(RVA = "0x2637434", Offset = "0x2637434", VA = "0x2637434")]
      public PassShopSave()
      {
      }
    }
  }
}
