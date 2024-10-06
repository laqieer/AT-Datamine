// Decompiled with JetBrains decompiler
// Type: CharacterResourceUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
[Token(Token = "0x2000240")]
public static class CharacterResourceUtility
{
  [Token(Token = "0x4000D2B")]
  private const string CONTENT_PREFIX = "content_chr_";
  [Token(Token = "0x4000D2C")]
  private const string THUMB_AB_NAME_FORMAT = "content_chr_{0}_{1}";
  [Token(Token = "0x4000D2D")]
  private const string THUMB_AB_NAME_FORMAT_EDITOR = "content_chr_{0}_{1}_thumb";
  [Token(Token = "0x4000D2E")]
  private const string THUMB_ASSET_NAME_FORMAT = "{0}_UnitThumb";
  [Token(Token = "0x4000D2F")]
  private const string MODEL3D_AB_NAME_FORMAT = "content_chr_{0}_{1}";
  [Token(Token = "0x4000D30")]
  private const string MODEL3D_AB_NAME_FORMAT_EDITOR = "content_chr_{0}_{1}_model";
  [Token(Token = "0x4000D31")]
  private const string MODEL3D_ASSET_NAME_FORMAT = "{0}_Model";
  [Token(Token = "0x4000D32")]
  private const string HOME_CHARACTER_MODEL_SETTINGS_ASSET_NAME_FORMAT = "{0}_HomeCharacterSettingsAsset";
  [Token(Token = "0x4000D33")]
  private const string CHARACTER_MODEL_SETTINGS_ASSET_NAME_FORMAT = "{0}_CharacterModelSettingsAsset";
  [Token(Token = "0x4000D34")]
  private const string VEHICLE_MODEL_SETTINGS_ASSET_NAME_FORMAT = "{0}_VehicleModelSettingsAsset";
  [Token(Token = "0x4000D35")]
  private const string FREEMAPCON_AB_NAME_FORMAT = "content_chr_{0}_{1}";
  [Token(Token = "0x4000D36")]
  private const string FREEMAPCON_AB_NAME_FORMAT_EDITOR = "content_chr_{0}_{1}_freemapcon";
  [Token(Token = "0x4000D37")]
  private const string FREEMAPCON_AB_NAME_APPEND_FORMAT = "content_chr_{0}_{1}";
  [Token(Token = "0x4000D38")]
  private const string FREEMAPCON_AB_NAME_APPEND_FORMAT_EDITOR = "content_chr_{0}_{1}_freemapcon{2:00}";
  [Token(Token = "0x4000D39")]
  private const string FREEMAPCON_ASSET_NAME_FORMAT = "{0}_FreeMapCon";
  [Token(Token = "0x4000D3A")]
  private const string FREEMAPCON_ASSET_NAME_APPEND_FORMAT = "{0}_FreeMapCon{1:00}";
  [Token(Token = "0x4000D3B")]
  private const string FREEMAPCLIP_AB_NAME_FORMAT = "content_chr_{0}_{1}";
  [Token(Token = "0x4000D3C")]
  private const string FREEMAPCLIP_AB_NAME_FORMAT_EDITOR = "content_chr_{0}_{1}_freemapclippack";
  [Token(Token = "0x4000D3D")]
  private const string FREEMAPCLIP_AB_NAME_APPEND_FORMAT = "content_chr_{0}_{1}";
  [Token(Token = "0x4000D3E")]
  private const string FREEMAPCLIP_AB_NAME_APPEND_FORMAT_EDITOR = "content_chr_{0}_{1}_freemapclippack{2:00}";
  [Token(Token = "0x4000D3F")]
  private const string FREEMAPCLIP_ASSET_NAME_FORMAT = "{0}_FreeMapClipPack";
  [Token(Token = "0x4000D40")]
  private const string FREEMAPCLIP_ASSET_NAME_APPEND_FORMAT = "{0}_FreeMapClipPack{1:00}";
  [Token(Token = "0x4000D41")]
  private const string FULLIMAGE_AB_NAME_FORMAT = "content_chr_{0}_{1}";
  [Token(Token = "0x4000D42")]
  private const string FULLIMAGE_AB_NAME_FORMAT_EDITOR = "content_chr_{0}_{1}_full";
  [Token(Token = "0x4000D43")]
  private const string FULLIMAGE_ASSET_NAME_FORMAT = "{0}_UnitImage_Full";
  [Token(Token = "0x4000D44")]
  private const string HIRESIMAGE_AB_NAME_FORMAT = "content_chr_{0}_{1}";
  [Token(Token = "0x4000D45")]
  private const string HIRESIMAGE_AB_NAME_FORMAT_EDITOR = "content_chr_{0}_{1}_hires";
  [Token(Token = "0x4000D46")]
  private const string HIRESIMAGE_ASSET_NAME_FORMAT = "{0}_UnitImage_HiRes";
  [Token(Token = "0x4000D47")]
  private const string HIRESIMAGE_POS_ASSET_NAME_FORMAT = "{0}_UnitImage_HiRes_pos";
  [Token(Token = "0x4000D48")]
  private const string FACEIMAGE_AB_NAME_FORMAT = "content_chr_{0}_{1}";
  [Token(Token = "0x4000D49")]
  private const string FACEIMAGE_AB_NAME_FORMAT_EDITOR = "content_chr_{0}_{1}_face";
  [Token(Token = "0x4000D4A")]
  private const string FACEIMAGE_ASSET_NAME_FORMAT = "{0}_UnitFace";
  [Token(Token = "0x4000D4B")]
  private const string DOT_CHARACTER_AB_NAME_FORMAT = "content_chr_{0}_{1}";
  [Token(Token = "0x4000D4C")]
  private const string DOT_CHARACTER_AB_NAME_FORMAT_EDITOR = "content_chr_{0}_{1}_dot";
  [Token(Token = "0x4000D4D")]
  private const string DOT_CHARACTER_ASSET_NAME_FORMAT = "{0}_DotUnit";
  [Token(Token = "0x4000D4E")]
  private const string DOT_WEAPON_AB_NAME = "content_dotmotion_wpn";
  [Token(Token = "0x4000D4F")]
  private const string DOT_DOTMOTION_AB_NAME_FORMAT = "content_dotmotion_classes_{0}";
  [Token(Token = "0x4000D50")]
  private const string DOT_MOTION_WEAPON_ATK_ASSET_NAME_FORMAT = "DotUnit_{0}_Atk_{1}";
  [Token(Token = "0x4000D51")]
  private const string DOT_MOTION_WEAPON_MAG_ASSET_NAME_FORMAT = "DotUnit_{0}_Mag_{1}";
  [Token(Token = "0x4000D52")]
  private const string DOT_MOTION_WEAPON_ASSET_NAME_FORMAT = "DotUnit_{0}_{1}_{2}_{3}";
  [Token(Token = "0x4000D53")]
  private const string DUEL_CLASS_AB_NAME_FORMAT = "content_duel_classes_{0}";
  [Token(Token = "0x4000D54")]
  private const string WEAPON_AB_NAME = "content_weapon_{0}";
  [Token(Token = "0x4000D55")]
  private const string WEAPON_MODEL_ASSET_NAME_FORMAT = "weapon_model_{0}";
  [Token(Token = "0x4000D56")]
  private const string WEAPON_THUMB_ASSET_NAME_FORMAT = "{0}_WeaponThumb";
  [Token(Token = "0x4000D57")]
  private const string WEAPON_IMAGE_ASSET_NAME_FORMAT = "{0}_WeaponImage";
  [Token(Token = "0x4000D58")]
  private const string EQUIPMENT_SETTINGS_ASSET_NAME_FORMAT = "{0}_EquipmentSettingsAsset";
  [Token(Token = "0x4000D59")]
  private const string CHARACTER_SETTINGS_ASSET_NAME_FORMAT = "{0}_{1}_CharacterSettingsAsset";
  [Token(Token = "0x4000D5A")]
  private const string STYLE_OVERRIDE_CHARACTER_SETTINGS_ASSET_NAME_FORMAT = "{0}_CharacterSettingsAsset";
  [Token(Token = "0x4000D5B")]
  public const string PROP_AB_NAME_FORMAT = "content_prop_{0}";
  [Token(Token = "0x4000D5C")]
  public const string PROP_ASSET_NAME_FORMAT = "{0}_PropModel";
  [Token(Token = "0x4000D5D")]
  private const string EMBLEM_IMAGE_AB_NAME = "content_emblem_{0}_image";
  [Token(Token = "0x4000D5E")]
  private const string EMBLEM_THUMB_AB_NAME = "content_emblem_{0}_thumb";
  [Token(Token = "0x4000D5F")]
  private const string EMBLEM_IMAGE_ASSET_NAME_FORMAT = "{0}_EmblemImage";
  [Token(Token = "0x4000D60")]
  private const string EMBLEM_THUMB_ASSET_NAME_FORMAT = "{0}_EmblemThumb";
  [Token(Token = "0x4000D61")]
  private const string PIECE_THUMB_AB_NAME_FORMAT = "content_chr_{0}_{1}";
  [Token(Token = "0x4000D62")]
  private const string PIECE_THUMB_AB_NAME_FORMAT_EDITOR = "content_chr_{0}_{1}_piecethumb";
  [Token(Token = "0x4000D63")]
  private const string PIECE_THUMB_ASSET_NAME_FORMAT = "{0}_UnitPieceThumb";
  [Token(Token = "0x4000D64")]
  private const string PIECE_IMAGE_AB_NAME_FORMAT = "content_chr_{0}_{1}";
  [Token(Token = "0x4000D65")]
  private const string PIECE_IMAGE_AB_NAME_FORMAT_EDITOR = "content_chr_{0}_{1}_pieceimage";
  [Token(Token = "0x4000D66")]
  private const string PIECE_IMAGE_ASSET_NAME_FORMAT = "{0}_UnitPieceImage";
  [Token(Token = "0x4000D67")]
  private const string ASSET_NAME_FORMAT_GACHA_SINGLE_SKILL_VIDEO = "Style/{0}/{0}_GachaSingleSkill";
  [Token(Token = "0x4000D68")]
  private const string THUMB_ILLUST_LAYOUT_INFO_AB_NAME_FORMAT = "content_chr_{0}_{1}";
  [Token(Token = "0x4000D69")]
  private const string THUMB_ILLUST_LAYOUT_INFO_AB_NAME_FORMAT_EDITOR = "content_chr_{0}_{1}_hires";
  [Token(Token = "0x4000D6A")]
  private const string THUMB_ILLUST_LAYOUT_INFO_NAME_FORMAT = "{0}_UnitImage_HiRes_pos";
  [Token(Token = "0x4000D6B")]
  private const string FACE_ILLUST_LAYOUT_INFO_AB_NAME_FORMAT = "content_chr_{0}_{1}";
  [Token(Token = "0x4000D6C")]
  private const string FACE_ILLUST_LAYOUT_INFO_AB_NAME_FORMAT_EDITOR = "content_chr_{0}_{1}_face";
  [Token(Token = "0x4000D6D")]
  private const string FACE_ILLUST_LAYOUT_INFO_NAME_FORMAT = "{0}_UnitFace_pos";

