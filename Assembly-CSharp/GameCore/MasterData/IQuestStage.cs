// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.IQuestStage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200142D")]
  public interface IQuestStage : IMasterDataEntity
  {
    [Token(Token = "0x17001123")]
    string QuestName { [Token(Token = "0x600718C")] get; }

    [Token(Token = "0x17001124")]
    string QuestSummary { [Token(Token = "0x600718D")] get; }

    [Token(Token = "0x17001125")]
    int ConsumeCost { [Token(Token = "0x600718E")] get; }

    [Token(Token = "0x17001126")]
    BattleComsumeCostTypeEnum ConsumeCostType { [Token(Token = "0x600718F")] get; }

    [Token(Token = "0x17001127")]
    int LimitWeaponProficiency { [Token(Token = "0x6007190")] get; }

    [Token(Token = "0x17001128")]
    int BattleId { [Token(Token = "0x6007191")] get; }

    [Token(Token = "0x17001129")]
    int GetApCost { [Token(Token = "0x6007192")] get; }

    [Token(Token = "0x1700112A")]
    int FieldImageResourceID { [Token(Token = "0x6007193")] get; }
  }
}
