-- このluaスクリプトは、MA_01B109_31.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110071_01","110071_01_h")
Include("content_adv_advsmall_110071_01","Template110071_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",253.5005,CharaPos110071_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110071_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_505_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_001)
	InitializeTemplateRandomCamera110071_01()
	InitializeTemplate110071_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110071)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101019","001","101019001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("イゾルデ", "挨拶")
-- ▲直接出力

	--★★イゾルデ★★:意地悪しているように<br>お前からは見えてたかしら
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","MA_01B109_310002")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力

	--★★ノワール★★:なんの話だ、いきなり？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_310003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★イゾルデ★★:トリスタンのこと聞いていない？<br>ガラハッド卿から
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","MA_01B109_310004")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01B109_310005","MA_01B109_310006")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ガラハッドになにかしたのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_310008")

-- ▼直接出力
 --PlayPartVoice("イゾルデ", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★イゾルデ★★:彼女のこと心配してあげているの？<br>優しいのね
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","MA_01B109_310009")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★イゾルデ★★:私たちは見守っているだけよ<br>彼女が危ういことをしないようにね
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","MA_01B109_310010")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:新入生の監視も大変だな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_310012")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("イゾルデ", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★イゾルデ★★:身に覚えがあるものね
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","MA_01B109_310013")

	change_face(Actor002,"Smile")

	--★★イゾルデ★★:うっとうしいったらないでしょ<br>つきまとわれるのは
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","MA_01B109_310014")

	goto Block1end

::Block1end::
	change_face(Actor001,"Normal")

	--★★ノワール★★:聞いてもいいか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_310016")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("イゾルデ", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★イゾルデ★★:どうぞ？<br>答えられることであれば
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","MA_01B109_310017")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")

	--★★ノワール★★:どうして目の敵にするんだ？<br>俺のことも、ガラハッドのことも
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_310018")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★イゾルデ★★:自覚はあったのね
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","MA_01B109_310019")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:意地悪でやっているわけじゃないことは<br>もちろんわかる
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_310020")


	--★★ノワール★★:けどガラハッドは行動で<br>自らの高潔さを示そうとしている
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_310021")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("イゾルデ", "肯定2")
-- ▲直接出力

	--★★イゾルデ★★:そうね、願っているわ<br>うまくやってくれることを
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","MA_01B109_310022")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★イゾルデ★★:行動の伴う本音で<br>信じさせて欲しいのよ
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","MA_01B109_310023")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("イゾルデ", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★イゾルデ★★:誰よりも臆病だから、彼
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","MA_01B109_310024")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
 --PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:臆病…？<br>トリスタンが？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_310026")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("イゾルデ", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★イゾルデ★★:奥ゆかしくって可愛らしいでしょ？
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","MA_01B109_310028")

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
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101019","001","101019001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110071_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
