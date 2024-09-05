// Decompiled with JetBrains decompiler
// Type: Scenes.Story.RadarChartMesh
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Story
{
  [Token(Token = "0x2002D77")]
  [ExecuteAlways]
  public class RadarChartMesh : Graphic
  {
    [Token(Token = "0x400C31F")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private float[] stepvolumes;
    [Token(Token = "0x400C320")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private float radius;
    [Token(Token = "0x400C321")]
    [FieldOffset(Offset = "0xAC")]
    [Range(3f, 30f)]
    [SerializeField]
    private int verticesCount;
    [Token(Token = "0x400C322")]
    [FieldOffset(Offset = "0xB0")]
    [Range(0.0f, 1f)]
    [SerializeField]
    private float maxVolume;
    [Token(Token = "0x400C323")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    private List<float> volumes;

    [Token(Token = "0x6011C52")]
    [Address(RVA = "0x42BE76C", Offset = "0x42BE76C", VA = "0x42BE76C")]
    public int GetVerticesCount() => new int();

    [Token(Token = "0x6011C53")]
    [Address(RVA = "0x42BE774", Offset = "0x42BE774", VA = "0x42BE774")]
    public void SetVolumeLevel(int index, int value)
    {
    }

    [Token(Token = "0x6011C54")]
    [Address(RVA = "0x42BE898", Offset = "0x42BE898", VA = "0x42BE898")]
    public void SetVolume(int index, float value)
    {
    }

    [Token(Token = "0x6011C55")]
    [Address(RVA = "0x42BE900", Offset = "0x42BE900", VA = "0x42BE900")]
    public float GetVolumeLevel(int level) => new float();

    [Token(Token = "0x6011C56")]
    [Address(RVA = "0x42BE930", Offset = "0x42BE930", VA = "0x42BE930")]
    public float GetVolume(int index) => new float();

    [Token(Token = "0x6011C57")]
    [Address(RVA = "0x42BE9BC", Offset = "0x42BE9BC", VA = "0x42BE9BC")]
    public int GetMaxStep() => new int();

    [Token(Token = "0x6011C58")]
    [Address(RVA = "0x42BE9D8", Offset = "0x42BE9D8", VA = "0x42BE9D8", Slot = "44")]
    protected override void OnPopulateMesh(VertexHelper vh)
    {
    }

    [Token(Token = "0x6011C59")]
    [Address(RVA = "0x42BEEE0", Offset = "0x42BEEE0", VA = "0x42BEEE0")]
    private Vector2 CreatePos(float x, float y) => new Vector2();

    [Token(Token = "0x6011C5A")]
    [Address(RVA = "0x42BF014", Offset = "0x42BF014", VA = "0x42BF014")]
    public RadarChartMesh()
    {
    }
  }
}
