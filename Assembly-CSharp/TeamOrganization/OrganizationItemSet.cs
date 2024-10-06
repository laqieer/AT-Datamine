// Decompiled with JetBrains decompiler
// Type: TeamOrganization.OrganizationItemSet
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.API;
using StaqData;
using System.Collections.Generic;

#nullable disable
namespace TeamOrganization
{
  [Token(Token = "0x2000789")]
  public class OrganizationItemSet
  {
    [Token(Token = "0x40022BF")]
    [FieldOffset(Offset = "0x10")]
    private int itemsetSlotMax;

    [Token(Token = "0x17000651")]
    public int Idx
    {
      [Token(Token = "0x6002A32"), Address(RVA = "0x35001A8", Offset = "0x35001A8", VA = "0x35001A8")] get
      {
        return new int();
      }
      [Token(Token = "0x6002A33"), Address(RVA = "0x35001B0", Offset = "0x35001B0", VA = "0x35001B0")] private set
      {
      }
    }

    [Token(Token = "0x17000652")]
    public string Name
    {
      [Token(Token = "0x6002A34"), Address(RVA = "0x35001B8", Offset = "0x35001B8", VA = "0x35001B8")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6002A35"), Address(RVA = "0x35001C0", Offset = "0x35001C0", VA = "0x35001C0")] set
      {
      }
    }

    [Token(Token = "0x17000653")]
    public OrganizationItemSetSlot[] SlotData
    {
      [Token(Token = "0x6002A36"), Address(RVA = "0x35001C8", Offset = "0x35001C8", VA = "0x35001C8")] get
      {
        return (OrganizationItemSetSlot[]) null;
      }
      [Token(Token = "0x6002A37"), Address(RVA = "0x35001D0", Offset = "0x35001D0", VA = "0x35001D0")] set
      {
      }
    }

    [Token(Token = "0x6002A38")]
    [Address(RVA = "0x34FBCC0", Offset = "0x34FBCC0", VA = "0x34FBCC0")]
    public OrganizationItemSet(BattleItemset itemset)
    {
    }

    [Token(Token = "0x6002A39")]
    [Address(RVA = "0x34FBB30", Offset = "0x34FBB30", VA = "0x34FBB30")]
    public OrganizationItemSet(int index)
    {
    }

    [Token(Token = "0x6002A3A")]
    [Address(RVA = "0x35001D8", Offset = "0x35001D8", VA = "0x35001D8")]
    private string GetItemSetName(int index) => (string) null;

    [Token(Token = "0x6002A3B")]
    [Address(RVA = "0x3500308", Offset = "0x3500308", VA = "0x3500308")]
    public void RefreshSlot()
    {
    }

    [Token(Token = "0x6002A3C")]
    [Address(RVA = "0x3500538", Offset = "0x3500538", VA = "0x3500538")]
    public bool IsSlotMax() => new bool();

    [Token(Token = "0x6002A3D")]
    [Address(RVA = "0x350058C", Offset = "0x350058C", VA = "0x350058C")]
    public bool IsItemEquipment(int itemId) => new bool();

    [Token(Token = "0x6002A3E")]
    [Address(RVA = "0x35005EC", Offset = "0x35005EC", VA = "0x35005EC")]
    public bool IsItemSetEmpty() => new bool();

    [Token(Token = "0x6002A3F")]
    [Address(RVA = "0x3500640", Offset = "0x3500640", VA = "0x3500640")]
    public void AddItemEquipment(Expendable expendable)
    {
    }

    [Token(Token = "0x6002A40")]
    [Address(RVA = "0x34FCCF0", Offset = "0x34FCCF0", VA = "0x34FCCF0")]
    public void ChangeItemEquipment(int index, Expendable expendable)
    {
    }

    [Token(Token = "0x6002A41")]
    [Address(RVA = "0x34FCE80", Offset = "0x34FCE80", VA = "0x34FCE80")]
    public void RemoveItemEquipment(int index)
    {
    }

    [Token(Token = "0x6002A42")]
    [Address(RVA = "0x34FB7D8", Offset = "0x34FB7D8", VA = "0x34FB7D8")]
    public Expendable GetExpendable(int index) => (Expendable) null;

    [Token(Token = "0x6002A43")]
    [Address(RVA = "0x34FBFEC", Offset = "0x34FBFEC", VA = "0x34FBFEC")]
    public IReadOnlyList<Expendable> GetExpendables() => (IReadOnlyList<Expendable>) null;

    [Token(Token = "0x6002A44")]
    [Address(RVA = "0x34FC7B0", Offset = "0x34FC7B0", VA = "0x34FC7B0")]
    public bool CheckDifference() => new bool();

    [Token(Token = "0x6002A45")]
    [Address(RVA = "0x34FD314", Offset = "0x34FD314", VA = "0x34FD314")]
    public static APIDeckEditItemSetRequest CreatePlayerItemSetRequest(OrganizationItemSet itemSet)
    {
      return (APIDeckEditItemSetRequest) null;
    }
  }
}
