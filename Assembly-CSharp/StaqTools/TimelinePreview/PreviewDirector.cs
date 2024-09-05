// Decompiled with JetBrains decompiler
// Type: StaqTools.TimelinePreview.PreviewDirector
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

#nullable disable
namespace StaqTools.TimelinePreview
{
  [Token(Token = "0x2000361")]
  public class PreviewDirector : MonoBehaviour
  {
    [Token(Token = "0x40013E7")]
    [FieldOffset(Offset = "0x18")]
    public GameObject attakActor;
    [Token(Token = "0x40013E8")]
    [FieldOffset(Offset = "0x20")]
    public GameObject attakVehicle;
    [Token(Token = "0x40013E9")]
    [FieldOffset(Offset = "0x28")]
    public GameObject defenceActor;
    [Token(Token = "0x40013EA")]
    [FieldOffset(Offset = "0x30")]
    public GameObject defenceVehicle;
    [Token(Token = "0x40013EB")]
    [FieldOffset(Offset = "0x38")]
    public GameObject StageFolder;
    [Token(Token = "0x40013EC")]
    [FieldOffset(Offset = "0x40")]
    public GameObject attackActorFolder;
    [Token(Token = "0x40013ED")]
    [FieldOffset(Offset = "0x48")]
    public GameObject defenceActorFolder;
    [Token(Token = "0x40013EE")]
    [FieldOffset(Offset = "0x50")]
    public List<string> soundPackList;
    [Token(Token = "0x40013EF")]
    [FieldOffset(Offset = "0x58")]
    public List<string> textAssetList;
    [Token(Token = "0x40013F0")]
    [FieldOffset(Offset = "0x60")]
    public GameObject advUI;
    [Token(Token = "0x40013F1")]
    [FieldOffset(Offset = "0x68")]
    private PlayableDirector playableDirector;
    [Token(Token = "0x40013F2")]
    [FieldOffset(Offset = "0x70")]
    private readonly string[] SOUNDPACKNAMES;
    [Token(Token = "0x40013F3")]
    [FieldOffset(Offset = "0x78")]
    private GameObject[] rootGameObjects;

    [Token(Token = "0x6001367")]
    [Address(RVA = "0x2869544", Offset = "0x2869544", VA = "0x2869544")]
    private void Start()
    {
    }

    [Token(Token = "0x6001368")]
    [Address(RVA = "0x286A4D0", Offset = "0x286A4D0", VA = "0x286A4D0")]
    public void SetupMode(PreviewDirector.Mode mode)
    {
    }

    [Token(Token = "0x6001369")]
    [Address(RVA = "0x286A4F4", Offset = "0x286A4F4", VA = "0x286A4F4")]
    public void EntrySceneAttackActor(GameObject actor, GameObject vehicle)
    {
    }

    [Token(Token = "0x600136A")]
    [Address(RVA = "0x286A8E4", Offset = "0x286A8E4", VA = "0x286A8E4")]
    public void EntrySceneDefenceActor(GameObject actor, GameObject vehicle)
    {
    }

    [Token(Token = "0x600136B")]
    [Address(RVA = "0x286ACD4", Offset = "0x286ACD4", VA = "0x286ACD4")]
    public void SetSound(List<string> list, int count)
    {
    }

    [Token(Token = "0x600136C")]
    [Address(RVA = "0x286A468", Offset = "0x286A468", VA = "0x286A468")]
    private IEnumerator SetupAsync() => (IEnumerator) null;

    [Token(Token = "0x600136D")]
    [Address(RVA = "0x28697C8", Offset = "0x28697C8", VA = "0x28697C8")]
    private void SetupAttacker(PlayableDirector playableDirector, GameObject actor)
    {
    }

    [Token(Token = "0x600136E")]
    [Address(RVA = "0x2869CFC", Offset = "0x2869CFC", VA = "0x2869CFC")]
    private void SetupDefender(PlayableDirector playableDirector, GameObject actor)
    {
    }

    [Token(Token = "0x600136F")]
    [Address(RVA = "0x2869FB8", Offset = "0x2869FB8", VA = "0x2869FB8")]
    private void SetupStage()
    {
    }

    [Token(Token = "0x6001370")]
    [Address(RVA = "0x286AE64", Offset = "0x286AE64", VA = "0x286AE64")]
    public PreviewDirector()
    {
    }

    [Token(Token = "0x2000362")]
    public enum Mode
    {
      [Token(Token = "0x40013F5")] ADV,
      [Token(Token = "0x40013F6")] SingleSkill,
      [Token(Token = "0x40013F7")] CommonSkill,
    }
  }
}
