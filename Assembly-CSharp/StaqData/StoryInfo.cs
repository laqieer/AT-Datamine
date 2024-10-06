// Decompiled with JetBrains decompiler
// Type: StaqData.StoryInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.API;
using Network.Param;
using StaqData.AreaEvent;
using StaqData.Story;
using System.Collections.Generic;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x20020DC")]
  public class StoryInfo
  {
    [Token(Token = "0x17002AC2")]
    public HumanParameterInfo HumanParameter
    {
      [Token(Token = "0x600C701"), Address(RVA = "0x1CDA718", Offset = "0x1CDA718", VA = "0x1CDA718")] get
      {
        return (HumanParameterInfo) null;
      }
    }

    [Token(Token = "0x17002AC3")]
    public CommunicationInfo CommunicationInfo
    {
      [Token(Token = "0x600C702"), Address(RVA = "0x1CDA720", Offset = "0x1CDA720", VA = "0x1CDA720")] get
      {
        return (CommunicationInfo) null;
      }
    }

    [Token(Token = "0x17002AC4")]
    public StoryShopList StoryShops
    {
      [Token(Token = "0x600C703"), Address(RVA = "0x1CDA728", Offset = "0x1CDA728", VA = "0x1CDA728")] get
      {
        return (StoryShopList) null;
      }
    }

    [Token(Token = "0x17002AC5")]
    public StoryAbilityList Abilities
    {
      [Token(Token = "0x600C704"), Address(RVA = "0x1CDA730", Offset = "0x1CDA730", VA = "0x1CDA730")] get
      {
        return (StoryAbilityList) null;
      }
    }

    [Token(Token = "0x17002AC6")]
    public SubQuestManager SubQuestManager
    {
      [Token(Token = "0x600C705"), Address(RVA = "0x1CDA738", Offset = "0x1CDA738", VA = "0x1CDA738")] get
      {
        return (SubQuestManager) null;
      }
    }

    [Token(Token = "0x17002AC7")]
    public AreaEventQuestManager AreaEventQuestManager
    {
      [Token(Token = "0x600C706"), Address(RVA = "0x1CDA740", Offset = "0x1CDA740", VA = "0x1CDA740")] get
      {
        return (AreaEventQuestManager) null;
      }
    }

    [Token(Token = "0x17002AC8")]
    public FreeActionInfo FreeActionInfo
    {
      [Token(Token = "0x600C707"), Address(RVA = "0x1CDA748", Offset = "0x1CDA748", VA = "0x1CDA748")] get
      {
        return (FreeActionInfo) null;
      }
    }

    [Token(Token = "0x17002AC9")]
    public FacilityInfo FacilityInfo
    {
      [Token(Token = "0x600C708"), Address(RVA = "0x1CDA750", Offset = "0x1CDA750", VA = "0x1CDA750")] get
      {
        return (FacilityInfo) null;
      }
    }

    [Token(Token = "0x17002ACA")]
    public AreaMapObjectStatusInfo AreaMapObjectStatusInfo
    {
      [Token(Token = "0x600C709"), Address(RVA = "0x1CDA758", Offset = "0x1CDA758", VA = "0x1CDA758")] get
      {
        return (AreaMapObjectStatusInfo) null;
      }
    }

    [Token(Token = "0x17002ACB")]
    public ObliviaeInfo ObliviaeInfo
    {
      [Token(Token = "0x600C70A"), Address(RVA = "0x1CDA760", Offset = "0x1CDA760", VA = "0x1CDA760")] get
      {
        return (ObliviaeInfo) null;
      }
    }

    [Token(Token = "0x17002ACC")]
    public StoryPointInfo StoryPoint
    {
      [Token(Token = "0x600C70B"), Address(RVA = "0x1CDA768", Offset = "0x1CDA768", VA = "0x1CDA768")] get
      {
        return (StoryPointInfo) null;
      }
    }

    [Token(Token = "0x17002ACD")]
    public Dictionary<StoryID, Chapter> Chapters
    {
      [Token(Token = "0x600C70C"), Address(RVA = "0x1CDA770", Offset = "0x1CDA770", VA = "0x1CDA770")] get
      {
        return (Dictionary<StoryID, Chapter>) null;
      }
    }

    [Token(Token = "0x17002ACE")]
    public Dictionary<StoryID, SequenceInfo> Sequences
    {
      [Token(Token = "0x600C70D"), Address(RVA = "0x1CDA778", Offset = "0x1CDA778", VA = "0x1CDA778")] get
      {
        return (Dictionary<StoryID, SequenceInfo>) null;
      }
    }

    [Token(Token = "0x17002ACF")]
    public Dictionary<StoryID, ChartInfo> Charts
    {
      [Token(Token = "0x600C70E"), Address(RVA = "0x1CDA780", Offset = "0x1CDA780", VA = "0x1CDA780")] get
      {
        return (Dictionary<StoryID, ChartInfo>) null;
      }
    }

    [Token(Token = "0x600C70F")]
    [Address(RVA = "0x1CDA788", Offset = "0x1CDA788", VA = "0x1CDA788")]
    public StoryInfo()
    {
    }

    [Token(Token = "0x600C710")]
    [Address(RVA = "0x1CDABA8", Offset = "0x1CDABA8", VA = "0x1CDABA8")]
    public StoryInfo(StoryID storyID, APIStoryResponse response)
    {
    }

    [Token(Token = "0x600C711")]
    [Address(RVA = "0x1CDAEC4", Offset = "0x1CDAEC4", VA = "0x1CDAEC4")]
    public void Apply(StoryID storyID, APIStoryResponse response)
    {
    }

    [Token(Token = "0x600C712")]
    [Address(RVA = "0x1CDB798", Offset = "0x1CDB798", VA = "0x1CDB798")]
    public void Initialize()
    {
    }

    [Token(Token = "0x600C713")]
    [Address(RVA = "0x1CDBD68", Offset = "0x1CDBD68", VA = "0x1CDBD68")]
    public void Apply(APIPlayerSigninResponse response)
    {
    }

    [Token(Token = "0x600C714")]
    [Address(RVA = "0x1CDC0D4", Offset = "0x1CDC0D4", VA = "0x1CDC0D4")]
    public void Apply(ISequenceTransitionResult entity)
    {
    }

    [Token(Token = "0x600C715")]
    [Address(RVA = "0x1CDC470", Offset = "0x1CDC470", VA = "0x1CDC470")]
    public void Apply(UpdatedPlayerStoryDataSet entity)
    {
    }

    [Token(Token = "0x600C716")]
    [Address(RVA = "0x1CDC3A4", Offset = "0x1CDC3A4", VA = "0x1CDC3A4")]
    public void Apply(PlayerStoryChapterType entity)
    {
    }

    [Token(Token = "0x600C717")]
    [Address(RVA = "0x1CDB0FC", Offset = "0x1CDB0FC", VA = "0x1CDB0FC")]
    public void Apply(PlayerFreeActionSequenceStatus entity)
    {
    }
  }
}
