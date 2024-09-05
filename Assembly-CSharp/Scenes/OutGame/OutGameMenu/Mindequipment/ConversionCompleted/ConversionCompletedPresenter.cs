// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.Mindequipment.ConversionCompleted.ConversionCompletedPresenter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.OutGameMenu.Mindequipment.ConversionCompleted
{
  [Token(Token = "0x2003C0E")]
  public class ConversionCompletedPresenter : MonoBehaviour
  {
    [Token(Token = "0x4010A10")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private ConversionCompletedView _view;
    [Token(Token = "0x4010A13")]
    [FieldOffset(Offset = "0x30")]
    private ConversionCompletedModel _model;

    [Token(Token = "0x17004CB2")]
    public Action Closure
    {
      [Token(Token = "0x60179AF"), Address(RVA = "0x237F604", Offset = "0x237F604", VA = "0x237F604")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x60179B0"), Address(RVA = "0x237F60C", Offset = "0x237F60C", VA = "0x237F60C")] set
      {
      }
    }

    [Token(Token = "0x17004CB3")]
    public AssetCachedSpawner AssetCachedSpawner
    {
      [Token(Token = "0x60179B1"), Address(RVA = "0x237F614", Offset = "0x237F614", VA = "0x237F614")] get
      {
        return (AssetCachedSpawner) null;
      }
      [Token(Token = "0x60179B2"), Address(RVA = "0x237F61C", Offset = "0x237F61C", VA = "0x237F61C")] set
      {
      }
    }

    [Token(Token = "0x60179B3")]
    [Address(RVA = "0x237EE24", Offset = "0x237EE24", VA = "0x237EE24")]
    public void Initialize(ConversionContext context)
    {
    }

    [Token(Token = "0x60179B4")]
    [Address(RVA = "0x237F744", Offset = "0x237F744", VA = "0x237F744")]
    private void OnClose()
    {
    }

    [Token(Token = "0x60179B5")]
    [Address(RVA = "0x237F760", Offset = "0x237F760", VA = "0x237F760")]
    public ConversionCompletedPresenter()
    {
    }
  }
}
