using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class ComboSystem : MonoBehaviour
{
    private List<string> bumperTags = new List<string>();
    private int scoreMultiplier = 1;

    public static event Action<int, int> OnScoreChange;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        BumperHit.onBumperHit += CheckForCombo;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDisable()
    {
        BumperHit.onBumperHit -= CheckForCombo;
    }

    private void CheckForCombo(string Tag, int bumpervalue )
    {
        bumperTags.Add(Tag);
        if (bumperTags.Count > 1)
        {
           
                if (bumperTags[bumperTags.Count - 2] == bumperTags[bumperTags.Count - 1 ])
                {
                    scoreMultiplier++;
                }
                else
                {
                    scoreMultiplier = 1;
                    bumperTags.Clear();
                }

             // Reset de lijst na het controleren van de combo
        ScoreManager.Instance.AddScore(bumpervalue * scoreMultiplier);

        OnScoreChange?.Invoke(ScoreManager.Instance.score, scoreMultiplier);

        //Debug.Log($"Score: {ScoreManager.Instance.score} || multiplier: {scoreMultiplier}X");
        }
    }
}
