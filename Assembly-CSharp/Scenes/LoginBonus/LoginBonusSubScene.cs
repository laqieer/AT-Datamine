// Decompiled with JetBrains decompiler
// Type: Scenes.LoginBonus.LoginBonusSubScene
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.Scene;
using Home;
using Il2CppDummyDll;
using LoginBonus;
using StaqData;
using System.Collections;
using System.Collections.Generic;

#nullable disable
namespace Scenes.LoginBonus
{
  [Token(Token = "0x200317E")]
  public class LoginBonusSubScene : SubScene
  {
    [Token(Token = "0x400D2B4")]
    [FieldOffset(Offset = "0x58")]
    private ILoginBonus3DEffectPlayer loginBonus3DEffectPlayer;
    [Token(Token = "0x400D2B5")]
    [FieldOffset(Offset = "0x60")]
    private HomeTransitionContoller homeTransitionContoller;
    [Token(Token = "0x400D2B6")]
    [FieldOffset(Offset = "0x68")]
    private LoginBonusSequencePlayer loginBonusSequencePlayer;
    [Token(Token = "0x400D2B7")]
    [FieldOffset(Offset = "0x70")]
    private LoginBonusInfoHolder loginBonusInfoHolder;
    [Token(Token = "0x400D2B8")]
    [FieldOffset(Offset = "0x78")]
    private bool IsSkipTodayEffect;
    [Token(Token = "0x400D2B9")]
    [FieldOffset(Offset = "0x80")]
    private List<ILoginBonusSequence> waitForInitializeSequences;
    [Token(Token = "0x400D2BA")]
    [FieldOffset(Offset = "0x88")]
    private AssetCachedSpawner assetCachedSpawner;

    [Token(Token = "0x60134EF")]
    [Address(RVA = "0x4A2DBB0", Offset = "0x4A2DBB0", VA = "0x4A2DBB0", Slot = "6")]
    public override void Initialize(ChangeSceneParameter param = null)
    {
    }

    [Token(Token = "0x60134F0")]
    [Address(RVA = "0x4A2DCE8", Offset = "0x4A2DCE8", VA = "0x4A2DCE8", Slot = "7")]
    public override IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x60134F1")]
    [Address(RVA = "0x4A2DD78", Offset = "0x4A2DD78", VA = "0x4A2DD78", Slot = "9")]
    public override void Destroy()
    {
    }

    [Token(Token = "0x60134F2")]
    [Address(RVA = "0x4A2DE00", Offset = "0x4A2DE00", VA = "0x4A2DE00")]
    private void Update()
    {
    }

    [Token(Token = "0x60134F3")]
    [Address(RVA = "0x4A2DE38", Offset = "0x4A2DE38", VA = "0x4A2DE38")]
    private void CreateLoginBonusSequence()
    {
    }

    [Token(Token = "0x60134F4")]
    [Address(RVA = "0x4A2E720", Offset = "0x4A2E720", VA = "0x4A2E720")]
    private IEnumerator WaitForInitializeSequence() => (IEnumerator) null;

    [Token(Token = "0x60134F5")]
    [Address(RVA = "0x4A2E7B0", Offset = "0x4A2E7B0", VA = "0x4A2E7B0")]
    public LoginBonusSubScene()
    {
    }
  }
}
