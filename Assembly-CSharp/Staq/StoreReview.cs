// Decompiled with JetBrains decompiler
// Type: staq.StoreReview
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using UnityEngine;

#nullable disable
namespace staq
{
  [Token(Token = "0x2003C4E")]
  public static class StoreReview
  {
    [Token(Token = "0x4010B95")]
    [FieldOffset(Offset = "0x0")]
    private static Coroutine timerCoroutine;
    [Token(Token = "0x4010B96")]
    [FieldOffset(Offset = "0x8")]
    private static StoreReview.UserInActiveTimer userInActiveTimer;
    [Token(Token = "0x4010B97")]
    private const float reviewShowIdolTime = 3f;
    [Token(Token = "0x4010B98")]
    private const string activeCheckScene = "HomeTopSubScene";

    [Token(Token = "0x6017B61")]
    [Address(RVA = "0x37B2660", Offset = "0x37B2660", VA = "0x37B2660")]
    public static void CheckRequest()
    {
    }

    [Token(Token = "0x6017B62")]
    [Address(RVA = "0x37B2A9C", Offset = "0x37B2A9C", VA = "0x37B2A9C")]
    public static IEnumerator Request() => (IEnumerator) null;

    [Token(Token = "0x6017B63")]
    [Address(RVA = "0x37B2B24", Offset = "0x37B2B24", VA = "0x37B2B24")]
    private static void ChangeMainScene(System.Type sceneType)
    {
    }

    [Token(Token = "0x6017B64")]
    [Address(RVA = "0x37B2B9C", Offset = "0x37B2B9C", VA = "0x37B2B9C")]
    private static void ChangeSubScene(string subScene)
    {
    }

    [Token(Token = "0x2003C4F")]
    private class UserInActiveTimer : MonoBehaviour
    {
      [Token(Token = "0x4010B99")]
      [FieldOffset(Offset = "0x18")]
      public Action OnFinish;
      [Token(Token = "0x4010B9A")]
      [FieldOffset(Offset = "0x20")]
      private float idolTime;

      [Token(Token = "0x6017B65")]
      [Address(RVA = "0x37B29CC", Offset = "0x37B29CC", VA = "0x37B29CC")]
      public void Initialize()
      {
      }

      [Token(Token = "0x6017B66")]
      [Address(RVA = "0x37B2A24", Offset = "0x37B2A24", VA = "0x37B2A24")]
      public IEnumerator SetTimer(float reviewShowIdolTime, string activeSubScene)
      {
        return (IEnumerator) null;
      }

      [Token(Token = "0x6017B67")]
      [Address(RVA = "0x37B2B94", Offset = "0x37B2B94", VA = "0x37B2B94")]
      public void ResetTime()
      {
      }

      [Token(Token = "0x6017B68")]
      [Address(RVA = "0x37B2C9C", Offset = "0x37B2C9C", VA = "0x37B2C9C")]
      private void OnApplicationPause(bool pauseStatus)
      {
      }

      [Token(Token = "0x6017B69")]
      [Address(RVA = "0x37B2CA4", Offset = "0x37B2CA4", VA = "0x37B2CA4")]
      public UserInActiveTimer()
      {
      }
    }
  }
}
