// Decompiled with JetBrains decompiler
// Type: Tayx.Graphy.Advanced.G_AdvancedData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using System.Text;
using Tayx.Graphy.UI;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Tayx.Graphy.Advanced
{
  [Token(Token = "0x20003A3")]
  public class G_AdvancedData : MonoBehaviour, IMovable, IModifiableState
  {
    [Token(Token = "0x4001589")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private List<Image> m_backgroundImages;
    [Token(Token = "0x400158A")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private UnityEngine.UI.Text m_graphicsDeviceVersionText;
    [Token(Token = "0x400158B")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private UnityEngine.UI.Text m_processorTypeText;
    [Token(Token = "0x400158C")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private UnityEngine.UI.Text m_operatingSystemText;
    [Token(Token = "0x400158D")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private UnityEngine.UI.Text m_systemMemoryText;
    [Token(Token = "0x400158E")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private UnityEngine.UI.Text m_graphicsDeviceNameText;
    [Token(Token = "0x400158F")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private UnityEngine.UI.Text m_graphicsMemorySizeText;
    [Token(Token = "0x4001590")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private UnityEngine.UI.Text m_screenResolutionText;
    [Token(Token = "0x4001591")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private UnityEngine.UI.Text m_gameWindowResolutionText;
    [Token(Token = "0x4001592")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    [Range(1f, 60f)]
    private float m_updateRate;
    [Token(Token = "0x4001593")]
    [FieldOffset(Offset = "0x68")]
    private GraphyManager m_graphyManager;
    [Token(Token = "0x4001594")]
    [FieldOffset(Offset = "0x70")]
    private RectTransform m_rectTransform;
    [Token(Token = "0x4001595")]
    [FieldOffset(Offset = "0x78")]
    private float m_deltaTime;
    [Token(Token = "0x4001596")]
    [FieldOffset(Offset = "0x80")]
    private StringBuilder m_sb;
    [Token(Token = "0x4001597")]
    [FieldOffset(Offset = "0x88")]
    private GraphyManager.ModuleState m_previousModuleState;
    [Token(Token = "0x4001598")]
    [FieldOffset(Offset = "0x8C")]
    private GraphyManager.ModuleState m_currentModuleState;
    [Token(Token = "0x4001599")]
    [FieldOffset(Offset = "0x90")]
    private readonly string[] m_windowStrings;

    [Token(Token = "0x60014F5")]
    [Address(RVA = "0x252D9F8", Offset = "0x252D9F8", VA = "0x252D9F8")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x60014F6")]
    [Address(RVA = "0x252E8E4", Offset = "0x252E8E4", VA = "0x252E8E4")]
    private void Update()
    {
    }

    [Token(Token = "0x60014F7")]
    [Address(RVA = "0x2526C68", Offset = "0x2526C68", VA = "0x2526C68", Slot = "4")]
    public void SetPosition(GraphyManager.ModulePosition newModulePosition)
    {
    }

    [Token(Token = "0x60014F8")]
    [Address(RVA = "0x2526BC8", Offset = "0x2526BC8", VA = "0x2526BC8", Slot = "5")]
    public void SetState(GraphyManager.ModuleState state, bool silentUpdate = false)
    {
    }

    [Token(Token = "0x60014F9")]
    [Address(RVA = "0x2527F1C", Offset = "0x2527F1C", VA = "0x2527F1C")]
    public void RestorePreviousState()
    {
    }

    [Token(Token = "0x60014FA")]
    [Address(RVA = "0x2528060", Offset = "0x2528060", VA = "0x2528060")]
    public void UpdateParameters()
    {
    }

    [Token(Token = "0x60014FB")]
    [Address(RVA = "0x2528710", Offset = "0x2528710", VA = "0x2528710")]
    public void RefreshParameters()
    {
    }

    [Token(Token = "0x60014FC")]
    [Address(RVA = "0x252D9FC", Offset = "0x252D9FC", VA = "0x252D9FC")]
    private void Init()
    {
    }

    [Token(Token = "0x60014FD")]
    [Address(RVA = "0x252EB7C", Offset = "0x252EB7C", VA = "0x252EB7C")]
    public G_AdvancedData()
    {
    }
  }
}
