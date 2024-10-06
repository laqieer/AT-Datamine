-- このluaスクリプトは、CO_101014_0502.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110161_01","110161_01_h")
Include("content_adv_advsmall_110161_01","Template110161_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",240,CharaPos110161_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110161_01,CameraPos110161_01_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110161_01_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_505_01_StdController","to Std_Loop",CameraAssetBundleName110161_01,CameraPos110161_01_008)
	InitializeTemplateRandomCamera110161_01()
	InitializeTemplate110161_01()
-- ▼直接出力
Hide(Actor002)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110161)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101019","001","101019001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:イゾルデは<ruby=ここ>『連鎖する幸運』の教室</ruby>で待ってろって言ってたけど…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_05020002")

-- ▼直接出力
setup_small_camera_start(Camera001)
Appear(Actor002)
CloseTalkWindow()
wait_time(WAIT_TIME_SHORT)
setup_small_camera_start(Camera002)
turn_lookat(Actor001,Actor002,0)
set_enable_auto_lookat(Actor001,false)
lookat_delay_weight(Actor001, {0.4, 0.08, 0.7, 0.2} , 1)
keep_ik_lookat(Actor001,Actor002,"J_Head")
set_enable_auto_lookat(Actor002,false)
lookat_delay_weight(Actor002, {0.4, 0.08, 0.7, 0.2} , 1)
keep_ik_lookat(Actor002,Actor001,"J_Head")
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("イゾルデ", "怒り")
-- ▲直接出力

	--★★イゾルデ★★:私ならここにいるわよ
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","CO_101014_05020004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Surp")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:わ！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_05020005")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力

	--★★ノワール★★:や、やあ、イゾルデビックリしたよ。気配をまるで感じなかった
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_05020007")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★イゾルデ★★:私はいつもどおりよお前の注意力が散漫なのではなくて？
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","CO_101014_05020008")


	--★★ノワール★★:そ、そんなことはないつもりなんだ、けど…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_05020009")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:それより俺に話したいことっていうのは？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_05020010")

-- ▼直接出力
PlayPartVoice("イゾルデ", "肯定")
-- ▲直接出力

	--★★イゾルデ★★:お前とトリスタンの…
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","CO_101014_05020011")

	change_face(Actor001,"Normal")

	--★★ノワール★★:俺とトリスタンの？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_05020012")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("イゾルデ", "悩む")
-- ▲直接出力

	--★★イゾルデ★★:…ここはあまり場所が良くないわねもう少し静かなところに移動しましょう
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","CO_101014_05020013")

-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_トリスタン_ランクアップ5_3")
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
	load_area_scene_preload(110161)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101019","001","101019001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110161_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
