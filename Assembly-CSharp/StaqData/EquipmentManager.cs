// Decompiled with JetBrains decompiler
// Type: StaqData.EquipmentManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.Param;
using System.Collections;
using System.Collections.Generic;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x200201E")]
  public sealed class EquipmentManager : IEnumerable<Equipment>, IEnumerable
  {
    [Token(Token = "0x40088D2")]
    [FieldOffset(Offset = "0x18")]
    private List<Equipment> list;

    [Token(Token = "0x17002804")]
    public EntityUpdateEventSender EntityUpdateEventSender
    {
      [Token(Token = "0x600BFEC"), Address(RVA = "0x20094D0", Offset = "0x20094D0", VA = "0x20094D0")] get
      {
        return (EntityUpdateEventSender) null;
      }
    }

    [Token(Token = "0x17002805")]
    public WeaponManager WeaponManager
    {
      [Token(Token = "0x600BFED"), Address(RVA = "0x20094D8", Offset = "0x20094D8", VA = "0x20094D8")] get
      {
        return (WeaponManager) null;
      }
      [Token(Token = "0x600BFEE"), Address(RVA = "0x20094E0", Offset = "0x20094E0", VA = "0x20094E0")] private set
      {
      }
    }

    [Token(Token = "0x17002806")]
    public AccessoryManager AccessoryManager
    {
      [Token(Token = "0x600BFEF"), Address(RVA = "0x20094E8", Offset = "0x20094E8", VA = "0x20094E8")] get
      {
        return (AccessoryManager) null;
      }
      [Token(Token = "0x600BFF0"), Address(RVA = "0x20094F0", Offset = "0x20094F0", VA = "0x20094F0")] private set
      {
      }
    }

    [Token(Token = "0x17002807")]
    public MindEquipmentManager MindEquipmentManager
    {
      [Token(Token = "0x600BFF1"), Address(RVA = "0x20094F8", Offset = "0x20094F8", VA = "0x20094F8")] get
      {
        return (MindEquipmentManager) null;
      }
      [Token(Token = "0x600BFF2"), Address(RVA = "0x2009500", Offset = "0x2009500", VA = "0x2009500")] private set
      {
      }
    }

    [Token(Token = "0x600BFF3")]
    [Address(RVA = "0x2009508", Offset = "0x2009508", VA = "0x2009508")]
    public void Apply(List<PlayerGearWeaponType> weapons)
    {
    }

    [Token(Token = "0x600BFF4")]
    [Address(RVA = "0x20095F4", Offset = "0x20095F4", VA = "0x20095F4")]
    public void Apply(List<PlayerGearAccessoryType> accessories)
    {
    }

    [Token(Token = "0x600BFF5")]
    [Address(RVA = "0x2009620", Offset = "0x2009620", VA = "0x2009620")]
    public void Apply(List<PlayerGearMindEquipmentType> mindEquipments)
    {
    }

    [Token(Token = "0x600BFF6")]
    [Address(RVA = "0x2009534", Offset = "0x2009534", VA = "0x2009534")]
    private void ApplyEquipmentList()
    {
    }

    [Token(Token = "0x600BFF7")]
    [Address(RVA = "0x200964C", Offset = "0x200964C", VA = "0x200964C")]
    public Equipment Find(UniqueID uniqueID) => (Equipment) null;

    [Token(Token = "0x600BFF8")]
    public List<TResult> FilteredList<TResult>(IEquipmentFilter<TResult> filter)
    {
      return (List<TResult>) null;
    }

    [Token(Token = "0x600BFF9")]
    [Address(RVA = "0x2009730", Offset = "0x2009730", VA = "0x2009730", Slot = "4")]
    public IEnumerator<Equipment> GetEnumerator() => (IEnumerator<Equipment>) null;

    [Token(Token = "0x600BFFA")]
    [Address(RVA = "0x20097C0", Offset = "0x20097C0", VA = "0x20097C0", Slot = "5")]
    private IEnumerator System\u002ECollections\u002EIEnumerable\u002EGetEnumerator()
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600BFFB")]
    [Address(RVA = "0x2009850", Offset = "0x2009850", VA = "0x2009850")]
    public EquipmentManager()
    {
    }
  }
}
