// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.StyleLimitBreakEffect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.MasterData;
using Il2CppDummyDll;
using StaqData;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.OutGameMenu
{
  [Token(Token = "0x2003A75")]
  public class StyleLimitBreakEffect : LimitBreakEffectBase
  {
    [Token(Token = "0x401004A")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private DetailSkillListThumb[] skillThumb;
    [Token(Token = "0x401004B")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private GameObject[] skillGetEffect;
    [Token(Token = "0x401004C")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private GameObject nothingObj;
    [Token(Token = "0x401004D")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private float skillThumbActiveFrame;
    [Token(Token = "0x401004E")]
    [FieldOffset(Offset = "0x7C")]
    private int getSkillCount;
    [Token(Token = "0x401004F")]
    [FieldOffset(Offset = "0x80")]
    private Dictionary<int, RarityStyleData> getSkillDic;
    [Token(Token = "0x4010050")]
    [FieldOffset(Offset = "0x88")]
    private AssetCachedSpawner assetCachedSpawner;

    [Token(Token = "0x6016FA0")]
    [Address(RVA = "0x29C5660", Offset = "0x29C5660", VA = "0x29C5660")]
    public IEnumerator InitializeAsync(
      AssetCachedSpawner assetCachedSpawner,
      Style dispStyle,
      int limitBreakNum)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6016FA1")]
    [Address(RVA = "0x29C5764", Offset = "0x29C5764", VA = "0x29C5764")]
    private void SetSkillDetail(
      DetailSkillListThumb skillListThumb,
      Style style,
      RarityStyleData data)
    {
    }

    [Token(Token = "0x6016FA2")]
    [Address(RVA = "0x29C583C", Offset = "0x29C583C", VA = "0x29C583C")]
    public StyleLimitBreakEffect()
    {
    }
  }
}
