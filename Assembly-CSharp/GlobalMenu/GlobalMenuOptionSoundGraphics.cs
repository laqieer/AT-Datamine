// Decompiled with JetBrains decompiler
// Type: GlobalMenu.GlobalMenuOptionSoundGraphics
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Scenes.OutGame;
using UnityEngine;

#nullable disable
namespace GlobalMenu
{
  [Token(Token = "0x2000BA5")]
  public class GlobalMenuOptionSoundGraphics : MonoBehaviour
  {
    [Token(Token = "0x4003516")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private BattleConfigItemSlider bgmSlider;
    [Token(Token = "0x4003517")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private BattleConfigItemSlider seSlider;
    [Token(Token = "0x4003518")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private BattleConfigItemSlider voiceSlider;
    [Token(Token = "0x4003519")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private BattleConfigItemQuality qualityConfig;
    [Token(Token = "0x400351A")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private BattleConfigItem fpsConfig;

    [Token(Token = "0x6004277")]
    [Address(RVA = "0x363921C", Offset = "0x363921C", VA = "0x363921C")]
    public void Initialize()
    {
    }

    [Token(Token = "0x6004278")]
    [Address(RVA = "0x3639540", Offset = "0x3639540", VA = "0x3639540")]
    public void OnValueChangedBgmSlider(float value)
    {
    }

    [Token(Token = "0x6004279")]
    [Address(RVA = "0x36396E0", Offset = "0x36396E0", VA = "0x36396E0")]
    public void OnValueChangedSeSlider(float value)
    {
    }

    [Token(Token = "0x600427A")]
    [Address(RVA = "0x3639880", Offset = "0x3639880", VA = "0x3639880")]
    public void OnValueChangedVoiceSlider(float value)
    {
    }

    [Token(Token = "0x600427B")]
    [Address(RVA = "0x3639A20", Offset = "0x3639A20", VA = "0x3639A20")]
    public void OnValueChangedQualityConfig(int value)
    {
    }

    [Token(Token = "0x600427C")]
    [Address(RVA = "0x3639C64", Offset = "0x3639C64", VA = "0x3639C64")]
    public void OnValueChangedFpsConfig(bool isOn)
    {
    }

    [Token(Token = "0x600427D")]
    [Address(RVA = "0x3639E44", Offset = "0x3639E44", VA = "0x3639E44")]
    public GlobalMenuOptionSoundGraphics()
    {
    }
  }
}
