// Decompiled with JetBrains decompiler
// Type: Tayx.Graphy.Ram.G_RamGraph
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Tayx.Graphy.Graph;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Tayx.Graphy.Ram
{
  [Token(Token = "0x2000396")]
  public class G_RamGraph : G_Graph
  {
    [Token(Token = "0x4001511")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Image m_imageAllocated;
    [Token(Token = "0x4001512")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Image m_imageReserved;
    [Token(Token = "0x4001513")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Image m_imageMono;
    [Token(Token = "0x4001514")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Shader ShaderFull;
    [Token(Token = "0x4001515")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Shader ShaderLight;
    [Token(Token = "0x4001516")]
    [FieldOffset(Offset = "0x40")]
    private GraphyManager m_graphyManager;
    [Token(Token = "0x4001517")]
    [FieldOffset(Offset = "0x48")]
    private G_RamMonitor m_ramMonitor;
    [Token(Token = "0x4001518")]
    [FieldOffset(Offset = "0x50")]
    private int m_resolution;
    [Token(Token = "0x4001519")]
    [FieldOffset(Offset = "0x58")]
    private G_GraphShader m_shaderGraphAllocated;
    [Token(Token = "0x400151A")]
    [FieldOffset(Offset = "0x60")]
    private G_GraphShader m_shaderGraphReserved;
    [Token(Token = "0x400151B")]
    [FieldOffset(Offset = "0x68")]
    private G_GraphShader m_shaderGraphMono;
    [Token(Token = "0x400151C")]
    [FieldOffset(Offset = "0x70")]
    private float[] m_allocatedArray;
    [Token(Token = "0x400151D")]
    [FieldOffset(Offset = "0x78")]
    private float[] m_reservedArray;
    [Token(Token = "0x400151E")]
    [FieldOffset(Offset = "0x80")]
    private float[] m_monoArray;
    [Token(Token = "0x400151F")]
    [FieldOffset(Offset = "0x88")]
    private float m_highestMemory;

    [Token(Token = "0x6001491")]
    [Address(RVA = "0x2529DDC", Offset = "0x2529DDC", VA = "0x2529DDC")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x6001492")]
    [Address(RVA = "0x2529EF8", Offset = "0x2529EF8", VA = "0x2529EF8")]
    private void Update()
    {
    }

    [Token(Token = "0x6001493")]
    [Address(RVA = "0x2529F04", Offset = "0x2529F04", VA = "0x2529F04")]
    public void UpdateParameters()
    {
    }

    [Token(Token = "0x6001494")]
    [Address(RVA = "0x252A18C", Offset = "0x252A18C", VA = "0x252A18C", Slot = "4")]
    protected override void UpdateGraph()
    {
    }

    [Token(Token = "0x6001495")]
    [Address(RVA = "0x252A3E4", Offset = "0x252A3E4", VA = "0x252A3E4", Slot = "5")]
    protected override void CreatePoints()
    {
    }

    [Token(Token = "0x6001496")]
    [Address(RVA = "0x2529DE0", Offset = "0x2529DE0", VA = "0x2529DE0")]
    private void Init()
    {
    }

    [Token(Token = "0x6001497")]
    [Address(RVA = "0x252A6B4", Offset = "0x252A6B4", VA = "0x252A6B4")]
    public G_RamGraph()
    {
    }
  }
}
