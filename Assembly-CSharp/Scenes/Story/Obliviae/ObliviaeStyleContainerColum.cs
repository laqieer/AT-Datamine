// Decompiled with JetBrains decompiler
// Type: Scenes.Story.Obliviae.ObliviaeStyleContainerColum
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Scenes.OutGame.OutGameMenu;
using UnityEngine;

#nullable disable
namespace Scenes.Story.Obliviae
{
  [Token(Token = "0x2002E72")]
  public class ObliviaeStyleContainerColum : InfiniteCellBase
  {
    [Token(Token = "0x400C747")]
    [FieldOffset(Offset = "0x0")]
    public static readonly int CONTAINER_IN_ICON_COUNT;
    [Token(Token = "0x400C748")]
    [FieldOffset(Offset = "0x28")]
    [Header("真ん中・上・下の順で入れること")]
    [SerializeField]
    private StyleThumb[] styleThumb;
    [Token(Token = "0x400C749")]
    [FieldOffset(Offset = "0x30")]
    [Header("アイコンが1つの場合のprefabの幅")]
    [SerializeField]
    private float singleContainerSize;

    [Token(Token = "0x17003DA8")]
    public float ContainerWidthSingle
    {
      [Token(Token = "0x601225D"), Address(RVA = "0x458E3C8", Offset = "0x458E3C8", VA = "0x458E3C8")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x17003DA9")]
    public float ContainerWidthFull
    {
      [Token(Token = "0x601225E"), Address(RVA = "0x458E3D0", Offset = "0x458E3D0", VA = "0x458E3D0")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x601225F")]
    [Address(RVA = "0x458E444", Offset = "0x458E444", VA = "0x458E444")]
    public StyleThumb[] GetStyleThumb() => (StyleThumb[]) null;

    [Token(Token = "0x6012260")]
    [Address(RVA = "0x458E44C", Offset = "0x458E44C", VA = "0x458E44C", Slot = "4")]
    public override void OnUpdate()
    {
    }

    [Token(Token = "0x6012261")]
    [Address(RVA = "0x458E544", Offset = "0x458E544", VA = "0x458E544")]
    private void SetupThumbnail(ObliviaeStyleContainerColumData data)
    {
    }

    [Token(Token = "0x6012262")]
    [Address(RVA = "0x458E940", Offset = "0x458E940", VA = "0x458E940")]
    public ObliviaeStyleContainerColum()
    {
    }

    [Token(Token = "0x6012263")]
    [Address(RVA = "0x458E948", Offset = "0x458E948", VA = "0x458E948")]
    static ObliviaeStyleContainerColum()
    {
    }
  }
}
