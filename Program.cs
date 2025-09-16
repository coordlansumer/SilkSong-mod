using BepInEx;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using System;
using HutongGames.PlayMaker.Actions;


namespace SKS
{   

    struct ButtonConfig
        {
            public string label;
            public bool value;
            public float yOffset;
        }
         struct SliderConfig
        {
            public string label;
            public int value;
            public float yOffset;
            public int min;
            public int max;
        }
   
[BepInPlugin("GRY.ns", "SILKSONG_MANAGER", "1.0.0")]
public class MyPlugin : BaseUnityPlugin
{   
    
    private GameObject panel;
    private bool isInvincible = false;
    private bool infiniteAirJump = true;
    private bool mapAllRooms = false;
    private bool betaEnd = false;
    private bool hasDash = false;
    private bool hasWalljump = false;
    private bool hasDoubleJump = false;
    private bool hasHarpoonDash = false;
    private bool hasSuperJump = false;
    private bool hasNeedolin = false;
    private bool hasSilkCharge = false;
    private bool hasSilkBomb = false;

    // int 变量
    private int nailUpgrades = 0;
    private int silkSpecialLevel = 0;
    private int healthBlue = 10;
    private int geo = 9999;

   void Awake()
    {   
        Logger.LogInfo("Awake");

            try
            {   
                CreateRedPanel();
                //CreatePanel();
                panel.SetActive(false); // 默认隐藏
                Logger.LogInfo("created panel");
            }
            catch (Exception e)
            {
                Debug.LogError($"Error creating panel: {e.Message}");
            }
       
    }

    private void CreateRedPanel()
{
    // 创建画布
    panel = new GameObject("RedCanvas");
    Canvas canvas = panel.AddComponent<Canvas>();
    canvas.renderMode = RenderMode.ScreenSpaceOverlay;
    
    // 添加并配置 CanvasScaler
    CanvasScaler scaler = panel.AddComponent<CanvasScaler>();
    scaler.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
    scaler.referenceResolution = new Vector2(1920, 1080); // 根据您的项目设置调整
    scaler.screenMatchMode = CanvasScaler.ScreenMatchMode.MatchWidthOrHeight;
    scaler.matchWidthOrHeight = 0.5f; // 根据需要调整
    
    panel.AddComponent<GraphicRaycaster>();
    canvas.sortingOrder = 100;

    // 创建全屏背景
    GameObject bg = new GameObject("BG");
    bg.transform.SetParent(canvas.transform, false);
    RectTransform rect = bg.AddComponent<RectTransform>(); // 先添加RectTransform
    
    // 设置背景全屏覆盖
    rect.anchorMin = Vector2.zero;
    rect.anchorMax = Vector2.one;
    rect.offsetMin = Vector2.zero;
    rect.offsetMax = Vector2.zero;
    
    // 添加Image组件并设置颜色
    Image bgImage = bg.AddComponent<Image>();
    bgImage.color = new Color(1, 0, 0, 1); // 确保alpha值为1（完全不透明）
}        private bool is_activate = false;
        void Update()
        {
            Logger.LogInfo("update");

            // if (is_activate ==false)
            // {
            //     if (panel == null)
            //     {
            //         Logger.LogInfo("panel is null");
            //         CreatePanel();
            //         panel.SetActive(false);

            //     }
            //     else
            //     {

            //         panel.SetActive(true);
            //         is_activate = true;
            //     }
            // }
            if (PlayerData.instance == null) return;

            if (Input.GetKeyDown(KeyCode.F1))
            {
                Logger.LogInfo("updateeeeeeeeeeee");

                panel.SetActive(!panel.activeSelf);
            }
            if (isInvincible)
            {
                PlayerData.instance.isInvincible = true;
            }

            if (infiniteAirJump)
            {
                PlayerData.instance.infiniteAirJump = true;
            }

            if (mapAllRooms)
            {
                PlayerData.instance.mapAllRooms = true;
            }
            if (betaEnd)
            {
                PlayerData.instance.betaEnd = true;
            }
            if (hasDash)
            {
                PlayerData.instance.hasDash = true;
            }
            if (hasWalljump)
            {
                PlayerData.instance.hasWalljump = true;
            }
            if (hasDoubleJump)
            {
                PlayerData.instance.hasDoubleJump = true;
            }
            if (hasHarpoonDash)
            {
                PlayerData.instance.hasHarpoonDash = true;
            }
            if (hasSuperJump)
            {
                PlayerData.instance.hasSuperJump = true;
            }
            if (hasNeedolin)
            {
                PlayerData.instance.hasNeedolin = true;
            }
            if (hasSilkCharge)
            {
                PlayerData.instance.hasSilkCharge = true;
            }
            if (hasSilkBomb)
            {
                PlayerData.instance.hasSilkBomb = true;
            }
            PlayerData.instance.nailUpgrades = nailUpgrades;
            PlayerData.instance.silkSpecialLevel = silkSpecialLevel;
            PlayerData.instance.healthBlue = healthBlue;
            PlayerData.instance.AddGeo(1);
            PlayerData.instance.showGeoUI = true;

    }
    
