// Decompiled with JetBrains decompiler
// Type: ADV2.Adv2AnimationLipSync
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Dicing;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace ADV2
{
  [Token(Token = "0x2003E07")]
  [RequireComponent(typeof (Adv2LinkageAnimation))]
  [ExecuteAlways]
  public class Adv2AnimationLipSync : MonoBehaviour
  {
    [Token(Token = "0x4011007")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    protected Adv2LinkageAnimation targetComponent;
    [Token(Token = "0x4011008")]
    [FieldOffset(Offset = "0x20")]
    public Action RequestAction;
    [Token(Token = "0x4011009")]
    [FieldOffset(Offset = "0x28")]
    public Action RequestActionCloseMouth;
    [Token(Token = "0x401100A")]
    [FieldOffset(Offset = "0x30")]
    public Action RequestActionOpenMouth;
    [Token(Token = "0x401100B")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    protected string linkTag;
    [Token(Token = "0x401100C")]
    [FieldOffset(Offset = "0x40")]
    protected HashSet<char> noLipSyncTexts;
    [Token(Token = "0x401100D")]
    [FieldOffset(Offset = "0x48")]
    public Adv2AnimationLipSync.Mode PlayMode;
    [Token(Token = "0x401100E")]
    [FieldOffset(Offset = "0x4C")]
    private Adv2AnimationLipSync.ForceMode forcePlayMode;
    [Token(Token = "0x401100F")]
    [FieldOffset(Offset = "0x50")]
    protected string playingClipTag;
    [Token(Token = "0x4011010")]
    [FieldOffset(Offset = "0x58")]
    protected string playingAnimationTag;
    [Token(Token = "0x4011011")]
    [FieldOffset(Offset = "0x60")]
    protected Adv2Manager.OnProccessSignal signal;
    [Token(Token = "0x4011012")]
    [FieldOffset(Offset = "0x68")]
    public CharaImage charaImage;
    [Token(Token = "0x4011013")]
    [FieldOffset(Offset = "0x70")]
    public float transitionTime;
    [Token(Token = "0x4011014")]
    [FieldOffset(Offset = "0x74")]
    private Adv2AnimationLipSync.Mode dicingMode;
    [Token(Token = "0x4011015")]
    [FieldOffset(Offset = "0x78")]
    private float dicingStartTime;
    [Token(Token = "0x4011016")]
    [FieldOffset(Offset = "0x7C")]
    private bool isActiveLipSync;
    [Token(Token = "0x4011017")]
    [FieldOffset(Offset = "0x80")]
    private int[] lipPatternTable;
    [Token(Token = "0x4011018")]
    private const int lipPatternMin = 1;
    [Token(Token = "0x4011019")]
    private const int lipPatternMax = 4;
    [Token(Token = "0x401101A")]
    [FieldOffset(Offset = "0x88")]
    private int lastLipPattern;
    [Token(Token = "0x401101B")]
    [FieldOffset(Offset = "0x90")]
    private string lipSyncText;
    [Token(Token = "0x401101C")]
    [FieldOffset(Offset = "0x98")]
    private float lipSyncTime;
    [Token(Token = "0x401101D")]
    [FieldOffset(Offset = "0x9C")]
    private float lipSyncMaxTime;
    [Token(Token = "0x401101E")]
    [FieldOffset(Offset = "0xA0")]
    private float lipCloseDuration;

    [Token(Token = "0x6018F57")]
    [Address(RVA = "0x2CB5440", Offset = "0x2CB5440", VA = "0x2CB5440")]
    public void SetIsActiveLipSync(bool flag)
    {
    }

    [Token(Token = "0x6018F58")]
    [Address(RVA = "0x2CB5598", Offset = "0x2CB5598", VA = "0x2CB5598")]
    public static Adv2AnimationLipSync AddComponent(
      Adv2LinkageAnimation target,
      string linkageTag,
      HashSet<char> noLipSyncTexts)
    {
      return (Adv2AnimationLipSync) null;
    }

    [Token(Token = "0x6018F59")]
    [Address(RVA = "0x2CB5698", Offset = "0x2CB5698", VA = "0x2CB5698")]
    public void SetLipSyncText(string text, float time)
    {
    }

    [Token(Token = "0x6018F5A")]
    [Address(RVA = "0x2CB56A4", Offset = "0x2CB56A4", VA = "0x2CB56A4")]
    public void ForceLipSync(string syncTag)
    {
    }

    [Token(Token = "0x6018F5B")]
    [Address(RVA = "0x2CB5A3C", Offset = "0x2CB5A3C", VA = "0x2CB5A3C")]
    private void DicingImageControl()
    {
    }

    [Token(Token = "0x6018F5C")]
    [Address(RVA = "0x2CB57B0", Offset = "0x2CB57B0", VA = "0x2CB57B0")]
    private void CloseLip(int number)
    {
    }

    [Token(Token = "0x6018F5D")]
    [Address(RVA = "0x2CB5460", Offset = "0x2CB5460", VA = "0x2CB5460")]
    private void CloseLip()
    {
    }

    [Token(Token = "0x6018F5E")]
    [Address(RVA = "0x2CB5B84", Offset = "0x2CB5B84", VA = "0x2CB5B84")]
    private void PatternLipSync(int number)
    {
    }

    [Token(Token = "0x6018F5F")]
    [Address(RVA = "0x2CB58E0", Offset = "0x2CB58E0", VA = "0x2CB58E0")]
    private void OpenLip(int number)
    {
    }

    [Token(Token = "0x6018F60")]
    [Address(RVA = "0x2CB5C58", Offset = "0x2CB5C58", VA = "0x2CB5C58")]
    private int randomLipPattern() => new int();

    [Token(Token = "0x6018F61")]
    [Address(RVA = "0x2CB5CE8", Offset = "0x2CB5CE8", VA = "0x2CB5CE8")]
    private void TalkLip()
    {
    }

    [Token(Token = "0x6018F62")]
    [Address(RVA = "0x2CB5D60", Offset = "0x2CB5D60", VA = "0x2CB5D60")]
    public void InitializeNoLipSyncText(HashSet<char> noLipSyncTexts)
    {
    }

    [Token(Token = "0x6018F63")]
    [Address(RVA = "0x2CB5D68", Offset = "0x2CB5D68", VA = "0x2CB5D68")]
    private bool SilenceLipSync() => new bool();

    [Token(Token = "0x6018F64")]
    [Address(RVA = "0x2CB5EA8", Offset = "0x2CB5EA8", VA = "0x2CB5EA8")]
    private void Update()
    {
    }

    [Token(Token = "0x6018F65")]
    [Address(RVA = "0x2CB5EEC", Offset = "0x2CB5EEC", VA = "0x2CB5EEC")]
    public Adv2AnimationLipSync()
    {
    }

    [Token(Token = "0x2003E08")]
    public enum Mode
    {
      [Token(Token = "0x4011020")] Close,
      [Token(Token = "0x4011021")] Open,
      [Token(Token = "0x4011022")] Talk,
    }

    [Token(Token = "0x2003E09")]
    private enum ForceMode
    {
      [Token(Token = "0x4011024")] Close1,
      [Token(Token = "0x4011025")] Close2,
      [Token(Token = "0x4011026")] Open1,
      [Token(Token = "0x4011027")] Open2,
      [Token(Token = "0x4011028")] Auto,
    }
  }
}
