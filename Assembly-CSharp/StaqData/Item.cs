// Decompiled with JetBrains decompiler
// Type: StaqData.Item
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x2002038")]
  public abstract class Item
  {
    [Token(Token = "0x17002868")]
    public UniqueID UniqueID
    {
      [Token(Token = "0x600C109"), Address(RVA = "0x2012458", Offset = "0x2012458", VA = "0x2012458")] get
      {
        return new UniqueID();
      }
      [Token(Token = "0x600C10A"), Address(RVA = "0x2012460", Offset = "0x2012460", VA = "0x2012460")] protected set
      {
      }
    }

    [Token(Token = "0x17002869")]
    public int ID
    {
      [Token(Token = "0x600C10B"), Address(RVA = "0x2012468", Offset = "0x2012468", VA = "0x2012468")] get
      {
        return new int();
      }
      [Token(Token = "0x600C10C"), Address(RVA = "0x2012470", Offset = "0x2012470", VA = "0x2012470")] protected set
      {
      }
    }

    [Token(Token = "0x1700286A")]
    public int Amount
    {
      [Token(Token = "0x600C10D"), Address(RVA = "0x2012478", Offset = "0x2012478", VA = "0x2012478")] get
      {
        return new int();
      }
      [Token(Token = "0x600C10E"), Address(RVA = "0x2012480", Offset = "0x2012480", VA = "0x2012480")] protected set
      {
      }
    }

    [Token(Token = "0x1700286B")]
    public abstract string Name { [Token(Token = "0x600C10F")] get; }

    [Token(Token = "0x1700286C")]
    public abstract ItemTypeEnum ItemType { [Token(Token = "0x600C110")] get; }

    [Token(Token = "0x1700286D")]
    public abstract RarityTypeEnum Rarity { [Token(Token = "0x600C111")] get; }

    [Token(Token = "0x1700286E")]
    public abstract bool IsSellable { [Token(Token = "0x600C112")] get; }

    [Token(Token = "0x1700286F")]
    public bool IsNew
    {
      [Token(Token = "0x600C113"), Address(RVA = "0x2012488", Offset = "0x2012488", VA = "0x2012488")] get
      {
        return new bool();
      }
      [Token(Token = "0x600C114"), Address(RVA = "0x2012490", Offset = "0x2012490", VA = "0x2012490")] protected set
      {
      }
    }

    [Token(Token = "0x17002870")]
    public virtual bool HasExpirationDate
    {
      [Token(Token = "0x600C115"), Address(RVA = "0x201249C", Offset = "0x201249C", VA = "0x201249C", Slot = "8")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002871")]
    public virtual DateTime ExpirationBeginDate
    {
      [Token(Token = "0x600C116"), Address(RVA = "0x20124DC", Offset = "0x20124DC", VA = "0x20124DC", Slot = "9")] get
      {
        return new DateTime();
      }
    }

    [Token(Token = "0x17002872")]
    public virtual DateTime ExpirationEndDate
    {
      [Token(Token = "0x600C117"), Address(RVA = "0x201251C", Offset = "0x201251C", VA = "0x201251C", Slot = "10")] get
      {
        return new DateTime();
      }
    }

    [Token(Token = "0x600C118")]
    [Address(RVA = "0x200AA40", Offset = "0x200AA40", VA = "0x200AA40")]
    public void SetAmount(int value)
    {
    }

    [Token(Token = "0x600C119")]
    [Address(RVA = "0x201255C", Offset = "0x201255C", VA = "0x201255C")]
    public void Increase(int value)
    {
    }

    [Token(Token = "0x600C11A")]
    [Address(RVA = "0x201256C", Offset = "0x201256C", VA = "0x201256C")]
    public void Decrease(int value)
    {
    }

    [Token(Token = "0x600C11B")]
    [Address(RVA = "0x20125E0", Offset = "0x20125E0", VA = "0x20125E0")]
    public int AmountSufficient(int value) => new int();

    [Token(Token = "0x600C11C")]
    [Address(RVA = "0x201264C", Offset = "0x201264C", VA = "0x201264C")]
    public void BringDownNewFlag()
    {
    }

    [Token(Token = "0x600C11D")]
    [Address(RVA = "0x2012654", Offset = "0x2012654", VA = "0x2012654")]
    public bool IsWithinExpirationDate(DateTime? current = null) => new bool();

    [Token(Token = "0x600C11E")]
    [Address(RVA = "0x20040C8", Offset = "0x20040C8", VA = "0x20040C8")]
    protected Item()
    {
    }
  }
}
