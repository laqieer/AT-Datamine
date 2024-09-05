// Decompiled with JetBrains decompiler
// Type: Scenes.Expedition.BossList.ExpeditionBossListConst
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System;

#nullable disable
namespace Scenes.Expedition.BossList
{
  [Token(Token = "0x2002D2D")]
  public class ExpeditionBossListConst
  {
    [Token(Token = "0x400C1C6")]
    [FieldOffset(Offset = "0x0")]
    public static Func<string> SoulNameRed;
    [Token(Token = "0x400C1C7")]
    [FieldOffset(Offset = "0x8")]
    public static Func<string> SoulNameBlue;
    [Token(Token = "0x400C1C8")]
    public const string ItemIconAssetLabel = "2dassets_contents_expedition_item";
    [Token(Token = "0x400C1C9")]
    public const string ItemIconAssetNameHeader = "img_item64_";
    [Token(Token = "0x400C1CA")]
    public const string ExpeditionBossListSpriteAssetBundleName = "ui_page_expeditionsimulator_bosslist_texture_spriteatlas";

    [Token(Token = "0x6011AC4")]
    [Address(RVA = "0x42AD174", Offset = "0x42AD174", VA = "0x42AD174")]
    public static string SideMenuBackGroundAssetName(ElementTypeEnum elementType) => (string) null;

    [Token(Token = "0x6011AC5")]
    [Address(RVA = "0x42ADDB4", Offset = "0x42ADDB4", VA = "0x42ADDB4")]
    public ExpeditionBossListConst()
    {
    }

    [Token(Token = "0x6011AC6")]
    [Address(RVA = "0x42ADDBC", Offset = "0x42ADDBC", VA = "0x42ADDBC")]
    static ExpeditionBossListConst()
    {
    }
  }
}
