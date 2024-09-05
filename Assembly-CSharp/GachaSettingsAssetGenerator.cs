// Decompiled with JetBrains decompiler
// Type: GachaSettingsAssetGenerator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using StaqData;
using System.Collections;
using System.Collections.Generic;

#nullable disable
[Token(Token = "0x2000206")]
public class GachaSettingsAssetGenerator
{
  [Token(Token = "0x4000BF7")]
  private const float PROPERBILITY_PATTERN_1_CAT = 30f;
  [Token(Token = "0x4000BF8")]
  private const float PROPERBILITY_PATTERN_1_MONOLITH = 80f;
  [Token(Token = "0x4000BF9")]
  private const float PROPERBILITY_PATTERN_1_WEAPON = 70f;
  [Token(Token = "0x4000BFA")]
  private const float PROPERBILITY_PATTERN_2_CAT = 18f;
  [Token(Token = "0x4000BFB")]
  private const float PROPERBILITY_PATTERN_2_MONOLITH = 65f;
  [Token(Token = "0x4000BFC")]
  private const float PROPERBILITY_PATTERN_2_WEAPON = 60f;
  [Token(Token = "0x4000BFD")]
  private const float PROPERBILITY_PATTERN_3_CAT = 0.0f;
  [Token(Token = "0x4000BFE")]
  private const float PROPERBILITY_PATTERN_3_MONOLITH = 55f;
  [Token(Token = "0x4000BFF")]
  private const float PROPERBILITY_PATTERN_3_WEAPON = 18f;
  [Token(Token = "0x4000C00")]
  private const float PROPERBILITY_PATTERN_4_CAT = 0.0f;
  [Token(Token = "0x4000C01")]
  private const float PROPERBILITY_PATTERN_4_MONOLITH = 0.0f;
  [Token(Token = "0x4000C02")]
  private const float PROPERBILITY_PATTERN_4_WEAPON = 0.0f;

  [Token(Token = "0x170000FD")]
  public GachaSettingsAsset GachaSettings
  {
    [Token(Token = "0x6000CC3"), Address(RVA = "0x4C7C808", Offset = "0x4C7C808", VA = "0x4C7C808")] get
    {
      return (GachaSettingsAsset) null;
    }
    [Token(Token = "0x6000CC4"), Address(RVA = "0x4C7C810", Offset = "0x4C7C810", VA = "0x4C7C810")] set
    {
    }
  }

  [Token(Token = "0x6000CC5")]
  [Address(RVA = "0x4C7C818", Offset = "0x4C7C818", VA = "0x4C7C818")]
  public IEnumerator Generate(
    IReadOnlyList<GachaResultDetailInfo> resultItems,
    IReadOnlyList<int> newCharacterIds)
  {
    return (IEnumerator) null;
  }

  [Token(Token = "0x6000CC6")]
  [Address(RVA = "0x4C7C8BC", Offset = "0x4C7C8BC", VA = "0x4C7C8BC")]
  private IEnumerator SetupGachaStage(GachaSettingsAsset gachaSettings) => (IEnumerator) null;

  [Token(Token = "0x6000CC7")]
  [Address(RVA = "0x4C7C94C", Offset = "0x4C7C94C", VA = "0x4C7C94C")]
  private IEnumerator SetupGachaAward(
    GachaSettingsAsset gachaSettings,
    IReadOnlyList<GachaResultDetailInfo> resultItems,
    IReadOnlyList<int> newCharacterIds)
  {
    return (IEnumerator) null;
  }

  [Token(Token = "0x6000CC8")]
  [Address(RVA = "0x4C7C9FC", Offset = "0x4C7C9FC", VA = "0x4C7C9FC")]
  private (string, RarityTypeEnum) GetItemInfo(RewardTypeEnum rewardType, int rewardId) => ();

  [Token(Token = "0x6000CC9")]
  [Address(RVA = "0x4C7D278", Offset = "0x4C7D278", VA = "0x4C7D278")]
  private void SetupGachaColor(GachaSettingsAsset gachaSettings)
  {
  }

  [Token(Token = "0x6000CCA")]
  [Address(RVA = "0x4C7D594", Offset = "0x4C7D594", VA = "0x4C7D594")]
  private static GachaAwardData.RarityType NormalizeRarityType(RarityTypeEnum rarity)
  {
    return new GachaAwardData.RarityType();
  }

  [Token(Token = "0x6000CCB")]
  [Address(RVA = "0x4C7D598", Offset = "0x4C7D598", VA = "0x4C7D598")]
  public GachaSettingsAssetGenerator()
  {
  }
}
