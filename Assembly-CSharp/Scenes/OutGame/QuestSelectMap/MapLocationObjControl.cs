// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.QuestSelectMap.MapLocationObjControl
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

#nullable disable
namespace Scenes.OutGame.QuestSelectMap
{
  [Token(Token = "0x20033C9")]
  public class MapLocationObjControl : MonoBehaviour
  {
    [Token(Token = "0x400E0EF")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private PlayableDirector inDirector;
    [Token(Token = "0x400E0F0")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private PlayableDirector outDirector;
    [Token(Token = "0x400E0F1")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private SpriteRenderer landmarkRenderer;
    [Token(Token = "0x400E0F2")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private GameObject dotCharaPos;
    [Token(Token = "0x400E0F3")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private GameObject namePlateDisplaySpaceLocPos;
    [Token(Token = "0x400E0F4")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private GameObject billboardOrigin;
    [Token(Token = "0x400E0F5")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private MapDotCharaModelFadeAccesser dotCharaFadeAccesser;

    [Token(Token = "0x170043C5")]
    public PlayableDirector InDirector
    {
      [Token(Token = "0x601459C"), Address(RVA = "0x207001C", Offset = "0x207001C", VA = "0x207001C")] get
      {
        return (PlayableDirector) null;
      }
    }

    [Token(Token = "0x170043C6")]
    public PlayableDirector OutDirector
    {
      [Token(Token = "0x601459D"), Address(RVA = "0x2070024", Offset = "0x2070024", VA = "0x2070024")] get
      {
        return (PlayableDirector) null;
      }
    }

    [Token(Token = "0x170043C7")]
    public SpriteRenderer LandmarkRenderer
    {
      [Token(Token = "0x601459E"), Address(RVA = "0x207002C", Offset = "0x207002C", VA = "0x207002C")] get
      {
        return (SpriteRenderer) null;
      }
    }

    [Token(Token = "0x170043C8")]
    public GameObject DotCharaPos
    {
      [Token(Token = "0x601459F"), Address(RVA = "0x2070034", Offset = "0x2070034", VA = "0x2070034")] get
      {
        return (GameObject) null;
      }
    }

    [Token(Token = "0x170043C9")]
    public GameObject NamePlateLocSpacePos
    {
      [Token(Token = "0x60145A0"), Address(RVA = "0x207003C", Offset = "0x207003C", VA = "0x207003C")] get
      {
        return (GameObject) null;
      }
    }

    [Token(Token = "0x170043CA")]
    public GameObject BillboardOrigin
    {
      [Token(Token = "0x60145A1"), Address(RVA = "0x2070044", Offset = "0x2070044", VA = "0x2070044")] get
      {
        return (GameObject) null;
      }
    }

    [Token(Token = "0x170043CB")]
    public MapDotCharaModelFadeAccesser DotCharaFadeAccesser
    {
      [Token(Token = "0x60145A2"), Address(RVA = "0x207004C", Offset = "0x207004C", VA = "0x207004C")] get
      {
        return (MapDotCharaModelFadeAccesser) null;
      }
    }

    [Token(Token = "0x60145A3")]
    [Address(RVA = "0x2070054", Offset = "0x2070054", VA = "0x2070054")]
    public MapLocationObjControl()
    {
    }
  }
}
