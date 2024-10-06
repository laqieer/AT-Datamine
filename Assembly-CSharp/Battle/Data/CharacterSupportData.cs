// Decompiled with JetBrains decompiler
// Type: Battle.Data.CharacterSupportData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using GameCore.MasterData;
using Il2CppDummyDll;
using StaqData;
using System.Collections.Generic;

#nullable disable
namespace Battle.Data
{
  [Token(Token = "0x200271B")]
  public sealed class CharacterSupportData : IReadableCharacterSupportData
  {
    [Token(Token = "0x400A745")]
    [FieldOffset(Offset = "0x10")]
    private Dictionary<(int charaId1, int charaId2), (SupportRankData data, int current, int achieved)> supportMap;
    [Token(Token = "0x400A746")]
    [FieldOffset(Offset = "0x18")]
    private SupportRankData defaultRankData;

    [Token(Token = "0x600F2EF")]
    [Address(RVA = "0x41BBA6C", Offset = "0x41BBA6C", VA = "0x41BBA6C")]
    public CharacterSupportData(UnitSupportList supports, Deck deck)
    {
    }

    [Token(Token = "0x600F2F0")]
    [Address(RVA = "0x41BC1CC", Offset = "0x41BC1CC", VA = "0x41BC1CC")]
    public CharacterSupportData(UnitSupportList supports = null)
    {
    }

    [Token(Token = "0x600F2F1")]
    [Address(RVA = "0x41BBDA8", Offset = "0x41BBDA8", VA = "0x41BBDA8")]
    private void Initialize(IReadOnlyList<UnitSupportData> supportList, HashSet<int> characterHash = null)
    {
    }

    [Token(Token = "0x600F2F2")]
    [Address(RVA = "0x41BC304", Offset = "0x41BC304", VA = "0x41BC304")]
    public CharacterSupportData(
      Dictionary<(int charaId1, int charaId2), (SupportRankData data, int current, int achieved)> map)
    {
    }

    [Token(Token = "0x600F2F3")]
    [Address(RVA = "0x41BC54C", Offset = "0x41BC54C", VA = "0x41BC54C", Slot = "4")]
    public SupportRankData GetSupportData(UnitParameterData unit1, UnitParameterData unit2)
    {
      return (SupportRankData) null;
    }

    [Token(Token = "0x600F2F4")]
    [Address(RVA = "0x41BC670", Offset = "0x41BC670", VA = "0x41BC670", Slot = "5")]
    public int GetSupportAchieved(UnitParameterData unit1, UnitParameterData unit2) => new int();

    [Token(Token = "0x600F2F5")]
    [Address(RVA = "0x41BC7B8", Offset = "0x41BC7B8", VA = "0x41BC7B8", Slot = "6")]
    public SupportRankTypeEnum GetSupportRank(UnitParameterData unit1, UnitParameterData unit2)
    {
      return new SupportRankTypeEnum();
    }

    [Token(Token = "0x600F2F6")]
    [Address(RVA = "0x41BC854", Offset = "0x41BC854", VA = "0x41BC854")]
    public int AddAchieve(UnitParameterData unit1, UnitParameterData unit2, int addPoint)
    {
      return new int();
    }

    [Token(Token = "0x600F2F7")]
    [Address(RVA = "0x41BC5B4", Offset = "0x41BC5B4", VA = "0x41BC5B4")]
    public SupportRankData GetSupportData(int charaId1, int charaId2) => (SupportRankData) null;

    [Token(Token = "0x600F2F8")]
    [Address(RVA = "0x41BC6F4", Offset = "0x41BC6F4", VA = "0x41BC6F4", Slot = "7")]
    public int GetSupportAchieved(int charaId1, int charaId2) => new int();

    [Token(Token = "0x600F2F9")]
    [Address(RVA = "0x41BC834", Offset = "0x41BC834", VA = "0x41BC834", Slot = "8")]
    public SupportRankTypeEnum GetSupportRank(int charaId1, int charaId2)
    {
      return new SupportRankTypeEnum();
    }

    [Token(Token = "0x600F2FA")]
    [Address(RVA = "0x41BC8CC", Offset = "0x41BC8CC", VA = "0x41BC8CC")]
    public int AddAchieve(int charaId1, int charaId2, int addPoint) => new int();

    [Token(Token = "0x600F2FB")]
    [Address(RVA = "0x41BCA88", Offset = "0x41BCA88", VA = "0x41BCA88")]
    public bool IsSupportable(int charaId1, int charaId2) => new bool();

    [Token(Token = "0x600F2FC")]
    [Address(RVA = "0x41BC210", Offset = "0x41BC210", VA = "0x41BC210")]
    public void SetSupportMapInfo(
      int charaId1,
      int charaId2,
      SupportRankData rank,
      int current,
      int acheived)
    {
    }

    [Token(Token = "0x600F2FD")]
    [Address(RVA = "0x41BCAA4", Offset = "0x41BCAA4", VA = "0x41BCAA4")]
    private (SupportRankData, int, int)? GetSupportMapInfo(int charaId1, int charaId2)
    {
      return new (SupportRankData, int, int)?();
    }

    [Token(Token = "0x600F2FE")]
    [Address(RVA = "0x41BCB98", Offset = "0x41BCB98", VA = "0x41BCB98", Slot = "9")]
    public List<(int, int, SupportRankData, int, int)> GetList()
    {
      return (List<(int, int, SupportRankData, int, int)>) null;
    }

    [Token(Token = "0x600F2FF")]
    [Address(RVA = "0x41BCE18", Offset = "0x41BCE18", VA = "0x41BCE18")]
    public CharacterSupportData Copy() => (CharacterSupportData) null;

    [Token(Token = "0x600F300")]
    [Address(RVA = "0x41BCEDC", Offset = "0x41BCEDC", VA = "0x41BCEDC")]
    public string ToJson() => (string) null;
  }
}
