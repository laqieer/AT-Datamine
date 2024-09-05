// Decompiled with JetBrains decompiler
// Type: ADV2.Adv2FriendshipUp
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
  [Token(Token = "0x2003E4D")]
  public class Adv2FriendshipUp : Adv2Timeline
  {
    [Token(Token = "0x4011193")]
    private const string TrackNamePattern_Line = "Line_";
    [Token(Token = "0x4011194")]
    private const string TrackNamePattern_Gauge = "Gauge_";
    [Token(Token = "0x4011195")]
    private const int TrackGroupCount = 2;
    [Token(Token = "0x4011196")]
    [FieldOffset(Offset = "0x20")]
    private Adv2FollowUI followUI;
    [Token(Token = "0x4011197")]
    [FieldOffset(Offset = "0x28")]
    private string seName;

    [Token(Token = "0x6019191")]
    [Address(RVA = "0x2974BD8", Offset = "0x2974BD8", VA = "0x2974BD8")]
    public static Adv2FriendshipUp Create(string objectName, GameObject parent)
    {
      return (Adv2FriendshipUp) null;
    }

    [Token(Token = "0x6019192")]
    [Address(RVA = "0x2974C34", Offset = "0x2974C34", VA = "0x2974C34")]
    public void AddFollowUI(GameObject addComponent, Canvas rootCanvas)
    {
    }

    [Token(Token = "0x6019193")]
    [Address(RVA = "0x2974CA4", Offset = "0x2974CA4", VA = "0x2974CA4")]
    public void SetFollowObject(Adv2Object followObject, bool updateFollowPosition)
    {
    }

    [Token(Token = "0x6019194")]
    [Address(RVA = "0x2974CC4", Offset = "0x2974CC4", VA = "0x2974CC4")]
    public void Play(int expDif)
    {
    }

    [Token(Token = "0x6019195")]
    [Address(RVA = "0x2974F28", Offset = "0x2974F28", VA = "0x2974F28")]
    private bool PrepareAsset(int expDif) => new bool();

    [Token(Token = "0x6019196")]
    [Address(RVA = "0x2975298", Offset = "0x2975298", VA = "0x2975298")]
    private AdvFriendshipUpTypeData GetTypeData(int expDif) => (AdvFriendshipUpTypeData) null;

    [Token(Token = "0x6019197")]
    [Address(RVA = "0x2975338", Offset = "0x2975338", VA = "0x2975338")]
    private void PlayOneShot(CinemachineBrain brain)
    {
    }

    [Token(Token = "0x6019198")]
    [Address(RVA = "0x29754E4", Offset = "0x29754E4", VA = "0x29754E4")]
    public Adv2FriendshipUp()
    {
    }
  }
}
