// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.CustomSkillListThumbElement
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using Scenes.OutGame.Armoury.CustomSkillList;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.OutGameMenu
{
  [Token(Token = "0x20039C7")]
  public class CustomSkillListThumbElement : MonoBehaviour
  {
    [Token(Token = "0x400FCA1")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private CustomSkillListThumb[] thumbList;
    [Token(Token = "0x400FCA2")]
    [FieldOffset(Offset = "0x20")]
    private CustomSkillScreen customSkillScreen;

    [Token(Token = "0x6016B0F")]
    [Address(RVA = "0x3F676D8", Offset = "0x3F676D8", VA = "0x3F676D8")]
    public void Initialize(
      CustomSkillScreen screen,
      int idx,
      CustomSkillScreen.CustomSkillListKind kind,
      AssetCachedSpawner assetCachedSpawner)
    {
    }

    [Token(Token = "0x6016B10")]
    [Address(RVA = "0x3F67894", Offset = "0x3F67894", VA = "0x3F67894")]
    public void SetActive(bool requestActive)
    {
    }

    [Token(Token = "0x6016B11")]
    [Address(RVA = "0x3F678F4", Offset = "0x3F678F4", VA = "0x3F678F4")]
    public void SetThumbButtonOperationPossible(bool flg)
    {
    }

    [Token(Token = "0x6016B12")]
    [Address(RVA = "0x3F67964", Offset = "0x3F67964", VA = "0x3F67964")]
    private void Update()
    {
    }

    [Token(Token = "0x6016B13")]
    [Address(RVA = "0x3F67AA4", Offset = "0x3F67AA4", VA = "0x3F67AA4")]
    public CustomSkillListThumbElement()
    {
    }
  }
}
