// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.IFacilityPlacementData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20013EA")]
  public interface IFacilityPlacementData
  {
    [Token(Token = "0x170010BF")]
    int Id { [Token(Token = "0x6006FB8")] get; }

    [Token(Token = "0x170010C0")]
    int BattleFacility { [Token(Token = "0x6006FB9")] get; }

    [Token(Token = "0x170010C1")]
    int GroupId { [Token(Token = "0x6006FBA")] get; }

    [Token(Token = "0x170010C2")]
    Vector2Int Coordinate { [Token(Token = "0x6006FBB")] get; }

    [Token(Token = "0x170010C3")]
    int Direct { [Token(Token = "0x6006FBC")] get; }

    [Token(Token = "0x170010C4")]
    bool DefaultSwitch { [Token(Token = "0x6006FBD")] get; }

    [Token(Token = "0x170010C5")]
    int ForceId { [Token(Token = "0x6006FBE")] get; }

    [Token(Token = "0x170010C6")]
    bool ControllableAlly { [Token(Token = "0x6006FBF")] get; }

    [Token(Token = "0x170010C7")]
    bool ControllableEnemy { [Token(Token = "0x6006FC0")] get; }

    [Token(Token = "0x170010C8")]
    bool ControllableFriend { [Token(Token = "0x6006FC1")] get; }

    [Token(Token = "0x170010C9")]
    bool ControllableThird { [Token(Token = "0x6006FC2")] get; }

    [Token(Token = "0x170010CA")]
    int RequiredExpendables { [Token(Token = "0x6006FC3")] get; }

    [Token(Token = "0x170010CB")]
    int RequiredAmount { [Token(Token = "0x6006FC4")] get; }

    [Token(Token = "0x170010CC")]
    string OverrideDescription { [Token(Token = "0x6006FC5")] get; }
  }
}