  [Token(Token = "0x6000E14")]
  [Address(RVA = "0x1C8AB8C", Offset = "0x1C8AB8C", VA = "0x1C8AB8C")]
  private static (int, int) GetResourceId(int styleId) => ();

  [Token(Token = "0x6000E15")]
  [Address(RVA = "0x1C8AC68", Offset = "0x1C8AC68", VA = "0x1C8AC68")]
  public static string GetThumbnailAssetbundleNameByStyleId(int styleId) => (string) null;

  [Token(Token = "0x6000E16")]
  [Address(RVA = "0x1C8AD88", Offset = "0x1C8AD88", VA = "0x1C8AD88")]
  public static string GetThumbnailAssetNameByStyleId(int styleId) => (string) null;

  [Token(Token = "0x6000E17")]
  [Address(RVA = "0x1C8AE84", Offset = "0x1C8AE84", VA = "0x1C8AE84")]
  public static string GetModel3DAssetBundleNameByStyleId(int styleId) => (string) null;

  [Token(Token = "0x6000E18")]
  [Address(RVA = "0x1C8AFA4", Offset = "0x1C8AFA4", VA = "0x1C8AFA4")]
  public static string GetHomeCharacterModelSettingsAssetNameByStyleID(int styleId)
  {
    return (string) null;
  }

