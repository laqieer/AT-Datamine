// Decompiled with JetBrains decompiler
// Type: Tayx.Graphy.GraphyDebugger
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using Tayx.Graphy.Audio;
using Tayx.Graphy.Fps;
using Tayx.Graphy.Ram;
using Tayx.Graphy.Utils;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
namespace Tayx.Graphy
{
  [Token(Token = "0x200037D")]
  public class GraphyDebugger : G_Singleton<GraphyDebugger>
  {
    [Token(Token = "0x400146C")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private List<GraphyDebugger.DebugPacket> m_debugPackets;
    [Token(Token = "0x400146D")]
    [FieldOffset(Offset = "0x20")]
    private G_FpsMonitor m_fpsMonitor;
    [Token(Token = "0x400146E")]
    [FieldOffset(Offset = "0x28")]
    private G_RamMonitor m_ramMonitor;
    [Token(Token = "0x400146F")]
    [FieldOffset(Offset = "0x30")]
    private G_AudioMonitor m_audioMonitor;

    [Token(Token = "0x60013F8")]
    [Address(RVA = "0x2523870", Offset = "0x2523870", VA = "0x2523870")]
    protected GraphyDebugger()
    {
    }

    [Token(Token = "0x60013F9")]
    [Address(RVA = "0x252392C", Offset = "0x252392C", VA = "0x252392C")]
    private void Start()
    {
    }

    [Token(Token = "0x60013FA")]
    [Address(RVA = "0x25239CC", Offset = "0x25239CC", VA = "0x25239CC")]
    private void Update()
    {
    }

    [Token(Token = "0x60013FB")]
    [Address(RVA = "0x2523DEC", Offset = "0x2523DEC", VA = "0x2523DEC")]
    public void AddNewDebugPacket(GraphyDebugger.DebugPacket newDebugPacket)
    {
    }

    [Token(Token = "0x60013FC")]
    [Address(RVA = "0x2523E94", Offset = "0x2523E94", VA = "0x2523E94")]
    public void AddNewDebugPacket(
      int newId,
      GraphyDebugger.DebugCondition newDebugCondition,
      GraphyDebugger.MessageType newMessageType,
      string newMessage,
      bool newDebugBreak,
      Action newCallback)
    {
    }

    [Token(Token = "0x60013FD")]
    [Address(RVA = "0x252414C", Offset = "0x252414C", VA = "0x252414C")]
    public void AddNewDebugPacket(
      int newId,
      List<GraphyDebugger.DebugCondition> newDebugConditions,
      GraphyDebugger.MessageType newMessageType,
      string newMessage,
      bool newDebugBreak,
      Action newCallback)
    {
    }

    [Token(Token = "0x60013FE")]
    [Address(RVA = "0x2524264", Offset = "0x2524264", VA = "0x2524264")]
    public void AddNewDebugPacket(
      int newId,
      GraphyDebugger.DebugCondition newDebugCondition,
      GraphyDebugger.MessageType newMessageType,
      string newMessage,
      bool newDebugBreak,
      List<Action> newCallbacks)
    {
    }

    [Token(Token = "0x60013FF")]
    [Address(RVA = "0x2524394", Offset = "0x2524394", VA = "0x2524394")]
    public void AddNewDebugPacket(
      int newId,
      List<GraphyDebugger.DebugCondition> newDebugConditions,
      GraphyDebugger.MessageType newMessageType,
      string newMessage,
      bool newDebugBreak,
      List<Action> newCallbacks)
    {
    }

    [Token(Token = "0x6001400")]
    [Address(RVA = "0x2524440", Offset = "0x2524440", VA = "0x2524440")]
    public GraphyDebugger.DebugPacket GetFirstDebugPacketWithId(int packetId)
    {
      return (GraphyDebugger.DebugPacket) null;
    }

    [Token(Token = "0x6001401")]
    [Address(RVA = "0x2524520", Offset = "0x2524520", VA = "0x2524520")]
    public List<GraphyDebugger.DebugPacket> GetAllDebugPacketsWithId(int packetId)
    {
      return (List<GraphyDebugger.DebugPacket>) null;
    }

    [Token(Token = "0x6001402")]
    [Address(RVA = "0x2524604", Offset = "0x2524604", VA = "0x2524604")]
    public void RemoveFirstDebugPacketWithId(int packetId)
    {
    }

    [Token(Token = "0x6001403")]
    [Address(RVA = "0x2524690", Offset = "0x2524690", VA = "0x2524690")]
    public void RemoveAllDebugPacketsWithId(int packetId)
    {
    }

    [Token(Token = "0x6001404")]
    [Address(RVA = "0x2524784", Offset = "0x2524784", VA = "0x2524784")]
    public void AddCallbackToFirstDebugPacketWithId(Action callback, int id)
    {
    }

    [Token(Token = "0x6001405")]
    [Address(RVA = "0x252485C", Offset = "0x252485C", VA = "0x252485C")]
    public void AddCallbackToAllDebugPacketWithId(Action callback, int id)
    {
    }

    [Token(Token = "0x6001406")]
    [Address(RVA = "0x25239D0", Offset = "0x25239D0", VA = "0x25239D0")]
    private void CheckDebugPackets()
    {
    }

    [Token(Token = "0x6001407")]
    [Address(RVA = "0x2524AA4", Offset = "0x2524AA4", VA = "0x2524AA4")]
    private bool CheckIfConditionIsMet(GraphyDebugger.DebugCondition debugCondition) => new bool();

    [Token(Token = "0x6001408")]
    [Address(RVA = "0x2524F70", Offset = "0x2524F70", VA = "0x2524F70")]
    private float GetRequestedValueFromDebugVariable(GraphyDebugger.DebugVariable debugVariable)
    {
      return new float();
    }

    [Token(Token = "0x6001409")]
    [Address(RVA = "0x2524BB4", Offset = "0x2524BB4", VA = "0x2524BB4")]
    private void ExecuteOperationsInDebugPacket(GraphyDebugger.DebugPacket debugPacket)
    {
    }

    [Token(Token = "0x200037E")]
    public enum DebugVariable
    {
      [Token(Token = "0x4001471")] Fps,
      [Token(Token = "0x4001472")] Fps_Min,
      [Token(Token = "0x4001473")] Fps_Max,
      [Token(Token = "0x4001474")] Fps_Avg,
      [Token(Token = "0x4001475")] Ram_Allocated,
      [Token(Token = "0x4001476")] Ram_Reserved,
      [Token(Token = "0x4001477")] Ram_Mono,
      [Token(Token = "0x4001478")] Audio_DB,
    }

    [Token(Token = "0x200037F")]
    public enum DebugComparer
    {
      [Token(Token = "0x400147A")] Less_than,
      [Token(Token = "0x400147B")] Equals_or_less_than,
      [Token(Token = "0x400147C")] Equals,
      [Token(Token = "0x400147D")] Equals_or_greater_than,
      [Token(Token = "0x400147E")] Greater_than,
    }

    [Token(Token = "0x2000380")]
    public enum ConditionEvaluation
    {
      [Token(Token = "0x4001480")] All_conditions_must_be_met,
      [Token(Token = "0x4001481")] Only_one_condition_has_to_be_met,
    }

    [Token(Token = "0x2000381")]
    public enum MessageType
    {
      [Token(Token = "0x4001483")] Log,
      [Token(Token = "0x4001484")] Warning,
      [Token(Token = "0x4001485")] Error,
    }

    [Token(Token = "0x2000382")]
    [Serializable]
    public struct DebugCondition
    {
      [Token(Token = "0x4001486")]
      [FieldOffset(Offset = "0x0")]
      [Tooltip("Variable to compare against")]
      public GraphyDebugger.DebugVariable Variable;
      [Token(Token = "0x4001487")]
      [FieldOffset(Offset = "0x4")]
      [Tooltip("Comparer operator to use")]
      public GraphyDebugger.DebugComparer Comparer;
      [Token(Token = "0x4001488")]
      [FieldOffset(Offset = "0x8")]
      [Tooltip("Value to compare against the chosen variable")]
      public float Value;
    }

    [Token(Token = "0x2000383")]
    [Serializable]
    public class DebugPacket
    {
      [Token(Token = "0x4001489")]
      [FieldOffset(Offset = "0x10")]
      [Tooltip("If false, it won't be checked")]
      public bool Active;
      [Token(Token = "0x400148A")]
      [FieldOffset(Offset = "0x14")]
      [Tooltip("Optional Id. It's used to get or remove DebugPackets in runtime")]
      public int Id;
      [Token(Token = "0x400148B")]
      [FieldOffset(Offset = "0x18")]
      [Tooltip("If true, once the actions are executed, this DebugPacket will delete itself")]
      public bool ExecuteOnce;
      [Token(Token = "0x400148C")]
      [FieldOffset(Offset = "0x1C")]
      [Tooltip("Time to wait before checking if conditions are met (use this to avoid low fps drops triggering the conditions when loading the game)")]
      public float InitSleepTime;
      [Token(Token = "0x400148D")]
      [FieldOffset(Offset = "0x20")]
      [Tooltip("Time to wait before checking if conditions are met again (once they have already been met and if ExecuteOnce is false)")]
      public float ExecuteSleepTime;
      [Token(Token = "0x400148E")]
      [FieldOffset(Offset = "0x24")]
      public GraphyDebugger.ConditionEvaluation ConditionEvaluation;
      [Token(Token = "0x400148F")]
      [FieldOffset(Offset = "0x28")]
      [Tooltip("List of conditions that will be checked each frame")]
      public List<GraphyDebugger.DebugCondition> DebugConditions;
      [Token(Token = "0x4001490")]
      [FieldOffset(Offset = "0x30")]
      public GraphyDebugger.MessageType MessageType;
      [Token(Token = "0x4001491")]
      [FieldOffset(Offset = "0x38")]
      [Multiline]
      public string Message;
      [Token(Token = "0x4001492")]
      [FieldOffset(Offset = "0x40")]
      public bool TakeScreenshot;
      [Token(Token = "0x4001493")]
      [FieldOffset(Offset = "0x48")]
      public string ScreenshotFileName;
      [Token(Token = "0x4001494")]
      [FieldOffset(Offset = "0x50")]
      [Tooltip("If true, it pauses the editor")]
      public bool DebugBreak;
      [Token(Token = "0x4001495")]
      [FieldOffset(Offset = "0x58")]
      public UnityEvent UnityEvents;
      [Token(Token = "0x4001496")]
      [FieldOffset(Offset = "0x60")]
      public List<Action> Callbacks;
      [Token(Token = "0x4001497")]
      [FieldOffset(Offset = "0x68")]
      private bool canBeChecked;
      [Token(Token = "0x4001498")]
      [FieldOffset(Offset = "0x69")]
      private bool executed;
      [Token(Token = "0x4001499")]
      [FieldOffset(Offset = "0x6C")]
      private float timePassed;

      [Token(Token = "0x170001F1")]
      public bool Check
      {
        [Token(Token = "0x600140A"), Address(RVA = "0x2525144", Offset = "0x2525144", VA = "0x2525144")] get
        {
          return new bool();
        }
      }

      [Token(Token = "0x600140B")]
      [Address(RVA = "0x2524A48", Offset = "0x2524A48", VA = "0x2524A48")]
      public void Update()
      {
      }

      [Token(Token = "0x600140C")]
      [Address(RVA = "0x2525138", Offset = "0x2525138", VA = "0x2525138")]
      public void Executed()
      {
      }

      [Token(Token = "0x600140D")]
      [Address(RVA = "0x2524030", Offset = "0x2524030", VA = "0x2524030")]
      public DebugPacket()
      {
      }
    }
  }
}
