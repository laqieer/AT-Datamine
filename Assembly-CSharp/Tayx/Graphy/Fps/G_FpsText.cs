// Decompiled with JetBrains decompiler
// Type: Tayx.Graphy.Fps.G_FpsText
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Tayx.Graphy.Fps
{
  [Token(Token = "0x200039E")]
  public class G_FpsText : MonoBehaviour
  {
    [Token(Token = "0x4001557")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text m_fpsText;
    [Token(Token = "0x4001558")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text m_msText;
    [Token(Token = "0x4001559")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Text m_avgFpsText;
    [Token(Token = "0x400155A")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Text m_minFpsText;
    [Token(Token = "0x400155B")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Text m_maxFpsText;
    [Token(Token = "0x400155C")]
    [FieldOffset(Offset = "0x40")]
    private GraphyManager m_graphyManager;
    [Token(Token = "0x400155D")]
    [FieldOffset(Offset = "0x48")]
    private G_FpsMonitor m_fpsMonitor;
    [Token(Token = "0x400155E")]
    [FieldOffset(Offset = "0x50")]
    private int m_updateRate;
    [Token(Token = "0x400155F")]
    [FieldOffset(Offset = "0x54")]
    private int m_frameCount;
    [Token(Token = "0x4001560")]
    [FieldOffset(Offset = "0x58")]
    private float m_deltaTime;
    [Token(Token = "0x4001561")]
    [FieldOffset(Offset = "0x5C")]
    private float m_fps;
    [Token(Token = "0x4001562")]
    private const int m_minFps = 0;
    [Token(Token = "0x4001563")]
    private const int m_maxFps = 10000;
    [Token(Token = "0x4001564")]
    private const string m_msStringFormat = "0.0";

    [Token(Token = "0x60014CB")]
    [Address(RVA = "0x252BD84", Offset = "0x252BD84", VA = "0x252BD84")]
    private void Awake()
    {
    }

    [Token(Token = "0x60014CC")]
    [Address(RVA = "0x252BEAC", Offset = "0x252BEAC", VA = "0x252BEAC")]
    private void Update()
    {
    }

    [Token(Token = "0x60014CD")]
    [Address(RVA = "0x252B9E4", Offset = "0x252B9E4", VA = "0x252B9E4")]
    public void UpdateParameters()
    {
    }

    [Token(Token = "0x60014CE")]
    [Address(RVA = "0x252C1D8", Offset = "0x252C1D8", VA = "0x252C1D8")]
    private void SetFpsRelatedTextColor(Text text, float fps)
    {
    }

    [Token(Token = "0x60014CF")]
    [Address(RVA = "0x252BD88", Offset = "0x252BD88", VA = "0x252BD88")]
    private void Init()
    {
    }

    [Token(Token = "0x60014D0")]
    [Address(RVA = "0x252C254", Offset = "0x252C254", VA = "0x252C254")]
    public G_FpsText()
    {
    }
  }
}
