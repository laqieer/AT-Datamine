// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.QuestSelectMap.MapDataHolder
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

#nullable disable
namespace Scenes.OutGame.QuestSelectMap
{
  [Token(Token = "0x20033C4")]
  public class MapDataHolder : MonoBehaviour
  {
    [Token(Token = "0x400E0E5")]
    [FieldOffset(Offset = "0x18")]
    [FormerlySerializedAs("mapRangeWith")]
    [SerializeField]
    private float mapRangeWidth;
    [Token(Token = "0x400E0E6")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private float mapRangeHeight;

    [Token(Token = "0x601458A")]
    [Address(RVA = "0x206DD44", Offset = "0x206DD44", VA = "0x206DD44")]
    public MapGroundData GetMapData() => (MapGroundData) null;

    [Token(Token = "0x601458B")]
    [Address(RVA = "0x206FE44", Offset = "0x206FE44", VA = "0x206FE44")]
    public MapDataHolder()
    {
    }
  }
}
