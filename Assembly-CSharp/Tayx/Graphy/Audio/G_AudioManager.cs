// Decompiled with JetBrains decompiler
// Type: Tayx.Graphy.Audio.G_AudioManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using Tayx.Graphy.UI;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Tayx.Graphy.Audio
{
  [Token(Token = "0x20003A0")]
  public class G_AudioManager : MonoBehaviour, IMovable, IModifiableState
  {
    [Token(Token = "0x4001570")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject m_audioGraphGameObject;
    [Token(Token = "0x4001571")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text m_audioDbText;
    [Token(Token = "0x4001572")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private List<Image> m_backgroundImages;
    [Token(Token = "0x4001573")]
    [FieldOffset(Offset = "0x30")]
    private GraphyManager m_graphyManager;
    [Token(Token = "0x4001574")]
    [FieldOffset(Offset = "0x38")]
    private G_AudioGraph m_audioGraph;
    [Token(Token = "0x4001575")]
    [FieldOffset(Offset = "0x40")]
    private G_AudioMonitor m_audioMonitor;
    [Token(Token = "0x4001576")]
    [FieldOffset(Offset = "0x48")]
    private G_AudioText m_audioText;
    [Token(Token = "0x4001577")]
    [FieldOffset(Offset = "0x50")]
    private RectTransform m_rectTransform;
    [Token(Token = "0x4001578")]
    [FieldOffset(Offset = "0x58")]
    private List<GameObject> m_childrenGameObjects;
    [Token(Token = "0x4001579")]
    [FieldOffset(Offset = "0x60")]
    private GraphyManager.ModuleState m_previousModuleState;
    [Token(Token = "0x400157A")]
    [FieldOffset(Offset = "0x64")]
    private GraphyManager.ModuleState m_currentModuleState;

    [Token(Token = "0x60014D8")]
    [Address(RVA = "0x252CCA0", Offset = "0x252CCA0", VA = "0x252CCA0")]
    private void Awake()
    {
    }

    [Token(Token = "0x60014D9")]
    [Address(RVA = "0x252D148", Offset = "0x252D148", VA = "0x252D148")]
    private void Start()
    {
    }

    [Token(Token = "0x60014DA")]
    [Address(RVA = "0x2525A34", Offset = "0x2525A34", VA = "0x2525A34", Slot = "4")]
    public void SetPosition(GraphyManager.ModulePosition newModulePosition)
    {
    }

    [Token(Token = "0x60014DB")]
    [Address(RVA = "0x2526730", Offset = "0x2526730", VA = "0x2526730", Slot = "5")]
    public void SetState(GraphyManager.ModuleState state, bool silentUpdate = false)
    {
    }

    [Token(Token = "0x60014DC")]
    [Address(RVA = "0x2527F10", Offset = "0x2527F10", VA = "0x2527F10")]
    public void RestorePreviousState()
    {
    }

    [Token(Token = "0x60014DD")]
    [Address(RVA = "0x25268A8", Offset = "0x25268A8", VA = "0x25268A8")]
    public void UpdateParameters()
    {
    }

    [Token(Token = "0x60014DE")]
    [Address(RVA = "0x2528554", Offset = "0x2528554", VA = "0x2528554")]
    public void RefreshParameters()
    {
    }

    [Token(Token = "0x60014DF")]
    [Address(RVA = "0x252CCA4", Offset = "0x252CCA4", VA = "0x252CCA4")]
    private void Init()
    {
    }

    [Token(Token = "0x60014E0")]
    [Address(RVA = "0x252D14C", Offset = "0x252D14C", VA = "0x252D14C")]
    private void SetGraphActive(bool active)
    {
    }

    [Token(Token = "0x60014E1")]
    [Address(RVA = "0x252D280", Offset = "0x252D280", VA = "0x252D280")]
    public G_AudioManager()
    {
    }
  }
}
