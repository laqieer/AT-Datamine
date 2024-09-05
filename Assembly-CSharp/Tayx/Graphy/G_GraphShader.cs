// Decompiled with JetBrains decompiler
// Type: Tayx.Graphy.G_GraphShader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Tayx.Graphy
{
  [Token(Token = "0x200038F")]
  public class G_GraphShader
  {
    [Token(Token = "0x40014F5")]
    public const int ArrayMaxSizeFull = 512;
    [Token(Token = "0x40014F6")]
    public const int ArrayMaxSizeLight = 128;
    [Token(Token = "0x40014F7")]
    [FieldOffset(Offset = "0x10")]
    public int ArrayMaxSize;
    [Token(Token = "0x40014F8")]
    [FieldOffset(Offset = "0x18")]
    public float[] Array;
    [Token(Token = "0x40014F9")]
    [FieldOffset(Offset = "0x20")]
    public Image Image;
    [Token(Token = "0x40014FA")]
    [FieldOffset(Offset = "0x28")]
    private string Name;
    [Token(Token = "0x40014FB")]
    [FieldOffset(Offset = "0x30")]
    private string Name_Length;
    [Token(Token = "0x40014FC")]
    [FieldOffset(Offset = "0x38")]
    public float Average;
    [Token(Token = "0x40014FD")]
    [FieldOffset(Offset = "0x3C")]
    private int averagePropertyId;
    [Token(Token = "0x40014FE")]
    [FieldOffset(Offset = "0x40")]
    public float GoodThreshold;
    [Token(Token = "0x40014FF")]
    [FieldOffset(Offset = "0x44")]
    public float CautionThreshold;
    [Token(Token = "0x4001500")]
    [FieldOffset(Offset = "0x48")]
    private int goodThresholdPropertyId;
    [Token(Token = "0x4001501")]
    [FieldOffset(Offset = "0x4C")]
    private int cautionThresholdPropertyId;
    [Token(Token = "0x4001502")]
    [FieldOffset(Offset = "0x50")]
    public Color GoodColor;
    [Token(Token = "0x4001503")]
    [FieldOffset(Offset = "0x60")]
    public Color CautionColor;
    [Token(Token = "0x4001504")]
    [FieldOffset(Offset = "0x70")]
    public Color CriticalColor;
    [Token(Token = "0x4001505")]
    [FieldOffset(Offset = "0x80")]
    private int goodColorPropertyId;
    [Token(Token = "0x4001506")]
    [FieldOffset(Offset = "0x84")]
    private int cautionColorPropertyId;
    [Token(Token = "0x4001507")]
    [FieldOffset(Offset = "0x88")]
    private int criticalColorPropertyId;

    [Token(Token = "0x600146E")]
    [Address(RVA = "0x25288A0", Offset = "0x25288A0", VA = "0x25288A0")]
    public void InitializeShader()
    {
    }

    [Token(Token = "0x600146F")]
    [Address(RVA = "0x2528A1C", Offset = "0x2528A1C", VA = "0x2528A1C")]
    public void UpdateArray()
    {
    }

    [Token(Token = "0x6001470")]
    [Address(RVA = "0x2528A60", Offset = "0x2528A60", VA = "0x2528A60")]
    public void UpdateAverage()
    {
    }

    [Token(Token = "0x6001471")]
    [Address(RVA = "0x2528A9C", Offset = "0x2528A9C", VA = "0x2528A9C")]
    public void UpdateThresholds()
    {
    }

    [Token(Token = "0x6001472")]
    [Address(RVA = "0x2528B04", Offset = "0x2528B04", VA = "0x2528B04")]
    public void UpdateColors()
    {
    }

    [Token(Token = "0x6001473")]
    [Address(RVA = "0x2528BA4", Offset = "0x2528BA4", VA = "0x2528BA4")]
    public void UpdatePoints()
    {
    }

    [Token(Token = "0x6001474")]
    [Address(RVA = "0x2528BE0", Offset = "0x2528BE0", VA = "0x2528BE0")]
    public G_GraphShader()
    {
    }
  }
}