  [Token(Token = "0x6000E19")]
  [Address(RVA = "0x1C8B0A0", Offset = "0x1C8B0A0", VA = "0x1C8B0A0")]
  public static string GetCharacterModelSettingsAssetNameByStyleID(int styleId) => (string) null;

  [Token(Token = "0x6000E1A")]
  [Address(RVA = "0x1C8B19C", Offset = "0x1C8B19C", VA = "0x1C8B19C")]
  public static string GetVehicleModelSettingsAssetNameByStyleID(int styleId) => (string) null;

  [Token(Token = "0x6000E1B")]
  [Address(RVA = "0x1C8B298", Offset = "0x1C8B298", VA = "0x1C8B298")]
  public static string GetEquipmentSettingsAssetNameByWeaponID(int weaponID) => (string) null;

  [Token(Token = "0x6000E1C")]
  [Address(RVA = "0x1C8B318", Offset = "0x1C8B318", VA = "0x1C8B318")]
  public static string GetCharacterSettingsAssetName(
    string duelMotionTypeName,
    string duelEquipmentClassificationName)
  {
    return (string) null;
  }

  [Token(Token = "0x6000E1D")]
  [Address(RVA = "0x1C8B374", Offset = "0x1C8B374", VA = "0x1C8B374")]
  public static string GetCharacterSettingsAssetName(
    StyleData style,
    string duelMotionTypeName,
    string duelEquipmentClassificationName)
  {
    return (string) null;
  }

