// Decompiled with JetBrains decompiler
// Type: Tayx.Graphy.Fps.G_FpsManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using Tayx.Graphy.UI;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Tayx.Graphy.Fps
{
  [Token(Token = "0x200039C")]
  public class G_FpsManager : MonoBehaviour, IMovable, IModifiableState
  {
    [Token(Token = "0x400153D")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject m_fpsGraphGameObject;
    [Token(Token = "0x400153E")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private List<GameObject> m_nonBasicTextGameObjects;
    [Token(Token = "0x400153F")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private List<Image> m_backgroundImages;
    [Token(Token = "0x4001540")]
    [FieldOffset(Offset = "0x30")]
    private GraphyManager m_graphyManager;
    [Token(Token = "0x4001541")]
    [FieldOffset(Offset = "0x38")]
    private G_FpsGraph m_fpsGraph;
    [Token(Token = "0x4001542")]
    [FieldOffset(Offset = "0x40")]
    private G_FpsMonitor m_fpsMonitor;
    [Token(Token = "0x4001543")]
    [FieldOffset(Offset = "0x48")]
    private G_FpsText m_fpsText;
    [Token(Token = "0x4001544")]
    [FieldOffset(Offset = "0x50")]
    private RectTransform m_rectTransform;
    [Token(Token = "0x4001545")]
    [FieldOffset(Offset = "0x58")]
    private List<GameObject> m_childrenGameObjects;
    [Token(Token = "0x4001546")]
    [FieldOffset(Offset = "0x60")]
    private GraphyManager.ModuleState m_previousModuleState;
    [Token(Token = "0x4001547")]
    [FieldOffset(Offset = "0x64")]
    private GraphyManager.ModuleState m_currentModuleState;

    [Token(Token = "0x60014B6")]
    [Address(RVA = "0x252B4D4", Offset = "0x252B4D4", VA = "0x252B4D4")]
    private void Awake()
    {
    }

    [Token(Token = "0x60014B7")]
    [Address(RVA = "0x252B97C", Offset = "0x252B97C", VA = "0x252B97C")]
    private void Start()
    {
    }

    [Token(Token = "0x60014B8")]
    [Address(RVA = "0x2525464", Offset = "0x2525464", VA = "0x2525464", Slot = "4")]
    public void SetPosition(GraphyManager.ModulePosition newModulePosition)
    {
    }

    [Token(Token = "0x60014B9")]
    [Address(RVA = "0x2525D60", Offset = "0x2525D60", VA = "0x2525D60", Slot = "5")]
    public void SetState(GraphyManager.ModuleState state, bool silentUpdate = false)
    {
    }

    [Token(Token = "0x60014BA")]
    [Address(RVA = "0x2527EF8", Offset = "0x2527EF8", VA = "0x2527EF8")]
    public void RestorePreviousState()
    {
    }

    [Token(Token = "0x60014BB")]
    [Address(RVA = "0x2525F38", Offset = "0x2525F38", VA = "0x2525F38")]
    public void UpdateParameters()
    {
    }

    [Token(Token = "0x60014BC")]
    [Address(RVA = "0x25281F8", Offset = "0x25281F8", VA = "0x25281F8")]
    public void RefreshParameters()
    {
    }

    [Token(Token = "0x60014BD")]
    [Address(RVA = "0x252B4D8", Offset = "0x252B4D8", VA = "0x252B4D8")]
    private void Init()
    {
    }

    [Token(Token = "0x60014BE")]
    [Address(RVA = "0x252B980", Offset = "0x252B980", VA = "0x252B980")]
    private void SetGraphActive(bool active)
    {
    }

    [Token(Token = "0x60014BF")]
    [Address(RVA = "0x252BA04", Offset = "0x252BA04", VA = "0x252BA04")]
    public G_FpsManager()
    {
    }
  }
}
