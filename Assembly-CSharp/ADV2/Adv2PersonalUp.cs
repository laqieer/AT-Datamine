// Decompiled with JetBrains decompiler
// Type: ADV2.Adv2PersonalUp
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Cinemachine;
using GameCore.MasterData;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace ADV2
{
  [Token(Token = "0x2003E4E")]
  public class Adv2PersonalUp : Adv2Timeline
  {
    [Token(Token = "0x4011198")]
    private const string TrackNamePattern_Line = "Line_";
    [Token(Token = "0x4011199")]
    private const string TrackNamePattern_Gauge = "Gauge_";
    [Token(Token = "0x401119A")]
    private const int TrackGroupCount = 2;
    [Token(Token = "0x401119B")]
    [FieldOffset(Offset = "0x20")]
    private Adv2FollowUI followUI;
    [Token(Token = "0x401119C")]
    [FieldOffset(Offset = "0x28")]
    private string seName;

    [Token(Token = "0x6019199")]
    [Address(RVA = "0x2975538", Offset = "0x2975538", VA = "0x2975538")]
    public static Adv2PersonalUp Create(string objectName, GameObject parent)
    {
      return (Adv2PersonalUp) null;
    }

    [Token(Token = "0x601919A")]
    [Address(RVA = "0x2975594", Offset = "0x2975594", VA = "0x2975594")]
    public void AddFollowUI(GameObject addComponent, Canvas rootCanvas)
    {
    }

    [Token(Token = "0x601919B")]
    [Address(RVA = "0x2975604", Offset = "0x2975604", VA = "0x2975604")]
    public void SetFollowObject(Adv2Object followObject, bool updateFollowPosition)
    {
    }

    [Token(Token = "0x601919C")]
    [Address(RVA = "0x2975624", Offset = "0x2975624", VA = "0x2975624")]
    public void Play(int expDif)
    {
    }

    [Token(Token = "0x601919D")]
    [Address(RVA = "0x2975710", Offset = "0x2975710", VA = "0x2975710")]
    private bool PrepareAsset(int expDif) => new bool();

    [Token(Token = "0x601919E")]
    [Address(RVA = "0x2975A80", Offset = "0x2975A80", VA = "0x2975A80")]
    private AdvPersonalUpTypeData GetTypeData(int expDif) => (AdvPersonalUpTypeData) null;

    [Token(Token = "0x601919F")]
    [Address(RVA = "0x2975B20", Offset = "0x2975B20", VA = "0x2975B20")]
    private void PlayOneShot(CinemachineBrain brain)
    {
    }

    [Token(Token = "0x60191A0")]
    [Address(RVA = "0x2975CCC", Offset = "0x2975CCC", VA = "0x2975CCC")]
    public Adv2PersonalUp()
    {
    }
  }
}