  [Token(Token = "0x6000E1E")]
  [Address(RVA = "0x1C8B45C", Offset = "0x1C8B45C", VA = "0x1C8B45C")]
  public static string GetStyleOverrideCharacterSettingsAssetName(string overideMotionTypeName)
  {
    return (string) null;
  }

  [Token(Token = "0x6000E1F")]
  [Address(RVA = "0x1C8B4A8", Offset = "0x1C8B4A8", VA = "0x1C8B4A8")]
  public static string GetModel3DAssetNameByStyleId(int styleId) => (string) null;

  [Token(Token = "0x6000E20")]
  [Address(RVA = "0x1C8B5B0", Offset = "0x1C8B5B0", VA = "0x1C8B5B0")]
  public static string GetFreeMapControllerAssetBundleNameByStyleId(int styleId) => (string) null;

  [Token(Token = "0x6000E21")]
  [Address(RVA = "0x1C8B6D0", Offset = "0x1C8B6D0", VA = "0x1C8B6D0")]
  public static string GetFreeMapControllerAssetNameByStyleId(int styleId) => (string) null;

  [Token(Token = "0x6000E22")]
  [Address(RVA = "0x1C8B7D8", Offset = "0x1C8B7D8", VA = "0x1C8B7D8")]
  public static string GetFreeMapAnimationClipPackAssetBundleNameByStyleId(int styleId)
  {
    return (string) null;
  }

  [Token(Token = "0x6000E23")]
  [Address(RVA = "0x1C8B8F8", Offset = "0x1C8B8F8", VA = "0x1C8B8F8")]
  public static string GetFreeMapControllerAssetNameByStyleId(int styleId, int controllerId = 0)
  {
    return (string) null;
  }

