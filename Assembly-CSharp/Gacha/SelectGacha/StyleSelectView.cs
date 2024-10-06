// Decompiled with JetBrains decompiler
// Type: Gacha.SelectGacha.StyleSelectView
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
  [Token(Token = "0x20015A2")]
  public class StyleSelectView : MonoBehaviour
  {
    [Token(Token = "0x4006324")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private StyleThumb styleThumb;
    [Token(Token = "0x4006325")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private VerticalGridInfiniteScrollView infiniteScrollView;
    [Token(Token = "0x4006326")]
    [FieldOffset(Offset = "0x28")]
    public Action<int> OnSelectedStyle;

    [Token(Token = "0x170012CD")]
    public bool IsInitialized
    {
      [Token(Token = "0x6007A8D"), Address(RVA = "0x229D9D4", Offset = "0x229D9D4", VA = "0x229D9D4")] get
      {
        return new bool();
      }
      [Token(Token = "0x6007A8E"), Address(RVA = "0x229D9DC", Offset = "0x229D9DC", VA = "0x229D9DC")] private set
      {
      }
    }

    [Token(Token = "0x6007A8F")]
    [Address(RVA = "0x229D9E8", Offset = "0x229D9E8", VA = "0x229D9E8")]
    private void Awake()
    {
    }

    [Token(Token = "0x6007A90")]
    [Address(RVA = "0x229DA14", Offset = "0x229DA14", VA = "0x229DA14")]
    public void Initialize(
      AssetCachedSpawner spawner,
      SelectGachaTargetDetailInfo selected,
      List<SelectGachaTargetDetailInfo> list)
    {
    }

    [Token(Token = "0x6007A91")]
    [Address(RVA = "0x229DD20", Offset = "0x229DD20", VA = "0x229DD20")]
    public StyleSelectView()
    {
    }
  }
}
