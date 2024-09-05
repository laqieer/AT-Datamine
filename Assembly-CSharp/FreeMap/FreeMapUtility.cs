// Decompiled with JetBrains decompiler
// Type: FreeMap.FreeMapUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.AI;

#nullable disable
namespace FreeMap
{
  [Token(Token = "0x20015ED")]
  public static class FreeMapUtility
  {
    [Token(Token = "0x6007C20")]
    public static void InsertComponentArray<T>(ref T[] array, T target) where T : Component
    {
    }

    [Token(Token = "0x6007C21")]
    public static bool RemoveComponentArray<T>(ref T[] array, T target) where T : Component
    {
      return new bool();
    }

    [Token(Token = "0x6007C22")]
    public static T FindInArray<T>(T[] array, Predicate<T> match) where T : class => (T) null;

    [Token(Token = "0x6007C23")]
    public static int TryCountInArray<T>(T[] array, Predicate<T> match) => new int();

    [Token(Token = "0x6007C24")]
    public static T CreateGameObject<T>(string objectName, Transform parent) where T : Component
    {
      return (T) null;
    }

    [Token(Token = "0x6007C25")]
    public static void CountRenameInCollections<T>(
      T target,
      string objectName,
      IEnumerable<T> list)
      where T : Component
    {
    }

    [Token(Token = "0x6007C26")]
    [Address(RVA = "0x219E228", Offset = "0x219E228", VA = "0x219E228")]
    [Conditional("UNITY_EDITOR")]
    public static void DrawNavMeshPath(NavMeshPath path)
    {
    }
  }
}
