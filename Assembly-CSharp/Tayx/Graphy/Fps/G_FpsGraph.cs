// Decompiled with JetBrains decompiler
// Type: Tayx.Graphy.Fps.G_FpsGraph
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Tayx.Graphy.Graph;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Tayx.Graphy.Fps
{
  [Token(Token = "0x200039B")]
  public class G_FpsGraph : G_Graph
  {
    [Token(Token = "0x4001534")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Image m_imageGraph;
    [Token(Token = "0x4001535")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Shader ShaderFull;
    [Token(Token = "0x4001536")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Shader ShaderLight;
    [Token(Token = "0x4001537")]
    [FieldOffset(Offset = "0x30")]
    private GraphyManager m_graphyManager;
    [Token(Token = "0x4001538")]
    [FieldOffset(Offset = "0x38")]
    private G_FpsMonitor m_fpsMonitor;
    [Token(Token = "0x4001539")]
    [FieldOffset(Offset = "0x40")]
    private int m_resolution;
    [Token(Token = "0x400153A")]
    [FieldOffset(Offset = "0x48")]
    private G_GraphShader m_shaderGraph;
    [Token(Token = "0x400153B")]
    [FieldOffset(Offset = "0x50")]
    private int[] m_fpsArray;
    [Token(Token = "0x400153C")]
    [FieldOffset(Offset = "0x58")]
    private int m_highestFps;

    [Token(Token = "0x60014AF")]
    [Address(RVA = "0x252B02C", Offset = "0x252B02C", VA = "0x252B02C")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x60014B0")]
    [Address(RVA = "0x252B0F8", Offset = "0x252B0F8", VA = "0x252B0F8")]
    private void Update()
    {
    }

    [Token(Token = "0x60014B1")]
    [Address(RVA = "0x252B104", Offset = "0x252B104", VA = "0x252B104")]
    public void UpdateParameters()
    {
    }

    [Token(Token = "0x60014B2")]
    [Address(RVA = "0x252B1FC", Offset = "0x252B1FC", VA = "0x252B1FC", Slot = "4")]
    protected override void UpdateGraph()
    {
    }

    [Token(Token = "0x60014B3")]
    [Address(RVA = "0x252B3A8", Offset = "0x252B3A8", VA = "0x252B3A8", Slot = "5")]
    protected override void CreatePoints()
    {
    }

    [Token(Token = "0x60014B4")]
    [Address(RVA = "0x252B030", Offset = "0x252B030", VA = "0x252B030")]
    private void Init()
    {
    }

    [Token(Token = "0x60014B5")]
    [Address(RVA = "0x252B4C4", Offset = "0x252B4C4", VA = "0x252B4C4")]
    public G_FpsGraph()
    {
    }
  }
}
