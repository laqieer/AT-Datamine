// Decompiled with JetBrains decompiler
// Type: Tayx.Graphy.Audio.G_AudioGraph
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Tayx.Graphy.Graph;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Tayx.Graphy.Audio
{
  [Token(Token = "0x200039F")]
  public class G_AudioGraph : G_Graph
  {
    [Token(Token = "0x4001565")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Image m_imageGraph;
    [Token(Token = "0x4001566")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Image m_imageGraphHighestValues;
    [Token(Token = "0x4001567")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Shader ShaderFull;
    [Token(Token = "0x4001568")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Shader ShaderLight;
    [Token(Token = "0x4001569")]
    [FieldOffset(Offset = "0x38")]
    private GraphyManager m_graphyManager;
    [Token(Token = "0x400156A")]
    [FieldOffset(Offset = "0x40")]
    private G_AudioMonitor m_audioMonitor;
    [Token(Token = "0x400156B")]
    [FieldOffset(Offset = "0x48")]
    private int m_resolution;
    [Token(Token = "0x400156C")]
    [FieldOffset(Offset = "0x50")]
    private G_GraphShader m_shaderGraph;
    [Token(Token = "0x400156D")]
    [FieldOffset(Offset = "0x58")]
    private G_GraphShader m_shaderGraphHighestValues;
    [Token(Token = "0x400156E")]
    [FieldOffset(Offset = "0x60")]
    private float[] m_graphArray;
    [Token(Token = "0x400156F")]
    [FieldOffset(Offset = "0x68")]
    private float[] m_graphArrayHighestValue;

    [Token(Token = "0x60014D1")]
    [Address(RVA = "0x252C264", Offset = "0x252C264", VA = "0x252C264")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x60014D2")]
    [Address(RVA = "0x252C350", Offset = "0x252C350", VA = "0x252C350")]
    private void Update()
    {
    }

    [Token(Token = "0x60014D3")]
    [Address(RVA = "0x252C3E8", Offset = "0x252C3E8", VA = "0x252C3E8")]
    public void UpdateParameters()
    {
    }

    [Token(Token = "0x60014D4")]
    [Address(RVA = "0x252C58C", Offset = "0x252C58C", VA = "0x252C58C", Slot = "4")]
    protected override void UpdateGraph()
    {
    }

    [Token(Token = "0x60014D5")]
    [Address(RVA = "0x252CA98", Offset = "0x252CA98", VA = "0x252CA98", Slot = "5")]
    protected override void CreatePoints()
    {
    }

    [Token(Token = "0x60014D6")]
    [Address(RVA = "0x252C268", Offset = "0x252C268", VA = "0x252C268")]
    private void Init()
    {
    }

    [Token(Token = "0x60014D7")]
    [Address(RVA = "0x252CC90", Offset = "0x252CC90", VA = "0x252CC90")]
    public G_AudioGraph()
    {
    }
  }
}
