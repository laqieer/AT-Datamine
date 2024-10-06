// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.IBattleGroupEffectDataGetter`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20013E8")]
  public interface IBattleGroupEffectDataGetter<TDataEntity> where TDataEntity : IMasterDataEntity, IBattleGroupEffectDataEntity
  {
    [Token(Token = "0x6006FB6")]
    TDataEntity GetByGroupAndValue(int groupId, int value);
  }
}
