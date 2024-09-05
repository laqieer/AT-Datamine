// Decompiled with JetBrains decompiler
// Type: Story.Chart.ChartParameter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Story.Chart
{
  [Token(Token = "0x20006E7")]
  [Serializable]
  public class ChartParameter
  {
    [Token(Token = "0x4002090")]
    [FieldOffset(Offset = "0x10")]
    [Header("ノードの間隔")]
    [SerializeField]
    public Vector2 Space;

    [Token(Token = "0x6002721")]
    [Address(RVA = "0x366C3B4", Offset = "0x366C3B4", VA = "0x366C3B4")]
    public ChartParameter()
    {
    }
  }
}
