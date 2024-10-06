// Decompiled with JetBrains decompiler
// Type: Tayx.Graphy.CustomizationScene.CustomizeGraphy
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Tayx.Graphy.CustomizationScene
{
  [Token(Token = "0x20003A6")]
  public class CustomizeGraphy : MonoBehaviour
  {
    [Token(Token = "0x40015B3")]
    [FieldOffset(Offset = "0x18")]
    [Header("Customize Graphy")]
    [SerializeField]
    private G_CUIColorPicker m_colorPicker;
    [Token(Token = "0x40015B4")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Toggle m_backgroundToggle;
    [Token(Token = "0x40015B5")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Dropdown m_graphyModeDropdown;
    [Token(Token = "0x40015B6")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Button m_backgroundColorButton;
    [Token(Token = "0x40015B7")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Dropdown m_graphModulePositionDropdown;
    [Token(Token = "0x40015B8")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    [Header("Fps")]
    private Dropdown m_fpsModuleStateDropdown;
    [Token(Token = "0x40015B9")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private InputField m_goodInputField;
    [Token(Token = "0x40015BA")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private InputField m_cautionInputField;
    [Token(Token = "0x40015BB")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private Button m_goodColorButton;
    [Token(Token = "0x40015BC")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private Button m_cautionColorButton;
    [Token(Token = "0x40015BD")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private Button m_criticalColorButton;
    [Token(Token = "0x40015BE")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private Slider m_timeToResetMinMaxSlider;
    [Token(Token = "0x40015BF")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private Slider m_fpsGraphResolutionSlider;
    [Token(Token = "0x40015C0")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private Slider m_fpsTextUpdateRateSlider;
    [Token(Token = "0x40015C1")]
    [FieldOffset(Offset = "0x88")]
    [Header("Memory")]
    [SerializeField]
    private Dropdown m_ramModuleStateDropdown;
    [Token(Token = "0x40015C2")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private Button m_reservedColorButton;
    [Token(Token = "0x40015C3")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private Button m_allocatedColorButton;
    [Token(Token = "0x40015C4")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private Button m_monoColorButton;
    [Token(Token = "0x40015C5")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private Slider m_ramGraphResolutionSlider;
    [Token(Token = "0x40015C6")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private Slider m_ramTextUpdateRateSlider;
    [Token(Token = "0x40015C7")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    [Header("Audio")]
    private Dropdown m_audioModuleStateDropdown;
    [Token(Token = "0x40015C8")]
    [FieldOffset(Offset = "0xC0")]
    [SerializeField]
    private Button m_audioGraphColorButton;
    [Token(Token = "0x40015C9")]
    [FieldOffset(Offset = "0xC8")]
    [SerializeField]
    private Dropdown m_findAudioListenerDropdown;
    [Token(Token = "0x40015CA")]
    [FieldOffset(Offset = "0xD0")]
    [SerializeField]
    private Dropdown m_fttWindowDropdown;
    [Token(Token = "0x40015CB")]
    [FieldOffset(Offset = "0xD8")]
    [SerializeField]
    private Slider m_spectrumSizeSlider;
    [Token(Token = "0x40015CC")]
    [FieldOffset(Offset = "0xE0")]
    [SerializeField]
    private Slider m_audioGraphResolutionSlider;
    [Token(Token = "0x40015CD")]
    [FieldOffset(Offset = "0xE8")]
    [SerializeField]
    private Slider m_audioTextUpdateRateSlider;
    [Token(Token = "0x40015CE")]
    [FieldOffset(Offset = "0xF0")]
    [SerializeField]
    [Header("Advanced")]
    private Dropdown m_advancedModulePositionDropdown;
    [Token(Token = "0x40015CF")]
    [FieldOffset(Offset = "0xF8")]
    [SerializeField]
    private Toggle m_advancedModuleToggle;
    [Token(Token = "0x40015D0")]
    [FieldOffset(Offset = "0x100")]
    [SerializeField]
    [Header("Other")]
    private Button m_musicButton;
    [Token(Token = "0x40015D1")]
    [FieldOffset(Offset = "0x108")]
    [SerializeField]
    private Button m_sfxButton;
    [Token(Token = "0x40015D2")]
    [FieldOffset(Offset = "0x110")]
    [SerializeField]
    private Slider m_musicVolumeSlider;
    [Token(Token = "0x40015D3")]
    [FieldOffset(Offset = "0x118")]
    [SerializeField]
    private Slider m_sfxVolumeSlider;
    [Token(Token = "0x40015D4")]
    [FieldOffset(Offset = "0x120")]
    [SerializeField]
    private AudioSource m_musicAudioSource;
    [Token(Token = "0x40015D5")]
    [FieldOffset(Offset = "0x128")]
    [SerializeField]
    private AudioSource m_sfxAudioSource;
    [Token(Token = "0x40015D6")]
    [FieldOffset(Offset = "0x130")]
    [SerializeField]
    private List<AudioClip> m_sfxAudioClips;
    [Token(Token = "0x40015D7")]
    [FieldOffset(Offset = "0x138")]
    private GraphyManager m_graphyManager;

    [Token(Token = "0x6001513")]
    [Address(RVA = "0x25300EC", Offset = "0x25300EC", VA = "0x25300EC")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x6001514")]
    [Address(RVA = "0x2530160", Offset = "0x2530160", VA = "0x2530160")]
    private void SetupCallbacks()
    {
    }

    [Token(Token = "0x6001515")]
    [Address(RVA = "0x2530FE0", Offset = "0x2530FE0", VA = "0x2530FE0")]
    private void ToggleMusic()
    {
    }

    [Token(Token = "0x6001516")]
    [Address(RVA = "0x2531028", Offset = "0x2531028", VA = "0x2531028")]
    private void PlayRandomSFX()
    {
    }

    [Token(Token = "0x6001517")]
    [Address(RVA = "0x25310E4", Offset = "0x25310E4", VA = "0x25310E4")]
    public CustomizeGraphy()
    {
    }
  }
}
