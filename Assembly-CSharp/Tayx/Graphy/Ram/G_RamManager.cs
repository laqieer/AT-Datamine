// Decompiled with JetBrains decompiler
// Type: Tayx.Graphy.Ram.G_RamManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using Tayx.Graphy.UI;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Tayx.Graphy.Ram
{
  [Token(Token = "0x2000397")]
  public class G_RamManager : MonoBehaviour, IMovable, IModifiableState
  {
    [Token(Token = "0x4001520")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject m_ramGraphGameObject;
    [Token(Token = "0x4001521")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private List<Image> m_backgroundImages;
    [Token(Token = "0x4001522")]
    [FieldOffset(Offset = "0x28")]
    private GraphyManager m_graphyManager;
    [Token(Token = "0x4001523")]
    [FieldOffset(Offset = "0x30")]
    private G_RamGraph m_ramGraph;
    [Token(Token = "0x4001524")]
    [FieldOffset(Offset = "0x38")]
    private G_RamText m_ramText;
    [Token(Token = "0x4001525")]
    [FieldOffset(Offset = "0x40")]
    private RectTransform m_rectTransform;
    [Token(Token = "0x4001526")]
    [FieldOffset(Offset = "0x48")]
    private List<GameObject> m_childrenGameObjects;
    [Token(Token = "0x4001527")]
    [FieldOffset(Offset = "0x50")]
    private GraphyManager.ModuleState m_previousModuleState;
    [Token(Token = "0x4001528")]
    [FieldOffset(Offset = "0x54")]
    private GraphyManager.ModuleState m_currentModuleState;

    [Token(Token = "0x6001498")]
    [Address(RVA = "0x252A6CC", Offset = "0x252A6CC", VA = "0x252A6CC")]
    private void Awake()
    {
    }

    [Token(Token = "0x6001499")]
    [Address(RVA = "0x252AB50", Offset = "0x252AB50", VA = "0x252AB50")]
    private void Start()
    {
    }

    [Token(Token = "0x600149A")]
    [Address(RVA = "0x252574C", Offset = "0x252574C", VA = "0x252574C", Slot = "4")]
    public void SetPosition(GraphyManager.ModulePosition newModulePosition)
    {
    }

    [Token(Token = "0x600149B")]
    [Address(RVA = "0x25262D4", Offset = "0x25262D4", VA = "0x25262D4", Slot = "5")]
    public void SetState(GraphyManager.ModuleState state, bool silentUpdate = false)
    {
    }

    [Token(Token = "0x600149C")]
    [Address(RVA = "0x2527F04", Offset = "0x2527F04", VA = "0x2527F04")]
    public void RestorePreviousState()
    {
    }

    [Token(Token = "0x600149D")]
    [Address(RVA = "0x2526454", Offset = "0x2526454", VA = "0x2526454")]
    public void UpdateParameters()
    {
    }

    [Token(Token = "0x600149E")]
    [Address(RVA = "0x25283C0", Offset = "0x25283C0", VA = "0x25283C0")]
    public void RefreshParameters()
    {
    }

    [Token(Token = "0x600149F")]
    [Address(RVA = "0x252A6D0", Offset = "0x252A6D0", VA = "0x252A6D0")]
    private void Init()
    {
    }

    [Token(Token = "0x60014A0")]
    [Address(RVA = "0x252AB54", Offset = "0x252AB54", VA = "0x252AB54")]
    private void SetGraphActive(bool active)
    {
    }

    [Token(Token = "0x60014A1")]
    [Address(RVA = "0x252AC38", Offset = "0x252AC38", VA = "0x252AC38")]
    public G_RamManager()
    {
    }
  }
}
