-- このluaスクリプトは、MA_01C112_16.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110071_05","110071_05_h")
Include("content_adv_advsmall_110071_05","Template110071_05_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110071_05_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110071_05,CameraPos110071_05_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110071_05_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110071_05,CameraPos110071_05_005)
	InitializeTemplateRandomCamera110071_05()
	InitializeTemplate110071_05()
-- ▼直接出力
set_common_look_at(Actor001,Actor002)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110071)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	template1()
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力

	--★★ノワール★★:ディナタン、ここにいたのか<br>さがしたぞ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C112_160002")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ディナタン", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ディナタン★★:ごめん<br>なんだか落ち着かなくて
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C112_160003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ディナタン★★:もうすぐ出発だよね<br>私も準備しなくちゃ
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C112_160004")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:ああ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C112_160005")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01C112_160006","MA_01C112_160007")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:怖いのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C112_160009")

-- ▼直接出力
 --PlayPartVoice("ディナタン", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ディナタン★★:え？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C112_160010")

-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:手、震えてる
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C112_160011")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Sad")

	--★★ディナタン★★:あれ？隠せてるつもりだったのになぁ…
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C112_160012")

	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
 --PlayPartVoice("ディナタン", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ディナタン★★:正直言うと…ちょっと怖いかも<br>あまりにもわからないことが多すぎて
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C112_160013")

	change_face(Actor002,"Sad")

	--★★ディナタン★★:なにを信じていいかもわからなくて
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C112_160014")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:なら、頼りになる兄貴のことでも<br>信じておいたらどうだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C112_160015")

	change_face(Actor002,"Normal")

	--★★ディナタン★★:自分で言っちゃう？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C112_160016")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:俺だけじゃなくてさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C112_160017")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ディナタン", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ディナタン★★:…うん。そうだね<br>ランス兄ちゃん、大丈夫だよね
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C112_160018")

-- ▼直接出力
 --PlayPartVoice("ディナタン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ディナタン★★:――ありがと、兄さん
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C112_160019")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:ランスロットのことが心配か？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C112_160021")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ディナタン", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ディナタン★★:うん…<br>なんだか、すごく胸騒ぎがして
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C112_160022")

	change_face(Actor002,"Sad")

	--★★ディナタン★★:兄さんは心配じゃないの？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C112_160023")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:ランスロットなら大丈夫だ<br>最強騎士なんだから
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C112_160024")

	PlayAction(Actor002,"to  Std_Sad02")
-- ▼直接出力
 --PlayPartVoice("ディナタン", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ディナタン★★:そうだけど…
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C112_160025")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:それに、まだ話してもらっていないことが<br>たくさんある
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C112_160026")

	change_face(Actor001,"Laugh")

	--★★ノワール★★:いつか話すってアイツは言っていた<br>ランスロットは約束を破ったりしない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C112_160027")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:だから…大丈夫だ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C112_160028")

	change_face(Actor002,"Normal")

	--★★ディナタン★★:…そっか
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C112_160029")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ディナタン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ディナタン★★:うん…そうだよね
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C112_160030")

	goto Block1end

::Block1end::
	PlayAction(Actor002,"to  Std_No")
	change_face(Actor002,"Normal")

	--★★ディナタン★★:怖いからって立ち止まってちゃ<br>なにもわからないまま
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C112_160032")

-- ▼直接出力
setup_small_camera_start(RndCamera009)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
 --PlayPartVoice("ディナタン", "肯定3")
-- ▲直接出力

	--★★ディナタン★★:だから…行かなきゃね
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C112_160033")

	PlayAction(Actor001,"to  Std_Sad01")
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ああ。行こう<br>――スノードンへ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C112_160034")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110071)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
MobsNo = 0
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110071_05)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
