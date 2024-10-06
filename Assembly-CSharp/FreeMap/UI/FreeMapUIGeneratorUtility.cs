// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.FreeMapUIGeneratorUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace FreeMap.UI
{
  [Token(Token = "0x20015FD")]
  public static class FreeMapUIGeneratorUtility
  {
    [Token(Token = "0x4006439")]
    public const string SpriteHeaderName = "Adv_Map_ActionIc_";
    [Token(Token = "0x400643A")]
    public const string CharacterSpriteHeaderName = "CommunityIc_";
    [Token(Token = "0x400643B")]
    public const string IconMarkSpriteObjectName = "Img_Ic";
    [Token(Token = "0x400643C")]
    private const float DefaultClipDistance = 10f;

    [Token(Token = "0x6007C6A")]
    [Address(RVA = "0x21A12F8", Offset = "0x21A12F8", VA = "0x21A12F8")]
    public static Button GetButton(GameObject targetPrefab) => (Button) null;

    [Token(Token = "0x6007C6B")]
    [Address(RVA = "0x21A1348", Offset = "0x21A1348", VA = "0x21A1348")]
    public static void ChangeSprite(GameObject targetPrefab, Sprite targetSprite)
    {
    }

    [Token(Token = "0x6007C6C")]
    [Address(RVA = "0x21A1434", Offset = "0x21A1434", VA = "0x21A1434")]
    public static void ChangeText(GameObject target, string text)
    {
    }

    [Token(Token = "0x6007C6D")]
    [Address(RVA = "0x21A1548", Offset = "0x21A1548", VA = "0x21A1548")]
    public static void ChangeTextAccessor(GameObject target, string text)
    {
    }

    [Token(Token = "0x6007C6E")]
    [Address(RVA = "0x21A16D4", Offset = "0x21A16D4", VA = "0x21A16D4")]
    public static string GetSpriteName(ActionIconTypeEnum iconType) => (string) null;

    [Token(Token = "0x6007C6F")]
    [Address(RVA = "0x21A17A0", Offset = "0x21A17A0", VA = "0x21A17A0")]
    public static float GetClipDistance(ActionIconTypeEnum iconType) => new float();
  }
}
