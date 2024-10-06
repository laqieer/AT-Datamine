// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.EquipmentDetail.MnemnographLvUpEffect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using Scenes.OutGame.OutGameMenu;
using StaqData;
using System.Collections;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.EquipmentDetail
{
  [Token(Token = "0x20036ED")]
  public class MnemnographLvUpEffect : LvUpEffectBase
  {
    [Token(Token = "0x400EFB6")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private DetailSkillListThumb skillThumb;
    [Token(Token = "0x400EFB7")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private GameObject skillGetEffect;
    [Token(Token = "0x400EFB8")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private GameObject skillGetText;
    [Token(Token = "0x400EFB9")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private float skillThumbActiveFrame;
    [Token(Token = "0x400EFBA")]
    [FieldOffset(Offset = "0x7C")]
    [SerializeField]
    private Color levelMaxColor;
    [Token(Token = "0x400EFBB")]
    [FieldOffset(Offset = "0x90")]
    private AssetCachedSpawner assetCachedSpawner;
    [Token(Token = "0x400EFBC")]
    [FieldOffset(Offset = "0x98")]
    private bool isSkillGet;

    [Token(Token = "0x6015A26")]
    [Address(RVA = "0x1D7DD5C", Offset = "0x1D7DD5C", VA = "0x1D7DD5C")]
    public IEnumerator InitializeAsync(
      AssetCachedSpawner assetCachedSpawner,
      MindEquipment dispMnemnograph,
      int lvUpValue)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6015A27")]
    [Address(RVA = "0x1D7FD34", Offset = "0x1D7FD34", VA = "0x1D7FD34")]
    public MnemnographLvUpEffect()
    {
    }
  }
}
