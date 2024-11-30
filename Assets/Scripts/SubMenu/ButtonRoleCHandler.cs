using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonRoleCHandler : MonoBehaviour
{
    public string imgPath = "Sprites/Roles/C(Role)_1";
    void Start()
    {
        // 尋找 "Image" 子物件
        Transform imageTransform = transform.Find("Image");
        if (imageTransform == null)
        {
            Debug.LogError("Image component is null");
            return;
        }
        
        // 取得 Image 組件
        Image imageComponent = imageTransform.GetComponent<Image>();
        if (imageComponent == null)
        {
            Debug.LogError("Image component is null");
            return;
        }
        
        // 載入圖片
        Sprite customSprite = Resources.Load<Sprite>(imgPath);
        if (customSprite != null)
        {
            imageComponent.sprite = customSprite;
            Debug.Log("Sprite C set successfully");
        }
        else
        {
            Debug.LogError($"Sprite not found at {imgPath}");
        }

        // 設定按鈕點擊事件
        Button btn = this.GetComponent<Button>();
        if (btn.name == "Button_RoleC")
        {
            btn.onClick.AddListener(() =>{
                Debug.Log("Role C");
                SceneManager.LoadScene("DinnerCScene");
            });
        }
    }

    void Update()
    {
        
    }
}
