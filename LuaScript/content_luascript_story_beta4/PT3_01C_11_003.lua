-- このluaスクリプトは、PT3_01C_11_003.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110191_01","110191_01_h")
Include("content_adv_advsmall_110191_01","Template110191_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110191_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110191_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_522_01_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_002)
	InitializeTemplateRandomCamera110191_01()
	InitializeTemplate110191_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115200)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101032","001","101032001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")

end

function Play()
	StartPlay()

	PlayAction(Actor002,"to Greet_one")
-- ▼直接出力
PlayPartVoice("ガレス", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガレス★★:ノワール、おっはよ～♪
	Talk(Actor002,"CHRNAME_GARETH","speech","L","PT3_01C_11_003002")

	PlayAction(Actor001,"to Greet_one")
-- ▼直接出力
PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:おはよう、ガレス<br>朝から元気だな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01C_11_003003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ガレス", "喜び")
-- ▲直接出力

	--★★ガレス★★:元気で当然！<br>ハロウィンスペシャルメニューが完成したからな
	Talk(Actor002,"CHRNAME_GARETH","speech","L","PT3_01C_11_003004")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:それはよかった<br>で、どんなメニューにしたんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01C_11_003005")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ガレス", "照れ")
-- ▲直接出力

	--★★ガレス★★:聞いて驚け！<br>パンプキン…
	Talk(Actor002,"CHRNAME_GARETH","speech","L","PT3_01C_11_003006")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_No")

	--★★ノワール★★:あーっと、やっぱりいいや<br>当日を楽しみにしておくよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01C_11_003007")

	change_face(Actor001,"Sad")

	--★★ノワール★★:（聞くまでもなく<br>カボチャのフルコースだったな…）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","PT3_01C_11_003008")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガレス", "笑い")
-- ▲直接出力

	--★★ガレス★★:こないだ味見係してくれたお礼に<br>ちゃんとノワールのぶんを用意しておくからな♪
	Talk(Actor002,"CHRNAME_GARETH","speech","L","PT3_01C_11_003009")

-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力

	--★★ノワール★★:あ、ありがとう…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01C_11_003010")

	EndPlay()
end




function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115200)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101032","001","101032001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110191_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
