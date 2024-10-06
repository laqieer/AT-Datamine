// Decompiled with JetBrains decompiler
// Type: Tayx.Graphy.Fps.G_FpsMonitor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Runtime.CompilerServices;
using UnityEngine;

#nullable disable
namespace Tayx.Graphy.Fps
{
  [Token(Token = "0x200039D")]
  public class G_FpsMonitor : MonoBehaviour
  {
    [Token(Token = "0x4001548")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private int m_averageSamples;
    [Token(Token = "0x4001549")]
    [FieldOffset(Offset = "0x20")]
    private GraphyManager m_graphyManager;
    [Token(Token = "0x400154A")]
    [FieldOffset(Offset = "0x28")]
    private float m_currentFps;
    [Token(Token = "0x400154B")]
    [FieldOffset(Offset = "0x2C")]
    private float m_avgFps;
    [Token(Token = "0x400154C")]
    [FieldOffset(Offset = "0x30")]
    private float m_minFps;
    [Token(Token = "0x400154D")]
    [FieldOffset(Offset = "0x34")]
    private float m_maxFps;
    [Token(Token = "0x400154E")]
    [FieldOffset(Offset = "0x38")]
    private float[] m_averageFpsSamples;
    [Token(Token = "0x400154F")]
    [FieldOffset(Offset = "0x40")]
    private int m_avgFpsSamplesOffset;
    [Token(Token = "0x4001550")]
    [FieldOffset(Offset = "0x44")]
    private int m_indexMask;
    [Token(Token = "0x4001551")]
    [FieldOffset(Offset = "0x48")]
    private int m_avgFpsSamplesCapacity;
    [Token(Token = "0x4001552")]
    [FieldOffset(Offset = "0x4C")]
    private int m_avgFpsSamplesCount;
    [Token(Token = "0x4001553")]
    [FieldOffset(Offset = "0x50")]
    private int m_timeToResetMinMaxFps;
    [Token(Token = "0x4001554")]
    [FieldOffset(Offset = "0x54")]
    private float m_timeToResetMinFpsPassed;
    [Token(Token = "0x4001555")]
    [FieldOffset(Offset = "0x58")]
    private float m_timeToResetMaxFpsPassed;
    [Token(Token = "0x4001556")]
    [FieldOffset(Offset = "0x5C")]
    private float unscaledDeltaTime;

    [Token(Token = "0x17000224")]
    public float CurrentFPS
    {
      [Token(Token = "0x60014C0"), Address(RVA = "0x252BAE8", Offset = "0x252BAE8", VA = "0x252BAE8")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x17000225")]
    public float AverageFPS
    {
      [Token(Token = "0x60014C1"), Address(RVA = "0x252BAF0", Offset = "0x252BAF0", VA = "0x252BAF0")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x17000226")]
    public float MinFPS
    {
      [Token(Token = "0x60014C2"), Address(RVA = "0x252BAF8", Offset = "0x252BAF8", VA = "0x252BAF8")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x17000227")]
    public float MaxFPS
    {
      [Token(Token = "0x60014C3"), Address(RVA = "0x252BB00", Offset = "0x252BB00", VA = "0x252BB00")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x60014C4")]
    [Address(RVA = "0x252BB08", Offset = "0x252BB08", VA = "0x252BB08")]
    private void Awake()
    {
    }

    [Token(Token = "0x60014C5")]
    [Address(RVA = "0x252BB94", Offset = "0x252BB94", VA = "0x252BB94")]
    private void Update()
    {
    }

    [Token(Token = "0x60014C6")]
    [Address(RVA = "0x252B9C4", Offset = "0x252B9C4", VA = "0x252B9C4")]
    public void UpdateParameters()
    {
    }

    [Token(Token = "0x60014C7")]
    [Address(RVA = "0x252BB0C", Offset = "0x252BB0C", VA = "0x252BB0C")]
    private void Init()
    {
    }

    [Token(Token = "0x60014C8")]
    [Address(RVA = "0x252BCE4", Offset = "0x252BCE4", VA = "0x252BCE4")]
    private void ResizeSamplesBuffer(int size)
    {
    }

    [Token(Token = "0x60014C9")]
    [Address(RVA = "0x252BD5C", Offset = "0x252BD5C", VA = "0x252BD5C")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private int ToBufferIndex(int index) => new int();

    [Token(Token = "0x60014CA")]
    [Address(RVA = "0x252BD6C", Offset = "0x252BD6C", VA = "0x252BD6C")]
    public G_FpsMonitor()
    {
    }
  }
}
