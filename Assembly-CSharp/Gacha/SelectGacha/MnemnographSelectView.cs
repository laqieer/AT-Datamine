// Decompiled with JetBrains decompiler
// Type: Gacha.SelectGacha.MnemnographSelectView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using Scenes.OutGame.OutGameMenu;
using StaqData;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Gacha.SelectGacha
{
  [Token(Token = "0x200159E")]
  public class MnemnographSelectView : MonoBehaviour
  {
    [Token(Token = "0x4006318")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private MindequipmentThumb mindequipmentThumb;
    [Token(Token = "0x4006319")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private VerticalGridInfiniteScrollView infiniteScrollView;
    [Token(Token = "0x400631A")]
    [FieldOffset(Offset = "0x28")]
    public Action<int> OnSelectedMnemnograph;
    [Token(Token = "0x400631C")]
    [FieldOffset(Offset = "0x38")]
    private MindequipmentListAssetLoader mindequipmentListAssetLoader;

    [Token(Token = "0x170012CB")]
    public bool IsInitialized
    {
      [Token(Token = "0x6007A81"), Address(RVA = "0x229D41C", Offset = "0x229D41C", VA = "0x229D41C")] get
      {
        return new bool();
      }
      [Token(Token = "0x6007A82"), Address(RVA = "0x229D424", Offset = "0x229D424", VA = "0x229D424")] private set
      {
      }
    }

    [Token(Token = "0x6007A83")]
    [Address(RVA = "0x229D430", Offset = "0x229D430", VA = "0x229D430")]
    private void Awake()
    {
    }

    [Token(Token = "0x6007A84")]
    [Address(RVA = "0x229D45C", Offset = "0x229D45C", VA = "0x229D45C")]
    public void Initialize(
      AssetCachedSpawner spawner,
      SelectGachaTargetDetailInfo selected,
      List<SelectGachaTargetDetailInfo> list)
    {
    }

    [Token(Token = "0x6007A85")]
    [Address(RVA = "0x229D744", Offset = "0x229D744", VA = "0x229D744")]
    public MnemnographSelectView()
    {
    }
  }
}
