-- このluaスクリプトは、MA_01A110_52.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110901_01","110901_01_h")
Include("content_adv_advsmall_110901_01","Template110901_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110901_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110901_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_002)
	InitializeTemplateRandomCamera110901_01()
	InitializeTemplate110901_01()
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115907)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101030","001","101030001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
keep_ik_lookat(Actor001, Actor002, "J_Head")
lookWeight = {0.9, 0, 0.5, 0.35}
lookat_delay_weight(Actor001, lookWeight,0.5)
 --PlayPartVoice("エレイン", "照れ")
-- ▲直接出力
	change_face(Actor002,"Shy")

	--★★エレイン★★:おいしいものがいっぱいあったせいで私…<br>食べすぎちゃって…はずかしい
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A110_500006")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01A110_500008","MA_01A110_500009")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:楽しかったよ<br>色んなことを忘れるくらい
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_500011")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
keep_ik_lookat(Actor002, Actor001, "J_Head")
lookWeight = {0.9, 0, 0.5, 0.35}
lookat_delay_weight(Actor002, lookWeight,0.5)
 --PlayPartVoice("エレイン", "怒り")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★エレイン★★:…私の食べっぷりを見て、ですか？
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A110_500012")

-- ▼直接出力
 --PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:そ、そうじゃないけど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_500013")

-- ▼直接出力
 --PlayPartVoice("エレイン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★エレイン★★:えへへ…冗談です<br>イジワル言いました
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A110_500014")

	change_face(Actor002,"Smile")

	--★★エレイン★★:私、先輩とお昼…ご一緒して<br>わかったんです
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A110_500015")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("エレイン", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★エレイン★★:先輩とごはんを食べると<br>おいしいな、って
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A110_500016")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
lookat_delay_weight_reset(Actor002 , 0.6)
 --PlayPartVoice("エレイン", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Shy")

	--★★エレイン★★:いつも先輩と一緒が、いいな<br>…なんて
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A110_500018")

	change_face(Actor002,"Smile")

	--★★エレイン★★:………これも、冗談…ですけど
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A110_500019")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
 --PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:すこし疲れたかも…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_500021")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
keep_ik_lookat(Actor002, Actor001, "J_Head")
lookWeight = {0.9, 0, 0.5, 0.35}
lookat_delay_weight(Actor002, lookWeight,0.5)
 --PlayPartVoice("エレイン", "納得")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★エレイン★★:…ですよね<br>先輩ずっと頑張りっぱなしですから
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A110_500022")

	change_face(Actor002,"Sad")

	--★★エレイン★★:いやしてあげられたら…よかったんですけど<br>むずかしいですね、なかなか
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A110_500023")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("エレイン", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★エレイン★★:よければ、またチャレンジさせてください<br>先輩さえ…よければ
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A110_500024")

-- ▼直接出力
lookat_delay_weight_reset(Actor002 , 0.6)
-- ▲直接出力
	goto Block1end

::Block1end::
-- ▼直接出力
 --PlayPartVoice("エレイン", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★エレイン★★:好きになってしまいそうです
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A110_500026")

-- ▼直接出力
 --PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:え？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_500027")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("エレイン", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★エレイン★★:──学園が
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A110_500028")

-- ▼直接出力
 --PlayPartVoice("エレイン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★エレイン★★:こんなに楽しいところだなんて<br>思えたこと、なかったから
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A110_500029")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★エレイン★★:すごく、好きになってしまいそうです
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A110_500030")

-- ▼直接出力
 --PlayPartVoice("エレイン", "肯定")
-- ▲直接出力
	change_face(Actor002,"Shy")

	--★★エレイン★★:………ここが
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A110_500031")

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
	InitializeCharacter_3D_Preload("101030","001","101030001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110901_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