  [Token(Token = "0x6000E24")]
  [Address(RVA = "0x1C8BAA0", Offset = "0x1C8BAA0", VA = "0x1C8BAA0")]
  public static string GetFreeMapAnimationClipPackAssetNameByStyleId(int styleId) => (string) null;

  [Token(Token = "0x6000E25")]
  [Address(RVA = "0x1C8BBA8", Offset = "0x1C8BBA8", VA = "0x1C8BBA8")]
  public static string GetFreeMapControllerAssetBundleNameByStyleId(int styleId, int controllerId = 0)
  {
    return (string) null;
  }

  [Token(Token = "0x6000E26")]
  [Address(RVA = "0x1C8BC68", Offset = "0x1C8BC68", VA = "0x1C8BC68")]
  private static string GetFreeMapControllerAssetBundleName(
    int charcterResId,
    int styleFreemapConResId,
    int controllerId)
  {
    return (string) null;
  }

  [Token(Token = "0x6000E27")]
  [Address(RVA = "0x1C8B9B8", Offset = "0x1C8B9B8", VA = "0x1C8B9B8")]
  private static string GetFreeMapControllerAssetName(int styleFreemapConResId, int controllerId)
  {
    return (string) null;
  }

  [Token(Token = "0x6000E28")]
  [Address(RVA = "0x1C8BD70", Offset = "0x1C8BD70", VA = "0x1C8BD70")]
  public static string GetFullImageAssetBundleNameByStyleId(int styleId) => (string) null;

  [Token(Token = "0x6000E29")]
  [Address(RVA = "0x1C8BE90", Offset = "0x1C8BE90", VA = "0x1C8BE90")]
  public static string GetFullImageAssetNameByStyleId(int styleId) => (string) null;

  [Token(Token = "0x6000E2A")]
  [Address(RVA = "0x1C8BF98", Offset = "0x1C8BF98", VA = "0x1C8BF98")]
  public static string GetHiresImageIllustLayoutAssetBundleNameByStyleId(int styleId)
  {
    return (string) null;
  }

  [Token(Token = "0x6000E2B")]
  [Address(RVA = "0x1C8C0B8", Offset = "0x1C8C0B8", VA = "0x1C8C0B8")]
  public static string GetFaceImageIllustLayoutAssetBundleNameByStyleId(int styleId)
  {
    return (string) null;
  }

  [Token(Token = "0x6000E2C")]
  [Address(RVA = "0x1C8C1D8", Offset = "0x1C8C1D8", VA = "0x1C8C1D8")]
  public static string GetHiResImageAssetBundleNameByStyleId(int styleId) => (string) null;

  [Token(Token = "0x6000E2D")]
  [Address(RVA = "0x1C8C2F8", Offset = "0x1C8C2F8", VA = "0x1C8C2F8")]
  public static string GetSingleSkillVideoPath(int styleId) => (string) null;

  [Token(Token = "0x6000E2E")]
  [Address(RVA = "0x1C8C378", Offset = "0x1C8C378", VA = "0x1C8C378")]
  public static string GetFreeMapAnimationClipPackAssetNameByStyleId(int styleId, int clipPackId = 0)
  {
    return (string) null;
  }

  [Token(Token = "0x6000E2F")]
  [Address(RVA = "0x1C8C520", Offset = "0x1C8C520", VA = "0x1C8C520")]
  public static string GetHiResImageIllustLayoutAssetNameByStyleId(int styleId) => (string) null;

  [Token(Token = "0x6000E30")]
  [Address(RVA = "0x1C8C628", Offset = "0x1C8C628", VA = "0x1C8C628")]
  public static string GetFaceImageIllustLayoutAssetNameByStyleId(int styleId) => (string) null;

  [Token(Token = "0x6000E31")]
  [Address(RVA = "0x1C8C730", Offset = "0x1C8C730", VA = "0x1C8C730")]
  public static string GetHiResImageAssetNameByStyleId(int styleId) => (string) null;

