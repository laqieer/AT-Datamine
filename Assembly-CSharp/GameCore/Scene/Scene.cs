// Decompiled with JetBrains decompiler
// Type: GameCore.Scene.Scene
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.UIControls;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace GameCore.Scene
{
  [Token(Token = "0x2000C59")]
  public class Scene : SceneBase
  {
    [Token(Token = "0x40037C2")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Camera mainCamera;
    [Token(Token = "0x40037C3")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private GameObject subScene;
    [Token(Token = "0x40037C4")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Canvas mainCanvas;
    [Token(Token = "0x40037C5")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private GameObject subSceneBackground;
    [Token(Token = "0x40037C6")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private UISafeAreaInsets safeAreaInsets;
    [Token(Token = "0x40037C7")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private GameObject popup;

    [Token(Token = "0x17000A3B")]
    public Camera MainCamera
    {
      [Token(Token = "0x60046FA"), Address(RVA = "0x351D08C", Offset = "0x351D08C", VA = "0x351D08C")] get
      {
        return (Camera) null;
      }
      [Token(Token = "0x60046FB"), Address(RVA = "0x351D094", Offset = "0x351D094", VA = "0x351D094")] set
      {
      }
    }

    [Token(Token = "0x17000A3C")]
    public Canvas MainCanvas
    {
      [Token(Token = "0x60046FC"), Address(RVA = "0x351D09C", Offset = "0x351D09C", VA = "0x351D09C")] get
      {
        return (Canvas) null;
      }
      [Token(Token = "0x60046FD"), Address(RVA = "0x351D0A4", Offset = "0x351D0A4", VA = "0x351D0A4")] set
      {
      }
    }

    [Token(Token = "0x17000A3D")]
    public GameObject SubScene
    {
      [Token(Token = "0x60046FE"), Address(RVA = "0x351D0AC", Offset = "0x351D0AC", VA = "0x351D0AC")] get
      {
        return (GameObject) null;
      }
      [Token(Token = "0x60046FF"), Address(RVA = "0x351D0B4", Offset = "0x351D0B4", VA = "0x351D0B4")] set
      {
      }
    }

    [Token(Token = "0x17000A3E")]
    public GameObject SubSceneBackground
    {
      [Token(Token = "0x6004700"), Address(RVA = "0x351D0BC", Offset = "0x351D0BC", VA = "0x351D0BC")] get
      {
        return (GameObject) null;
      }
      [Token(Token = "0x6004701"), Address(RVA = "0x351D0C4", Offset = "0x351D0C4", VA = "0x351D0C4")] set
      {
      }
    }

    [Token(Token = "0x17000A3F")]
    public UISafeAreaInsets SafeAreaInsets
    {
      [Token(Token = "0x6004702"), Address(RVA = "0x351D0CC", Offset = "0x351D0CC", VA = "0x351D0CC")] get
      {
        return (UISafeAreaInsets) null;
      }
      [Token(Token = "0x6004703"), Address(RVA = "0x351D0D4", Offset = "0x351D0D4", VA = "0x351D0D4")] set
      {
      }
    }

    [Token(Token = "0x17000A40")]
    public GameObject Popup
    {
      [Token(Token = "0x6004704"), Address(RVA = "0x351D0DC", Offset = "0x351D0DC", VA = "0x351D0DC")] get
      {
        return (GameObject) null;
      }
      [Token(Token = "0x6004705"), Address(RVA = "0x351D0E4", Offset = "0x351D0E4", VA = "0x351D0E4")] set
      {
      }
    }

    [Token(Token = "0x6004706")]
    [Address(RVA = "0x351D0EC", Offset = "0x351D0EC", VA = "0x351D0EC")]
    private void Start()
    {
    }

    [Token(Token = "0x6004707")]
    [Address(RVA = "0x351D110", Offset = "0x351D110", VA = "0x351D110")]
    public void SafeAreaCalculateChilds()
    {
    }

    [Token(Token = "0x6004708")]
    [Address(RVA = "0x351D454", Offset = "0x351D454", VA = "0x351D454", Slot = "21")]
    public virtual void StartUp()
    {
    }

    [Token(Token = "0x6004709")]
    [Address(RVA = "0x351D458", Offset = "0x351D458", VA = "0x351D458", Slot = "22")]
    protected virtual void Update()
    {
    }

    [Token(Token = "0x600470A")]
    [Address(RVA = "0x351D5D4", Offset = "0x351D5D4", VA = "0x351D5D4")]
    private bool IsEnableBackKey() => new bool();

    [Token(Token = "0x600470B")]
    [Address(RVA = "0x351D73C", Offset = "0x351D73C", VA = "0x351D73C")]
    public Scene()
    {
    }
  }
}
