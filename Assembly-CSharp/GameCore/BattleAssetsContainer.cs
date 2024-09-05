// Decompiled with JetBrains decompiler
// Type: GameCore.BattleAssetsContainer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.U2D;

#nullable disable
namespace GameCore
{
  [Token(Token = "0x2000BAC")]
  public class BattleAssetsContainer
  {
    [Token(Token = "0x4003543")]
    [FieldOffset(Offset = "0x10")]
    private SpriteAtlas battleCommonAtlas;
    [Token(Token = "0x4003544")]
    [FieldOffset(Offset = "0x18")]
    private SpriteAtlas typeIconAtlas;
    [Token(Token = "0x4003545")]
    [FieldOffset(Offset = "0x20")]
    private SpriteAtlas weaponTypeIconAtlas;
    [Token(Token = "0x4003546")]
    [FieldOffset(Offset = "0x28")]
    private SpriteAtlas partyNumberIconAtlas;
    [Token(Token = "0x4003547")]
    [FieldOffset(Offset = "0x30")]
    private SpriteAtlas skillTypeIconAtlas;
    [Token(Token = "0x4003548")]
    [FieldOffset(Offset = "0x38")]
    private SpriteAtlas commandAtlas;

    [Token(Token = "0x6004294")]
    [Address(RVA = "0x363B13C", Offset = "0x363B13C", VA = "0x363B13C")]
    public void Start()
    {
    }

    [Token(Token = "0x6004295")]
    [Address(RVA = "0x363B14C", Offset = "0x363B14C", VA = "0x363B14C")]
    public void Load(AssetCachedSpawner cachedSpawner)
    {
    }

    [Token(Token = "0x6004296")]
    [Address(RVA = "0x363B484", Offset = "0x363B484", VA = "0x363B484")]
    public Sprite GetWeaponSystemIcon(int iconId) => (Sprite) null;

    [Token(Token = "0x6004297")]
    [Address(RVA = "0x363B544", Offset = "0x363B544", VA = "0x363B544")]
    public Sprite GetWeaponTypeIcon(WeaponTypeEnum type) => (Sprite) null;

    [Token(Token = "0x6004298")]
    [Address(RVA = "0x363B600", Offset = "0x363B600", VA = "0x363B600")]
    public Sprite GetBattleCommonAtlasSprite(string name) => (Sprite) null;

    [Token(Token = "0x6004299")]
    [Address(RVA = "0x363B61C", Offset = "0x363B61C", VA = "0x363B61C")]
    public Sprite GetHpStockCount(int count) => (Sprite) null;

    [Token(Token = "0x600429A")]
    [Address(RVA = "0x363B6E8", Offset = "0x363B6E8", VA = "0x363B6E8")]
    public Sprite GetElementIconM(ElementTypeEnum type) => (Sprite) null;

    [Token(Token = "0x600429B")]
    [Address(RVA = "0x363B774", Offset = "0x363B774", VA = "0x363B774")]
    public Sprite GetElementIconS(ElementTypeEnum type) => (Sprite) null;

    [Token(Token = "0x600429C")]
    [Address(RVA = "0x363B7A4", Offset = "0x363B7A4", VA = "0x363B7A4")]
    public Sprite GetUnitClassIcon(int classId) => (Sprite) null;

    [Token(Token = "0x600429D")]
    [Address(RVA = "0x363B7D4", Offset = "0x363B7D4", VA = "0x363B7D4")]
    public Sprite GetKillersFactorIcon(KillersFactorTypeEnum type) => (Sprite) null;

    [Token(Token = "0x600429E")]
    [Address(RVA = "0x363B804", Offset = "0x363B804", VA = "0x363B804")]
    public Sprite GetUnitMoveIcon(MoveTypeEnum type) => (Sprite) null;

    [Token(Token = "0x600429F")]
    [Address(RVA = "0x363B834", Offset = "0x363B834", VA = "0x363B834")]
    public Sprite GetUnitArmorIcon(ArmorTypeEnum type) => (Sprite) null;

    [Token(Token = "0x60042A0")]
    [Address(RVA = "0x363B864", Offset = "0x363B864", VA = "0x363B864")]
    public Sprite GetUnitRideIcon(RideTypeEnum type) => (Sprite) null;

    [Token(Token = "0x60042A1")]
    [Address(RVA = "0x363B894", Offset = "0x363B894", VA = "0x363B894")]
    public Sprite GetUnitSpeciesIcon(SpeciesTypeEnum type) => (Sprite) null;

    [Token(Token = "0x60042A2")]
    [Address(RVA = "0x363B8C4", Offset = "0x363B8C4", VA = "0x363B8C4")]
    public Sprite GetUnitAttackIcon(AttackTypeEnum type) => (Sprite) null;

    [Token(Token = "0x60042A3")]
    [Address(RVA = "0x363B8F4", Offset = "0x363B8F4", VA = "0x363B8F4")]
    public Sprite GetBadStatusIcon(BattleBadStatusTypeEnum type) => (Sprite) null;

    [Token(Token = "0x60042A4")]
    [Address(RVA = "0x363B99C", Offset = "0x363B99C", VA = "0x363B99C")]
    public Sprite GetPartyNumberIcon(ForceTypeEnum type, int number) => (Sprite) null;

    [Token(Token = "0x60042A5")]
    [Address(RVA = "0x363BA6C", Offset = "0x363BA6C", VA = "0x363BA6C")]
    public Sprite GetPartyNumberStayIcon() => (Sprite) null;

    [Token(Token = "0x60042A6")]
    [Address(RVA = "0x363BAC0", Offset = "0x363BAC0", VA = "0x363BAC0")]
    public Sprite GetBattleIcon(BattleIconTypeEnum type) => (Sprite) null;

    [Token(Token = "0x60042A7")]
    [Address(RVA = "0x363BC2C", Offset = "0x363BC2C", VA = "0x363BC2C")]
    public Sprite GetSkillTypeIcon(SkillTypeEnum type) => (Sprite) null;

    [Token(Token = "0x60042A8")]
    [Address(RVA = "0x363BCAC", Offset = "0x363BCAC", VA = "0x363BCAC")]
    public Sprite GetCommandIconNormalAttack() => (Sprite) null;

    [Token(Token = "0x60042A9")]
    [Address(RVA = "0x363BD00", Offset = "0x363BD00", VA = "0x363BD00")]
    public Sprite GetCommandIconHeal() => (Sprite) null;

    [Token(Token = "0x60042AA")]
    [Address(RVA = "0x363BD54", Offset = "0x363BD54", VA = "0x363BD54")]
    public BattleAssetsContainer()
    {
    }
  }
}
