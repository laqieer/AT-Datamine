// Decompiled with JetBrains decompiler
// Type: StaqData.PossessionLimitUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x2002058")]
  public static class PossessionLimitUtility
  {
    [Token(Token = "0x600C308")]
    [Address(RVA = "0x19EF074", Offset = "0x19EF074", VA = "0x19EF074")]
    public static bool IsOverPossessionLimit(ItemTypeEnum itemType, int itemId, int amount)
    {
      return new bool();
    }

    [Token(Token = "0x600C309")]
    [Address(RVA = "0x19EF170", Offset = "0x19EF170", VA = "0x19EF170")]
    public static bool GetShowLimit(ItemTypeEnum itemType, int itemId, out int result)
    {
      return new bool();
    }

    [Token(Token = "0x600C30A")]
    [Address(RVA = "0x19EF2A4", Offset = "0x19EF2A4", VA = "0x19EF2A4")]
    public static bool GetPossessionLimit(ItemTypeEnum itemType, int itemId, out int result)
    {
      return new bool();
    }

    [Token(Token = "0x600C30B")]
    [Address(RVA = "0x19EF0C8", Offset = "0x19EF0C8", VA = "0x19EF0C8")]
    public static IPossessionLimitData FindPossessionLimitData(ItemTypeEnum itemType, int itemId)
    {
      return (IPossessionLimitData) null;
    }

    [Token(Token = "0x600C30C")]
    [Address(RVA = "0x19EF3D8", Offset = "0x19EF3D8", VA = "0x19EF3D8")]
    public static IPossessionLimitData GetSoulPossessionLimitData(SoulTypeEnum soulType)
    {
      return (IPossessionLimitData) null;
    }

    [Token(Token = "0x600C30D")]
    [Address(RVA = "0x19EF480", Offset = "0x19EF480", VA = "0x19EF480")]
    public static PossessionAmountInfo CreatePossessionAmountInfo(int amount)
    {
      return new PossessionAmountInfo();
    }

    [Token(Token = "0x600C30E")]
    [Address(RVA = "0x19EF48C", Offset = "0x19EF48C", VA = "0x19EF48C")]
    public static PossessionAmountInfo CreatePossessionAmountInfo(
      ItemTypeEnum type,
      int id,
      int amount)
    {
      return new PossessionAmountInfo();
    }

    [Token(Token = "0x600C30F")]
    [Address(RVA = "0x19EF5C8", Offset = "0x19EF5C8", VA = "0x19EF5C8")]
    public static PossessionAmountInfo CreatePossessionAmountInfo(
      RewardTypeEnum type,
      int id,
      int amount)
    {
      return new PossessionAmountInfo();
    }

    [Token(Token = "0x600C310")]
    [Address(RVA = "0x19EF7AC", Offset = "0x19EF7AC", VA = "0x19EF7AC")]
    public static PossessionAmountInfo CreatePossessionAmountInfo(
      PaymentTypeEnum type,
      int id,
      int amount)
    {
      return new PossessionAmountInfo();
    }

    [Token(Token = "0x600C311")]
    [Address(RVA = "0x19EF994", Offset = "0x19EF994", VA = "0x19EF994")]
    public static int GetRoundedAmountByShowLimit(PaymentTypeEnum type, int id, int value)
    {
      return new int();
    }

    [Token(Token = "0x2002059")]
    private class SoulPossessionLimitData : IPossessionLimitData
    {
      [Token(Token = "0x17002912")]
      public ItemTypeEnum ItemType
      {
        [Token(Token = "0x600C312"), Address(RVA = "0x19EFAD0", Offset = "0x19EFAD0", VA = "0x19EFAD0", Slot = "4")] get
        {
          return new ItemTypeEnum();
        }
      }

      [Token(Token = "0x17002913")]
      public int ShowLimitNumber
      {
        [Token(Token = "0x600C313"), Address(RVA = "0x19EFAD8", Offset = "0x19EFAD8", VA = "0x19EFAD8", Slot = "5")] get
        {
          return new int();
        }
      }

      [Token(Token = "0x17002914")]
      public int PossessionLimitNumber
      {
        [Token(Token = "0x600C314"), Address(RVA = "0x19EFAE0", Offset = "0x19EFAE0", VA = "0x19EFAE0", Slot = "6")] get
        {
          return new int();
        }
      }

      [Token(Token = "0x17002915")]
      public bool SendPresent
      {
        [Token(Token = "0x600C315"), Address(RVA = "0x19EFAE8", Offset = "0x19EFAE8", VA = "0x19EFAE8", Slot = "7")] get
        {
          return new bool();
        }
      }

      [Token(Token = "0x600C316")]
      [Address(RVA = "0x19EF458", Offset = "0x19EF458", VA = "0x19EF458")]
      public SoulPossessionLimitData(int possessionLimitNumber)
      {
      }
    }
  }
}
