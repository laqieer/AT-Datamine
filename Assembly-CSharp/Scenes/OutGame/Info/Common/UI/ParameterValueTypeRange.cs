// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Info.Common.UI.ParameterValueTypeRange
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.Info.Common.UI
{
  [Token(Token = "0x20035F1")]
  public class ParameterValueTypeRange : MonoBehaviour
  {
    [Token(Token = "0x400EA9A")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text title;
    [Token(Token = "0x400EA9B")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text min;
    [Token(Token = "0x400EA9C")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Text max;
    [Token(Token = "0x400EA9D")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Image icon;

    [Token(Token = "0x60153B9")]
    [Address(RVA = "0x4D8A2A4", Offset = "0x4D8A2A4", VA = "0x4D8A2A4")]
    public void Set(int min, int max)
    {
    }

    [Token(Token = "0x60153BA")]
    [Address(RVA = "0x4D8D894", Offset = "0x4D8D894", VA = "0x4D8D894")]
    public void SetIcon(Sprite sprite)
    {
    }

    [Token(Token = "0x60153BB")]
    [Address(RVA = "0x4D8D8B0", Offset = "0x4D8D8B0", VA = "0x4D8D8B0")]
    public ParameterValueTypeRange()
    {
    }
  }
}
