// Decompiled with JetBrains decompiler
// Type: Scenes.Expedition.Boss.BattleResult.BossData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;

#nullable disable
namespace Scenes.Expedition.Boss.BattleResult
{
  [Token(Token = "0x2002D5F")]
  public class BossData
  {
    [Token(Token = "0x400C2B6")]
    [FieldOffset(Offset = "0x10")]
    public int BossID;
    [Token(Token = "0x400C2B7")]
    [FieldOffset(Offset = "0x18")]
    public string BossName;
    [Token(Token = "0x400C2B8")]
    [FieldOffset(Offset = "0x20")]
    public int Level;
    [Token(Token = "0x400C2B9")]
    [FieldOffset(Offset = "0x24")]
    public int CurrentHp;
    [Token(Token = "0x400C2BA")]
    [FieldOffset(Offset = "0x28")]
    public int MaxHp;
    [Token(Token = "0x400C2BB")]
    [FieldOffset(Offset = "0x2C")]
    public int CombatPower;
    [Token(Token = "0x400C2BC")]
    [FieldOffset(Offset = "0x30")]
    public ElementTypeEnum Element;

    [Token(Token = "0x6011BC2")]
    [Address(RVA = "0x42BB808", Offset = "0x42BB808", VA = "0x42BB808")]
    public BossData(
      int bossId,
      string bossName,
      int level,
      int currentHp,
      int maxHp,
      int combatPower,
      ElementTypeEnum element)
    {
    }
  }
}
