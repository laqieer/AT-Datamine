// Decompiled with JetBrains decompiler
// Type: Battle.Grid.GridTextureContainer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Battle.Grid
{
  [Token(Token = "0x2002536")]
  public sealed class GridTextureContainer : MonoBehaviour
  {
    [Token(Token = "0x4009FFF")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Texture2D ally;
    [Token(Token = "0x400A000")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Texture2D enemy;
    [Token(Token = "0x400A001")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Texture2D route;
    [Token(Token = "0x400A002")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Texture2D movable;
    [Token(Token = "0x400A003")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Texture2D attackable;
    [Token(Token = "0x400A004")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Texture2D healing;
    [Token(Token = "0x400A005")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Texture2D danger;

    [Token(Token = "0x600E5F2")]
    [Address(RVA = "0x486B3FC", Offset = "0x486B3FC", VA = "0x486B3FC")]
    public Texture2D Get(GridViewType type, bool isDanger, AdjoiningDirection dangerNodeFlag = AdjoiningDirection.None)
    {
      return (Texture2D) null;
    }

    [Token(Token = "0x600E5F3")]
    [Address(RVA = "0x486B474", Offset = "0x486B474", VA = "0x486B474")]
    public GridTextureContainer()
    {
    }
  }
}
