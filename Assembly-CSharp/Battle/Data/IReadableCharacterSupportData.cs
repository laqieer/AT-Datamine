// Decompiled with JetBrains decompiler
// Type: Battle.Data.IReadableCharacterSupportData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Battle.Data
{
  [Token(Token = "0x200271A")]
  public interface IReadableCharacterSupportData
  {
    [Token(Token = "0x600F2E9")]
    SupportRankData GetSupportData(UnitParameterData unit1, UnitParameterData unit2);

    [Token(Token = "0x600F2EA")]
    int GetSupportAchieved(UnitParameterData unit1, UnitParameterData unit2);

    [Token(Token = "0x600F2EB")]
    SupportRankTypeEnum GetSupportRank(UnitParameterData unit1, UnitParameterData unit2);

    [Token(Token = "0x600F2EC")]
    int GetSupportAchieved(int charaId1, int charaId2);

    [Token(Token = "0x600F2ED")]
    SupportRankTypeEnum GetSupportRank(int charaId1, int charaId2);

    [Token(Token = "0x600F2EE")]
    List<(int, int, SupportRankData, int, int)> GetList();
  }
}
