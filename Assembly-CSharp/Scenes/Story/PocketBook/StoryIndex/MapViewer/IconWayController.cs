// Decompiled with JetBrains decompiler
// Type: Scenes.Story.PocketBook.StoryIndex.MapViewer.IconWayController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Scenes.Story.PocketBook.StoryIndex.Map.UI;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Scenes.Story.PocketBook.StoryIndex.MapViewer
{
  [Token(Token = "0x2002E20")]
  public class IconWayController
  {
    [Token(Token = "0x400C5ED")]
    [FieldOffset(Offset = "0x10")]
    private readonly List<MapActionIcon> icons;
    [Token(Token = "0x400C5EE")]
    [FieldOffset(Offset = "0x18")]
    private readonly IconWayController.WayPoint CenterUpWayPoint;
    [Token(Token = "0x400C5EF")]
    [FieldOffset(Offset = "0x28")]
    private readonly IconWayController.WayPoint RightUpWayPoint;
    [Token(Token = "0x400C5F0")]
    [FieldOffset(Offset = "0x38")]
    private readonly IconWayController.WayPoint LeftUpWayPoint;
    [Token(Token = "0x400C5F1")]
    [FieldOffset(Offset = "0x48")]
    private readonly IconWayController.WayPoint RightDownWayPoint;
    [Token(Token = "0x400C5F2")]
    [FieldOffset(Offset = "0x58")]
    private readonly IconWayController.WayPoint LeftDownWayPoint;

    [Token(Token = "0x6012047")]
    [Address(RVA = "0x437A898", Offset = "0x437A898", VA = "0x437A898")]
    public void Register(MapActionIcon actionIcon)
    {
    }

    [Token(Token = "0x6012048")]
    [Address(RVA = "0x437BC08", Offset = "0x437BC08", VA = "0x437BC08")]
    public IconWayController.WayPoint GetWayPoint(int index) => new IconWayController.WayPoint();

    [Token(Token = "0x6012049")]
    [Address(RVA = "0x437BA74", Offset = "0x437BA74", VA = "0x437BA74")]
    public void Rotation()
    {
    }

    [Token(Token = "0x601204A")]
    [Address(RVA = "0x437A284", Offset = "0x437A284", VA = "0x437A284")]
    public IconWayController()
    {
    }

    [Token(Token = "0x2002E21")]
    public struct WayPoint
    {
      [Token(Token = "0x17003D60")]
      public Vector2 Pivot
      {
        [Token(Token = "0x601204B"), Address(RVA = "0x437BD2C", Offset = "0x437BD2C", VA = "0x437BD2C")] readonly get
        {
          return new Vector2();
        }
        [Token(Token = "0x601204C"), Address(RVA = "0x437BD34", Offset = "0x437BD34", VA = "0x437BD34")] set
        {
        }
      }

      [Token(Token = "0x17003D61")]
      public string TweenRotationKey
      {
        [Token(Token = "0x601204D"), Address(RVA = "0x437BD3C", Offset = "0x437BD3C", VA = "0x437BD3C")] readonly get
        {
          return (string) null;
        }
        [Token(Token = "0x601204E"), Address(RVA = "0x437BD44", Offset = "0x437BD44", VA = "0x437BD44")] set
        {
        }
      }
    }
  }
}
