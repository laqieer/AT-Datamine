// Decompiled with JetBrains decompiler
// Type: StaqData.CommunicationInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.Param;
using System.Collections.Generic;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x20020A6")]
  public class CommunicationInfo
  {
    [Token(Token = "0x4008AC2")]
    [FieldOffset(Offset = "0x10")]
    private readonly Dictionary<int, Communication> communications;

    [Token(Token = "0x17002A34")]
    public IEnumerable<Communication> AllItem
    {
      [Token(Token = "0x600C587"), Address(RVA = "0x19F5E90", Offset = "0x19F5E90", VA = "0x19F5E90")] get
      {
        return (IEnumerable<Communication>) null;
      }
    }

    [Token(Token = "0x17002A35")]
    public IEnumerable<Communication> OpenedCommunications
    {
      [Token(Token = "0x600C588"), Address(RVA = "0x1A03E78", Offset = "0x1A03E78", VA = "0x1A03E78")] get
      {
        return (IEnumerable<Communication>) null;
      }
    }

    [Token(Token = "0x600C589")]
    [Address(RVA = "0x1A03F84", Offset = "0x1A03F84", VA = "0x1A03F84")]
    public Communication Any() => (Communication) null;

    [Token(Token = "0x600C58A")]
    [Address(RVA = "0x1A0410C", Offset = "0x1A0410C", VA = "0x1A0410C")]
    public void Initialize()
    {
    }

    [Token(Token = "0x600C58B")]
    [Address(RVA = "0x1A0466C", Offset = "0x1A0466C", VA = "0x1A0466C")]
    public void Setup(int communicationLabel)
    {
    }

    [Token(Token = "0x600C58C")]
    [Address(RVA = "0x1A04A88", Offset = "0x1A04A88", VA = "0x1A04A88")]
    public void Clear()
    {
    }

    [Token(Token = "0x600C58D")]
    [Address(RVA = "0x1A04AD8", Offset = "0x1A04AD8", VA = "0x1A04AD8")]
    public void Update(
      IEnumerable<PlayerStoryCommunicationType> communications)
    {
    }

    [Token(Token = "0x600C58E")]
    [Address(RVA = "0x1A050AC", Offset = "0x1A050AC", VA = "0x1A050AC")]
    public void Update(PlayerStoryCommunicationType response)
    {
    }

    [Token(Token = "0x600C58F")]
    [Address(RVA = "0x1A04590", Offset = "0x1A04590", VA = "0x1A04590")]
    public Communication Get(int communicationID) => (Communication) null;

    [Token(Token = "0x600C590")]
    [Address(RVA = "0x1A050E8", Offset = "0x1A050E8", VA = "0x1A050E8")]
    public void DebugUpdate()
    {
    }

    [Token(Token = "0x600C591")]
    [Address(RVA = "0x1A05504", Offset = "0x1A05504", VA = "0x1A05504")]
    public void DebugRankupUpdate(int rank)
    {
    }

    [Token(Token = "0x600C592")]
    [Address(RVA = "0x1A058AC", Offset = "0x1A058AC", VA = "0x1A058AC")]
    public void DebugNormalUpdate(int rank)
    {
    }

    [Token(Token = "0x600C593")]
    [Address(RVA = "0x1A05C50", Offset = "0x1A05C50", VA = "0x1A05C50")]
    public CommunicationInfo()
    {
    }
  }
}
