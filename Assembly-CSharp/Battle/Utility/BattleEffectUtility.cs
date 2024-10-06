// Decompiled with JetBrains decompiler
// Type: Battle.Utility.BattleEffectUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;

#nullable disable
namespace Battle.Utility
{
  [Token(Token = "0x20022C7")]
  public static class BattleEffectUtility
  {
    [Token(Token = "0x600D416")]
    [Address(RVA = "0x19DE6C4", Offset = "0x19DE6C4", VA = "0x19DE6C4")]
    public static float CalcValueWithContext(
      BattleEffectTypeEnum type,
      BattleEffectValueTypeEnum valueType,
      int context,
      int value,
      int subValue)
    {
      return new float();
    }

    [Token(Token = "0x600D417")]
    private static float GetRatio<TDataEntity>(
      IBattleGroupEffectDataGetter<TDataEntity> master,
      int groupId,
      int contextValue,
      float defaultValue)
      where TDataEntity : IMasterDataEntity, IBattleGroupEffectDataEntity
    {
      return new float();
    }
  }
}
