// Decompiled with JetBrains decompiler
// Type: StaqData.FacilityInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.Param;
using System.Collections.Generic;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x20020B3")]
  public class FacilityInfo
  {
    [Token(Token = "0x4008AE0")]
    [FieldOffset(Offset = "0x10")]
    private readonly Dictionary<int, Facility> facilities;

    [Token(Token = "0x17002A4D")]
    public IEnumerable<Facility> Facilities
    {
      [Token(Token = "0x600C5E8"), Address(RVA = "0x1CD2358", Offset = "0x1CD2358", VA = "0x1CD2358")] get
      {
        return (IEnumerable<Facility>) null;
      }
    }

    [Token(Token = "0x17002A4E")]
    public IEnumerable<Facility> OpenedFacilities
    {
      [Token(Token = "0x600C5E9"), Address(RVA = "0x1CD23A8", Offset = "0x1CD23A8", VA = "0x1CD23A8")] get
      {
        return (IEnumerable<Facility>) null;
      }
    }

    [Token(Token = "0x17002A4F")]
    public IEnumerable<Facility> ActiveFacilities
    {
      [Token(Token = "0x600C5EA"), Address(RVA = "0x1CD24B4", Offset = "0x1CD24B4", VA = "0x1CD24B4")] get
      {
        return (IEnumerable<Facility>) null;
      }
    }

    [Token(Token = "0x17002A50")]
    public List<BookInfo> RentBooks
    {
      [Token(Token = "0x600C5EB"), Address(RVA = "0x1CD25C0", Offset = "0x1CD25C0", VA = "0x1CD25C0")] get
      {
        return (List<BookInfo>) null;
      }
    }

    [Token(Token = "0x600C5EC")]
    [Address(RVA = "0x1CD27A4", Offset = "0x1CD27A4", VA = "0x1CD27A4")]
    public Facility Get(int attachID) => (Facility) null;

    [Token(Token = "0x600C5ED")]
    [Address(RVA = "0x1CD28CC", Offset = "0x1CD28CC", VA = "0x1CD28CC")]
    public void Setup(int facilityLabel)
    {
    }

    [Token(Token = "0x600C5EE")]
    [Address(RVA = "0x1CD2E14", Offset = "0x1CD2E14", VA = "0x1CD2E14")]
    public void Update(PlayerStoryFacilityType serverData)
    {
    }

    [Token(Token = "0x600C5EF")]
    [Address(RVA = "0x1CD2FD4", Offset = "0x1CD2FD4", VA = "0x1CD2FD4")]
    public void Update(List<PlayerStoryFacilityType> serverDatas)
    {
    }

    [Token(Token = "0x600C5F0")]
    [Address(RVA = "0x1CD3110", Offset = "0x1CD3110", VA = "0x1CD3110")]
    public FacilityInfo()
    {
    }
  }
}
