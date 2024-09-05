// Decompiled with JetBrains decompiler
// Type: Tayx.Graphy.Ram.G_RamMonitor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Tayx.Graphy.Ram
{
  [Token(Token = "0x2000398")]
  public class G_RamMonitor : MonoBehaviour
  {
    [Token(Token = "0x4001529")]
    [FieldOffset(Offset = "0x18")]
    private float m_allocatedRam;
    [Token(Token = "0x400152A")]
    [FieldOffset(Offset = "0x1C")]
    private float m_reservedRam;
    [Token(Token = "0x400152B")]
    [FieldOffset(Offset = "0x20")]
    private float m_monoRam;

    [Token(Token = "0x17000221")]
    public float AllocatedRam
    {
      [Token(Token = "0x60014A2"), Address(RVA = "0x252ACF8", Offset = "0x252ACF8", VA = "0x252ACF8")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x17000222")]
    public float ReservedRam
    {
      [Token(Token = "0x60014A3"), Address(RVA = "0x252AD00", Offset = "0x252AD00", VA = "0x252AD00")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x17000223")]
    public float MonoRam
    {
      [Token(Token = "0x60014A4"), Address(RVA = "0x252AD08", Offset = "0x252AD08", VA = "0x252AD08")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x60014A5")]
    [Address(RVA = "0x252AD10", Offset = "0x252AD10", VA = "0x252AD10")]
    private void Update()
    {
    }

    [Token(Token = "0x60014A6")]
    [Address(RVA = "0x252AD6C", Offset = "0x252AD6C", VA = "0x252AD6C")]
    public G_RamMonitor()
    {
    }
  }
}
