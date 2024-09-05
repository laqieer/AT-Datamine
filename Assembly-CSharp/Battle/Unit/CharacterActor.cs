// Decompiled with JetBrains decompiler
// Type: Battle.Unit.CharacterActor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using Battle.Data.Board;
using Battle.Particle;
using Battle.Stage;
using Battle.UI;
using Battle.ViewCamera;
using GameCore.MasterData;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Battle.Unit
{
  [Token(Token = "0x20022E3")]
  public class CharacterActor : Actor, IUnitView
  {
    [Token(Token = "0x4009381")]
    [FieldOffset(Offset = "0x98")]
    private AnimatorOverrideController overrideController;
    [Token(Token = "0x4009382")]
    [FieldOffset(Offset = "0xA0")]
    private CharacterActorMaterialController materialController;
    [Token(Token = "0x4009383")]
    [FieldOffset(Offset = "0xA8")]
    private List<CharacterActorMaterialController> weaponMaterials;
    [Token(Token = "0x4009384")]
    [FieldOffset(Offset = "0xB0")]
    private Dictionary<int, DotWeaponAssetDataBase> weaponAssetDic;
    [Token(Token = "0x4009385")]
    [FieldOffset(Offset = "0xB8")]
    private GameObject mainWeaponObject;
    [Token(Token = "0x4009386")]
    [FieldOffset(Offset = "0xC0")]
    private GameObject subWeaponObject;
    [Token(Token = "0x4009387")]
    [FieldOffset(Offset = "0xC8")]
    private IReadOnlyList<IBarrier> barrierObjects;
    [Token(Token = "0x4009388")]
    [FieldOffset(Offset = "0xD0")]
    private List<WeakReference<IMapViewCamera>> registeredCameras;
    [Token(Token = "0x4009389")]
    [FieldOffset(Offset = "0xD8")]
    private VfxFlagContainer vfxFlagContainer;
    [Token(Token = "0x400938A")]
    [FieldOffset(Offset = "0xDC")]
    private BattleBadStatusTypeEnum? displayBadStatus;
    [Token(Token = "0x400938B")]
    [FieldOffset(Offset = "0xE4")]
    private BattleEffectTypeEnum? displayPositiveEffect;
    [Token(Token = "0x400938C")]
    [FieldOffset(Offset = "0xEC")]
    private BattleEffectTypeEnum? displayNegativeEffect;
    [Token(Token = "0x400938D")]
    [FieldOffset(Offset = "0xF8")]
    private BattleConfigAsset battleConfig;
    [Token(Token = "0x400938E")]
    [FieldOffset(Offset = "0x100")]
    private IActorViewData characterActorViewData;
    [Token(Token = "0x400938F")]
    [FieldOffset(Offset = "0x108")]
    private CharacterActorUI characterActorUI;
    [Token(Token = "0x4009390")]
    [FieldOffset(Offset = "0x110")]
    private Actor.Direction? reserveDirection;

    [Token(Token = "0x17002E15")]
    public override Transform LocatorEffectHead
    {
      [Token(Token = "0x600D4F2"), Address(RVA = "0x19E8ED4", Offset = "0x19E8ED4", VA = "0x19E8ED4", Slot = "36")] get
      {
        return (Transform) null;
      }
    }

    [Token(Token = "0x17002E16")]
    public override Transform LocatorEffectBody
    {
      [Token(Token = "0x600D4F3"), Address(RVA = "0x19E8EF4", Offset = "0x19E8EF4", VA = "0x19E8EF4", Slot = "37")] get
      {
        return (Transform) null;
      }
    }

    [Token(Token = "0x17002E17")]
    public override Transform LocatorEffectBottom
    {
      [Token(Token = "0x600D4F4"), Address(RVA = "0x19E8F14", Offset = "0x19E8F14", VA = "0x19E8F14", Slot = "38")] get
      {
        return (Transform) null;
      }
    }

    [Token(Token = "0x17002E18")]
    public override Transform LocatorEffectWeapon
    {
      [Token(Token = "0x600D4F5"), Address(RVA = "0x19E8F34", Offset = "0x19E8F34", VA = "0x19E8F34", Slot = "39")] get
      {
        return (Transform) null;
      }
    }

    [Token(Token = "0x17002E19")]
    public ActorLocator Locator
    {
      [Token(Token = "0x600D4F6"), Address(RVA = "0x19E8F54", Offset = "0x19E8F54", VA = "0x19E8F54")] get
      {
        return (ActorLocator) null;
      }
      [Token(Token = "0x600D4F7"), Address(RVA = "0x19E8F5C", Offset = "0x19E8F5C", VA = "0x19E8F5C")] private set
      {
      }
    }

    [Token(Token = "0x17002E1A")]
    public Vector3 FootPositionOffset
    {
      [Token(Token = "0x600D4F8"), Address(RVA = "0x19E8F64", Offset = "0x19E8F64", VA = "0x19E8F64", Slot = "102")] get
      {
        return new Vector3();
      }
      [Token(Token = "0x600D4F9"), Address(RVA = "0x19E8F70", Offset = "0x19E8F70", VA = "0x19E8F70")] private set
      {
      }
    }

    [Token(Token = "0x17002E1B")]
    public OverrideResourceData OverrideResource
    {
      [Token(Token = "0x600D4FA"), Address(RVA = "0x19E8F7C", Offset = "0x19E8F7C", VA = "0x19E8F7C")] get
      {
        return (OverrideResourceData) null;
      }
      [Token(Token = "0x600D4FB"), Address(RVA = "0x19E8F84", Offset = "0x19E8F84", VA = "0x19E8F84")] private set
      {
      }
    }

    [Token(Token = "0x17002E1C")]
    public Vector3 EffectBottomPos
    {
      [Token(Token = "0x600D4FC"), Address(RVA = "0x19E8F8C", Offset = "0x19E8F8C", VA = "0x19E8F8C")] get
      {
        return new Vector3();
      }
    }

    [Token(Token = "0x600D4FD")]
    [Address(RVA = "0x19E8FD0", Offset = "0x19E8FD0", VA = "0x19E8FD0")]
    public Transform GetLocator(string name) => (Transform) null;

    [Token(Token = "0x17002E1D")]
    public bool IsFixedDotUnitColor
    {
      [Token(Token = "0x600D4FE"), Address(RVA = "0x19E8FE8", Offset = "0x19E8FE8", VA = "0x19E8FE8")] get
      {
        return new bool();
      }
      [Token(Token = "0x600D4FF"), Address(RVA = "0x19E8FF0", Offset = "0x19E8FF0", VA = "0x19E8FF0")] set
      {
      }
    }

    [Token(Token = "0x17002E1E")]
    public CharacterActorUI CharacterActorUI
    {
      [Token(Token = "0x600D500"), Address(RVA = "0x19E8FFC", Offset = "0x19E8FFC", VA = "0x19E8FFC", Slot = "76")] get
      {
        return (CharacterActorUI) null;
      }
    }

    [Token(Token = "0x17002E1F")]
    public Actor.Direction? ReserveDirection
    {
      [Token(Token = "0x600D501"), Address(RVA = "0x19E9004", Offset = "0x19E9004", VA = "0x19E9004")] get
      {
        return new Actor.Direction?();
      }
      [Token(Token = "0x600D502"), Address(RVA = "0x19E900C", Offset = "0x19E900C", VA = "0x19E900C")] set
      {
      }
    }

    [Token(Token = "0x600D503")]
    [Address(RVA = "0x19E9014", Offset = "0x19E9014", VA = "0x19E9014")]
    private void ExecuteReserveDirection()
    {
    }

    [Token(Token = "0x600D504")]
    [Address(RVA = "0x19E90A4", Offset = "0x19E90A4", VA = "0x19E90A4", Slot = "47")]
    protected override void InitializeInternal(
      IActorViewData actorViewData,
      BattleConfigAsset config)
    {
    }

    [Token(Token = "0x600D505")]
    [Address(RVA = "0x19E93E0", Offset = "0x19E93E0", VA = "0x19E93E0")]
    public void SetUp(
      BattleStage battleStage,
      ISystemFlags sys,
      UIManager uiManager,
      UnitParameterData unitParam,
      OverrideResourceData overrideResource,
      IReadOnlyList<IBarrier> barrierObjects,
      bool isExpeditionBossBattle = false)
    {
    }

    [Token(Token = "0x600D506")]
    [Address(RVA = "0x19E9528", Offset = "0x19E9528", VA = "0x19E9528")]
    public void EquipWeapon(WeaponParameterData weapon)
    {
    }

    [Token(Token = "0x600D507")]
    [Address(RVA = "0x19E9660", Offset = "0x19E9660", VA = "0x19E9660")]
    private void DetachEquippedWeaponObject()
    {
    }

    [Token(Token = "0x600D508")]
    [Address(RVA = "0x19E9780", Offset = "0x19E9780", VA = "0x19E9780")]
    private void EquipWeaponObject(GameObject main, GameObject sub)
    {
    }

    [Token(Token = "0x600D509")]
    [Address(RVA = "0x19E9A90", Offset = "0x19E9A90", VA = "0x19E9A90")]
    public void PlayFormChange()
    {
    }

    [Token(Token = "0x600D50A")]
    [Address(RVA = "0x19E9A94", Offset = "0x19E9A94", VA = "0x19E9A94", Slot = "66")]
    public override void PlayDefaultAnimation()
    {
    }

    [Token(Token = "0x600D50B")]
    [Address(RVA = "0x19E9AB0", Offset = "0x19E9AB0", VA = "0x19E9AB0", Slot = "48")]
    protected override void InternalPlayAnimation(
      Actor.AnimationType animation,
      Actor.Direction direction,
      bool resetTime)
    {
    }

    [Token(Token = "0x600D50C")]
    [Address(RVA = "0x19E9BA4", Offset = "0x19E9BA4", VA = "0x19E9BA4", Slot = "67")]
    public override void UpdateUnitAlpha(float alpha)
    {
    }

    [Token(Token = "0x600D50D")]
    [Address(RVA = "0x19E9DF8", Offset = "0x19E9DF8", VA = "0x19E9DF8", Slot = "46")]
    public override void ChangeMotions(IDotWeaponAssetData weaponAssetData)
    {
    }

    [Token(Token = "0x600D50E")]
    [Address(RVA = "0x19E9EA0", Offset = "0x19E9EA0", VA = "0x19E9EA0", Slot = "68")]
    public override void ResetBadStatusShaderProperty()
    {
    }

    [Token(Token = "0x600D50F")]
    [Address(RVA = "0x19EA004", Offset = "0x19EA004", VA = "0x19EA004", Slot = "69")]
    public override void UpdateUnitColor(Color color)
    {
    }

    [Token(Token = "0x600D510")]
    [Address(RVA = "0x19EA1A0", Offset = "0x19EA1A0", VA = "0x19EA1A0", Slot = "70")]
    public override void UpdateUnitMonochrome(float enable)
    {
    }

    [Token(Token = "0x600D511")]
    [Address(RVA = "0x19EA310", Offset = "0x19EA310", VA = "0x19EA310", Slot = "71")]
    public override void UpdateUnitHardlightBlend(float blend)
    {
    }

    [Token(Token = "0x600D512")]
    [Address(RVA = "0x19EA480", Offset = "0x19EA480", VA = "0x19EA480", Slot = "72")]
    public override void UpdateUnitHardlightColor(Color color)
    {
    }

    [Token(Token = "0x600D513")]
    [Address(RVA = "0x19EA61C", Offset = "0x19EA61C", VA = "0x19EA61C", Slot = "73")]
    public override void ForceUpdateUnitMaterial()
    {
    }

    [Token(Token = "0x600D514")]
    [Address(RVA = "0x19EA778", Offset = "0x19EA778", VA = "0x19EA778", Slot = "74")]
    protected override void Update()
    {
    }

    [Token(Token = "0x600D515")]
    [Address(RVA = "0x19EA8DC", Offset = "0x19EA8DC", VA = "0x19EA8DC")]
    public void UpdateFromUnitParam(UnitParameterData unitParam, CharacterActor frontActor = null)
    {
    }

    [Token(Token = "0x600D516")]
    [Address(RVA = "0x19EAE9C", Offset = "0x19EAE9C", VA = "0x19EAE9C")]
    private void UpdateEquipWeaponView(UnitParameterData unitParam)
    {
    }

    [Token(Token = "0x600D517")]
    [Address(RVA = "0x19EB7B8", Offset = "0x19EB7B8", VA = "0x19EB7B8")]
    public void UpdateEquipWeapon(UnitParameterData unitParam)
    {
    }

    [Token(Token = "0x600D518")]
    [Address(RVA = "0x19EACA8", Offset = "0x19EACA8", VA = "0x19EACA8")]
    public void SetPositionOffset(UnitParameterData unitParam)
    {
    }

    [Token(Token = "0x600D519")]
    [Address(RVA = "0x19EAD9C", Offset = "0x19EAD9C", VA = "0x19EAD9C")]
    private void UpdateFierceCount(UnitParameterData unitParam)
    {
    }

    [Token(Token = "0x600D51A")]
    [Address(RVA = "0x19E9354", Offset = "0x19E9354", VA = "0x19E9354")]
    public void UpdateFromTargetState(TargetState state)
    {
    }

    [Token(Token = "0x600D51B")]
    [Address(RVA = "0x19EB7BC", Offset = "0x19EB7BC", VA = "0x19EB7BC")]
    public void UpdatePredictionHP(int maxHp, int currentHp, int afterHp)
    {
    }

    [Token(Token = "0x600D51C")]
    [Address(RVA = "0x19EB87C", Offset = "0x19EB87C", VA = "0x19EB87C")]
    public void SetHpGaugeAnimation(int damage)
    {
    }

    [Token(Token = "0x600D51D")]
    [Address(RVA = "0x19EB920", Offset = "0x19EB920", VA = "0x19EB920")]
    public void SetHpGaugeHealAnimation(int healValue)
    {
    }

    [Token(Token = "0x600D51E")]
    [Address(RVA = "0x19EB928", Offset = "0x19EB928", VA = "0x19EB928")]
    public void AddWeaponAsset(int weaponId, DotWeaponAssetDataBase asset)
    {
    }

    [Token(Token = "0x600D51F")]
    [Address(RVA = "0x19EB9C8", Offset = "0x19EB9C8", VA = "0x19EB9C8")]
    public Vector3 GetDoubleUnitPositionOffset(CharacterActor doubleActor) => new Vector3();

    [Token(Token = "0x600D520")]
    [Address(RVA = "0x19EBAFC", Offset = "0x19EBAFC", VA = "0x19EBAFC")]
    public Vector3 GetDoubleLeaderUnitPositionOffset() => new Vector3();

    [Token(Token = "0x600D521")]
    [Address(RVA = "0x19EBB40", Offset = "0x19EBB40", VA = "0x19EBB40")]
    public void Release()
    {
    }

    [Token(Token = "0x600D522")]
    [Address(RVA = "0x19EBF04", Offset = "0x19EBF04", VA = "0x19EBF04")]
    public (string, Transform) GetInitiationEffectInformation(
      BattleBadStatusTypeEnum badStatusTypeEnum)
    {
      return ();
    }

    [Token(Token = "0x600D523")]
    [Address(RVA = "0x19EC080", Offset = "0x19EC080", VA = "0x19EC080")]
    public (string, Transform) GetLoopEffectInformation(BattleBadStatusTypeEnum badStatusTypeEnum)
    {
      return ();
    }

    [Token(Token = "0x600D524")]
    [Address(RVA = "0x19EC1FC", Offset = "0x19EC1FC", VA = "0x19EC1FC")]
    public void UpdateBadStatusShaderProperty(BattleBadStatusTypeEnum badStatusTypeEnum)
    {
    }

    [Token(Token = "0x17002E20")]
    public ParticleEmitter.Handle BadStatusVfxHandle
    {
      [Token(Token = "0x600D525"), Address(RVA = "0x19EC378", Offset = "0x19EC378", VA = "0x19EC378", Slot = "82")] get
      {
        return new ParticleEmitter.Handle();
      }
      [Token(Token = "0x600D526"), Address(RVA = "0x19EC384", Offset = "0x19EC384", VA = "0x19EC384")] private set
      {
      }
    }

    [Token(Token = "0x17002E21")]
    public ParticleEmitter.Handle PositiveEffectVfxHandle
    {
      [Token(Token = "0x600D527"), Address(RVA = "0x19EC38C", Offset = "0x19EC38C", VA = "0x19EC38C", Slot = "84")] get
      {
        return new ParticleEmitter.Handle();
      }
      [Token(Token = "0x600D528"), Address(RVA = "0x19EC398", Offset = "0x19EC398", VA = "0x19EC398")] private set
      {
      }
    }

    [Token(Token = "0x17002E22")]
    public ParticleEmitter.Handle NegativeEffectVfxHandle
    {
      [Token(Token = "0x600D529"), Address(RVA = "0x19EC3A0", Offset = "0x19EC3A0", VA = "0x19EC3A0", Slot = "86")] get
      {
        return new ParticleEmitter.Handle();
      }
      [Token(Token = "0x600D52A"), Address(RVA = "0x19EC3AC", Offset = "0x19EC3AC", VA = "0x19EC3AC")] private set
      {
      }
    }

    [Token(Token = "0x17002E23")]
    public bool IsDirtyBadStatusVfx
    {
      [Token(Token = "0x600D52B"), Address(RVA = "0x19EC3B4", Offset = "0x19EC3B4", VA = "0x19EC3B4", Slot = "77")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002E24")]
    public bool IsDirtyPositiveVfx
    {
      [Token(Token = "0x600D52C"), Address(RVA = "0x19EC3BC", Offset = "0x19EC3BC", VA = "0x19EC3BC", Slot = "78")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002E25")]
    public bool IsDirtyNegativeVfx
    {
      [Token(Token = "0x600D52D"), Address(RVA = "0x19EC3C4", Offset = "0x19EC3C4", VA = "0x19EC3C4", Slot = "79")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002E26")]
    public ParticleEmitter.Handle FierceAttackChargingVfxHandle
    {
      [Token(Token = "0x600D52E"), Address(RVA = "0x19EC3CC", Offset = "0x19EC3CC", VA = "0x19EC3CC", Slot = "88")] get
      {
        return new ParticleEmitter.Handle();
      }
      [Token(Token = "0x600D52F"), Address(RVA = "0x19EC3D8", Offset = "0x19EC3D8", VA = "0x19EC3D8")] private set
      {
      }
    }

    [Token(Token = "0x600D530")]
    [Address(RVA = "0x19EC3E0", Offset = "0x19EC3E0", VA = "0x19EC3E0", Slot = "80")]
    public void RegisterMapViewCamera(IMapViewCamera camera)
    {
    }

    [Token(Token = "0x600D531")]
    [Address(RVA = "0x19EBD3C", Offset = "0x19EBD3C", VA = "0x19EBD3C", Slot = "81")]
    public void RemoveMapViewCamera(IMapViewCamera camera)
    {
    }

    [Token(Token = "0x600D532")]
    [Address(RVA = "0x19EC600", Offset = "0x19EC600", VA = "0x19EC600")]
    protected new void OnUpdateMapViewCameraRotation(Quaternion rotation)
    {
    }

    [Token(Token = "0x600D533")]
    [Address(RVA = "0x19EC9D4", Offset = "0x19EC9D4", VA = "0x19EC9D4", Slot = "83")]
    public void UpdateCurrentBadStatusVfx(ParticleEmitter.Handle vfxHandle)
    {
    }

    [Token(Token = "0x600D534")]
    [Address(RVA = "0x19EC9DC", Offset = "0x19EC9DC", VA = "0x19EC9DC", Slot = "85")]
    public void UpdateCurrentPositiveEffectVfx(ParticleEmitter.Handle vfxHandle)
    {
    }

    [Token(Token = "0x600D535")]
    [Address(RVA = "0x19EC9E4", Offset = "0x19EC9E4", VA = "0x19EC9E4", Slot = "97")]
    public void UpdateCurrentNegativeEffectVfx(ParticleEmitter.Handle vfxHandle)
    {
    }

    [Token(Token = "0x600D536")]
    [Address(RVA = "0x19EC9EC", Offset = "0x19EC9EC", VA = "0x19EC9EC", Slot = "87")]
    public void UpdateFierceAttackChargingVfx(ParticleEmitter.Handle vfxHandle)
    {
    }

    [Token(Token = "0x600D537")]
    [Address(RVA = "0x19EC9F4", Offset = "0x19EC9F4", VA = "0x19EC9F4", Slot = "44")]
    public override void Show()
    {
    }

    [Token(Token = "0x600D538")]
    [Address(RVA = "0x19ECA24", Offset = "0x19ECA24", VA = "0x19ECA24", Slot = "91")]
    public void ShowSubParts()
    {
    }

    [Token(Token = "0x600D539")]
    [Address(RVA = "0x19ECD8C", Offset = "0x19ECD8C", VA = "0x19ECD8C", Slot = "45")]
    public override void Hide()
    {
    }

    [Token(Token = "0x600D53A")]
    [Address(RVA = "0x19EB794", Offset = "0x19EB794", VA = "0x19EB794", Slot = "92")]
    public void HideSubParts()
    {
    }

    [Token(Token = "0x600D53B")]
    [Address(RVA = "0x19ECA48", Offset = "0x19ECA48", VA = "0x19ECA48", Slot = "93")]
    public void ShowBarriers()
    {
    }

    [Token(Token = "0x600D53C")]
    [Address(RVA = "0x19ECDBC", Offset = "0x19ECDBC", VA = "0x19ECDBC", Slot = "94")]
    public void HideBarriers()
    {
    }

    [Token(Token = "0x600D53D")]
    [Address(RVA = "0x19EAFD0", Offset = "0x19EAFD0", VA = "0x19EAFD0", Slot = "95")]
    public void UpdateBarrierObjects(BarrierContainer barrier)
    {
    }

    [Token(Token = "0x600D53E")]
    [Address(RVA = "0x19EB3B8", Offset = "0x19EB3B8", VA = "0x19EB3B8", Slot = "96")]
    public void UpdateSubPartsPositions(Vector3 position)
    {
    }

    [Token(Token = "0x600D53F")]
    [Address(RVA = "0x19ED104", Offset = "0x19ED104", VA = "0x19ED104", Slot = "103")]
    public void UpdateWorldPositionTo(Vector3 position, bool ignoreOffset = false)
    {
    }

    [Token(Token = "0x600D540")]
    [Address(RVA = "0x19ED17C", Offset = "0x19ED17C", VA = "0x19ED17C")]
    public void UpdateWorldPositionTo(
      UnitParameterData unitParam,
      Vector3 position,
      bool ignoreOffset = false)
    {
    }

    [Token(Token = "0x600D541")]
    [Address(RVA = "0x19ED1F4", Offset = "0x19ED1F4", VA = "0x19ED1F4")]
    public void UpdateWorldPositionOnDoubled(CharacterActor leaderActor)
    {
    }

    [Token(Token = "0x600D542")]
    [Address(RVA = "0x19EB1E8", Offset = "0x19EB1E8", VA = "0x19EB1E8", Slot = "104")]
    public void UpdateWorldPositionWithCurrentMainGrid(
      UnitParameterData unitParam,
      bool ignoreOffset = false,
      CharacterActor doubleCharacter = null)
    {
    }

    [Token(Token = "0x600D543")]
    [Address(RVA = "0x19ED3A8", Offset = "0x19ED3A8", VA = "0x19ED3A8")]
    public void SwitchActor(
      UnitParameterData frontUnitParam,
      CharacterActor frontActor,
      CharacterActor backActor)
    {
    }

    [Token(Token = "0x600D544")]
    [Address(RVA = "0x19ED298", Offset = "0x19ED298", VA = "0x19ED298")]
    private Vector3 GetBackUnitPosition(
      Vector3? pos,
      UnitParameterData unit,
      CharacterActor doubleActor = null)
    {
      return new Vector3();
    }

    [Token(Token = "0x600D545")]
    [Address(RVA = "0x19ED508", Offset = "0x19ED508", VA = "0x19ED508", Slot = "105")]
    public void UpdateDealSlayIcon(bool hasDealSlay)
    {
    }

    [Token(Token = "0x600D546")]
    [Address(RVA = "0x19ED5AC", Offset = "0x19ED5AC", VA = "0x19ED5AC", Slot = "106")]
    public void UpdateTakeSlayIcon(bool hasTakeSlay)
    {
    }

    [Token(Token = "0x600D547")]
    [Address(RVA = "0x19ED650", Offset = "0x19ED650", VA = "0x19ED650")]
    public void ResetSlayIcon()
    {
    }

    [Token(Token = "0x600D548")]
    [Address(RVA = "0x19ED70C", Offset = "0x19ED70C", VA = "0x19ED70C")]
    public void UpdateElementAdvantageIcon(bool hasElementAdvantage)
    {
    }

    [Token(Token = "0x600D549")]
    [Address(RVA = "0x19ED7B0", Offset = "0x19ED7B0", VA = "0x19ED7B0")]
    public void UpdateElementDisAdvantageIcon(bool hasElementDisAdvantage)
    {
    }

    [Token(Token = "0x600D54A")]
    [Address(RVA = "0x19ED854", Offset = "0x19ED854", VA = "0x19ED854")]
    public void ResetElementAdvantageIcon()
    {
    }

    [Token(Token = "0x600D54B")]
    [Address(RVA = "0x19ED910", Offset = "0x19ED910", VA = "0x19ED910")]
    public void UpdateBadStatusDisplayVfx(BattleBadStatusTypeEnum? badstatus)
    {
    }

    [Token(Token = "0x600D54C")]
    [Address(RVA = "0x19ED994", Offset = "0x19ED994", VA = "0x19ED994", Slot = "107")]
    public void UpdateDisplayVfx(
      BattleBadStatusTypeEnum? badstatus,
      BattleEffectTypeEnum? positive,
      BattleEffectTypeEnum? negative)
    {
    }

    [Token(Token = "0x600D54D")]
    [Address(RVA = "0x19EDAB8", Offset = "0x19EDAB8", VA = "0x19EDAB8", Slot = "108")]
    public void UnMarkVfxDirty()
    {
    }

    [Token(Token = "0x600D54E")]
    [Address(RVA = "0x19EDAC4", Offset = "0x19EDAC4", VA = "0x19EDAC4")]
    public CharacterActor()
    {
    }
  }
}
