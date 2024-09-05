// Decompiled with JetBrains decompiler
// Type: GameCore.Scene.SubScene
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GlobalBackground;
using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace GameCore.Scene
{
  [Token(Token = "0x2000C83")]
  public class SubScene : SceneBase
  {
    [Token(Token = "0x400388A")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private string backGroundImageAssetName;
    [Token(Token = "0x400388B")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private string backGroundImageName;
    [Token(Token = "0x400388C")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private string bgmName;
    [Token(Token = "0x400388D")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private bool isWaitInitializeAsync;
    [Token(Token = "0x400388E")]
    [FieldOffset(Offset = "0x41")]
    [SerializeField]
    private bool isSceneResumeBGM;
    [Token(Token = "0x400388F")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    private SetupType setupBackGround;
    [Token(Token = "0x4003890")]
    [FieldOffset(Offset = "0x48")]
    private GameObject backgroundImage;
    [Token(Token = "0x4003891")]
    [FieldOffset(Offset = "0x50")]
    private List<string> playingBGMList;

    [Token(Token = "0x17000A7E")]
    public bool IsWaitInitializeAsync
    {
      [Token(Token = "0x6004828"), Address(RVA = "0x313095C", Offset = "0x313095C", VA = "0x313095C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6004829")]
    [Address(RVA = "0x3130964", Offset = "0x3130964", VA = "0x3130964", Slot = "21")]
    public virtual IEnumerator EnableEffect() => (IEnumerator) null;

    [Token(Token = "0x600482A")]
    [Address(RVA = "0x31309EC", Offset = "0x31309EC", VA = "0x31309EC", Slot = "22")]
    public virtual IEnumerator DisableEffect() => (IEnumerator) null;

    [Token(Token = "0x600482B")]
    [Address(RVA = "0x3130A74", Offset = "0x3130A74", VA = "0x3130A74", Slot = "23")]
    public virtual void FinishInitialize(ChangeSceneParameter param)
    {
    }

    [Token(Token = "0x600482C")]
    [Address(RVA = "0x3130B08", Offset = "0x3130B08", VA = "0x3130B08", Slot = "24")]
    public virtual void OnBeforeBackScene()
    {
    }

    [Token(Token = "0x600482D")]
    [Address(RVA = "0x3130B0C", Offset = "0x3130B0C", VA = "0x3130B0C", Slot = "25")]
    public virtual void OnBackScene()
    {
    }

    [Token(Token = "0x600482E")]
    [Address(RVA = "0x3130B10", Offset = "0x3130B10", VA = "0x3130B10", Slot = "26")]
    public virtual IEnumerator OnBackSceneAsync() => (IEnumerator) null;

    [Token(Token = "0x600482F")]
    [Address(RVA = "0x3130B98", Offset = "0x3130B98", VA = "0x3130B98", Slot = "27")]
    public virtual void OnNextScene()
    {
    }

    [Token(Token = "0x6004830")]
    [Address(RVA = "0x3130B9C", Offset = "0x3130B9C", VA = "0x3130B9C", Slot = "28")]
    public virtual IEnumerator OnNextSceneAsync() => (IEnumerator) null;

    [Token(Token = "0x6004831")]
    [Address(RVA = "0x3130C24", Offset = "0x3130C24", VA = "0x3130C24", Slot = "29")]
    public virtual void OnExitScene()
    {
    }

    [Token(Token = "0x6004832")]
    [Address(RVA = "0x3130C28", Offset = "0x3130C28", VA = "0x3130C28")]
    public IEnumerator StartEnableEffect(Action completeAction) => (IEnumerator) null;

    [Token(Token = "0x6004833")]
    [Address(RVA = "0x3130CC4", Offset = "0x3130CC4", VA = "0x3130CC4")]
    public IEnumerator StartDisableEffect(Action completeAction) => (IEnumerator) null;

    [Token(Token = "0x6004834")]
    [Address(RVA = "0x3130D60", Offset = "0x3130D60", VA = "0x3130D60", Slot = "20")]
    public override void BackKeyDownAction()
    {
    }

    [Token(Token = "0x6004835")]
    [Address(RVA = "0x3130F44", Offset = "0x3130F44", VA = "0x3130F44", Slot = "30")]
    protected virtual void BackKeyDownActionInSubScene()
    {
    }

    [Token(Token = "0x6004836")]
    [Address(RVA = "0x3130F4C", Offset = "0x3130F4C", VA = "0x3130F4C")]
    public void SuspendBGM()
    {
    }

    [Token(Token = "0x6004837")]
    [Address(RVA = "0x3130FD8", Offset = "0x3130FD8", VA = "0x3130FD8")]
    public void ResumeBGM()
    {
    }

    [Token(Token = "0x6004838")]
    [Address(RVA = "0x3131178", Offset = "0x3131178", VA = "0x3131178")]
    public void SetupBackGround(bool isBack, SetupType? reset = null)
    {
    }

    [Token(Token = "0x6004839")]
    [Address(RVA = "0x31312C0", Offset = "0x31312C0", VA = "0x31312C0", Slot = "31")]
    protected virtual void CustomizeBackGround(bool isBack)
    {
    }

    [Token(Token = "0x600483A")]
    [Address(RVA = "0x31312C4", Offset = "0x31312C4", VA = "0x31312C4")]
    public SubScene()
    {
    }
  }
}
