using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Score
{
    public const string HIGH_SCORE = "highScore"; // Clave en PlayerPrefs
    public const int POINTS = 100; // Cantidad de puntos que ganamos al comer comida

    private static int score; // Puntuación del jugador

    public static int GetHighScore()
    {
        return PlayerPrefs.GetInt(HIGH_SCORE, 0);
    }

    public static bool TrySetNewHighScore(int score)
    {
        int highScore = GetHighScore();
        if (score > highScore)
        {
            // Modificamos el High Score
            PlayerPrefs.SetInt(HIGH_SCORE, score);
            PlayerPrefs.Save();
            return true;
        }
        
        return false;
    }

    public static void InitializeStaticScore()
    {
        score = 0;
        AddScore(0); // PENDIENTE
    }
    
    public static int GetScore()
    {
        return score;
    }
    
    public static void AddScore(int pointsToAdd)
    {
        score += pointsToAdd;
        // scoreUIScript.UpdateScoreText(score);
    }
}