  [Token(Token = "0x6000E32")]
  [Address(RVA = "0x1C8C838", Offset = "0x1C8C838", VA = "0x1C8C838")]
  public static string GetHiResPosAssetNameByStyleId(int styleId) => (string) null;

  [Token(Token = "0x6000E33")]
  [Address(RVA = "0x1C8C940", Offset = "0x1C8C940", VA = "0x1C8C940")]
  public static string GetFaceImageAssetBundleNameByStyleId(int styleId) => (string) null;

  [Token(Token = "0x6000E34")]
  [Address(RVA = "0x1C8CA60", Offset = "0x1C8CA60", VA = "0x1C8CA60")]
  public static string GetFreeMapAnimationClipPackAssetBundleNameByStyleId(
    int styleId,
    int clipPackId = 0)
  {
    return (string) null;
  }

  [Token(Token = "0x6000E35")]
  [Address(RVA = "0x1C8CC28", Offset = "0x1C8CC28", VA = "0x1C8CC28")]
  public static string GetFaceImageAssetNameByStyleId(int styleId) => (string) null;

  [Token(Token = "0x6000E36")]
  [Address(RVA = "0x1C8C438", Offset = "0x1C8C438", VA = "0x1C8C438")]
  private static string GetFreeMapAnimationClipPackAssetName(
    int styleFreemapConResId,
    int clipPackId)
  {
    return (string) null;
  }

  [Token(Token = "0x6000E37")]
  [Address(RVA = "0x1C8CD30", Offset = "0x1C8CD30", VA = "0x1C8CD30")]
  private static (string, string) GetMotionName(int styleId, int equipmentClassificationId) => ();

  [Token(Token = "0x6000E38")]
  [Address(RVA = "0x1C8CE4C", Offset = "0x1C8CE4C", VA = "0x1C8CE4C")]
  public static string GetDuelClassAssetBundleName(int styleId, int equipmentClassificationId)
  {
    return (string) null;
  }

  [Token(Token = "0x6000E39")]
  [Address(RVA = "0x1C8CEEC", Offset = "0x1C8CEEC", VA = "0x1C8CEEC")]
  public static string GetDotClassAssetBundleName(int styleId, int equipmentClassificationId)
  {
    return (string) null;
  }

  [Token(Token = "0x6000E3A")]
  [Address(RVA = "0x1C8CF8C", Offset = "0x1C8CF8C", VA = "0x1C8CF8C")]
  public static string GetDotWeaponAssetBundleName() => (string) null;

  [Token(Token = "0x6000E3B")]
  [Address(RVA = "0x1C8CFCC", Offset = "0x1C8CFCC", VA = "0x1C8CFCC")]
  public static string GetDotWeaponOnlyAssetBundleName(int weaponId) => (string) null;

  [Token(Token = "0x6000E3C")]
  [Address(RVA = "0x1C8D04C", Offset = "0x1C8D04C", VA = "0x1C8D04C")]
  public static string GetDotMotionWeaponAssetBundleName(
    string styleMotionName,
    string classificationName)
  {
    return (string) null;
  }

  [Token(Token = "0x6000E3D")]
  [Address(RVA = "0x1C8D0E0", Offset = "0x1C8D0E0", VA = "0x1C8D0E0")]
  public static string GetDotStyleAssetBundleNameByStyleId(int styleId) => (string) null;

  [Token(Token = "0x6000E3E")]
  [Address(RVA = "0x1C8CB20", Offset = "0x1C8CB20", VA = "0x1C8CB20")]
  private static string GetFreeMapAnimationClipPackAssetBundleName(
    int charcterResId,
    int styleFreemapConResId,
    int clipPackId)
  {
    return (string) null;
  }

  [Token(Token = "0x6000E3F")]
  [Address(RVA = "0x1C8D248", Offset = "0x1C8D248", VA = "0x1C8D248")]
  public static List<string> GetDotAssetBundleNamesByStyleId(int styleId) => (List<string>) null;

