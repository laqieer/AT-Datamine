-- このluaスクリプトは、PT2_01_05_004.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110901_01","110901_01_h")
Include("content_adv_advsmall_110901_01","Template110901_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110901_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110901_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_003)
	InitializeTemplateRandomCamera110901_01()
	InitializeTemplate110901_01()
-- ▼直接出力
turn_lookat(Actor001,Actor002,0)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115907)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("ディナタン", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ディナタン★★:聞いたよ、兄さん
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT2_01_05_0040007")


	--★★ディナタン★★:ギネヴィアさんと一緒に<br>キャメリアードの様子を見に行くんでしょ？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT2_01_05_0040008")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:ああ<br>でも、心配はいらない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01_05_0040009")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ノワール★★:ギネヴィアとギネマウアさんは<br>ゲシュタルト・シフトを済ませているし
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01_05_0040010")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:俺にはティルフィングもついてるから<br>バルバロイが出たって大丈夫だ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01_05_0040011")

-- ▼直接出力
PlayPartVoice("ディナタン", "怒り")
-- ▲直接出力

	--★★ディナタン★★:ねえ、ランス兄ちゃんにお願いしたら<br>私も行っていいってことにならないかな？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT2_01_05_0040012")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力

	--★★ノワール★★:…ダメだ<br>ディナタンはここで大人しく待っていろ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01_05_0040013")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")

	--★★ディナタン★★:でも、私だって儀式は済ませてるし<br>傭兵時代は兄さんについて…
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT2_01_05_0040014")

	change_face(Actor001,"Sad")

	--★★ノワール★★:…頼む
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01_05_0040015")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ディナタン★★:…わかった<br>気を付けて行ってきてね、兄さん
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT2_01_05_0040016")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115907)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110901_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
