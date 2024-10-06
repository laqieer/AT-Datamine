-- このluaスクリプトは、MA_01C110_33.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110061_02","110061_02_h")
Include("content_adv_advsmall_110061_02","Template110061_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110061_02_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110061_02,CameraPos110061_02_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110061_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110061_02,CameraPos110061_02_001)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110061_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110061_02,CameraPos110061_02_002)
	InitializeTemplateRandomCamera110061_02()
	InitializeTemplate110061_02()
-- ▼直接出力
prop001 = setup_prop_object(10103005)
set_pos(prop001 , {3.754,0.814,10.385})
Hide(Actor001)
force_eyesync(Actor003,"Close")
reserve_eyesync(Actor003,"Close")
force_lipsync(Actor003,"Close1")
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor003,false)
set_enable_auto_lookat(Actor001,false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110061)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101017","001","101017001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★マルディサント★★:「天は騎士に世界を覆う危険を教え<br>その身に大いなる剣の加護をもたらした」
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01C110_330002")


	--★★マルディサント★★:「薄汚れた汚名は消え去り<br>騎士は新たな居場所で――」
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01C110_330003")


	--★★ディナタン★★:すぅ…
	Talk(Actor003,"CHRNAME_DINATAN","speech","N","MA_01C110_330004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("マルディサント", "悩む")
-- ▲直接出力

	--★★マルディサント★★:…なんだよ、寝たのかよ<br>アンタが聞きたいっていったくせに
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01C110_330005")


	--★★ディナタン★★:すぅ…すぅ…
	Talk(Actor003,"CHRNAME_DINATAN","speech","N","MA_01C110_330006")

-- ▼直接出力
CloseTalkWindow()
wait_time(1.5)
setup_small_camera_start(Camera002)

-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("マルディサント", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★マルディサント★★:まぁ、起きたら続き聞かせてやるから<br>いいんだけどさ
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01C110_330007")

	change_face(Actor002,"Normal")

	--★★マルディサント★★:なぁ、オニーサン
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01C110_330008")

-- ▼直接出力
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",1.0)
Appear(Actor001)
lookat_delay_weight(Actor002,1.0, 0.5, 0.5, 0.2,1.0)
setup_small_camera_start(Camera001)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:気づいてたのか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_330009")

-- ▼直接出力
setup_small_camera_start()
set_enable_auto_lookat(Actor001,true)
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("マルディサント", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★マルディサント★★:兄妹揃って盗み聞きが趣味とはねぇ
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01C110_330010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01C110_330011","MA_01C110_330012")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:そんなつもりじゃ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_330014")

-- ▼直接出力
 --PlayPartVoice("マルディサント", "怒り")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★マルディサント★★:あぁ？アタシの芝居なんか<br>見るつもりなかったって？
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01C110_330015")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:更にそんなつもりじゃ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_330016")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:マルディサントのお芝居の話は<br>ディナタンから聞かされていて
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_330018")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:どこかで<br>見てみたいって思ってたから
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_330019")

-- ▼直接出力
 --PlayPartVoice("マルディサント", "驚き")
-- ▲直接出力
	change_face(Actor002,"Shy")

	--★★マルディサント★★:なっ！？ディーナのヤツ…！<br>だ、黙ってろって言ったのに
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01C110_330020")

	goto Block1end

::Block1end::

	--★★ディナタン★★:うぅん…
	Talk(Actor003,"CHRNAME_DINATAN","speech","N","MA_01C110_330022")

	change_face(Actor002,"Surprise")

	--★★マルディサント★★:…っと、アブね<br>ディーナを起こすとこだった
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01C110_330024")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("マルディサント", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★マルディサント★★:見逃してやるよ、オニーサン<br>ディーナが寝てて助かったな
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01C110_330025")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:こんなところで寝るなんて<br>ディナタン、どうしたんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_330026")


	--★★マルディサント★★:さぁ？<br>最近、よく寝落ちすんだよ
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01C110_330027")

-- ▼直接出力
 --PlayPartVoice("マルディサント", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★マルディサント★★:夜更かしでもしてんじゃねぇの？<br>なにせ不良少女と仲良しだから
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01C110_330028")


	--★★ディナタン★★:…むにゃむにゃ<br>マァル…お話の続き、聞かせて…
	Talk(Actor003,"CHRNAME_DINATAN","speech","N","MA_01C110_330029")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
setup_prop_object_preload(10103005)
	InitializeLoad_Preload()
	load_area_scene_preload(110061)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101017","001","101017001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110061_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
