// Decompiled with JetBrains decompiler
// Type: Scenes.Mission.MissionTreasureBoxList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Scenes.Mission
{
  [Token(Token = "0x2002AAB")]
  public class MissionTreasureBoxList : MonoBehaviour
  {
    [Token(Token = "0x400B58F")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private MissionTreasureBox _baseBox;
    [Token(Token = "0x400B590")]
    [FieldOffset(Offset = "0x20")]
    private List<MissionTreasureBox> _list;

    [Token(Token = "0x6010B05")]
    [Address(RVA = "0x4BD2354", Offset = "0x4BD2354", VA = "0x4BD2354")]
    private void Awake()
    {
    }

    [Token(Token = "0x6010B06")]
    [Address(RVA = "0x4BD2380", Offset = "0x4BD2380", VA = "0x4BD2380")]
    public MissionTreasureBox AddBox() => (MissionTreasureBox) null;

    [Token(Token = "0x6010B07")]
    [Address(RVA = "0x4BD24BC", Offset = "0x4BD24BC", VA = "0x4BD24BC")]
    public void Clear()
    {
    }

    [Token(Token = "0x6010B08")]
    [Address(RVA = "0x4BD25C4", Offset = "0x4BD25C4", VA = "0x4BD25C4")]
    public void Alignment()
    {
    }

    [Token(Token = "0x6010B09")]
    [Address(RVA = "0x4BD2744", Offset = "0x4BD2744", VA = "0x4BD2744")]
    public MissionTreasureBox GetTreasureBox(int index) => (MissionTreasureBox) null;

    [Token(Token = "0x6010B0A")]
    [Address(RVA = "0x4BD27C4", Offset = "0x4BD27C4", VA = "0x4BD27C4")]
    public MissionTreasureBoxList()
    {
    }
  }
}
