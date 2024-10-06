// Decompiled with JetBrains decompiler
// Type: GameCore.Scene.SceneBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Input;
using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace GameCore.Scene
{
  [Token(Token = "0x2000C5D")]
  public class SceneBase : MonoBehaviour
  {
    [Token(Token = "0x40037D3")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    protected string transitionInEffectName;
    [Token(Token = "0x40037D4")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    protected string transitionOutEffectName;

    [Token(Token = "0x17000A41")]
    public string TransitionInEffectName
    {
      [Token(Token = "0x600470E"), Address(RVA = "0x351D9B4", Offset = "0x351D9B4", VA = "0x351D9B4")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000A42")]
    public string TransitionOutEffectName
    {
      [Token(Token = "0x600470F"), Address(RVA = "0x351D9BC", Offset = "0x351D9BC", VA = "0x351D9BC")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000A43")]
    public bool IsTransitionInEffectName
    {
      [Token(Token = "0x6004710"), Address(RVA = "0x351D9C4", Offset = "0x351D9C4", VA = "0x351D9C4")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000A44")]
    public bool IsTransitionOutEffectName
    {
      [Token(Token = "0x6004711"), Address(RVA = "0x351D9E4", Offset = "0x351D9E4", VA = "0x351D9E4")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6004712")]
    [Address(RVA = "0x351DA04", Offset = "0x351DA04", VA = "0x351DA04", Slot = "4")]
    public virtual void OnPause()
    {
    }

    [Token(Token = "0x6004713")]
    [Address(RVA = "0x351DA08", Offset = "0x351DA08", VA = "0x351DA08", Slot = "5")]
    public virtual void OnResume()
    {
    }

    [Token(Token = "0x6004714")]
    [Address(RVA = "0x351DA0C", Offset = "0x351DA0C", VA = "0x351DA0C", Slot = "6")]
    public virtual void Initialize(ChangeSceneParameter param = null)
    {
    }

    [Token(Token = "0x6004715")]
    [Address(RVA = "0x351DA10", Offset = "0x351DA10", VA = "0x351DA10", Slot = "7")]
    public virtual IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x6004716")]
    [Address(RVA = "0x351DA98", Offset = "0x351DA98", VA = "0x351DA98", Slot = "8")]
    public virtual void Disable()
    {
    }

    [Token(Token = "0x6004717")]
    [Address(RVA = "0x351DA9C", Offset = "0x351DA9C", VA = "0x351DA9C", Slot = "9")]
    public virtual void Destroy()
    {
    }

    [Token(Token = "0x6004718")]
    [Address(RVA = "0x351DAA0", Offset = "0x351DAA0", VA = "0x351DAA0", Slot = "10")]
    public virtual bool FlickAction(GameCore.Input.Input.Direction direction) => new bool();

    [Token(Token = "0x6004719")]
    [Address(RVA = "0x351DAA8", Offset = "0x351DAA8", VA = "0x351DAA8", Slot = "11")]
    public virtual bool ReleaseAction(Vector2 position, GameObject gameObject) => new bool();

    [Token(Token = "0x600471A")]
    [Address(RVA = "0x351DAB0", Offset = "0x351DAB0", VA = "0x351DAB0", Slot = "12")]
    public virtual bool LongPressStartAction(GameObject gameObject) => new bool();

    [Token(Token = "0x600471B")]
    [Address(RVA = "0x351DAB8", Offset = "0x351DAB8", VA = "0x351DAB8", Slot = "13")]
    public virtual bool LongPressAction(GameObject gameObject) => new bool();

    [Token(Token = "0x600471C")]
    [Address(RVA = "0x351DAC0", Offset = "0x351DAC0", VA = "0x351DAC0", Slot = "14")]
    public virtual bool DragStartAction(Vector2 position, Vector2 delta) => new bool();

    [Token(Token = "0x600471D")]
    [Address(RVA = "0x351DAC8", Offset = "0x351DAC8", VA = "0x351DAC8", Slot = "15")]
    public virtual bool DragAction(Vector2 position, Vector2 delta) => new bool();

    [Token(Token = "0x600471E")]
    [Address(RVA = "0x351DAD0", Offset = "0x351DAD0", VA = "0x351DAD0", Slot = "16")]
    public virtual bool DragEndAction(Vector2 position, Vector2 delta, GameObject gameObject)
    {
      return new bool();
    }

    [Token(Token = "0x600471F")]
    [Address(RVA = "0x351DAD8", Offset = "0x351DAD8", VA = "0x351DAD8", Slot = "17")]
    public virtual bool PinchAction(PinchEventData pinchEventData) => new bool();

    [Token(Token = "0x6004720")]
    [Address(RVA = "0x351DAE0", Offset = "0x351DAE0", VA = "0x351DAE0", Slot = "18")]
    public virtual bool DoubleDragAction(Vector2 position, Vector2 delta) => new bool();

    [Token(Token = "0x6004721")]
    [Address(RVA = "0x351DAE8", Offset = "0x351DAE8", VA = "0x351DAE8", Slot = "19")]
    public virtual bool DoubleTouchReleaseAction(Vector2 center) => new bool();

    [Token(Token = "0x6004722")]
    [Address(RVA = "0x351DAF0", Offset = "0x351DAF0", VA = "0x351DAF0", Slot = "20")]
    public virtual void BackKeyDownAction()
    {
    }

    [Token(Token = "0x6004723")]
    public bool DownCast<T>(ChangeSceneParameter changeSceneParameter, out T derivedParameter) where T : ChangeSceneParameter
    {
      return new bool();
    }

    [Token(Token = "0x6004724")]
    [Address(RVA = "0x351DC6C", Offset = "0x351DC6C", VA = "0x351DC6C")]
    public void CommonBackKeyAction()
    {
    }

    [Token(Token = "0x6004725")]
    [Address(RVA = "0x351D744", Offset = "0x351D744", VA = "0x351D744")]
    public SceneBase()
    {
    }
  }
}
