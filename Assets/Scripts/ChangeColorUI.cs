using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ChangeColorUI : MonoBehaviour
{
    public static ChangeColorUI Instance { get; private set; }

    [SerializeField] Sprite[] snakeColor = new Sprite[6];

    [SerializeField] private Button snakeRedButton;
    [SerializeField] private Button snakeGreenButton;
    [SerializeField] private Button snakeButton;

    private void Awake()
    {
        if (Instance != null)
        {
            Debug.LogError("More than one Instance");
        }

        Instance = this;
    
        if (Button.snakeRedButton.onClick) 
        {
            GameAssets.Instance.snakeHeadSprite() = this Sprite.snakeColor[0];
            GameAssets.Instance.snakeBodySprite() = this Sprite.snakeColor[3];
        }

        if (Button.snakeGreenButton.onClick)
        {
            GameAssets.Instance.snakeHeadSprite() = this Sprite.snakeColor[1];
            GameAssets.Instance.snakeBodySprite() = this Sprite.snakeColor[4];
        }

        if (Button.snakeButton.onClick)
        {
            GameAssets.Instance.snakeHeadSprite() = this Sprite.snakeColor[2];
            GameAssets.Instance.snakeBodySprite() = this Sprite.snakeColor[5];
        }

        Hide();
    }


    public void Show()
    {
        gameObject.SetActive(true);
    }

    public void Hide()
    {
        gameObject.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
