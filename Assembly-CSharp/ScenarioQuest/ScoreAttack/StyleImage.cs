// Decompiled with JetBrains decompiler
// Type: ScenarioQuest.ScoreAttack.StyleImage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using UI.Utilities;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace ScenarioQuest.ScoreAttack
{
  [Token(Token = "0x2000876")]
  public class StyleImage : MonoBehaviour
  {
    [Token(Token = "0x40027FF")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Image image;
    [Token(Token = "0x4002800")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private ImageAdjustController illustration;
    [Token(Token = "0x4002801")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private IllustLayoutComponent layoutComponent;
    [Token(Token = "0x4002802")]
    [FieldOffset(Offset = "0x30")]
    private Sprite _sprite;
    [Token(Token = "0x4002803")]
    [FieldOffset(Offset = "0x38")]
    private IllustLayoutInfo _info;

    [Token(Token = "0x6003084")]
    [Address(RVA = "0x3E74F34", Offset = "0x3E74F34", VA = "0x3E74F34")]
    public void Initialize(AssetCachedSpawner spawner, int styleId)
    {
    }

    [Token(Token = "0x6003085")]
    [Address(RVA = "0x3E76D24", Offset = "0x3E76D24", VA = "0x3E76D24")]
    public void SetImage()
    {
    }

    [Token(Token = "0x6003086")]
    [Address(RVA = "0x3E75604", Offset = "0x3E75604", VA = "0x3E75604")]
    public void SetLayoutImage()
    {
    }

    [Token(Token = "0x6003087")]
    [Address(RVA = "0x3E7A0B8", Offset = "0x3E7A0B8", VA = "0x3E7A0B8")]
    public StyleImage()
    {
    }
  }
}
