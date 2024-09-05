// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.CustomSkillListThumb
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using Scenes.OutGame.Armoury.CustomSkillList;
using System;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.OutGameMenu
{
  [Token(Token = "0x20039C4")]
  public class CustomSkillListThumb : SkillListThumbBase
  {
    [Token(Token = "0x400FC98")]
    [FieldOffset(Offset = "0xE0")]
    [SerializeField]
    private CanvasGroup equipCanvasGroup;
    [Token(Token = "0x400FC99")]
    [FieldOffset(Offset = "0xE8")]
    public bool use;
    [Token(Token = "0x400FC9A")]
    [FieldOffset(Offset = "0xEC")]
    private int itemIndex;
    [Token(Token = "0x400FC9B")]
    [FieldOffset(Offset = "0xF0")]
    private CustomSkillScreen.CustomSkillListKind itemKind;
    [Token(Token = "0x400FC9C")]
    [FieldOffset(Offset = "0xF8")]
    private CustomSkillScreen customSkillScreen;

    [Token(Token = "0x17004AA2")]
    public CommonButton thumbnailButton
    {
      [Token(Token = "0x6016B04"), Address(RVA = "0x3F66E78", Offset = "0x3F66E78", VA = "0x3F66E78")] get
      {
        return (CommonButton) null;
      }
    }

    [Token(Token = "0x6016B05")]
    [Address(RVA = "0x3F66E80", Offset = "0x3F66E80", VA = "0x3F66E80")]
    public void Initialize(
      CustomSkillScreen screen,
      int idx,
      CustomSkillScreen.CustomSkillListKind kind,
      CustomSkillScreen.CustomSkillList customSkillData,
      Action<int, CustomSkillScreen.CustomSkillListKind> onClick,
      AssetCachedSpawner assetCachedSpawner)
    {
    }

    [Token(Token = "0x6016B06")]
    [Address(RVA = "0x3F6752C", Offset = "0x3F6752C", VA = "0x3F6752C")]
    public void UpdateView(CustomSkillScreen.CustomSkillList customSkillData)
    {
    }

    [Token(Token = "0x6016B07")]
    [Address(RVA = "0x3F67578", Offset = "0x3F67578", VA = "0x3F67578")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6016B08")]
    [Address(RVA = "0x3F67580", Offset = "0x3F67580", VA = "0x3F67580")]
    public CustomSkillListThumb()
    {
    }
  }
}
