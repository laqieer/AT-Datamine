// Decompiled with JetBrains decompiler
// Type: Scenes.NativeMovie.DebugNativeMovieViewScene
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Scenes.NativeMovie
{
  [Token(Token = "0x2002A71")]
  public class DebugNativeMovieViewScene : GameCore.Scene.Scene
  {
    [Token(Token = "0x400B4A0")]
    private const string GUI_ON = "GUI: ON";
    [Token(Token = "0x400B4A1")]
    private const string GUI_OFF = "GUI: OFF";
    [Token(Token = "0x400B4A2")]
    private const string RETURN = "Return";
    [Token(Token = "0x400B4A3")]
    [FieldOffset(Offset = "0x58")]
    private int[] fpsList;
    [Token(Token = "0x400B4A4")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private List<DebugNativeMovieViewScene.NativeMovieItem> nativeMovieItems;
    [Token(Token = "0x400B4A5")]
    [FieldOffset(Offset = "0x68")]
    private bool showAllGUI;
    [Token(Token = "0x400B4A6")]
    [FieldOffset(Offset = "0x69")]
    private bool showGUI;
    [Token(Token = "0x400B4A7")]
    private const float standardScreenWidth = 512f;
    [Token(Token = "0x400B4A8")]
    private const float standardScreenheight = 911f;
    [Token(Token = "0x400B4A9")]
    [FieldOffset(Offset = "0x6C")]
    private int buttonHeight;
    [Token(Token = "0x400B4AA")]
    [FieldOffset(Offset = "0x70")]
    private int buttonWidth;
    [Token(Token = "0x400B4AB")]
    [FieldOffset(Offset = "0x74")]
    private int startOffsetX;
    [Token(Token = "0x400B4AC")]
    [FieldOffset(Offset = "0x78")]
    private int startOffsetY;
    [Token(Token = "0x400B4AD")]
    [FieldOffset(Offset = "0x7C")]
    private int marginYTop;
    [Token(Token = "0x400B4AE")]
    [FieldOffset(Offset = "0x80")]
    private int fontSize;
    [Token(Token = "0x400B4AF")]
    [FieldOffset(Offset = "0x88")]
    private GUIStyle customButton;
    [Token(Token = "0x400B4B0")]
    [FieldOffset(Offset = "0x90")]
    private string displayingNativeMovie;
    [Token(Token = "0x400B4B1")]
    [FieldOffset(Offset = "0x98")]
    private bool isLoading;
    [Token(Token = "0x400B4B2")]
    [FieldOffset(Offset = "0x9C")]
    private float maxRotationRateY;
    [Token(Token = "0x400B4B3")]
    [FieldOffset(Offset = "0xA0")]
    private float lastSwitchGUITime;
    [Token(Token = "0x400B4B4")]
    [FieldOffset(Offset = "0xA4")]
    private float minSwitchTimeInterval;

    [Token(Token = "0x60109DD")]
    [Address(RVA = "0x4C33708", Offset = "0x4C33708", VA = "0x4C33708")]
    private void Start()
    {
    }

    [Token(Token = "0x60109DE")]
    [Address(RVA = "0x4C33808", Offset = "0x4C33808", VA = "0x4C33808")]
    private new void Update()
    {
    }

    [Token(Token = "0x60109DF")]
    [Address(RVA = "0x4C3387C", Offset = "0x4C3387C", VA = "0x4C3387C")]
    private void OnGUI()
    {
    }

    [Token(Token = "0x60109E0")]
    [Address(RVA = "0x4C33E44", Offset = "0x4C33E44", VA = "0x4C33E44")]
    private IEnumerator LoadNativeMovie(string sceneName) => (IEnumerator) null;

    [Token(Token = "0x60109E1")]
    [Address(RVA = "0x4C33EE0", Offset = "0x4C33EE0", VA = "0x4C33EE0")]
    public DebugNativeMovieViewScene()
    {
    }

    [Token(Token = "0x2002A72")]
    [Serializable]
    private class NativeMovieItem
    {
      [Token(Token = "0x400B4B5")]
      [FieldOffset(Offset = "0x10")]
      public string sceneName;
      [Token(Token = "0x400B4B6")]
      [FieldOffset(Offset = "0x18")]
      public string itemName;

      [Token(Token = "0x60109E2")]
      [Address(RVA = "0x4C33FB8", Offset = "0x4C33FB8", VA = "0x4C33FB8")]
      public NativeMovieItem(string sceneName, string itemName)
      {
      }
    }
  }
}
