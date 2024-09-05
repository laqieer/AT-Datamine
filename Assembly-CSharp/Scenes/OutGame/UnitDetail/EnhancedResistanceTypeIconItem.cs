// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.UnitDetail.EnhancedResistanceTypeIconItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Scenes.OutGame.Icon;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.UnitDetail
{
  [Token(Token = "0x20032D0")]
  public class EnhancedResistanceTypeIconItem : MonoBehaviour
  {
    [Token(Token = "0x400DB13")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private TypeIcon typeIcon;
    [Token(Token = "0x400DB14")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private SignedValueText signedValueText;
    [Token(Token = "0x400DB15")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject iconObj;
    [Token(Token = "0x400DB16")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private GameObject allIconObj;

    [Token(Token = "0x6013F65")]
    [Address(RVA = "0x2343994", Offset = "0x2343994", VA = "0x2343994")]
    public void InitializeTypeIcon(Sprite sprite, int value)
    {
    }

    [Token(Token = "0x6013F66")]
    [Address(RVA = "0x2343AC8", Offset = "0x2343AC8", VA = "0x2343AC8")]
    public void InitializeAllIcon(int value)
    {
    }

    [Token(Token = "0x6013F67")]
    [Address(RVA = "0x2343B8C", Offset = "0x2343B8C", VA = "0x2343B8C")]
    public EnhancedResistanceTypeIconItem()
    {
    }
  }
}