    //     private void CreatePanel()
    //     {

    //         panel = new GameObject("SilksongModPanel");
    //         panel.transform.SetAsLastSibling();
    //         Canvas canvas = panel.AddComponent<Canvas>();
    //         canvas.renderMode = RenderMode.ScreenSpaceOverlay;
    //         CanvasScaler cs = panel.AddComponent<CanvasScaler>();
    //         cs.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
    //         cs.referenceResolution = new Vector2(1920,1080);
    //         panel.AddComponent<CanvasScaler>();
    //         panel.AddComponent<GraphicRaycaster>();

    //         GameObject bg = new GameObject("BG");
            
    //         bg.transform.SetParent(panel.transform);
    //         Image bgImage = bg.AddComponent<Image>();
    //         bgImage.color = new Color(0, 0, 0, 0.6f);
    //         RectTransform bgRect = bg.GetComponent<RectTransform>();
    //         bgRect.sizeDelta = new Vector2(250, 600);
    //         bgRect.anchoredPosition = Vector2.zero;

    //         // 布局初始偏移
    //         float yOffset = 400;

    //         Logger.LogInfo("创建按钮和滑条"); 
        
        

    //     // ✅ 创建 Bool 按钮数组
    //         ButtonConfig[] boolButtons = new ButtonConfig[]
    //     {
    //         new ButtonConfig { label = "无敌 isInvincible", value = false, yOffset = yOffset },
    //         new ButtonConfig { label = "无限空中跳跃 infiniteAirJump", value = false, yOffset = yOffset },
    //         new ButtonConfig { label = "显示全地图 mapAllRooms", value = false, yOffset = yOffset },
    //         new ButtonConfig { label = "测试版结束 betaEnd", value = false, yOffset = yOffset },
    //         new ButtonConfig { label = "拥有冲刺 hasDash", value = false, yOffset = yOffset },
    //         new ButtonConfig { label = "蹬墙跳 hasWalljump", value = false, yOffset = yOffset },
    //         new ButtonConfig { label = "二段跳 hasDoubleJump", value = false, yOffset = yOffset },
    //         new ButtonConfig { label = "鱼叉冲刺 hasHarpoonDash", value = false, yOffset = yOffset },
    //         new ButtonConfig { label = "超级跳 hasSuperJump", value = false, yOffset = yOffset },
    //         new ButtonConfig { label = "拥有尼德林 hasNeedolin", value = false, yOffset = yOffset },
    //         new ButtonConfig { label = "丝线充能 hasSilkCharge", value = false, yOffset = yOffset },
    //         new ButtonConfig { label = "丝线炸弹 hasSilkBomb", value = false, yOffset = yOffset }
    //     };

    //     // 遍历创建 Bool 按钮
    //     for (int i = 0; i < boolButtons.Length; i++)
    //     {   
    //         boolButtons[i].yOffset -= i * 40; // 每次使用最新的偏移
    //         CreateBoolButton(ref boolButtons[i]);  
    //     }