  [Token(Token = "0x6000E40")]
  [Address(RVA = "0x1C8DAB8", Offset = "0x1C8DAB8", VA = "0x1C8DAB8")]
  public static string GetDotAssetNameByStyleId(int styleId) => (string) null;

  [Token(Token = "0x6000E41")]
  [Address(RVA = "0x1C8DBB4", Offset = "0x1C8DBB4", VA = "0x1C8DBB4")]
  public static string GetDotMotionAnimationClipAtk(
    string duelMotionType,
    EquipmentClassificationData equipmentClassificationData)
  {
    return (string) null;
  }

  [Token(Token = "0x6000E42")]
  [Address(RVA = "0x1C8DC10", Offset = "0x1C8DC10", VA = "0x1C8DC10")]
  public static string GetDotMotionAnimationClipMag(
    string duelMotionType,
    EquipmentClassificationData equipmentClassificationData)
  {
    return (string) null;
  }

  [Token(Token = "0x6000E43")]
  [Address(RVA = "0x1C8DC6C", Offset = "0x1C8DC6C", VA = "0x1C8DC6C")]
  public static string GetPropAssetBundleName(int propID) => (string) null;

  [Token(Token = "0x6000E44")]
  [Address(RVA = "0x1C8DCEC", Offset = "0x1C8DCEC", VA = "0x1C8DCEC")]
  public static string GetPropAssetName(int propID) => (string) null;

  [Token(Token = "0x6000E45")]
  [Address(RVA = "0x1C8DD6C", Offset = "0x1C8DD6C", VA = "0x1C8DD6C")]
  public static string GetEmblemImageAssetBundleNameById(int emblemId) => (string) null;

  [Token(Token = "0x6000E46")]
  [Address(RVA = "0x1C8DDEC", Offset = "0x1C8DDEC", VA = "0x1C8DDEC")]
  public static string GetEmblemThumbAssetBundleNameById(int emblemId) => (string) null;

  [Token(Token = "0x6000E47")]
  [Address(RVA = "0x1C8DE6C", Offset = "0x1C8DE6C", VA = "0x1C8DE6C")]
  public static string GetEmblemImageAssetNameById(int emblemId) => (string) null;

  [Token(Token = "0x6000E48")]
  [Address(RVA = "0x1C8DEEC", Offset = "0x1C8DEEC", VA = "0x1C8DEEC")]
  public static string GetEmblemThumbAssetNameById(int emblemId) => (string) null;

  [Token(Token = "0x6000E49")]
  [Address(RVA = "0x1C8DF6C", Offset = "0x1C8DF6C", VA = "0x1C8DF6C")]
  public static string GetPieceImageAssetBundleNameById(int characterId, int styleId)
  {
    return (string) null;
  }

  [Token(Token = "0x6000E4A")]
  [Address(RVA = "0x1C8E010", Offset = "0x1C8E010", VA = "0x1C8E010")]
  public static string GetPieceImageAssetBundleNameById(int styleId) => (string) null;

  [Token(Token = "0x6000E4B")]
  [Address(RVA = "0x1C8E028", Offset = "0x1C8E028", VA = "0x1C8E028")]
  public static string GetPieceThumbAssetBundleNameById(int characterId, int styleId)
  {
    return (string) null;
  }

  [Token(Token = "0x6000E4C")]
  [Address(RVA = "0x1C8E0CC", Offset = "0x1C8E0CC", VA = "0x1C8E0CC")]
  public static string GetPieceThumbAssetBundleNameById(int styleId) => (string) null;

  [Token(Token = "0x6000E4D")]
  [Address(RVA = "0x1C8E0E4", Offset = "0x1C8E0E4", VA = "0x1C8E0E4")]
  public static string GetPieceImageAssetNameById(int styleId) => (string) null;

  [Token(Token = "0x6000E4E")]
  [Address(RVA = "0x1C8E164", Offset = "0x1C8E164", VA = "0x1C8E164")]
  public static string GetPieceThumbAssetNameById(int styleId) => (string) null;
}
