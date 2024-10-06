// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.IUnitPlacementData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20013ED")]
  public interface IUnitPlacementData
  {
    [Token(Token = "0x170010D0")]
    int Id { [Token(Token = "0x6006FCA")] get; }

    [Token(Token = "0x170010D1")]
    int Troops { [Token(Token = "0x6006FCB")] get; }

    [Token(Token = "0x170010D2")]
    int NpcMasterDataId { [Token(Token = "0x6006FCC")] get; }

    [Token(Token = "0x170010D3")]
    int UnitNo { [Token(Token = "0x6006FCD")] get; }

    [Token(Token = "0x170010D4")]
    int SortieFromX { [Token(Token = "0x6006FCE")] get; }

    [Token(Token = "0x170010D5")]
    int SortieFromY { [Token(Token = "0x6006FCF")] get; }

    [Token(Token = "0x170010D6")]
    int WaitTurnCount { [Token(Token = "0x6006FD0")] get; }

    [Token(Token = "0x170010D7")]
    int X { [Token(Token = "0x6006FD1")] get; }

    [Token(Token = "0x170010D8")]
    int Y { [Token(Token = "0x6006FD2")] get; }

    [Token(Token = "0x170010D9")]
    int BaseExp { [Token(Token = "0x6006FD3")] get; }

    [Token(Token = "0x170010DA")]
    int Damage { [Token(Token = "0x6006FD4")] get; [Token(Token = "0x6006FD5")] set; }

    [Token(Token = "0x170010DB")]
    int Barrier { [Token(Token = "0x6006FD6")] get; }

    [Token(Token = "0x170010DC")]
    int BarrierHp { [Token(Token = "0x6006FD7")] get; }

    [Token(Token = "0x170010DD")]
    bool Modifiable { [Token(Token = "0x6006FD8")] get; }

    [Token(Token = "0x170010DE")]
    int BaseSupportRank { [Token(Token = "0x6006FD9")] get; }

    [Token(Token = "0x6006FDA")]
    Dictionary<int, int> GetSupportInfo();

    [Token(Token = "0x170010DF")]
    QuestCorrection Correction { [Token(Token = "0x6006FDB")] get; [Token(Token = "0x6006FDC")] set; }

    [Token(Token = "0x170010E0")]
    bool IsBoss { [Token(Token = "0x6006FDD")] get; }
  }
}
