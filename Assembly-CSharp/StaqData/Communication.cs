// Decompiled with JetBrains decompiler
// Type: StaqData.Communication
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x20020A8")]
  public class Communication
  {
    [Token(Token = "0x4008AD5")]
    private const int INIT_RANK = 1;
    [Token(Token = "0x4008AD6")]
    private const int INIT_EXP = 0;

    [Token(Token = "0x17002A36")]
    public int CommunicationID
    {
      [Token(Token = "0x600C597"), Address(RVA = "0x1A05D50", Offset = "0x1A05D50", VA = "0x1A05D50")] get
      {
        return new int();
      }
      [Token(Token = "0x600C598"), Address(RVA = "0x1A05D58", Offset = "0x1A05D58", VA = "0x1A05D58")] private set
      {
      }
    }

    [Token(Token = "0x17002A37")]
    public int CommunicationParamID
    {
      [Token(Token = "0x600C599"), Address(RVA = "0x1A05D60", Offset = "0x1A05D60", VA = "0x1A05D60")] get
      {
        return new int();
      }
      [Token(Token = "0x600C59A"), Address(RVA = "0x1A05D68", Offset = "0x1A05D68", VA = "0x1A05D68")] private set
      {
      }
    }

    [Token(Token = "0x17002A38")]
    public bool IsOpen
    {
      [Token(Token = "0x600C59B"), Address(RVA = "0x1A05D70", Offset = "0x1A05D70", VA = "0x1A05D70")] get
      {
        return new bool();
      }
      [Token(Token = "0x600C59C"), Address(RVA = "0x1A05D78", Offset = "0x1A05D78", VA = "0x1A05D78")] private set
      {
      }
    }

    [Token(Token = "0x17002A39")]
    public NPCInfo AreaNPCInfo
    {
      [Token(Token = "0x600C59D"), Address(RVA = "0x1A05D84", Offset = "0x1A05D84", VA = "0x1A05D84")] get
      {
        return (NPCInfo) null;
      }
      [Token(Token = "0x600C59E"), Address(RVA = "0x1A05D8C", Offset = "0x1A05D8C", VA = "0x1A05D8C")] private set
      {
      }
    }

    [Token(Token = "0x17002A3A")]
    public int MaxRank
    {
      [Token(Token = "0x600C59F"), Address(RVA = "0x1A05D94", Offset = "0x1A05D94", VA = "0x1A05D94")] get
      {
        return new int();
      }
      [Token(Token = "0x600C5A0"), Address(RVA = "0x1A05D9C", Offset = "0x1A05D9C", VA = "0x1A05D9C")] private set
      {
      }
    }

    [Token(Token = "0x17002A3B")]
    public int Rank
    {
      [Token(Token = "0x600C5A1"), Address(RVA = "0x1A05DA4", Offset = "0x1A05DA4", VA = "0x1A05DA4")] get
      {
        return new int();
      }
      [Token(Token = "0x600C5A2"), Address(RVA = "0x1A05DAC", Offset = "0x1A05DAC", VA = "0x1A05DAC")] private set
      {
      }
    }

    [Token(Token = "0x17002A3C")]
    public int NextRank
    {
      [Token(Token = "0x600C5A3"), Address(RVA = "0x1A05DB4", Offset = "0x1A05DB4", VA = "0x1A05DB4")] get
      {
        return new int();
      }
      [Token(Token = "0x600C5A4"), Address(RVA = "0x1A05DBC", Offset = "0x1A05DBC", VA = "0x1A05DBC")] private set
      {
      }
    }

    [Token(Token = "0x17002A3D")]
    public int Exp
    {
      [Token(Token = "0x600C5A5"), Address(RVA = "0x1A05DC4", Offset = "0x1A05DC4", VA = "0x1A05DC4")] get
      {
        return new int();
      }
      [Token(Token = "0x600C5A6"), Address(RVA = "0x1A05DCC", Offset = "0x1A05DCC", VA = "0x1A05DCC")] private set
      {
      }
    }

    [Token(Token = "0x17002A3E")]
    public int NextRankExp
    {
      [Token(Token = "0x600C5A7"), Address(RVA = "0x1A05DD4", Offset = "0x1A05DD4", VA = "0x1A05DD4")] get
      {
        return new int();
      }
      [Token(Token = "0x600C5A8"), Address(RVA = "0x1A05DDC", Offset = "0x1A05DDC", VA = "0x1A05DDC")] private set
      {
      }
    }

    [Token(Token = "0x17002A3F")]
    public bool IsRankMax
    {
      [Token(Token = "0x600C5A9"), Address(RVA = "0x1A05DE4", Offset = "0x1A05DE4", VA = "0x1A05DE4")] get
      {
        return new bool();
      }
      [Token(Token = "0x600C5AA"), Address(RVA = "0x1A05DEC", Offset = "0x1A05DEC", VA = "0x1A05DEC")] private set
      {
      }
    }

    [Token(Token = "0x17002A40")]
    public int ADVID
    {
      [Token(Token = "0x600C5AB"), Address(RVA = "0x1A05DF8", Offset = "0x1A05DF8", VA = "0x1A05DF8")] get
      {
        return new int();
      }
      [Token(Token = "0x600C5AC"), Address(RVA = "0x1A05E00", Offset = "0x1A05E00", VA = "0x1A05E00")] private set
      {
      }
    }

    [Token(Token = "0x17002A41")]
    public int RankupADVID
    {
      [Token(Token = "0x600C5AD"), Address(RVA = "0x1A05E08", Offset = "0x1A05E08", VA = "0x1A05E08")] get
      {
        return new int();
      }
      [Token(Token = "0x600C5AE"), Address(RVA = "0x1A05E10", Offset = "0x1A05E10", VA = "0x1A05E10")] private set
      {
      }
    }

    [Token(Token = "0x17002A42")]
    public int Priority
    {
      [Token(Token = "0x600C5AF"), Address(RVA = "0x1A05E18", Offset = "0x1A05E18", VA = "0x1A05E18")] get
      {
        return new int();
      }
      [Token(Token = "0x600C5B0"), Address(RVA = "0x1A05E20", Offset = "0x1A05E20", VA = "0x1A05E20")] private set
      {
      }
    }

    [Token(Token = "0x17002A43")]
    public bool IsOpenedAtPastSequence
    {
      [Token(Token = "0x600C5B1"), Address(RVA = "0x1A05E28", Offset = "0x1A05E28", VA = "0x1A05E28")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002A44")]
    public bool IsRankUp
    {
      [Token(Token = "0x600C5B2"), Address(RVA = "0x1A05E38", Offset = "0x1A05E38", VA = "0x1A05E38")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002A45")]
    public bool IsRankUpCommuActive
    {
      [Token(Token = "0x600C5B3"), Address(RVA = "0x1A05EA4", Offset = "0x1A05EA4", VA = "0x1A05EA4")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002A46")]
    public int CharacterID
    {
      [Token(Token = "0x600C5B4"), Address(RVA = "0x1A05F08", Offset = "0x1A05F08", VA = "0x1A05F08")] get
      {
        return new int();
      }
      [Token(Token = "0x600C5B5"), Address(RVA = "0x1A05F10", Offset = "0x1A05F10", VA = "0x1A05F10")] private set
      {
      }
    }

    [Token(Token = "0x17002A47")]
    public string CharacterName
    {
      [Token(Token = "0x600C5B6"), Address(RVA = "0x1A05F18", Offset = "0x1A05F18", VA = "0x1A05F18")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17002A48")]
    public bool ReachedRelationShip
    {
      [Token(Token = "0x600C5B7"), Address(RVA = "0x1A05F24", Offset = "0x1A05F24", VA = "0x1A05F24")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002A49")]
    public bool ReachedHumanParameter
    {
      [Token(Token = "0x600C5B8"), Address(RVA = "0x1A06028", Offset = "0x1A06028", VA = "0x1A06028")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002A4A")]
    public int GroupLabel
    {
      [Token(Token = "0x600C5B9"), Address(RVA = "0x1A06434", Offset = "0x1A06434", VA = "0x1A06434")] get
      {
        return new int();
      }
      [Token(Token = "0x600C5BA"), Address(RVA = "0x1A0643C", Offset = "0x1A0643C", VA = "0x1A0643C")] private set
      {
      }
    }

    [Token(Token = "0x600C5BB")]
    [Address(RVA = "0x1A06044", Offset = "0x1A06044", VA = "0x1A06044")]
    public bool ReachedHumanParameters(
      out IReadOnlyList<StoryCommunicationRankupConditionData> conditions)
    {
      return new bool();
    }

    [Token(Token = "0x17002A4B")]
    public IReadOnlyList<StoryCommunicationRankupConditionData> RankupConditionHumanParameters
    {
      [Token(Token = "0x600C5BC"), Address(RVA = "0x1A06444", Offset = "0x1A06444", VA = "0x1A06444")] get
      {
        return (IReadOnlyList<StoryCommunicationRankupConditionData>) null;
      }
      [Token(Token = "0x600C5BD"), Address(RVA = "0x1A0644C", Offset = "0x1A0644C", VA = "0x1A0644C")] private set
      {
      }
    }

    [Token(Token = "0x600C5BE")]
    [Address(RVA = "0x1A04608", Offset = "0x1A04608", VA = "0x1A04608")]
    public Communication(int communicationID)
    {
    }

    [Token(Token = "0x600C5BF")]
    [Address(RVA = "0x1A0464C", Offset = "0x1A0464C", VA = "0x1A0464C")]
    public void SetObjectInfo(int objectID)
    {
    }

    [Token(Token = "0x600C5C0")]
    [Address(RVA = "0x1A04ED8", Offset = "0x1A04ED8", VA = "0x1A04ED8")]
    public void Apply(int communicationID, bool isOpen, int rank = 1, int exp = 0, int maxRank = 0)
    {
    }

    [Token(Token = "0x600C5C1")]
    [Address(RVA = "0x1A06454", Offset = "0x1A06454", VA = "0x1A06454")]
    public string GetRankupHintTextInFreeMap() => (string) null;

    [Token(Token = "0x600C5C2")]
    [Address(RVA = "0x1A0653C", Offset = "0x1A0653C", VA = "0x1A0653C")]
    public CharacterData GetCharacter() => (CharacterData) null;

    [Token(Token = "0x600C5C3")]
    [Address(RVA = "0x1A065D8", Offset = "0x1A065D8", VA = "0x1A065D8")]
    public List<StoryCommunicationLocationCharacterData> GetLocations()
    {
      return (List<StoryCommunicationLocationCharacterData>) null;
    }
  }
}
