-- このluaスクリプトは、CO_101034_0402.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110061_03","110061_03_h")
Include("content_adv_advsmall_110061_03","Template110061_03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",-90,CharaPos110061_03_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110061_03,CameraPos110061_03_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110061_03_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_510_01_StdController","to Std_Loop",CameraAssetBundleName110061_03,CameraPos110061_03_002)
	InitializeTemplateRandomCamera110061_03()
	InitializeTemplate110061_03()
-- ▼直接出力
set_pos(Actor001,{-4.4,0,3.4})
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110061)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101034","001","101034001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("エクセリア", "肯定")
-- ▲直接出力

	--★★エクセリア★★:植物に関する本が置かれている棚は<br>このあたりのようね
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_04020002")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:よし、手分けして本を探そう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_04020003")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(FADE_TIME)
setup_small_camera_start(RndCamera003)
wait_time(TIME_ELAPSED)
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("エクセリア", "挨拶")
-- ▲直接出力

	--★★エクセリア★★:当たり前のことを言うけれど<br>花って色々な種類があるのね
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_04020005")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:そうだな<br>季節ごとに咲く花も違うし
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_04020006")

	PlayAction(Actor002,"to  Std_No")

	--★★エクセリア★★:あなたに種をもらうまで<br>花に興味を抱いたことなんてなかったわ
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_04020007")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("エクセリア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★エクセリア★★:こうやって目的をもって<br>情報を収集するのは楽しいわね
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_04020009")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:楽しく感じてもらえているようでよかったよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_04020010")

-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_エクセリア_ランクアップ4_3")
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110061)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101034","001","101034001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110061_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
