// Decompiled with JetBrains decompiler
// Type: System.CoroutineUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
namespace System
{
  [Token(Token = "0x2000529")]
  public static class CoroutineUtility
  {
    [Token(Token = "0x6001DE1")]
    [Address(RVA = "0x29FB900", Offset = "0x29FB900", VA = "0x29FB900")]
    public static Coroutine StartCoroutine(this GameObject target, IEnumerator routine)
    {
      return (Coroutine) null;
    }

    [Token(Token = "0x6001DE2")]
    [Address(RVA = "0x29FB964", Offset = "0x29FB964", VA = "0x29FB964")]
    public static void StopCoroutine(this GameObject target, Coroutine coroutine)
    {
    }

    [Token(Token = "0x6001DE3")]
    [Address(RVA = "0x29FB9C8", Offset = "0x29FB9C8", VA = "0x29FB9C8")]
    public static void WaitForOneFrame(this GameObject target, UnityAction callback)
    {
    }

    [Token(Token = "0x6001DE4")]
    [Address(RVA = "0x29FBB58", Offset = "0x29FBB58", VA = "0x29FBB58")]
    public static void WaitForSeconds(this GameObject target, float seconds, UnityAction callback)
    {
    }

    [Token(Token = "0x6001DE5")]
    [Address(RVA = "0x29FBC74", Offset = "0x29FBC74", VA = "0x29FBC74")]
    public static void WaitForOneFrame(this MonoBehaviour target, UnityAction callback)
    {
    }

    [Token(Token = "0x6001DE6")]
    [Address(RVA = "0x29FBD28", Offset = "0x29FBD28", VA = "0x29FBD28")]
    public static void WaitForSeconds(
      this MonoBehaviour target,
      float seconds,
      UnityAction callback)
    {
    }

    [Token(Token = "0x6001DE7")]
    [Address(RVA = "0x29FBA58", Offset = "0x29FBA58", VA = "0x29FBA58")]
    private static bool Validate(GameObject target, UnityAction callback) => new bool();

    [Token(Token = "0x6001DE8")]
    [Address(RVA = "0x29FBAF0", Offset = "0x29FBAF0", VA = "0x29FBAF0")]
    private static IEnumerator InternalWaitForOneFrame(UnityAction callback) => (IEnumerator) null;

    [Token(Token = "0x6001DE9")]
    [Address(RVA = "0x29FBBFC", Offset = "0x29FBBFC", VA = "0x29FBBFC")]
    private static IEnumerator InternalWaitForSeconds(float seconds, UnityAction callback)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x200052A")]
    public static class SingleArgument
    {
      [Token(Token = "0x6001DEA")]
      public static void WaitForOneFrame<T>(GameObject target, UnityAction<T> callback, T argument)
      {
      }

      [Token(Token = "0x6001DEB")]
      public static void CallWaitForSeconds<T>(
        GameObject target,
        float seconds,
        UnityAction<T> callback,
        T argument)
      {
      }

      [Token(Token = "0x6001DEC")]
      public static void WaitForOneFrame<T>(
        MonoBehaviour target,
        UnityAction<T> callback,
        T argument)
      {
      }

      [Token(Token = "0x6001DED")]
      public static void CallWaitForSeconds<T>(
        MonoBehaviour target,
        float seconds,
        UnityAction<T> callback,
        T argument)
      {
      }

      [Token(Token = "0x6001DEE")]
      private static bool Validate<T>(GameObject target, UnityAction<T> callback) => new bool();

      [Token(Token = "0x6001DEF")]
      private static IEnumerator InternalWaitForOneFrame<T>(UnityAction<T> callback, T argument)
      {
        return (IEnumerator) null;
      }

      [Token(Token = "0x6001DF0")]
      private static IEnumerator InternalWaitForSeconds<T>(
        float seconds,
        UnityAction<T> callback,
        T argument)
      {
        return (IEnumerator) null;
      }
    }

    [Token(Token = "0x200052D")]
    public static class MultiArguments
    {
      [Token(Token = "0x6001DFD")]
      public static void WaitForOneFrame<T>(
        GameObject target,
        UnityAction<T[]> callback,
        params T[] arguments)
      {
      }

      [Token(Token = "0x6001DFE")]
      public static void WaitForSeconds<T>(
        GameObject target,
        float seconds,
        UnityAction<T[]> callback,
        params T[] arguments)
      {
      }

      [Token(Token = "0x6001DFF")]
      public static void WaitForOneFrame<T>(
        MonoBehaviour target,
        UnityAction<T[]> callback,
        params T[] arguments)
      {
      }

      [Token(Token = "0x6001E00")]
      public static void WaitForSeconds<T>(
        MonoBehaviour target,
        float seconds,
        UnityAction<T[]> callback,
        params T[] arguments)
      {
      }

      [Token(Token = "0x6001E01")]
      private static bool Validate<T>(
        GameObject target,
        UnityAction<T[]> callback,
        params T[] arguments)
      {
        return new bool();
      }

      [Token(Token = "0x6001E02")]
      private static IEnumerator InternalWaitForOneFrame<T>(
        UnityAction<T[]> callback,
        params T[] arguments)
      {
        return (IEnumerator) null;
      }

      [Token(Token = "0x6001E03")]
      private static IEnumerator InternalWaitForSeconds<T>(
        float seconds,
        UnityAction<T[]> callback,
        params T[] arguments)
      {
        return (IEnumerator) null;
      }
    }
  }
}
