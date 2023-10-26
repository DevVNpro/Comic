using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  static class ConfigData 
{
    #region Sound 
    private const string keyMusic = "Key_Music";
    private const string keyVfx = "Key_Vfx";
    public static int GetKeyMusic()
    {
        return PlayerPrefs.GetInt(keyMusic, 0);
    }
    public static void SetKeyMusic()
    {
        int value = GetKeyMusic();
        if (value == 0)
        {
            PlayerPrefs.SetInt(keyMusic, 1);
        }
        else PlayerPrefs.SetInt(keyMusic, 0);
        PlayerPrefs.Save();
    }

    public static int GetKeyVfx()
    {
        return PlayerPrefs.GetInt(keyVfx,0);
    }
    public static void SetKeYVfx()
    {
        int value = GetKeyVfx();
        if (value == 0)
        {
            PlayerPrefs.SetInt(keyVfx, 1);
        }
        else PlayerPrefs.SetInt(keyVfx, 0);
        PlayerPrefs.Save();
    }
    #endregion


    #region GamePlay
    public static int LevelStart = 1;
    public static int LevelMax =30;
    private static string KeyFistOpenGame = "Key_Fist_Open";
    private static string KeyTimeDeadInLevel = "Key_Dead_In_Level";
    public static string KeyCurrentLevelPlay = "Key_Current_Level";
    public static string KeyCurrentLevelUnlock = "Key_Current_Level";

    public static int GetKeyFistOpen()
    {
        return PlayerPrefs.GetInt(KeyFistOpenGame, 0);
    }
    public static void SetKeyFistOpen()
    {
        PlayerPrefs.SetInt(KeyFistOpenGame, 1);
        PlayerPrefs.Save();
    }

    public static int GetTimeDeadInLevel(int Level)
    {
        return PlayerPrefs.GetInt(KeyTimeDeadInLevel + Level, 0);
    }
    public static void SetTimeDadInLevel(int Level)
    {
        PlayerPrefs.SetInt(KeyTimeDeadInLevel + Level, GetTimeDeadInLevel(Level) + 1);
        PlayerPrefs.Save();
    }
    public static int GetCurrentLevelPlay()
    {
        return PlayerPrefs.GetInt(KeyCurrentLevelPlay, 10);
    }
    public static void SetKeyCurrentPlay(int level)
    {
        PlayerPrefs.SetInt(KeyCurrentLevelPlay, level);
        PlayerPrefs.Save();
    }

    #endregion
}
