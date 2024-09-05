// Decompiled with JetBrains decompiler
// Type: QuestFieldResourceUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
[Token(Token = "0x2000249")]
public static class QuestFieldResourceUtility
{
  [Token(Token = "0x4000D99")]
  private const string FIELD_BUTTON_IMAGE_AB_NAME_FORMAT = "content_field_{0}_button";
  [Token(Token = "0x4000D9A")]
  private const string FIELD_BUTTON_IMAGE_ASSET_NAME_FORMAT = "{0}_FieldButton";
  [Token(Token = "0x4000D9B")]
  private const string FIELD_IMAGE_AB_NAME_FORMAT = "content_field_{0}_image";
  [Token(Token = "0x4000D9C")]
  private const string FIELD_IMAGE_ASSET_NAME_FORMAT = "{0}_FieldImage";

  [Token(Token = "0x6000E70")]
  [Address(RVA = "0x1C8F14C", Offset = "0x1C8F14C", VA = "0x1C8F14C")]
  private static int GetFieldResourceIdByQuestStageIdInternal(int questStageId) => new int();

  [Token(Token = "0x6000E71")]
  [Address(RVA = "0x1C8F1F4", Offset = "0x1C8F1F4", VA = "0x1C8F1F4")]
  public static string GetFieldButtonImageAssetbundleNameByQuestStageId(int questStageId)
  {
    return (string) null;
  }

  [Token(Token = "0x6000E72")]
  [Address(RVA = "0x1C8F280", Offset = "0x1C8F280", VA = "0x1C8F280")]
  public static string GetFieldButtonImageAssetNameByQuestStageId(int questStageId)
  {
    return (string) null;
  }

  [Token(Token = "0x6000E73")]
  [Address(RVA = "0x1C8F30C", Offset = "0x1C8F30C", VA = "0x1C8F30C")]
  public static string GetFieldImageAssetbundleName(int fieldResourceId) => (string) null;

  [Token(Token = "0x6000E74")]
  [Address(RVA = "0x1C8F38C", Offset = "0x1C8F38C", VA = "0x1C8F38C")]
  public static string GetFieldImageAssetName(int fieldResourceId) => (string) null;
}