    //     // ✅ 创建 Int 滑条数组
    //     SliderConfig[] intSliders = new SliderConfig[]
    //     {
    //         new SliderConfig { label = "钉武器升级 nailUpgrades", value = 0, min = 0, max = 10, yOffset = yOffset },
    //         new SliderConfig { label = "丝线特殊技能 silkSpecialLevel", value = 0, min = 0, max = 5, yOffset = yOffset },
    //         new SliderConfig { label = "蓝色生命值 healthBlue", value = 0, min = 0, max = 20, yOffset = yOffset },
    //         new SliderConfig { label = "货币 geo", value = 0, min = 0, max = 9999, yOffset = yOffset }
    //     };

    //     // 遍历创建 Int 滑条
    //     for (int i = 0; i < intSliders.Length; i++)
    //     {
    //         intSliders[i].yOffset -= (boolButtons.Length * 40) + i * 40; 
    //         CreateIntSlider(ref intSliders[i]);
    //     }
    // }

        
private void CreatePanel()
{
    // 创建 Panel
    panel = new GameObject("SilksongModPanel");
    panel.transform.SetAsLastSibling();

    Canvas canvas = panel.AddComponent<Canvas>();
    canvas.renderMode = RenderMode.ScreenSpaceOverlay;

    CanvasScaler cs = panel.AddComponent<CanvasScaler>();
    cs.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
    cs.referenceResolution = new Vector2(1920, 1080);

    panel.AddComponent<GraphicRaycaster>();

    // Panel RectTransform 居中
    RectTransform panelRect = panel.GetComponent<RectTransform>();
    panelRect.anchorMin = new Vector2(0.5f, 0.5f);
    panelRect.anchorMax = new Vector2(0.5f, 0.5f);
    panelRect.pivot = new Vector2(0.5f, 0.5f);
    panelRect.anchoredPosition = Vector2.zero;
    panelRect.sizeDelta = new Vector2(300, 600);

    // 创建背景
    GameObject bg = new GameObject("BG");
    bg.transform.SetParent(panel.transform, false);
    Image bgImage = bg.AddComponent<Image>();
    bgImage.color = new Color(0, 0, 0, 0.6f);

    RectTransform bgRect = bg.GetComponent<RectTransform>();
    bgRect.anchorMin = new Vector2(0, 0);
    bgRect.anchorMax = new Vector2(1, 1);
    bgRect.pivot = new Vector2(0.5f, 0.5f);
    bgRect.anchoredPosition = Vector2.zero;
    bgRect.sizeDelta = Vector2.zero;

    Logger.LogInfo("创建按钮和滑条");

    // 布局初始偏移
    float yOffset = 250;

    // 创建 Bool 按钮
    ButtonConfig[] boolButtons = new ButtonConfig[]
    {
        new ButtonConfig { label = "无敌 isInvincible", value = false, yOffset = yOffset },
        new ButtonConfig { label = "无限空中跳跃 infiniteAirJump", value = false, yOffset = yOffset },
        new ButtonConfig { label = "显示全地图 mapAllRooms", value = false, yOffset = yOffset },
        new ButtonConfig { label = "测试版结束 betaEnd", value = false, yOffset = yOffset },
        new ButtonConfig { label = "拥有冲刺 hasDash", value = false, yOffset = yOffset },
        new ButtonConfig { label = "蹬墙跳 hasWalljump", value = false, yOffset = yOffset },
        new ButtonConfig { label = "二段跳 hasDoubleJump", value = false, yOffset = yOffset },
        new ButtonConfig { label = "鱼叉冲刺 hasHarpoonDash", value = false, yOffset = yOffset },
        new ButtonConfig { label = "超级跳 hasSuperJump", value = false, yOffset = yOffset },
        new ButtonConfig { label = "拥有尼德林 hasNeedolin", value = false, yOffset = yOffset },
        new ButtonConfig { label = "丝线充能 hasSilkCharge", value = false, yOffset = yOffset },
        new ButtonConfig { label = "丝线炸弹 hasSilkBomb", value = false, yOffset = yOffset }
    };

    for (int i = 0; i < boolButtons.Length; i++)
    {
        boolButtons[i].yOffset -= i * 40;
        CreateBoolButton(ref boolButtons[i]);
    }

    // 创建 Int 滑条
    SliderConfig[] intSliders = new SliderConfig[]
    {
        new SliderConfig { label = "钉武器升级 nailUpgrades", value = 0, min = 0, max = 10, yOffset = yOffset },
        new SliderConfig { label = "丝线特殊技能 silkSpecialLevel", value = 0, min = 0, max = 5, yOffset = yOffset },
        new SliderConfig { label = "蓝色生命值 healthBlue", value = 0, min = 0, max = 20, yOffset = yOffset },
        new SliderConfig { label = "货币 geo", value = 0, min = 0, max = 9999, yOffset = yOffset }
    };

    for (int i = 0; i < intSliders.Length; i++)
    {
        intSliders[i].yOffset -= (boolButtons.Length * 40) + i * 40;
        CreateIntSlider(ref intSliders[i]);
    }
}

