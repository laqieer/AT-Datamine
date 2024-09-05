// Decompiled with JetBrains decompiler
// Type: GameCore.UIControls.CustomSkillIcon
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using StaqData;
using UI.Common;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

#nullable disable
namespace GameCore.UIControls
{
  [Token(Token = "0x2000BEB")]
  public class CustomSkillIcon : MonoBehaviour
  {
    [Token(Token = "0x4003603")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Image Img_Thumb_Base;
    [Token(Token = "0x4003604")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Image Img_Icon;
    [Token(Token = "0x4003605")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject Img_Equip;
    [Token(Token = "0x4003606")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private RarityIcon rarityIcon;
    [Token(Token = "0x4003607")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private CommonButton button;

    [Token(Token = "0x6004400")]
    [Address(RVA = "0x3645058", Offset = "0x3645058", VA = "0x3645058")]
    public static void Preload(AssetCachedSpawner assetCachedSpawner, CustomSkillData customSkill)
    {
    }

    [Token(Token = "0x6004401")]
    [Address(RVA = "0x36452D8", Offset = "0x36452D8", VA = "0x36452D8")]
    public void Apply(AssetCachedSpawner assetCachedSpawner, CommunicationSkillData commuSkill)
    {
    }

    [Token(Token = "0x6004402")]
    [Address(RVA = "0x36454BC", Offset = "0x36454BC", VA = "0x36454BC")]
    public void Apply(AssetCachedSpawner assetCachedSpawner, CustomSkillData customSkill)
    {
    }

    [Token(Token = "0x6004403")]
    [Address(RVA = "0x36456AC", Offset = "0x36456AC", VA = "0x36456AC")]
    public void Apply(AssetCachedSpawner assetCachedSpawner, CustomSkill customSkill)
    {
    }

    [Token(Token = "0x6004404")]
    [Address(RVA = "0x36458B0", Offset = "0x36458B0", VA = "0x36458B0")]
    public void WithoutRarityIconView(
      AssetCachedSpawner assetCachedSpawner,
      CustomSkillData customSkill)
    {
    }

    [Token(Token = "0x6004405")]
    [Address(RVA = "0x3645A6C", Offset = "0x3645A6C", VA = "0x3645A6C")]
    public void WithoutRarityIconView(
      AssetCachedSpawner assetCachedSpawner,
      CustomSkill customSkill)
    {
    }

    [Token(Token = "0x6004406")]
    [Address(RVA = "0x3645C44", Offset = "0x3645C44", VA = "0x3645C44")]
    public void SetImage(Sprite sprite)
    {
    }

    [Token(Token = "0x6004407")]
    [Address(RVA = "0x364517C", Offset = "0x364517C", VA = "0x364517C")]
    public static string GetImageAssetbundleName() => (string) null;

    [Token(Token = "0x6004408")]
    [Address(RVA = "0x36451D0", Offset = "0x36451D0", VA = "0x36451D0")]
    public static string GetImageAssetName(SkillData skillData) => (string) null;

    [Token(Token = "0x6004409")]
    [Address(RVA = "0x3645C60", Offset = "0x3645C60", VA = "0x3645C60")]
    public void SetBaseImage(Sprite sprite)
    {
    }

    [Token(Token = "0x600440A")]
    [Address(RVA = "0x3645230", Offset = "0x3645230", VA = "0x3645230")]
    public static string GetBaseImageAssetbundleName() => (string) null;

    [Token(Token = "0x600440B")]
    [Address(RVA = "0x3645280", Offset = "0x3645280", VA = "0x3645280")]
    public static string GetBaseImageAssetName(RarityTypeEnum rarityType) => (string) null;

    [Token(Token = "0x600440C")]
    [Address(RVA = "0x3645C7C", Offset = "0x3645C7C", VA = "0x3645C7C")]
    public void SetEquipIcon(bool equip)
    {
    }

    [Token(Token = "0x600440D")]
    [Address(RVA = "0x3645690", Offset = "0x3645690", VA = "0x3645690")]
    public void SetRarityIcon(RarityTypeEnum rarityType, AssetCachedSpawner assetCachedSpawner)
    {
    }

    [Token(Token = "0x600440E")]
    [Address(RVA = "0x3645490", Offset = "0x3645490", VA = "0x3645490")]
    public void UnsetRarityIcon()
    {
    }

    [Token(Token = "0x600440F")]
    [Address(RVA = "0x3645C9C", Offset = "0x3645C9C", VA = "0x3645C9C")]
    public void SetOnClickEvent(UnityAction callback)
    {
    }

    [Token(Token = "0x6004410")]
    [Address(RVA = "0x3645CEC", Offset = "0x3645CEC", VA = "0x3645CEC")]
    public void SetInteractable(bool interactable)
    {
    }

    [Token(Token = "0x6004411")]
    [Address(RVA = "0x3645D0C", Offset = "0x3645D0C", VA = "0x3645D0C")]
    public CustomSkillIcon()
    {
    }
  }
}
