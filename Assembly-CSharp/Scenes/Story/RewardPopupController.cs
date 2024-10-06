// Decompiled with JetBrains decompiler
// Type: Scenes.Story.RewardPopupController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace Scenes.Story
{
  [Token(Token = "0x2002D62")]
  public class RewardPopupController
  {
    [Token(Token = "0x400C2C5")]
    [FieldOffset(Offset = "0x10")]
    private AdvReward instance;
    [Token(Token = "0x400C2C6")]
    [FieldOffset(Offset = "0x18")]
    private Transform root;
    [Token(Token = "0x400C2C7")]
    private const string ASSETBUNDLE_NAME = "ui_page_adv";
    [Token(Token = "0x400C2C8")]
    private const string ASSET_NAME = "Adv_Reward";
    [Token(Token = "0x400C2C9")]
    [FieldOffset(Offset = "0x20")]
    public RewardPopupController.Callback OnFinishCallback;

    [Token(Token = "0x6011BC5")]
    [Address(RVA = "0x42BB990", Offset = "0x42BB990", VA = "0x42BB990")]
    public void Initialize(Transform root)
    {
    }

    [Token(Token = "0x6011BC6")]
    [Address(RVA = "0x42BB998", Offset = "0x42BB998", VA = "0x42BB998")]
    public void Set(string name, int amount, Sprite sprite)
    {
    }

    [Token(Token = "0x6011BC7")]
    [Address(RVA = "0x42BBA7C", Offset = "0x42BBA7C", VA = "0x42BBA7C")]
    public IEnumerator Setup() => (IEnumerator) null;

    [Token(Token = "0x6011BC8")]
    [Address(RVA = "0x42BBB0C", Offset = "0x42BBB0C", VA = "0x42BBB0C")]
    public IEnumerator OnPlay() => (IEnumerator) null;

    [Token(Token = "0x6011BC9")]
    [Address(RVA = "0x42BBB9C", Offset = "0x42BBB9C", VA = "0x42BBB9C")]
    public void Destory()
    {
    }

    [Token(Token = "0x6011BCA")]
    [Address(RVA = "0x42BBC18", Offset = "0x42BBC18", VA = "0x42BBC18")]
    public RewardPopupController()
    {
    }

    [Token(Token = "0x2002D63")]
    public delegate void Callback();
  }
}