    private void CreateBoolButton(ref ButtonConfig cfg)
        {
            Logger.LogInfo($"创建 Bool 按钮: {cfg.label}");

            bool localValue = cfg.value;

            GameObject btnObj = new GameObject(cfg.label);
            btnObj.transform.SetParent(panel.transform, false);

            Button btn = btnObj.AddComponent<Button>();
            Image img = btnObj.AddComponent<Image>();
            img.color = Color.gray;

            RectTransform rect = btnObj.GetComponent<RectTransform>();
            rect.sizeDelta = new Vector2(250, 30);
            rect.anchoredPosition = new Vector2(0, cfg.yOffset);

            GameObject textObj = new GameObject("Text");
            textObj.transform.SetParent(btnObj.transform);
            Text text = textObj.AddComponent<Text>();
            text.font = Resources.GetBuiltinResource<Font>("Arial.ttf");
            text.alignment = TextAnchor.MiddleCenter;
            text.color = Color.white;
            var label = cfg.label;
            void UpdateText() => text.text = string.Format("{0}: {1}", label, localValue ? "开" : "关");
            UpdateText();

            btn.onClick.AddListener(() =>
            {
                localValue = !localValue;
                UpdateText();
            });

            cfg.value = localValue;

            RectTransform textRect = textObj.GetComponent<RectTransform>();
            textRect.sizeDelta = rect.sizeDelta;
            textRect.anchoredPosition = Vector2.zero;

        }

    private void CreateIntSlider(ref SliderConfig cfg)
    {
        Logger.LogInfo($"创建 Int 滑条: {cfg.label}");

        int tempValue = cfg.value;

        GameObject sliderObj = new GameObject(cfg.label);
        sliderObj.transform.SetParent(panel.transform, false);

        Slider slider = sliderObj.AddComponent<Slider>();
        slider.minValue = cfg.min;
        slider.maxValue = cfg.max;
        slider.value = tempValue;
        slider.wholeNumbers = true;

        RectTransform rect = sliderObj.GetComponent<RectTransform>();
        rect.sizeDelta = new Vector2(250, 20);
        rect.anchoredPosition = new Vector2(0, cfg.yOffset);

        GameObject textObj = new GameObject("Text");
        textObj.transform.SetParent(sliderObj.transform);
        Text text = textObj.AddComponent<Text>();
        text.font = Resources.GetBuiltinResource<Font>("Arial.ttf");
        text.alignment = TextAnchor.MiddleCenter;
        text.color = Color.white;
        var label = cfg.label;
        slider.onValueChanged.AddListener((v) =>
        {
            tempValue = (int)v;
            text.text = string.Format("{0}: {1}", label, tempValue);
        });

        cfg.value = tempValue;

        RectTransform textRect = textObj.GetComponent<RectTransform>();
        textRect.sizeDelta = new Vector2(250, 20);
        textRect.anchoredPosition = new Vector2(0, 15);

    }
}

}


