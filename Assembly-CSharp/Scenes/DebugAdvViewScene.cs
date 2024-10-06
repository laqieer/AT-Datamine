// Decompiled with JetBrains decompiler
// Type: Scenes.DebugAdvViewScene
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using ADV2;
using GameCore.Scene;
using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Scenes
{
  [Token(Token = "0x200287E")]
  internal class DebugAdvViewScene : GameCore.Scene.Scene
  {
    [Token(Token = "0x400ACA6")]
    private const int fontSize = 64;
    [Token(Token = "0x400ACA7")]
    [FieldOffset(Offset = "0x58")]
    protected DebugAdvViewScene.EventNamePath RootPath;
    [Token(Token = "0x400ACA8")]
    [FieldOffset(Offset = "0x60")]
    protected DebugAdvViewScene.EventNamePath SelectPath;
    [Token(Token = "0x400ACA9")]
    [FieldOffset(Offset = "0x68")]
    protected Rect variableViewRect;
    [Token(Token = "0x400ACAA")]
    [FieldOffset(Offset = "0x78")]
    protected Rect variableScreenRect;
    [Token(Token = "0x400ACAB")]
    [FieldOffset(Offset = "0x88")]
    protected Vector2 variablePosition;
    [Token(Token = "0x400ACAC")]
    [FieldOffset(Offset = "0x90")]
    protected Rect eventViewRect;
    [Token(Token = "0x400ACAD")]
    [FieldOffset(Offset = "0xA0")]
    protected Rect eventScreenRect;
    [Token(Token = "0x400ACAE")]
    [FieldOffset(Offset = "0xB0")]
    protected Vector2 eventPosition;
    [Token(Token = "0x400ACAF")]
    [FieldOffset(Offset = "0xB8")]
    protected float lineHeight;
    [Token(Token = "0x400ACB0")]
    [FieldOffset(Offset = "0xC0")]
    protected GUIStyle styleButton;
    [Token(Token = "0x400ACB1")]
    [FieldOffset(Offset = "0xC8")]
    protected Adv2Manager.OnProccessSignal signalAdv;
    [Token(Token = "0x400ACB2")]
    [FieldOffset(Offset = "0xD0")]
    protected string loadingAssetbundleName;
    [Token(Token = "0x400ACB3")]
    [FieldOffset(Offset = "0xD8")]
    protected string loadingFileName;

    [Token(Token = "0x600FF22")]
    [Address(RVA = "0x40F5608", Offset = "0x40F5608", VA = "0x40F5608", Slot = "6")]
    public override void Initialize(ChangeSceneParameter param = null)
    {
    }

    [Token(Token = "0x600FF23")]
    [Address(RVA = "0x40F5EC4", Offset = "0x40F5EC4", VA = "0x40F5EC4")]
    private void OnGUI()
    {
    }

    [Token(Token = "0x600FF24")]
    [Address(RVA = "0x40F5E58", Offset = "0x40F5E58", VA = "0x40F5E58")]
    private void SetSelectPath(DebugAdvViewScene.EventNamePath newPath)
    {
    }

    [Token(Token = "0x600FF25")]
    [Address(RVA = "0x40F69FC", Offset = "0x40F69FC", VA = "0x40F69FC")]
    private bool GuiButton(Rect viewRect, string text) => new bool();

    [Token(Token = "0x600FF26")]
    [Address(RVA = "0x40F6CF0", Offset = "0x40F6CF0", VA = "0x40F6CF0")]
    public DebugAdvViewScene()
    {
    }

    [Token(Token = "0x200287F")]
    public class EventNamePath
    {
      [Token(Token = "0x400ACB4")]
      [FieldOffset(Offset = "0x10")]
      public Dictionary<string, DebugAdvViewScene.EventNamePath> Child;
      [Token(Token = "0x400ACB5")]
      [FieldOffset(Offset = "0x18")]
      public DebugAdvViewScene.EventNamePath Parent;
      [Token(Token = "0x400ACB6")]
      [FieldOffset(Offset = "0x20")]
      public Dictionary<int, string> EventNameDictionary;

      [Token(Token = "0x600FF27")]
      [Address(RVA = "0x40F5A9C", Offset = "0x40F5A9C", VA = "0x40F5A9C")]
      public void SetEventPath(string eventPath, int id)
      {
      }

      [Token(Token = "0x1700381F")]
      public int MenuLength
      {
        [Token(Token = "0x600FF28"), Address(RVA = "0x40F6C60", Offset = "0x40F6C60", VA = "0x40F6C60")] get
        {
          return new int();
        }
      }

      [Token(Token = "0x600FF29")]
      [Address(RVA = "0x40F6DEC", Offset = "0x40F6DEC", VA = "0x40F6DEC")]
      public EventNamePath()
      {
      }
    }
  }
}
