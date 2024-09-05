// Decompiled with JetBrains decompiler
// Type: Tayx.Graphy.Ram.G_RamText
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Tayx.Graphy.Ram
{
  [Token(Token = "0x2000399")]
  public class G_RamText : MonoBehaviour
  {
    [Token(Token = "0x400152C")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text m_allocatedSystemMemorySizeText;
    [Token(Token = "0x400152D")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text m_reservedSystemMemorySizeText;
    [Token(Token = "0x400152E")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Text m_monoSystemMemorySizeText;
    [Token(Token = "0x400152F")]
    [FieldOffset(Offset = "0x30")]
    private GraphyManager m_graphyManager;
    [Token(Token = "0x4001530")]
    [FieldOffset(Offset = "0x38")]
    private G_RamMonitor m_ramMonitor;
    [Token(Token = "0x4001531")]
    [FieldOffset(Offset = "0x40")]
    private float m_updateRate;
    [Token(Token = "0x4001532")]
    [FieldOffset(Offset = "0x44")]
    private float m_deltaTime;
    [Token(Token = "0x4001533")]
    [FieldOffset(Offset = "0x48")]
    private readonly string m_memoryStringFormat;

    [Token(Token = "0x60014A7")]
    [Address(RVA = "0x252AD74", Offset = "0x252AD74", VA = "0x252AD74")]
    private void Awake()
    {
    }

    [Token(Token = "0x60014A8")]
    [Address(RVA = "0x252AEA8", Offset = "0x252AEA8", VA = "0x252AEA8")]
    private void Update()
    {
    }

    [Token(Token = "0x60014A9")]
    [Address(RVA = "0x252AB98", Offset = "0x252AB98", VA = "0x252AB98")]
    public void UpdateParameters()
    {
    }

    [Token(Token = "0x60014AA")]
    [Address(RVA = "0x252AD78", Offset = "0x252AD78", VA = "0x252AD78")]
    private void Init()
    {
    }

    [Token(Token = "0x60014AB")]
    [Address(RVA = "0x252AFD4", Offset = "0x252AFD4", VA = "0x252AFD4")]
    public G_RamText()
    {
    }
  }
}
