// Decompiled with JetBrains decompiler
// Type: Battle.IDuelDebugToolCharacterSettings
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;

#nullable disable
namespace Battle
{
  [Token(Token = "0x2002288")]
  public interface IDuelDebugToolCharacterSettings
  {
    [Token(Token = "0x600D289")]
    bool GetIsAvailable();

    [Token(Token = "0x600D28A")]
    string GetWeaponClass();

    [Token(Token = "0x600D28B")]
    string GetOverrideMotionType();

    [Token(Token = "0x600D28C")]
    int GetWeaponID();

    [Token(Token = "0x600D28D")]
    int GetCharacterID();

    [Token(Token = "0x600D28E")]
    int GetCharacterStyleID();

    [Token(Token = "0x600D28F")]
    string GetDuelMotionType();

    [Token(Token = "0x600D290")]
    string GetCommonSkillMotionType();

    [Token(Token = "0x600D291")]
    int GetVehicleStyleID();

    [Token(Token = "0x600D292")]
    SexTypeEnum GetGender();

    [Token(Token = "0x600D293")]
    bool GetIsAbnormalState();

    [Token(Token = "0x600D294")]
    BattleBadStatusTypeEnum GetAbnormalState();

    [Token(Token = "0x600D295")]
    int GetMaxHP();

    [Token(Token = "0x600D296")]
    int GetCurrentHP();
  }
}
