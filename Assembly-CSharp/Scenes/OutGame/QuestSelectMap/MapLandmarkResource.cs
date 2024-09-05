// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.QuestSelectMap.MapLandmarkResource
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.QuestSelectMap
{
  [Token(Token = "0x20033C7")]
  public class MapLandmarkResource : ScriptableObject
  {
    [Token(Token = "0x400E0EB")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Sprite landmarkSprite;

    [Token(Token = "0x6014596")]
    [Address(RVA = "0x206FFEC", Offset = "0x206FFEC", VA = "0x206FFEC")]
    public Sprite GetLandmarkSprite() => (Sprite) null;

    [Token(Token = "0x6014597")]
    [Address(RVA = "0x206FFF4", Offset = "0x206FFF4", VA = "0x206FFF4")]
    public MapLandmarkResource()
    {
    }
  }
}
