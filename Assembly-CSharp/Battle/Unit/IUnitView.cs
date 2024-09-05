// Decompiled with JetBrains decompiler
// Type: Battle.Unit.IUnitView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using Battle.Data.Board;
using Battle.Particle;
using Battle.UI;
using Battle.ViewCamera;
using GameCore.MasterData;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Battle.Unit
{
  [Token(Token = "0x20022E1")]
  public interface IUnitView
  {
    [Token(Token = "0x17002E0A")]
    CharacterActorUI CharacterActorUI { [Token(Token = "0x600D4CF")] get; }

    [Token(Token = "0x17002E0B")]
    bool IsDirtyBadStatusVfx { [Token(Token = "0x600D4D0")] get; }

    [Token(Token = "0x17002E0C")]
    bool IsDirtyPositiveVfx { [Token(Token = "0x600D4D1")] get; }

    [Token(Token = "0x17002E0D")]
    bool IsDirtyNegativeVfx { [Token(Token = "0x600D4D2")] get; }

    [Token(Token = "0x600D4D3")]
    void RegisterMapViewCamera(IMapViewCamera camera);

    [Token(Token = "0x600D4D4")]
    void RemoveMapViewCamera(IMapViewCamera camera);

    [Token(Token = "0x17002E0E")]
    ParticleEmitter.Handle BadStatusVfxHandle { [Token(Token = "0x600D4D5")] get; }

    [Token(Token = "0x600D4D6")]
    void UpdateCurrentBadStatusVfx(ParticleEmitter.Handle vfxHandle);

    [Token(Token = "0x17002E0F")]
    ParticleEmitter.Handle PositiveEffectVfxHandle { [Token(Token = "0x600D4D7")] get; }

    [Token(Token = "0x600D4D8")]
    void UpdateCurrentPositiveEffectVfx(ParticleEmitter.Handle vfxHandle);

    [Token(Token = "0x17002E10")]
    ParticleEmitter.Handle NegativeEffectVfxHandle { [Token(Token = "0x600D4D9")] get; }

    [Token(Token = "0x600D4DA")]
    void UpdateFierceAttackChargingVfx(ParticleEmitter.Handle vfxHandle);

    [Token(Token = "0x17002E11")]
    ParticleEmitter.Handle FierceAttackChargingVfxHandle { [Token(Token = "0x600D4DB")] get; }

    [Token(Token = "0x600D4DC")]
    void Show();

    [Token(Token = "0x600D4DD")]
    void Hide();

    [Token(Token = "0x600D4DE")]
    void ShowSubParts();

    [Token(Token = "0x600D4DF")]
    void HideSubParts();

    [Token(Token = "0x600D4E0")]
    void ShowBarriers();

    [Token(Token = "0x600D4E1")]
    void HideBarriers();

    [Token(Token = "0x600D4E2")]
    void UpdateBarrierObjects(BarrierContainer barrier);

    [Token(Token = "0x600D4E3")]
    void UpdateSubPartsPositions(Vector3 position);

    [Token(Token = "0x600D4E4")]
    void UpdateCurrentNegativeEffectVfx(ParticleEmitter.Handle vfxHandle);

    [Token(Token = "0x17002E12")]
    Vector3 PositionOffset { [Token(Token = "0x600D4E5")] get; [Token(Token = "0x600D4E6")] set; }

    [Token(Token = "0x17002E13")]
    Quaternion RotationOffset { [Token(Token = "0x600D4E7")] get; [Token(Token = "0x600D4E8")] set; }

    [Token(Token = "0x17002E14")]
    Vector3 FootPositionOffset { [Token(Token = "0x600D4E9")] get; }

    [Token(Token = "0x600D4EA")]
    void UpdateWorldPositionTo(Vector3 position, bool ignoreOffset = false);

    [Token(Token = "0x600D4EB")]
    void UpdateWorldPositionWithCurrentMainGrid(
      UnitParameterData unitParam,
      bool ignoreOffset = false,
      CharacterActor actor = null);

    [Token(Token = "0x600D4EC")]
    void UpdateDealSlayIcon(bool hasDealSlay);

    [Token(Token = "0x600D4ED")]
    void UpdateTakeSlayIcon(bool hasTakeSlay);

    [Token(Token = "0x600D4EE")]
    void UpdateDisplayVfx(
      BattleBadStatusTypeEnum? badstatus,
      BattleEffectTypeEnum? positive,
      BattleEffectTypeEnum? nagative);

    [Token(Token = "0x600D4EF")]
    void UnMarkVfxDirty();
  }
}
