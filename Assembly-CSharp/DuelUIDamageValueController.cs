// Decompiled with JetBrains decompiler
// Type: DuelUIDamageValueController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UI;

#nullable disable
[Token(Token = "0x2000184")]
public class DuelUIDamageValueController : MonoBehaviour
{
  [Token(Token = "0x40009F1")]
  [FieldOffset(Offset = "0x18")]
  [SerializeField]
  private List<Image> damageDigitImages;
  [Token(Token = "0x40009F2")]
  [FieldOffset(Offset = "0x20")]
  [SerializeField]
  private List<Image> criticalDamageDigitImages;
  [Token(Token = "0x40009F3")]
  [FieldOffset(Offset = "0x28")]
  [SerializeField]
  private List<Image> cutDamageDigitImages;
  [Token(Token = "0x40009F4")]
  [FieldOffset(Offset = "0x30")]
  [SerializeField]
  private PlayableDirector playableDirector;
  [Token(Token = "0x40009F5")]
  [FieldOffset(Offset = "0x38")]
  [SerializeField]
  private RectTransform rectTransform;
  [Token(Token = "0x40009F6")]
  [FieldOffset(Offset = "0x40")]
  [SerializeField]
  private List<Sprite> HPDigisSpriteList;
  [Token(Token = "0x40009F7")]
  [FieldOffset(Offset = "0x48")]
  [SerializeField]
  private List<string> trackGroupNames;
  [Token(Token = "0x40009F8")]
  [FieldOffset(Offset = "0x50")]
  [SerializeField]
  private Transform positionTarget;
  [Token(Token = "0x40009F9")]
  [FieldOffset(Offset = "0x58")]
  private Vector3 initialTargetPosition;
  [Token(Token = "0x40009FB")]
  [FieldOffset(Offset = "0x70")]
  [SerializeField]
  private Camera mainCamera;
  [Token(Token = "0x40009FC")]
  [FieldOffset(Offset = "0x78")]
  [SerializeField]
  private CanvasScaler canvasScaler;
  [Token(Token = "0x40009FD")]
  [FieldOffset(Offset = "0x80")]
  private bool isPlaying;
  [Token(Token = "0x40009FF")]
  private const string TRACK_GROUP_NAME_DAMAGE = "Damage";
  [Token(Token = "0x4000A00")]
  private const string TRACK_GROUP_NAME_CRITICAL_DAMAGE = "Damage_Critical";
  [Token(Token = "0x4000A01")]
  private const string TRACK_GROUP_NAME_MISS = "Miss";
  [Token(Token = "0x4000A02")]
  private const string TRACK_GROUP_NAME_NO_DAMAGE = "NoDamage";
  [Token(Token = "0x4000A03")]
  private const string TRACK_GROUP_NAME_CUT_DAMAGE = "DamageCut";

  [Token(Token = "0x170000CE")]
  public Vector2 ScreenPositionOffset
  {
    [Token(Token = "0x6000A8E"), Address(RVA = "0x4BB917C", Offset = "0x4BB917C", VA = "0x4BB917C")] get
    {
      return new Vector2();
    }
    [Token(Token = "0x6000A8F"), Address(RVA = "0x4BB9184", Offset = "0x4BB9184", VA = "0x4BB9184")] private set
    {
    }
  }

  [Token(Token = "0x140000DE")]
  public event DuelUIDamageValueController.OnDestroyDamageValueDelegate OnDestroy
  {
    [Token(Token = "0x6000A90"), Address(RVA = "0x4BB57E0", Offset = "0x4BB57E0", VA = "0x4BB57E0")] add
    {
    }
    [Token(Token = "0x6000A91"), Address(RVA = "0x4BB918C", Offset = "0x4BB918C", VA = "0x4BB918C")] remove
    {
    }
  }

  [Token(Token = "0x6000A92")]
  [Address(RVA = "0x4BB9228", Offset = "0x4BB9228", VA = "0x4BB9228")]
  private void Update()
  {
  }

  [Token(Token = "0x6000A93")]
  [Address(RVA = "0x4BB534C", Offset = "0x4BB534C", VA = "0x4BB534C")]
  public void Initialize(
    Camera mainCamera,
    CanvasScaler canvasScaler,
    Vector3 screenPositionOffset)
  {
  }

  [Token(Token = "0x6000A94")]
  [Address(RVA = "0x4BB5444", Offset = "0x4BB5444", VA = "0x4BB5444")]
  public void ShowDamage(int damageValue, Transform target)
  {
  }

  [Token(Token = "0x6000A95")]
  [Address(RVA = "0x4BB54CC", Offset = "0x4BB54CC", VA = "0x4BB54CC")]
  public void ShowCriticalDamage(int damageValue, Transform target)
  {
  }

  [Token(Token = "0x6000A96")]
  [Address(RVA = "0x4BB562C", Offset = "0x4BB562C", VA = "0x4BB562C")]
  public void ShowCutDamage(int damageValue, Transform target)
  {
  }

  [Token(Token = "0x6000A97")]
  [Address(RVA = "0x4BB55C0", Offset = "0x4BB55C0", VA = "0x4BB55C0")]
  public void ShowMiss(Transform target)
  {
  }

  [Token(Token = "0x6000A98")]
  [Address(RVA = "0x4BB5554", Offset = "0x4BB5554", VA = "0x4BB5554")]
  public void ShowNoDamage(Transform target)
  {
  }

  [Token(Token = "0x6000A99")]
  [Address(RVA = "0x4BB97E4", Offset = "0x4BB97E4", VA = "0x4BB97E4")]
  private void SetDamageDigitImages(int damageValue, List<Image> digitImages)
  {
  }

  [Token(Token = "0x6000A9A")]
  [Address(RVA = "0x4BB93A8", Offset = "0x4BB93A8", VA = "0x4BB93A8")]
  private void InitializeTrackGroupNames()
  {
  }

  [Token(Token = "0x6000A9B")]
  [Address(RVA = "0x4BB9A60", Offset = "0x4BB9A60", VA = "0x4BB9A60")]
  private void PlayTimeline(string trackGroupName)
  {
  }

  [Token(Token = "0x6000A9C")]
  [Address(RVA = "0x4BB92F0", Offset = "0x4BB92F0", VA = "0x4BB92F0")]
  private void UpdateScreenPosition()
  {
  }

  [Token(Token = "0x6000A9D")]
  [Address(RVA = "0x4BB9E54", Offset = "0x4BB9E54", VA = "0x4BB9E54")]
  public DuelUIDamageValueController()
  {
  }

  [Token(Token = "0x2000185")]
  public delegate void OnDestroyDamageValueDelegate(DuelUIDamageValueController instance);
}
