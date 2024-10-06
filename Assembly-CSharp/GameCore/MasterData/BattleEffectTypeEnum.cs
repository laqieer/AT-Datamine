// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.BattleEffectTypeEnum
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E40")]
  public enum BattleEffectTypeEnum
  {
    [Token(Token = "0x400441F")] Damage = 100001, // 0x000186A1
    [Token(Token = "0x4004420")] FieldDamage = 100002, // 0x000186A2
    [Token(Token = "0x4004421")] Drain = 100003, // 0x000186A3
    [Token(Token = "0x4004422")] DrainFromAll = 100004, // 0x000186A4
    [Token(Token = "0x4004423")] Endure = 110001, // 0x0001ADB1
    [Token(Token = "0x4004424")] Shield = 110002, // 0x0001ADB2
    [Token(Token = "0x4004425")] SupportGuard = 110003, // 0x0001ADB3
    [Token(Token = "0x4004426")] ClearBadStatus = 110004, // 0x0001ADB4
    [Token(Token = "0x4004427")] ClearBuffEffect = 110005, // 0x0001ADB5
    [Token(Token = "0x4004428")] ClearDebuffEffect = 110006, // 0x0001ADB6
    [Token(Token = "0x4004429")] Regeneration = 110007, // 0x0001ADB7
    [Token(Token = "0x400442A")] Healing = 120001, // 0x0001D4C1
    [Token(Token = "0x400442B")] AdditionalHeal = 120002, // 0x0001D4C2
    [Token(Token = "0x400442C")] AffectDamageUpBuff = 130001, // 0x0001FBD1
    [Token(Token = "0x400442D")] TakeDamageDownBuff = 130002, // 0x0001FBD2
    [Token(Token = "0x400442E")] BattleParamBuff = 130003, // 0x0001FBD3
    [Token(Token = "0x400442F")] RangeBuff = 130004, // 0x0001FBD4
    [Token(Token = "0x4004430")] MoveBuff = 130005, // 0x0001FBD5
    [Token(Token = "0x4004431")] DealDamageLimitBuff = 130006, // 0x0001FBD6
    [Token(Token = "0x4004432")] WeightBuff = 130007, // 0x0001FBD7
    [Token(Token = "0x4004433")] HitLimitBuff = 130008, // 0x0001FBD8
    [Token(Token = "0x4004434")] TakeHitLimitBuff = 130009, // 0x0001FBD9
    [Token(Token = "0x4004435")] CriticalLimitBuff = 130010, // 0x0001FBDA
    [Token(Token = "0x4004436")] TakeCriticalLimitBuff = 130011, // 0x0001FBDB
    [Token(Token = "0x4004437")] HealBuff = 130012, // 0x0001FBDC
    [Token(Token = "0x4004438")] SupportSkillActivateBuff = 130013, // 0x0001FBDD
    [Token(Token = "0x4004439")] AffectDamageDownDebuff = 140001, // 0x000222E1
    [Token(Token = "0x400443A")] TakeDamageUpDebuff = 140002, // 0x000222E2
    [Token(Token = "0x400443B")] BattleParamDebuff = 140003, // 0x000222E3
    [Token(Token = "0x400443C")] RangeDebuff = 140004, // 0x000222E4
    [Token(Token = "0x400443D")] MoveDebuff = 140005, // 0x000222E5
    [Token(Token = "0x400443E")] DealDamageLimitDebuff = 140006, // 0x000222E6
    [Token(Token = "0x400443F")] WeightDebuff = 140007, // 0x000222E7
    [Token(Token = "0x4004440")] HitLimitDebuff = 140008, // 0x000222E8
    [Token(Token = "0x4004441")] TakeHitLimitDebuff = 140009, // 0x000222E9
    [Token(Token = "0x4004442")] CriticalLimitDebuff = 140010, // 0x000222EA
    [Token(Token = "0x4004443")] TakeCriticalLimitDebuff = 140011, // 0x000222EB
    [Token(Token = "0x4004444")] EnchantBadStatus = 150001, // 0x000249F1
    [Token(Token = "0x4004445")] NullBadStatus = 150002, // 0x000249F2
    [Token(Token = "0x4004446")] ResistBadStatusBuff = 150003, // 0x000249F3
    [Token(Token = "0x4004447")] EnhanceBadStatusBuff = 150004, // 0x000249F4
    [Token(Token = "0x4004448")] ResistBadStatusDebuff = 150005, // 0x000249F5
    [Token(Token = "0x4004449")] EnhanceBadStatusDebuff = 150006, // 0x000249F6
    [Token(Token = "0x400444A")] BadStatus = 150007, // 0x000249F7
    [Token(Token = "0x400444B")] EnhanceElementBuff = 160001, // 0x00027101
    [Token(Token = "0x400444C")] EnhanceElementDebuff = 160002, // 0x00027102
    [Token(Token = "0x400444D")] EnhanceAttackTypeBuff = 160003, // 0x00027103
    [Token(Token = "0x400444E")] EnhanceAttackTypeDebuff = 160004, // 0x00027104
    [Token(Token = "0x400444F")] ResistElementBuff = 170001, // 0x00029811
    [Token(Token = "0x4004450")] ResistElementDebuff = 170002, // 0x00029812
    [Token(Token = "0x4004451")] ResistAttackTypeBuff = 170003, // 0x00029813
    [Token(Token = "0x4004452")] ResistAttackTypeDebuff = 170004, // 0x00029814
    [Token(Token = "0x4004453")] AddSlayElement = 180001, // 0x0002BF21
    [Token(Token = "0x4004454")] AddSlaySpecies = 180002, // 0x0002BF22
    [Token(Token = "0x4004455")] AddSlayArmor = 180003, // 0x0002BF23
    [Token(Token = "0x4004456")] AddSlayRide = 180004, // 0x0002BF24
    [Token(Token = "0x4004457")] AddSlayMove = 180005, // 0x0002BF25
    [Token(Token = "0x4004458")] AddSlayTag = 180006, // 0x0002BF26
    [Token(Token = "0x4004459")] AddResistSlayElement = 190001, // 0x0002E631
    [Token(Token = "0x400445A")] AddResistSlaySpecies = 190002, // 0x0002E632
    [Token(Token = "0x400445B")] AddResistSlayArmor = 190003, // 0x0002E633
    [Token(Token = "0x400445C")] AddResistSlayRide = 190004, // 0x0002E634
    [Token(Token = "0x400445D")] AddResistSlayMove = 190005, // 0x0002E635
    [Token(Token = "0x400445E")] AddResistSlayTag = 190006, // 0x0002E636
    [Token(Token = "0x400445F")] MoveRecovery = 200001, // 0x00030D41
    [Token(Token = "0x4004460")] ActionRecovery = 200002, // 0x00030D42
    [Token(Token = "0x4004461")] FirstStrike = 210001, // 0x00033451
    [Token(Token = "0x4004462")] SecondStrike = 210002, // 0x00033452
    [Token(Token = "0x4004463")] FastChase = 210003, // 0x00033453
    [Token(Token = "0x4004464")] NullCouterStrike = 210004, // 0x00033454
    [Token(Token = "0x4004465")] AbsoluteCounterStrike = 210005, // 0x00033455
    [Token(Token = "0x4004466")] NullChase = 210006, // 0x00033456
    [Token(Token = "0x4004467")] AbsoluteChase = 210007, // 0x00033457
    [Token(Token = "0x4004468")] Vault = 220001, // 0x00035B61
    [Token(Token = "0x4004469")] PushUp = 220002, // 0x00035B62
    [Token(Token = "0x400446A")] PullDown = 220003, // 0x00035B63
    [Token(Token = "0x400446B")] Lure = 220004, // 0x00035B64
    [Token(Token = "0x400446C")] SwapPosition = 220005, // 0x00035B65
    [Token(Token = "0x400446D")] AbsoluteHit = 230001, // 0x00038271
    [Token(Token = "0x400446E")] AbsoluteAvoid = 230002, // 0x00038272
    [Token(Token = "0x400446F")] AbsoluteCritical = 230003, // 0x00038273
    [Token(Token = "0x4004470")] AbsoluteCriticalAvoid = 230004, // 0x00038274
    [Token(Token = "0x4004471")] AbsoluteTakeHit = 230005, // 0x00038275
    [Token(Token = "0x4004472")] AbsoluteTakeCritical = 230006, // 0x00038276
    [Token(Token = "0x4004473")] OverrideMoveCost = 230007, // 0x00038277
    [Token(Token = "0x4004474")] OfferSkill = 230008, // 0x00038278
    [Token(Token = "0x4004475")] ReviveBarrier = 230009, // 0x00038279
    [Token(Token = "0x4004476")] Carry = 230010, // 0x0003827A
    [Token(Token = "0x4004477")] PassThrough = 230011, // 0x0003827B
    [Token(Token = "0x4004478")] Rescue = 230012, // 0x0003827C
    [Token(Token = "0x4004479")] UsableCountBuff = 230013, // 0x0003827D
    [Token(Token = "0x400447A")] ResitLand = 230014, // 0x0003827E
    [Token(Token = "0x400447B")] ReduceCost = 230015, // 0x0003827F
    [Token(Token = "0x400447C")] Stealth = 230016, // 0x00038280
    [Token(Token = "0x400447D")] ChangeLand = 230017, // 0x00038281
    [Token(Token = "0x400447E")] Unlock = 230018, // 0x00038282
    [Token(Token = "0x400447F")] AddElementChain = 230019, // 0x00038283
    [Token(Token = "0x4004480")] StratagemDamage = 230020, // 0x00038284
    [Token(Token = "0x4004481")] AddStockCounter = 230021, // 0x00038285
    [Token(Token = "0x4004482")] RemoveStockCounter = 230022, // 0x00038286
    [Token(Token = "0x4004483")] ZoC = 240000, // 0x0003A980
  }
}
