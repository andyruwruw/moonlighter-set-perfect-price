using BepInEx;
using HarmonyLib;
using System;
using System.Reflection;

namespace SetPerfectPrice
{
  /// <summary>
  /// Main mod class.
  /// </summary>
  [BepInPlugin("andyruwruw.SetPerfectPrice", "SetPerfectPrice", "1.0.0")]
  public class Main : BaseUnityPlugin
  {
    internal static Assembly modAssembly = Assembly.GetExecutingAssembly();
    internal static string modName = $"{modAssembly.GetName().Name}";
    internal static string modDir = $"{Environment.CurrentDirectory}\\BepInEx\\{modName}";

    /// <summary>
    /// Register the mod.
    /// </summary>
    void Awake()
    {
      new Harmony($"andyruwruw_{modName}").PatchAll(modAssembly);
      
      Logger.LogInfo($"{modName} has loaded");
    }
  }
}